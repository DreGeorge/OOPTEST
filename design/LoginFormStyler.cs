using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AttendanceTracker
{
    public static class LoginFormStyler
    {
        public static void SetupStaticUI(
            Button btnLogin,
            Label lblRegister,
            Panel panelUser,
            Panel panelPass)
        {
            btnLogin.BackColor = Color.FromArgb(80, 120, 255);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Height = 50;

            StyleInputPanel(panelUser);
            StyleInputPanel(panelPass);

            panelUser.Paint -= DrawLightBorder;
            panelPass.Paint -= DrawLightBorder;
            panelUser.Paint += DrawLightBorder;
            panelPass.Paint += DrawLightBorder;

            btnLogin.MouseEnter += (s, e) =>
                btnLogin.BackColor = Color.FromArgb(60, 100, 230);
            btnLogin.MouseLeave += (s, e) =>
                btnLogin.BackColor = Color.FromArgb(80, 120, 255);

            lblRegister.MouseEnter += (s, e) =>
                lblRegister.ForeColor = Color.FromArgb(80, 120, 255);
            lblRegister.MouseLeave += (s, e) =>
                lblRegister.ForeColor = Color.Black;
        }

        public static Panel ApplyRuntimeTweaks(
            Form form,
            Panel pnlCard,
            Panel shadow,
            Label lblTitle,
            Panel panelUser,
            Panel panelPass,
            Button btnLogin,
            Label lblRegister,
            TextBox txtID,
            TextBox txtPassword)
        {
            CenterCard(form, pnlCard);
            ApplyRoundedCorners(pnlCard);

            shadow = EnsureShadow(form, pnlCard, shadow);
            UpdateShadow(pnlCard, shadow);

            // ✅ NEW vertical rhythm for bigger card
            panelUser.Top = lblTitle.Bottom + 35;
            panelPass.Top = panelUser.Bottom + 20;
            btnLogin.Top = panelPass.Bottom + 30;
            lblRegister.Top = btnLogin.Bottom + 18;

            CenterControlsHorizontally(pnlCard, lblTitle, panelUser, panelPass, btnLogin, lblRegister);

            AlignInPanel(txtID, panelUser);
            AlignInPanel(txtPassword, panelPass);

            if (txtPassword.Text == "Password")
                txtPassword.ForeColor = Color.FromArgb(120, 120, 120);

            return shadow;
        }

        public static void PaintGradientBackground(Form form, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, form.Width, form.Height);
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(80, 140, 255),
                Color.FromArgb(160, 80, 255),
                45f))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        public static void SetPlaceholder(TextBox tb, string placeholder, bool isPassword = false)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;
            tb.UseSystemPasswordChar = false;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                    if (isPassword) tb.UseSystemPasswordChar = true;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                    if (isPassword) tb.UseSystemPasswordChar = false;
                }
            };
        }

        private static void StyleInputPanel(Panel p)
        {
            p.BackColor = Color.FromArgb(245, 245, 245);
            p.Padding = new Padding(12, 0, 12, 0); // ✅ more padding
        }

        private static void DrawLightBorder(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            if (p == null) return;

            using (Pen pen = new Pen(Color.FromArgb(220, 220, 220), 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen, 0, 0, p.Width - 1, p.Height - 1);
            }
        }

        private static void AlignInPanel(TextBox tb, Panel p)
        {
            tb.AutoSize = false;
            tb.Height = 27;
            tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            tb.Top = (p.Height - tb.Height) / 2;
            tb.Left = p.Padding.Left;

            int w = p.ClientSize.Width - p.Padding.Horizontal;
            if (w > 0) tb.Width = w;
        }

        private static void CenterControlsHorizontally(
            Panel pnlCard,
            Label lblTitle,
            Panel panelUser,
            Panel panelPass,
            Button btnLogin,
            Label lblRegister)
        {
            panelUser.Left = (pnlCard.Width - panelUser.Width) / 2;
            panelPass.Left = (pnlCard.Width - panelPass.Width) / 2;
            btnLogin.Left = (pnlCard.Width - btnLogin.Width) / 2;
            lblRegister.Left = (pnlCard.Width - lblRegister.Width) / 2;
            lblTitle.Left = (pnlCard.Width - lblTitle.Width) / 2;
        }

        private static void ApplyRoundedCorners(Panel pnlCard, int radius = 20)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(pnlCard.Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(pnlCard.Width - radius, pnlCard.Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, pnlCard.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();
                pnlCard.Region = new Region(path);
            }
        }

        private static void CenterCard(Form form, Panel pnlCard)
        {
            pnlCard.Left = (form.ClientSize.Width - pnlCard.Width) / 2;
            pnlCard.Top = (form.ClientSize.Height - pnlCard.Height) / 2;
        }

        private static Panel EnsureShadow(Form form, Panel pnlCard, Panel shadow)
        {
            if (shadow == null)
            {
                shadow = new Panel
                {
                    Size = pnlCard.Size,
                    BackColor = Color.FromArgb(50, 0, 0, 0),
                    Enabled = false
                };
                form.Controls.Add(shadow);
                shadow.SendToBack();
            }
            return shadow;
        }

        private static void UpdateShadow(Panel pnlCard, Panel shadow)
        {
            if (shadow == null) return;
            shadow.Size = pnlCard.Size;
            shadow.Location = new Point(pnlCard.Left + 5, pnlCard.Top + 5);
            shadow.SendToBack();
            pnlCard.BringToFront();
        }
    }
}
