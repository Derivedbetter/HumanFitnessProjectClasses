
namespace HumanFitnessProjectClasses
{
    public partial class WelcomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.motivationPicture1 = new System.Windows.Forms.PictureBox();
            this.gladLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.emailAddressBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthBox = new System.Windows.Forms.DateTimePicker();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.createPerson = new System.Windows.Forms.Label();
            this.addToEmail = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.submitAddress = new System.Windows.Forms.Label();
            this.createClient = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivationPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo1
            // 
            this.logo1.Image = global::HumanFitnessProjectClasses.Properties.Resources.Color_logo_with_background;
            this.logo1.Location = new System.Drawing.Point(12, 12);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(148, 148);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HumanFitnessProjectClasses.Properties.Resources.Color_logo_with_background;
            this.pictureBox1.Location = new System.Drawing.Point(1199, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // motivationPicture1
            // 
            this.motivationPicture1.Image = global::HumanFitnessProjectClasses.Properties.Resources.screen4;
            this.motivationPicture1.Location = new System.Drawing.Point(410, 89);
            this.motivationPicture1.Name = "motivationPicture1";
            this.motivationPicture1.Size = new System.Drawing.Size(526, 512);
            this.motivationPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.motivationPicture1.TabIndex = 2;
            this.motivationPicture1.TabStop = false;
            // 
            // gladLabel
            // 
            this.gladLabel.AutoSize = true;
            this.gladLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.gladLabel.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.gladLabel.Location = new System.Drawing.Point(353, 7);
            this.gladLabel.Name = "gladLabel";
            this.gladLabel.Size = new System.Drawing.Size(400, 49);
            this.gladLabel.TabIndex = 3;
            this.gladLabel.Text = "We are so glad you\'re here!";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.firstNameBox.Location = new System.Drawing.Point(194, 332);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(200, 30);
            this.firstNameBox.TabIndex = 4;
            this.firstNameBox.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lastNameBox.Location = new System.Drawing.Point(194, 381);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(200, 30);
            this.lastNameBox.TabIndex = 5;
            // 
            // emailAddressBox
            // 
            this.emailAddressBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.emailAddressBox.Location = new System.Drawing.Point(194, 479);
            this.emailAddressBox.Name = "emailAddressBox";
            this.emailAddressBox.Size = new System.Drawing.Size(200, 30);
            this.emailAddressBox.TabIndex = 7;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(33, 332);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(95, 24);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name:";
            // 
            // dateOfBirthBox
            // 
            this.dateOfBirthBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthBox.Location = new System.Drawing.Point(194, 430);
            this.dateOfBirthBox.Name = "dateOfBirthBox";
            this.dateOfBirthBox.Size = new System.Drawing.Size(200, 30);
            this.dateOfBirthBox.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(33, 385);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(92, 24);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.dateOfBirthLabel.Location = new System.Drawing.Point(9, 430);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(110, 24);
            this.dateOfBirthLabel.TabIndex = 11;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.emailAddressLabel.Location = new System.Drawing.Point(-2, 483);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(116, 24);
            this.emailAddressLabel.TabIndex = 12;
            this.emailAddressLabel.Text = "Email Address:";
            // 
            // createPerson
            // 
            this.createPerson.AutoSize = true;
            this.createPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createPerson.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.createPerson.Location = new System.Drawing.Point(194, 524);
            this.createPerson.Name = "createPerson";
            this.createPerson.Size = new System.Drawing.Size(43, 24);
            this.createPerson.TabIndex = 13;
            this.createPerson.Text = "Save";
            this.createPerson.Click += new System.EventHandler(this.createPerson_Click);
            // 
            // addToEmail
            // 
            this.addToEmail.AutoSize = true;
            this.addToEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addToEmail.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.addToEmail.Location = new System.Drawing.Point(326, 524);
            this.addToEmail.Name = "addToEmail";
            this.addToEmail.Size = new System.Drawing.Size(68, 24);
            this.addToEmail.TabIndex = 14;
            this.addToEmail.Text = "Add Me";
            this.addToEmail.Click += new System.EventHandler(this.addToEmail_Click);
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.addressBox.Location = new System.Drawing.Point(1124, 332);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(200, 27);
            this.addressBox.TabIndex = 15;
            this.addressBox.Visible = false;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(1039, 332);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(70, 24);
            this.addressLabel.TabIndex = 16;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Visible = false;
            // 
            // submitAddress
            // 
            this.submitAddress.AutoSize = true;
            this.submitAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.submitAddress.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.submitAddress.Location = new System.Drawing.Point(1165, 365);
            this.submitAddress.Name = "submitAddress";
            this.submitAddress.Size = new System.Drawing.Size(118, 24);
            this.submitAddress.TabIndex = 17;
            this.submitAddress.Text = "Submit Address";
            this.submitAddress.Visible = false;
            this.submitAddress.Click += new System.EventHandler(this.submitAddress_Click);
            // 
            // createClient
            // 
            this.createClient.AutoSize = true;
            this.createClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createClient.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.createClient.Location = new System.Drawing.Point(1029, 577);
            this.createClient.Name = "createClient";
            this.createClient.Size = new System.Drawing.Size(295, 24);
            this.createClient.TabIndex = 18;
            this.createClient.Text = "Click me to buy your first training session";
            this.createClient.Visible = false;
            this.createClient.Click += new System.EventHandler(this.createClient_Click);
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberBox.Location = new System.Drawing.Point(1124, 524);
            this.phoneNumberBox.Multiline = true;
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(200, 27);
            this.phoneNumberBox.TabIndex = 19;
            this.phoneNumberBox.Visible = false;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.Location = new System.Drawing.Point(990, 527);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(119, 24);
            this.phoneNumberLabel.TabIndex = 20;
            this.phoneNumberLabel.Text = "Phone Number:";
            this.phoneNumberLabel.Visible = false;
            this.phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1359, 634);
            this.ControlBox = false;
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.createClient);
            this.Controls.Add(this.submitAddress);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.addToEmail);
            this.Controls.Add(this.createPerson);
            this.Controls.Add(this.emailAddressLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.dateOfBirthBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailAddressBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.gladLabel);
            this.Controls.Add(this.motivationPicture1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logo1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1385, 705);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Human Fitness Project";
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivationPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox motivationPicture1;
        private System.Windows.Forms.Label gladLabel;
        public System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        public System.Windows.Forms.TextBox emailAddressBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label emailAddressLabel;
        private System.Windows.Forms.Label createPerson;
        public System.Windows.Forms.Label addToEmail;
        public System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label addressLabel;
        public System.Windows.Forms.Label submitAddress;
        public System.Windows.Forms.Label createClient;
        public System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label phoneNumberLabel;
    }
}

