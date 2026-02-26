namespace LibraryManagementSystem.Forms
{
    partial class LoginForm
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
            label1 = new Label();
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonClear = new Button();
            buttonExit = new Button();
            panel1 = new Panel();
            checkBoxShow = new CheckBox();
            buttonRegistrationPage = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 33);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(413, 42);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // labelUserName
            // 
            labelUserName.Anchor = AnchorStyles.None;
            labelUserName.AutoSize = true;
            labelUserName.Cursor = Cursors.IBeam;
            labelUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(89, 95);
            labelUserName.Margin = new Padding(5, 0, 5, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(114, 25);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "UserName: ";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.Cursor = Cursors.IBeam;
            labelPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(89, 170);
            labelPassword.Margin = new Padding(5, 0, 5, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(107, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password: ";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.None;
            textBoxUserName.Cursor = Cursors.IBeam;
            textBoxUserName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(89, 125);
            textBoxUserName.Margin = new Padding(5);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(323, 33);
            textBoxUserName.TabIndex = 3;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            textBoxUserName.KeyDown += textBoxUserName_KeyDown;
            textBoxUserName.KeyPress += textBoxUserName_KeyPress;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(89, 200);
            textBoxPassword.Margin = new Padding(5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(323, 33);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            textBoxPassword.KeyUp += textBoxPassword_KeyUp;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.BackColor = SystemColors.Info;
            buttonLogin.BackgroundImageLayout = ImageLayout.None;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Location = new Point(89, 268);
            buttonLogin.Margin = new Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(323, 38);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.None;
            buttonClear.BackColor = SystemColors.Info;
            buttonClear.BackgroundImageLayout = ImageLayout.None;
            buttonClear.Cursor = Cursors.Hand;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Location = new Point(342, 409);
            buttonClear.Margin = new Padding(5);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(118, 38);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.None;
            buttonExit.BackColor = SystemColors.Info;
            buttonExit.BackgroundImageLayout = ImageLayout.None;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Location = new Point(51, 409);
            buttonExit.Margin = new Padding(5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(118, 38);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(checkBoxShow);
            panel1.Controls.Add(buttonRegistrationPage);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUserName);
            panel1.Location = new Point(371, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 479);
            panel1.TabIndex = 8;
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            checkBoxShow.Location = new Point(93, 235);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(63, 23);
            checkBoxShow.TabIndex = 9;
            checkBoxShow.Text = "Show";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // buttonRegistrationPage
            // 
            buttonRegistrationPage.Anchor = AnchorStyles.None;
            buttonRegistrationPage.BackColor = SystemColors.ActiveBorder;
            buttonRegistrationPage.BackgroundImageLayout = ImageLayout.None;
            buttonRegistrationPage.Cursor = Cursors.Hand;
            buttonRegistrationPage.FlatStyle = FlatStyle.Popup;
            buttonRegistrationPage.Location = new Point(89, 316);
            buttonRegistrationPage.Margin = new Padding(5);
            buttonRegistrationPage.Name = "buttonRegistrationPage";
            buttonRegistrationPage.Size = new Size(323, 38);
            buttonRegistrationPage.TabIndex = 8;
            buttonRegistrationPage.Text = "Register";
            buttonRegistrationPage.UseVisualStyleBackColor = false;
            buttonRegistrationPage.Click += buttonRegistrationPage_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.abundant_collection_antique_book;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPage";
            Load += LoginPage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonClear;
        private Button buttonExit;
        private Panel panel1;
        private Button buttonRegistrationPage;
        private CheckBox checkBoxShow;
    }
}