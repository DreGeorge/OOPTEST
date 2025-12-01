using System;
using System.Windows.Forms;

namespace AttendanceTracker
{
    public partial class LoginForm : Form
    {
        private Panel shadow;

        public LoginForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.DoubleBuffered = true;

            this.Load += LoginForm_Load;
            this.Resize += LoginForm_Resize;

            btnLogin.Click += BtnLogin_Click;
            lblRegister.Click += LblRegister_Click;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LoginFormStyler.PaintGradientBackground(this, e);
            base.OnPaint(e);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Setup design once
            LoginFormStyler.SetupStaticUI(
                btnLogin,
                lblRegister,
                panelUser,
                panelPass
            );

            // Placeholders
            LoginFormStyler.SetPlaceholder(txtID, "ID");
            LoginFormStyler.SetPlaceholder(txtPassword, "Password", isPassword: true);

            ApplyUI();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            ApplyUI();
        }

        private void ApplyUI()
        {
            shadow = LoginFormStyler.ApplyRuntimeTweaks(
                this,
                pnlCard,
                shadow,
                lblTitle,
                panelUser,
                panelPass,
                btnLogin,
                lblRegister,
                txtID,
                txtPassword
            );
        }

        // PURE LOGIC (later DB check)
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string password = txtPassword.Text;

            if (id == "ID" || password == "Password")
            {
                MessageBox.Show("Please enter ID and password.");
                return;
            }

            bool valid = UserRepository.ValidateLogin(id, password);

            if (valid)
            {
                MessageBox.Show("Login successful!");
                // TODO: open another form after login
                // new DashboardForm(id).Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or password.");
            }
        }


        private void LblRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.FormClosed += (s, args) => this.Show();
            reg.Show();
            this.Hide();
        }
    }
}
