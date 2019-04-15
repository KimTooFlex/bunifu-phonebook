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
    public partial class frmAddContact : Form
    {
        private phonebookEntities database;

        public frmAddContact()
        {   
            //create database instance
            database = new EntityFramework.phonebookEntities();

            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            //do validation here


            database.contacts.Add(
              new contact()
              {
                  ContactID = database.contacts.Count(),
                  name = txtName.Text.Trim(),
                  email = txtEmail.Text.Trim(),
                  phone = txtPhone.Text.Trim(),
                  address = txtAddress.Text.Trim(),
                  isFriend= isFriend.Checked,
                  isFamily = isFamily.Checked,
                  isCoWorker = isCoWorker.Checked,
                  isBusiness = isBusiness.Checked
              }  
             );

            //Save changes
            if (database.SaveChanges() > 0)
            {
                Bunifu.Snackbar.Show(this.FindForm(), txtName.Text.Trim() + " Successfully Added.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
           
            }
            else
            {
                Bunifu.Snackbar.Show(this.FindForm(), "Failed,Check database connection.", 3000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);

            } 
            //thats it

        }
    }
}
