namespace ShopManagement
{
    partial class Form2
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
            this.lblRegisterUser = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblMobilenumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbbxType = new System.Windows.Forms.ComboBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rdbbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegisterUser
            // 
            this.lblRegisterUser.AutoSize = true;
            this.lblRegisterUser.Location = new System.Drawing.Point(387, 14);
            this.lblRegisterUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterUser.Name = "lblRegisterUser";
            this.lblRegisterUser.Size = new System.Drawing.Size(107, 20);
            this.lblRegisterUser.TabIndex = 0;
            this.lblRegisterUser.Text = "Register User";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(189, 55);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(189, 134);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(189, 229);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(189, 329);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            this.lblGender.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(194, 415);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 20);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State";
            // 
            // lblMobilenumber
            // 
            this.lblMobilenumber.AutoSize = true;
            this.lblMobilenumber.Location = new System.Drawing.Point(189, 523);
            this.lblMobilenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobilenumber.Name = "lblMobilenumber";
            this.lblMobilenumber.Size = new System.Drawing.Size(113, 20);
            this.lblMobilenumber.TabIndex = 6;
            this.lblMobilenumber.Text = "Mobile number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(510, 129);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(508, 218);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(510, 518);
            this.txtMobileNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(180, 26);
            this.txtMobileNumber.TabIndex = 9;
            this.txtMobileNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(510, 626);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 26);
            this.txtPassword.TabIndex = 10;
            // 
            // cmbbxType
            // 
            this.cmbbxType.FormattingEnabled = true;
            this.cmbbxType.Location = new System.Drawing.Point(510, 51);
            this.cmbbxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxType.Name = "cmbbxType";
            this.cmbbxType.Size = new System.Drawing.Size(180, 28);
            this.cmbbxType.TabIndex = 11;
            this.cmbbxType.SelectedIndexChanged += new System.EventHandler(this.cmbbxType_SelectedIndexChanged);
            // 
            // cmbbxState
            // 
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(510, 403);
            this.cmbbxState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(180, 28);
            this.cmbbxState.TabIndex = 12;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(189, 637);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // rdbbtnMale
            // 
            this.rdbbtnMale.AutoSize = true;
            this.rdbbtnMale.Location = new System.Drawing.Point(528, 320);
            this.rdbbtnMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbbtnMale.Name = "rdbbtnMale";
            this.rdbbtnMale.Size = new System.Drawing.Size(68, 24);
            this.rdbbtnMale.TabIndex = 14;
            this.rdbbtnMale.TabStop = true;
            this.rdbbtnMale.Text = "Male";
            this.rdbbtnMale.UseVisualStyleBackColor = true;
            this.rdbbtnMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // rdbbtnFemale
            // 
            this.rdbbtnFemale.AutoSize = true;
            this.rdbbtnFemale.Location = new System.Drawing.Point(720, 320);
            this.rdbbtnFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbbtnFemale.Name = "rdbbtnFemale";
            this.rdbbtnFemale.Size = new System.Drawing.Size(87, 24);
            this.rdbbtnFemale.TabIndex = 15;
            this.rdbbtnFemale.TabStop = true;
            this.rdbbtnFemale.Text = "Female";
            this.rdbbtnFemale.UseVisualStyleBackColor = true;
            this.rdbbtnFemale.CheckedChanged += new System.EventHandler(this.rbtFemale_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(392, 708);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 35);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(658, 708);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 792);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.rdbbtnFemale);
            this.Controls.Add(this.rdbbtnMale);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.cmbbxType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMobilenumber);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblRegisterUser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisterUser;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblMobilenumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbbxType;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.RadioButton rdbbtnMale;
        private System.Windows.Forms.RadioButton rdbbtnFemale;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
    }
}