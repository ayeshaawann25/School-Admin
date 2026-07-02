namespace SchoolAdmin
{
    partial class Form1
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
            this.panelHeader = new Panel();
            this.lblLogin = new Label();
            this.lblTitle = new Label();

            this.panelMain = new Panel();
            this.lblWelcome = new Label();

            this.btnAdmission = new Button();
            this.btnFee = new Button();
            this.btnLogout = new Button();
            this.btnExit = new Button();

            this.lblFooter = new Label();

            // ===== Form =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(240, 245, 252);
            this.ClientSize = new Size(900, 550);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Student Admission System";

            // ===== Header =====
            panelHeader.BackColor = Color.FromArgb(52, 120, 200);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 70;

            lblTitle.Text = "🎓 Student Admission System";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.AutoSize = true;

            lblLogin.Text = "Logged in as: admin";
            lblLogin.ForeColor = Color.White;
            lblLogin.Font = new Font("Segoe UI", 10F);
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(700, 25);

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(lblLogin);

            // ===== Main Panel =====
            panelMain.BackColor = Color.White;
            panelMain.Size = new Size(760, 380);
            panelMain.Location = new Point(70, 100);

            lblWelcome.Text = "Welcome to the Student Admission System";
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(40, 70, 120);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(140, 20);

            // ===== Buttons =====
            ConfigureButton(btnAdmission, "Student Admission", 100, 90, true);
            ConfigureButton(btnFee, "Fee Slip", 400, 90, true);
            ConfigureButton(btnLogout, "Logout", 100, 200, false);
            ConfigureButton(btnExit, "Exit", 400, 200, false);

            panelMain.Controls.Add(lblWelcome);
            panelMain.Controls.Add(btnAdmission);
            panelMain.Controls.Add(btnFee);
            panelMain.Controls.Add(btnLogout);
            panelMain.Controls.Add(btnExit);

            // ===== Footer =====
            lblFooter.Text = "© 2025 Student Admission System";
            lblFooter.Font = new Font("Segoe UI", 9F);
            lblFooter.ForeColor = Color.Gray;
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(330, 500);

            // ===== Add Controls =====
            this.Controls.Add(panelHeader);
            this.Controls.Add(panelMain);
            this.Controls.Add(lblFooter);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelMain;
        private Label lblTitle;
        private Label lblLogin;
        private Label lblWelcome;
        private Label lblFooter;
        private Button btnAdmission;
        private Button btnFee;
        private Button btnLogout;
        private Button btnExit;

        private void ConfigureButton(Button btn, string text, int x, int y, bool primary)
        {
            btn.Text = text;
            btn.Size = new Size(240, 80);
            btn.Location = new Point(x, y);
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            if (primary)
            {
                btn.BackColor = Color.FromArgb(52, 120, 200);
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.BackColor = Color.FromArgb(245, 247, 250);
                btn.ForeColor = Color.FromArgb(70, 90, 120);
            }
        }
    }
}
