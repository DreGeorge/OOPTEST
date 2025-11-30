using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AttendanceTracker
{
    public static class RegisterFormStyler
    {
        // Call once on Load
        public static void SetupStaticUI(
            Button btnRegister,
            Label lblBackToLogin,
            params Panel[] inputPanels)
        {
            // Button styles
            btnRegister.BackColor = Color.FromArgb(80, 120, 255);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Height = 50;

            // Panels style + light borders
            foreach (Panel p in inputPanels)
            {
                StyleInputPanel(p);
                p.Paint -= DrawLightBorder;   // avoid double-hook
                p.Paint += DrawLightBorder;
            }

            // Hover effects
            btnRegister.MouseEnter += (s, e) =>
                btnRegister.BackColor = Color.FromArgb(60, 100, 230);
            btnRegister.MouseLeave += (s, e) =>
                btnRegister.BackColor = Color.FromArgb(80, 120, 255);

            lblBackToLogin.MouseEnter += (s, e) =>
                lblBackToLogin.ForeColor = Color.FromArgb(80, 120, 255);
            lblBackToLogin.MouseLeave += (s, e) =>
                lblBackToLogin.ForeColor = Color.Black;
        }

        // Call on Load and Resize
        public static Panel ApplyRuntimeTweaks(
            Form form,
            Panel pnlCard,
            Panel shadow,
            Label lblTitle,
            Button btnRegister,
            Label lblBackToLogin,
            params (TextBox tb, Panel panel)[] fields)
        {
            CenterCard(form, pnlCard);
            ApplyRoundedCorners(pnlCard);

            shadow = EnsureShadow(form, pnlCard, shadow);
            UpdateShadow(pnlCard, shadow);

            foreach (var f in fields)
                AlignInPanel(f.tb, f.panel);

            CenterTitleAndBottom(pnlCard, lblTitle, btnRegister, lblBackToLogin);

            return shadow;
        }

        // Gradient background helper (for Form.OnPaint)
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
            p.Padding = new Padding(10, 0, 10, 0);
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

        private static void CenterTitleAndBottom(
            Panel pnlCard, Label lblTitle, Button btnRegister, Label lblBackToLogin)
        {
            lblTitle.Left = (pnlCard.Width - lblTitle.Width) / 2;
            btnRegister.Left = (pnlCard.Width - btnRegister.Width) / 2;
            lblBackToLogin.Left = (pnlCard.Width - lblBackToLogin.Width) / 2;
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
