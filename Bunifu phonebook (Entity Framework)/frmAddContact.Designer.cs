namespace Bunifu_phonebook__Entity_Framework_
{
    partial class frmAddContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContact));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtAddress = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.isFriend = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isFamily = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isBusiness = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isCoWorker = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.lblCurTab = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnAddContact = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(438, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(26, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderRadius = 30;
            this.txtName.BorderThickness = 1;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(80, 95);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(311, 35);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Name";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtEmail.BorderRadius = 30;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.White;
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.Location = new System.Drawing.Point(80, 158);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtEmail.Modified = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(311, 35);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginLeft = 5;
            this.txtEmail.TextPlaceholder = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = false;
            this.txtAddress.AcceptsTab = false;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAddress.BackgroundImage")));
            this.txtAddress.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtAddress.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAddress.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtAddress.BorderRadius = 30;
            this.txtAddress.BorderThickness = 1;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.DefaultText = "";
            this.txtAddress.FillColor = System.Drawing.Color.White;
            this.txtAddress.HideSelection = true;
            this.txtAddress.IconLeft = null;
            this.txtAddress.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.IconPadding = 10;
            this.txtAddress.IconRight = null;
            this.txtAddress.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.Location = new System.Drawing.Point(80, 282);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAddress.Modified = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(311, 35);
            this.txtAddress.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAddress.TabIndex = 7;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMarginLeft = 5;
            this.txtAddress.TextPlaceholder = "Address";
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsReturn = false;
            this.txtPhone.AcceptsTab = false;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
            this.txtPhone.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPhone.BorderColorHover = System.Drawing.Color.DodgerBlue;
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPhone.BorderRadius = 30;
            this.txtPhone.BorderThickness = 1;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.White;
            this.txtPhone.HideSelection = true;
            this.txtPhone.IconLeft = null;
            this.txtPhone.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.IconPadding = 10;
            this.txtPhone.IconRight = null;
            this.txtPhone.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.Location = new System.Drawing.Point(80, 219);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPhone.Modified = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = false;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(311, 35);
            this.txtPhone.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMarginLeft = 5;
            this.txtPhone.TextPlaceholder = "Phone";
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // isFriend
            // 
            this.isFriend.AllowBindingControlAnimation = true;
            this.isFriend.AllowBindingControlColorChanges = false;
            this.isFriend.AllowBindingControlLocation = true;
            this.isFriend.AllowCheckBoxAnimation = false;
            this.isFriend.AllowCheckmarkAnimation = true;
            this.isFriend.AllowOnHoverStates = true;
            this.isFriend.BackColor = System.Drawing.Color.Transparent;
            this.isFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isFriend.BackgroundImage")));
            this.isFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFriend.BindingControl = null;
            this.isFriend.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isFriend.Checked = true;
            this.isFriend.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isFriend.CustomCheckmarkImage = null;
            this.isFriend.Location = new System.Drawing.Point(95, 344);
            this.isFriend.MinimumSize = new System.Drawing.Size(17, 17);
            this.isFriend.Name = "isFriend";
            this.isFriend.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFriend.OnCheck.BorderRadius = 2;
            this.isFriend.OnCheck.BorderThickness = 2;
            this.isFriend.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFriend.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isFriend.OnCheck.CheckmarkThickness = 2;
            this.isFriend.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isFriend.OnDisable.BorderRadius = 2;
            this.isFriend.OnDisable.BorderThickness = 2;
            this.isFriend.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFriend.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isFriend.OnDisable.CheckmarkThickness = 2;
            this.isFriend.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFriend.OnHoverChecked.BorderRadius = 2;
            this.isFriend.OnHoverChecked.BorderThickness = 2;
            this.isFriend.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFriend.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isFriend.OnHoverChecked.CheckmarkThickness = 2;
            this.isFriend.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFriend.OnHoverUnchecked.BorderRadius = 2;
            this.isFriend.OnHoverUnchecked.BorderThickness = 2;
            this.isFriend.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFriend.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFriend.OnUncheck.BorderRadius = 2;
            this.isFriend.OnUncheck.BorderThickness = 2;
            this.isFriend.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFriend.Size = new System.Drawing.Size(21, 21);
            this.isFriend.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isFriend.TabIndex = 8;
            this.isFriend.ThreeState = false;
            this.isFriend.ToolTipText = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(127, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Friend";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(325, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Family";
            // 
            // isFamily
            // 
            this.isFamily.AllowBindingControlAnimation = true;
            this.isFamily.AllowBindingControlColorChanges = false;
            this.isFamily.AllowBindingControlLocation = true;
            this.isFamily.AllowCheckBoxAnimation = false;
            this.isFamily.AllowCheckmarkAnimation = true;
            this.isFamily.AllowOnHoverStates = true;
            this.isFamily.BackColor = System.Drawing.Color.Transparent;
            this.isFamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isFamily.BackgroundImage")));
            this.isFamily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFamily.BindingControl = null;
            this.isFamily.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isFamily.Checked = true;
            this.isFamily.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isFamily.CustomCheckmarkImage = null;
            this.isFamily.Location = new System.Drawing.Point(293, 342);
            this.isFamily.MinimumSize = new System.Drawing.Size(17, 17);
            this.isFamily.Name = "isFamily";
            this.isFamily.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFamily.OnCheck.BorderRadius = 2;
            this.isFamily.OnCheck.BorderThickness = 2;
            this.isFamily.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFamily.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isFamily.OnCheck.CheckmarkThickness = 2;
            this.isFamily.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isFamily.OnDisable.BorderRadius = 2;
            this.isFamily.OnDisable.BorderThickness = 2;
            this.isFamily.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFamily.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isFamily.OnDisable.CheckmarkThickness = 2;
            this.isFamily.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFamily.OnHoverChecked.BorderRadius = 2;
            this.isFamily.OnHoverChecked.BorderThickness = 2;
            this.isFamily.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFamily.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isFamily.OnHoverChecked.CheckmarkThickness = 2;
            this.isFamily.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFamily.OnHoverUnchecked.BorderRadius = 2;
            this.isFamily.OnHoverUnchecked.BorderThickness = 2;
            this.isFamily.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFamily.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFamily.OnUncheck.BorderRadius = 2;
            this.isFamily.OnUncheck.BorderThickness = 2;
            this.isFamily.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFamily.Size = new System.Drawing.Size(21, 21);
            this.isFamily.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isFamily.TabIndex = 10;
            this.isFamily.ThreeState = false;
            this.isFamily.ToolTipText = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(325, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Business";
            // 
            // isBusiness
            // 
            this.isBusiness.AllowBindingControlAnimation = true;
            this.isBusiness.AllowBindingControlColorChanges = false;
            this.isBusiness.AllowBindingControlLocation = true;
            this.isBusiness.AllowCheckBoxAnimation = false;
            this.isBusiness.AllowCheckmarkAnimation = true;
            this.isBusiness.AllowOnHoverStates = true;
            this.isBusiness.BackColor = System.Drawing.Color.Transparent;
            this.isBusiness.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isBusiness.BackgroundImage")));
            this.isBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isBusiness.BindingControl = null;
            this.isBusiness.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isBusiness.Checked = true;
            this.isBusiness.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isBusiness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isBusiness.CustomCheckmarkImage = null;
            this.isBusiness.Location = new System.Drawing.Point(293, 382);
            this.isBusiness.MinimumSize = new System.Drawing.Size(17, 17);
            this.isBusiness.Name = "isBusiness";
            this.isBusiness.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isBusiness.OnCheck.BorderRadius = 2;
            this.isBusiness.OnCheck.BorderThickness = 2;
            this.isBusiness.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isBusiness.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isBusiness.OnCheck.CheckmarkThickness = 2;
            this.isBusiness.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isBusiness.OnDisable.BorderRadius = 2;
            this.isBusiness.OnDisable.BorderThickness = 2;
            this.isBusiness.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isBusiness.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isBusiness.OnDisable.CheckmarkThickness = 2;
            this.isBusiness.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isBusiness.OnHoverChecked.BorderRadius = 2;
            this.isBusiness.OnHoverChecked.BorderThickness = 2;
            this.isBusiness.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isBusiness.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isBusiness.OnHoverChecked.CheckmarkThickness = 2;
            this.isBusiness.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isBusiness.OnHoverUnchecked.BorderRadius = 2;
            this.isBusiness.OnHoverUnchecked.BorderThickness = 2;
            this.isBusiness.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isBusiness.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isBusiness.OnUncheck.BorderRadius = 2;
            this.isBusiness.OnUncheck.BorderThickness = 2;
            this.isBusiness.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isBusiness.Size = new System.Drawing.Size(21, 21);
            this.isBusiness.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isBusiness.TabIndex = 14;
            this.isBusiness.ThreeState = false;
            this.isBusiness.ToolTipText = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(127, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Co-Worker";
            // 
            // isCoWorker
            // 
            this.isCoWorker.AllowBindingControlAnimation = true;
            this.isCoWorker.AllowBindingControlColorChanges = false;
            this.isCoWorker.AllowBindingControlLocation = true;
            this.isCoWorker.AllowCheckBoxAnimation = false;
            this.isCoWorker.AllowCheckmarkAnimation = true;
            this.isCoWorker.AllowOnHoverStates = true;
            this.isCoWorker.BackColor = System.Drawing.Color.Transparent;
            this.isCoWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isCoWorker.BackgroundImage")));
            this.isCoWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isCoWorker.BindingControl = null;
            this.isCoWorker.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isCoWorker.Checked = true;
            this.isCoWorker.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isCoWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isCoWorker.CustomCheckmarkImage = null;
            this.isCoWorker.Location = new System.Drawing.Point(95, 384);
            this.isCoWorker.MinimumSize = new System.Drawing.Size(17, 17);
            this.isCoWorker.Name = "isCoWorker";
            this.isCoWorker.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isCoWorker.OnCheck.BorderRadius = 2;
            this.isCoWorker.OnCheck.BorderThickness = 2;
            this.isCoWorker.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isCoWorker.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isCoWorker.OnCheck.CheckmarkThickness = 2;
            this.isCoWorker.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isCoWorker.OnDisable.BorderRadius = 2;
            this.isCoWorker.OnDisable.BorderThickness = 2;
            this.isCoWorker.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isCoWorker.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isCoWorker.OnDisable.CheckmarkThickness = 2;
            this.isCoWorker.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isCoWorker.OnHoverChecked.BorderRadius = 2;
            this.isCoWorker.OnHoverChecked.BorderThickness = 2;
            this.isCoWorker.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isCoWorker.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isCoWorker.OnHoverChecked.CheckmarkThickness = 2;
            this.isCoWorker.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isCoWorker.OnHoverUnchecked.BorderRadius = 2;
            this.isCoWorker.OnHoverUnchecked.BorderThickness = 2;
            this.isCoWorker.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isCoWorker.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isCoWorker.OnUncheck.BorderRadius = 2;
            this.isCoWorker.OnUncheck.BorderThickness = 2;
            this.isCoWorker.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isCoWorker.Size = new System.Drawing.Size(21, 21);
            this.isCoWorker.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isCoWorker.TabIndex = 12;
            this.isCoWorker.ThreeState = false;
            this.isCoWorker.ToolTipText = null;
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurTab.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurTab.Location = new System.Drawing.Point(173, 25);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(102, 21);
            this.lblCurTab.TabIndex = 16;
            this.lblCurTab.Text = "Add Contact";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 54);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(476, 35);
            this.bunifuSeparator1.TabIndex = 17;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Transparent;
            this.btnAddContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddContact.BackgroundImage")));
            this.btnAddContact.ButtonText = "Add Contact";
            this.btnAddContact.ButtonTextMarginLeft = 0;
            this.btnAddContact.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddContact.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddContact.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddContact.ForeColor = System.Drawing.Color.White;
            this.btnAddContact.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddContact.IconPadding = 10;
            this.btnAddContact.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddContact.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleBorderRadius = 35;
            this.btnAddContact.IdleBorderThickness = 0;
            this.btnAddContact.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleIconLeftImage = null;
            this.btnAddContact.IdleIconRightImage = null;
            this.btnAddContact.Location = new System.Drawing.Point(80, 438);
            this.btnAddContact.Name = "btnAddContact";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 35;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddContact.onHoverState = stateProperties1;
            this.btnAddContact.Size = new System.Drawing.Size(311, 45);
            this.btnAddContact.TabIndex = 18;
            this.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 524);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isBusiness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isCoWorker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isFamily);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isFriend);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bunifuImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddContact";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAddress;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPhone;
        private Bunifu.UI.WinForms.BunifuCheckBox isFriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuCheckBox isFamily;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuCheckBox isBusiness;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuCheckBox isCoWorker;
        private System.Windows.Forms.Label lblCurTab;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddContact;
    }
}