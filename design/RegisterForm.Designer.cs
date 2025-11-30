namespace AttendanceTracker
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();

            this.pnlID = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.txtContact = new System.Windows.Forms.TextBox();

            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();

            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlConfirmPassword = new System.Windows.Forms.Panel();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();

            this.btnRegister = new System.Windows.Forms.Button();
            this.lblBackToLogin = new System.Windows.Forms.Label();

            this.pnlCard.SuspendLayout();

            this.pnlFirstName.SuspendLayout();
            this.pnlLastName.SuspendLayout();
            this.pnlID.SuspendLayout();
            this.pnlContact.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlConfirmPassword.SuspendLayout();

            this.SuspendLayout();
            // 
            // pnlCard (VERY WIDE)
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblTitle);

            this.pnlCard.Controls.Add(this.pnlFirstName);
            this.pnlCard.Controls.Add(this.pnlLastName);

            this.pnlCard.Controls.Add(this.pnlID);
            this.pnlCard.Controls.Add(this.pnlContact);

            this.pnlCard.Controls.Add(this.pnlAddress);
            this.pnlCard.Controls.Add(this.pnlEmail);

            this.pnlCard.Controls.Add(this.pnlPassword);
            this.pnlCard.Controls.Add(this.pnlConfirmPassword);

            this.pnlCard.Controls.Add(this.btnRegister);
            this.pnlCard.Controls.Add(this.lblBackToLogin);

            this.pnlCard.Location = new System.Drawing.Point(101, 15); // centered for 680 width
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(680, 700); // ✅ takes most of center screen
            this.pnlCard.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(275, 65); // centered for 680w
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Register";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // New geometry for 680px card:
            // Left X = 90
            // Right X = 370
            // Column width = 220
            // Gap = 60
            // Full width fields = 500 (same as button)
            //
            // pnlFirstName
            // 
            this.pnlFirstName.BackColor = System.Drawing.Color.White;
            this.pnlFirstName.Controls.Add(this.txtFirstName);
            this.pnlFirstName.Location = new System.Drawing.Point(90, 145);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Size = new System.Drawing.Size(220, 58); // ✅ roomy
            this.pnlFirstName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.Location = new System.Drawing.Point(0, 0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 27);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Text = "First Name";
            // 
            // pnlLastName
            // 
            this.pnlLastName.BackColor = System.Drawing.Color.White;
            this.pnlLastName.Controls.Add(this.txtLastName);
            this.pnlLastName.Location = new System.Drawing.Point(370, 145);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Size = new System.Drawing.Size(220, 58);
            this.pnlLastName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.Location = new System.Drawing.Point(0, 0);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(220, 27);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.Text = "Last Name";
            // 
            // pnlID
            // 
            this.pnlID.BackColor = System.Drawing.Color.White;
            this.pnlID.Controls.Add(this.txtID);
            this.pnlID.Location = new System.Drawing.Point(90, 220);
            this.pnlID.Name = "pnlID";
            this.pnlID.Size = new System.Drawing.Size(220, 58);
            this.pnlID.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 27);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "ID";
            // 
            // pnlContact
            // 
            this.pnlContact.BackColor = System.Drawing.Color.White;
            this.pnlContact.Controls.Add(this.txtContact);
            this.pnlContact.Location = new System.Drawing.Point(370, 220);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(220, 58);
            this.pnlContact.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContact.ForeColor = System.Drawing.Color.Gray;
            this.txtContact.Location = new System.Drawing.Point(0, 0);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(220, 27);
            this.txtContact.TabIndex = 0;
            this.txtContact.Text = "Contact Number";
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.White;
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Location = new System.Drawing.Point(90, 305);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(500, 75); // ✅ full wide block
            this.pnlAddress.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtAddress.Location = new System.Drawing.Point(0, 0);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(500, 75);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.Text = "Address";
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(90, 400);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(500, 58);
            this.pnlEmail.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(0, 0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 27);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Email";
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(90, 480);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(220, 58);
            this.pnlPassword.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 27);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Password";
            // 
            // pnlConfirmPassword
            // 
            this.pnlConfirmPassword.BackColor = System.Drawing.Color.White;
            this.pnlConfirmPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlConfirmPassword.Location = new System.Drawing.Point(370, 480);
            this.pnlConfirmPassword.Name = "pnlConfirmPassword";
            this.pnlConfirmPassword.Size = new System.Drawing.Size(220, 58);
            this.pnlConfirmPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.Location = new System.Drawing.Point(0, 0);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(220, 27);
            this.txtConfirmPassword.TabIndex = 0;
            this.txtConfirmPassword.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(90, 565);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(500, 50);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblBackToLogin
            // 
            this.lblBackToLogin.AutoSize = true;
            this.lblBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBackToLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblBackToLogin.ForeColor = System.Drawing.Color.Black;
            this.lblBackToLogin.Location = new System.Drawing.Point(285, 650); // centered
            this.lblBackToLogin.Name = "lblBackToLogin";
            this.lblBackToLogin.Size = new System.Drawing.Size(110, 25);
            this.lblBackToLogin.TabIndex = 10;
            this.lblBackToLogin.Text = "Back to Login";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 680);
            this.Controls.Add(this.pnlCard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterForm";
            this.Text = "Register";

            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();

            this.pnlFirstName.ResumeLayout(false);
            this.pnlFirstName.PerformLayout();
            this.pnlLastName.ResumeLayout(false);
            this.pnlLastName.PerformLayout();
            this.pnlID.ResumeLayout(false);
            this.pnlID.PerformLayout();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlConfirmPassword.ResumeLayout(false);
            this.pnlConfirmPassword.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.TextBox txtLastName;

        private System.Windows.Forms.Panel pnlID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.TextBox txtContact;

        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txtAddress;

        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblBackToLogin;
    }
}
