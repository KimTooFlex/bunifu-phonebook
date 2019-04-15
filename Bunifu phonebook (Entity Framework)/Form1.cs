using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu_phonebook__Entity_Framework_.EntityFramework;

namespace Bunifu_phonebook__Entity_Framework_
{
    public partial class Form1 : Form
    {
        private phonebookEntities database;

        public Form1()
        {
            //create database instance
            database = new EntityFramework.phonebookEntities();

            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new PopupEffect.transparentBg(this, new frmAddContact());
            PopulateDatatoDatagrid();
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            lblCurTab.Text = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Text.Trim();
            //reload data here
            PopulateDatatoDatagrid();
        }


        void PopulateDatatoDatagrid()
        {

            //load data fro database
            var results = database.contacts.Select(r=>r);

            //filter search
            if(txtSearch.Text.Trim().Length>0)
            {
                results = results.Where(r=>r.name.Contains(txtSearch.Text.Trim().ToLower()) || r.phone.Contains(txtSearch.Text.Trim().ToLower()));
            }

            grid.Rows.Clear();

            foreach (var contact in results)
            {
                grid.Rows.Add(
                           new object[]
                           {
                             contact.name,
                             contact.email,
                             contact.phone,
                             contact.address, 
                           }
                          );
                grid.Rows[grid.RowCount - 1].Tag = contact;
            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            PopulateDatatoDatagrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Delete selected rows
            foreach (DataGridViewRow row in grid.SelectedRows)
            {
                var contact = (contact)row.Tag;
                database.contacts.Remove(contact);
                grid.Rows.Remove(row);
            }

            //save changes
            if(database.ChangeTracker.HasChanges())
            {
                if (database.SaveChanges()>0)
                {
                    Bunifu.Snackbar.Show(this.FindForm(), "Success.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
                }
                else
                {
                    Bunifu.Snackbar.Show(this.FindForm(), "Failed.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);

                }
              
            }
        }
    }
}
