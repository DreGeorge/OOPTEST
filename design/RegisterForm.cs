using System;
using System.Windows.Forms;

namespace AttendanceTracker
{
    public partial class RegisterForm : Form
    {
        private Panel shadow;

        public RegisterForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            this.Load += RegisterForm_Load;
            this.Resize += RegisterForm_Resize;

            btnRegister.Click += BtnRegister_Click;
            lblBackToLogin.Click += LblBackToLogin_Click;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            RegisterFormStyler.PaintGradientBackground(this, e);
            base.OnPaint(e);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Setup design once
            RegisterFormStyler.SetupStaticUI(
                btnRegister,
                lblBackToLogin,
                pnlFirstName, pnlLastName, pnlID, pnlContact,
                pnlAddress, pnlEmail, pnlPassword, pnlConfirmPassword
            );

            // Placeholders
            RegisterFormStyler.SetPlaceholder(txtFirstName, "First Name");
            RegisterFormStyler.SetPlaceholder(txtLastName, "Last Name");
            RegisterFormStyler.SetPlaceholder(txtID, "ID");
            RegisterFormStyler.SetPlaceholder(txtContact, "Contact Number");
            RegisterFormStyler.SetPlaceholder(txtAddress, "Address");
            RegisterFormStyler.SetPlaceholder(txtEmail, "Email");
            RegisterFormStyler.SetPlaceholder(txtPassword, "Password", isPassword: true);
            RegisterFormStyler.SetPlaceholder(txtConfirmPassword, "Confirm Password", isPassword: true);

            ApplyUI();
        }

        private void RegisterForm_Resize(object sender, EventArgs e)
        {
            ApplyUI();
        }

        private void ApplyUI()
        {
            shadow = RegisterFormStyler.ApplyRuntimeTweaks(
                this,
                pnlCard,
                shadow,
                lblTitle,
                btnRegister,
                lblBackToLogin,
                (txtFirstName, pnlFirstName),
                (txtLastName, pnlLastName),
                (txtID, pnlID),
                (txtContact, pnlContact),
                (txtAddress, pnlAddress),
                (txtEmail, pnlEmail),
                (txtPassword, pnlPassword),
                (txtConfirmPassword, pnlConfirmPassword)
            );
        }

        // PURE LOGIC (DB validation later)
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register logic will be added later.");
        }

        private void LblBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
