namespace StudentViolationApp.View
{
    partial class DefaultForm
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
            this.txtBoxSearchAll = new System.Windows.Forms.TextBox();
            this.panelAppName = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelAccountConainer = new System.Windows.Forms.Panel();
            this.panelProfile_Logout = new System.Windows.Forms.Panel();
            this.panelLblAccountDisp = new System.Windows.Forms.Panel();
            this.lblMyAccount = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelSideMenu2 = new System.Windows.Forms.Panel();
            this.panelSide_logo = new System.Windows.Forms.Panel();
            this.panel_ID_Role = new System.Windows.Forms.Panel();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panelSideMenu1 = new System.Windows.Forms.Panel();
            this.verticalLinePanel = new System.Windows.Forms.Panel();
            this.btnSearchIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserAccount = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnLogout = new StudentViolationApp.View.CustomButton();
            this.btnProfile = new StudentViolationApp.View.CustomButton();
            this.btnSettingForm = new StudentViolationApp.View.CustomButton();
            this.btnDashboardForm = new StudentViolationApp.View.CustomButton();
            this.btnReportForm = new StudentViolationApp.View.CustomButton();
            this.btnStudentsForm = new StudentViolationApp.View.CustomButton();
            this.btnViolationsForm = new StudentViolationApp.View.CustomButton();
            this.panelAppName.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelAccountConainer.SuspendLayout();
            this.panelProfile_Logout.SuspendLayout();
            this.panelLblAccountDisp.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelSideMenu2.SuspendLayout();
            this.panelSide_logo.SuspendLayout();
            this.panel_ID_Role.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panelSideMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserAccount)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSearchAll
            // 
            this.txtBoxSearchAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxSearchAll.BackColor = System.Drawing.Color.White;
            this.txtBoxSearchAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxSearchAll.CausesValidation = false;
            this.txtBoxSearchAll.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchAll.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearchAll.Location = new System.Drawing.Point(622, 26);
            this.txtBoxSearchAll.Margin = new System.Windows.Forms.Padding(0);
            this.txtBoxSearchAll.MaxLength = 200;
            this.txtBoxSearchAll.Multiline = true;
            this.txtBoxSearchAll.Name = "txtBoxSearchAll";
            this.txtBoxSearchAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxSearchAll.Size = new System.Drawing.Size(389, 35);
            this.txtBoxSearchAll.TabIndex = 1;
            this.txtBoxSearchAll.TextChanged += new System.EventHandler(this.txtBoxSearchAll_TextChanged);
            this.txtBoxSearchAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxSearchAll_KeyDown);
            // 
            // panelAppName
            // 
            this.panelAppName.Controls.Add(this.lblAppName);
            this.panelAppName.Location = new System.Drawing.Point(11, 3);
            this.panelAppName.Name = "panelAppName";
            this.panelAppName.Size = new System.Drawing.Size(335, 90);
            this.panelAppName.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(-34, -21);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(448, 116);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Student Violation Management";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppName.UseMnemonic = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.btnSearchIcon);
            this.panelTop.Controls.Add(this.txtBoxSearchAll);
            this.panelTop.Controls.Add(this.btnUserAccount);
            this.panelTop.Controls.Add(this.panelAppName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1438, 94);
            this.panelTop.TabIndex = 2;
            // 
            // panelAccountConainer
            // 
            this.panelAccountConainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAccountConainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelAccountConainer.Controls.Add(this.panelProfile_Logout);
            this.panelAccountConainer.Controls.Add(this.panelLblAccountDisp);
            this.panelAccountConainer.Location = new System.Drawing.Point(965, 3);
            this.panelAccountConainer.Name = "panelAccountConainer";
            this.panelAccountConainer.Size = new System.Drawing.Size(154, 146);
            this.panelAccountConainer.TabIndex = 3;
            // 
            // panelProfile_Logout
            // 
            this.panelProfile_Logout.BackColor = System.Drawing.Color.Transparent;
            this.panelProfile_Logout.Controls.Add(this.btnLogout);
            this.panelProfile_Logout.Controls.Add(this.btnProfile);
            this.panelProfile_Logout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProfile_Logout.Location = new System.Drawing.Point(0, 50);
            this.panelProfile_Logout.Name = "panelProfile_Logout";
            this.panelProfile_Logout.Size = new System.Drawing.Size(154, 96);
            this.panelProfile_Logout.TabIndex = 9;
            // 
            // panelLblAccountDisp
            // 
            this.panelLblAccountDisp.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLblAccountDisp.Controls.Add(this.lblMyAccount);
            this.panelLblAccountDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLblAccountDisp.Location = new System.Drawing.Point(0, 0);
            this.panelLblAccountDisp.Name = "panelLblAccountDisp";
            this.panelLblAccountDisp.Size = new System.Drawing.Size(154, 50);
            this.panelLblAccountDisp.TabIndex = 7;
            // 
            // lblMyAccount
            // 
            this.lblMyAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblMyAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyAccount.Location = new System.Drawing.Point(0, 0);
            this.lblMyAccount.Name = "lblMyAccount";
            this.lblMyAccount.Size = new System.Drawing.Size(154, 50);
            this.lblMyAccount.TabIndex = 5;
            this.lblMyAccount.Text = "My Account";
            this.lblMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ID.Location = new System.Drawing.Point(0, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(303, 23);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "ID: ";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSide
            // 
            this.panelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSide.Controls.Add(this.panelSideMenu1);
            this.panelSide.Controls.Add(this.panelSide_logo);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 94);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(307, 655);
            this.panelSide.TabIndex = 7;
            // 
            // panelSideMenu2
            // 
            this.panelSideMenu2.AutoScroll = true;
            this.panelSideMenu2.Controls.Add(this.btnSettingForm);
            this.panelSideMenu2.Controls.Add(this.btnDashboardForm);
            this.panelSideMenu2.Controls.Add(this.btnReportForm);
            this.panelSideMenu2.Controls.Add(this.btnStudentsForm);
            this.panelSideMenu2.Controls.Add(this.btnViolationsForm);
            this.panelSideMenu2.Location = new System.Drawing.Point(18, 3);
            this.panelSideMenu2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panelSideMenu2.Name = "panelSideMenu2";
            this.panelSideMenu2.Size = new System.Drawing.Size(267, 423);
            this.panelSideMenu2.TabIndex = 1;
            // 
            // panelSide_logo
            // 
            this.panelSide_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSide_logo.Controls.Add(this.panel_ID_Role);
            this.panelSide_logo.Controls.Add(this.panel_logo);
            this.panelSide_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSide_logo.Location = new System.Drawing.Point(0, 0);
            this.panelSide_logo.Name = "panelSide_logo";
            this.panelSide_logo.Size = new System.Drawing.Size(305, 224);
            this.panelSide_logo.TabIndex = 0;
            // 
            // panel_ID_Role
            // 
            this.panel_ID_Role.Controls.Add(this.lbl_Role);
            this.panel_ID_Role.Controls.Add(this.lbl_ID);
            this.panel_ID_Role.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ID_Role.Location = new System.Drawing.Point(0, 161);
            this.panel_ID_Role.Name = "panel_ID_Role";
            this.panel_ID_Role.Size = new System.Drawing.Size(303, 61);
            this.panel_ID_Role.TabIndex = 2;
            // 
            // lbl_Role
            // 
            this.lbl_Role.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.Location = new System.Drawing.Point(0, 23);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(303, 37);
            this.lbl_Role.TabIndex = 7;
            this.lbl_Role.Text = "Role";
            this.lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Role.Click += new System.EventHandler(this.lbl_Role_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.verticalLinePanel);
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(303, 135);
            this.panel_logo.TabIndex = 1;
            // 
            // panelSideMenu1
            // 
            this.panelSideMenu1.AutoScroll = true;
            this.panelSideMenu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSideMenu1.Controls.Add(this.panelSideMenu2);
            this.panelSideMenu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSideMenu1.Location = new System.Drawing.Point(0, 224);
            this.panelSideMenu1.Name = "panelSideMenu1";
            this.panelSideMenu1.Size = new System.Drawing.Size(305, 429);
            this.panelSideMenu1.TabIndex = 1;
            // 
            // verticalLinePanel
            // 
            this.verticalLinePanel.BackColor = System.Drawing.Color.DimGray;
            this.verticalLinePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.verticalLinePanel.Location = new System.Drawing.Point(0, 134);
            this.verticalLinePanel.Name = "verticalLinePanel";
            this.verticalLinePanel.Size = new System.Drawing.Size(303, 1);
            this.verticalLinePanel.TabIndex = 0;
            // 
            // btnSearchIcon
            // 
            this.btnSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchIcon.Image = global::StudentViolationApp.Properties.Resources.search__1_;
            this.btnSearchIcon.Location = new System.Drawing.Point(581, 26);
            this.btnSearchIcon.Name = "btnSearchIcon";
            this.btnSearchIcon.Size = new System.Drawing.Size(35, 35);
            this.btnSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearchIcon.TabIndex = 2;
            this.btnSearchIcon.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Location = new System.Drawing.Point(102, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUserAccount.Location = new System.Drawing.Point(1313, 11);
            this.btnUserAccount.Name = "btnUserAccount";
            this.btnUserAccount.Size = new System.Drawing.Size(74, 74);
            this.btnUserAccount.TabIndex = 2;
            this.btnUserAccount.TabStop = false;
            this.btnUserAccount.Click += new System.EventHandler(this.btnUserAccount_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelAccountConainer);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(307, 94);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1131, 655);
            this.panelMain.TabIndex = 8;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundColor = System.Drawing.Color.White;
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(8, 50);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextColor = System.Drawing.Color.Black;
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.BackgroundColor = System.Drawing.Color.White;
            this.btnProfile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProfile.BorderRadius = 5;
            this.btnProfile.BorderSize = 0;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Location = new System.Drawing.Point(8, 6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(132, 40);
            this.btnProfile.TabIndex = 10;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextColor = System.Drawing.Color.Black;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnSettingForm
            // 
            this.btnSettingForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettingForm.BackColor = System.Drawing.Color.White;
            this.btnSettingForm.BackgroundColor = System.Drawing.Color.White;
            this.btnSettingForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettingForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettingForm.BorderRadius = 5;
            this.btnSettingForm.BorderSize = 1;
            this.btnSettingForm.FlatAppearance.BorderSize = 0;
            this.btnSettingForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnSettingForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSettingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingForm.ForeColor = System.Drawing.Color.Black;
            this.btnSettingForm.Image = global::StudentViolationApp.Properties.Resources.menu;
            this.btnSettingForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingForm.Location = new System.Drawing.Point(0, 219);
            this.btnSettingForm.Name = "btnSettingForm";
            this.btnSettingForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSettingForm.Size = new System.Drawing.Size(267, 40);
            this.btnSettingForm.TabIndex = 11;
            this.btnSettingForm.Text = "           Settings";
            this.btnSettingForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettingForm.TextColor = System.Drawing.Color.Black;
            this.btnSettingForm.UseVisualStyleBackColor = false;
            this.btnSettingForm.Click += new System.EventHandler(this.btnSettingForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboardForm.BackColor = System.Drawing.Color.White;
            this.btnDashboardForm.BackgroundColor = System.Drawing.Color.White;
            this.btnDashboardForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboardForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboardForm.BorderRadius = 5;
            this.btnDashboardForm.BorderSize = 1;
            this.btnDashboardForm.FlatAppearance.BorderSize = 0;
            this.btnDashboardForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnDashboardForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.Black;
            this.btnDashboardForm.Image = global::StudentViolationApp.Properties.Resources.menu;
            this.btnDashboardForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardForm.Location = new System.Drawing.Point(0, 35);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboardForm.Size = new System.Drawing.Size(267, 40);
            this.btnDashboardForm.TabIndex = 0;
            this.btnDashboardForm.Text = "           Dashboard";
            this.btnDashboardForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboardForm.TextColor = System.Drawing.Color.Black;
            this.btnDashboardForm.UseVisualStyleBackColor = false;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnReportForm
            // 
            this.btnReportForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportForm.BackColor = System.Drawing.Color.White;
            this.btnReportForm.BackgroundColor = System.Drawing.Color.White;
            this.btnReportForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnReportForm.BorderRadius = 5;
            this.btnReportForm.BorderSize = 1;
            this.btnReportForm.FlatAppearance.BorderSize = 0;
            this.btnReportForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnReportForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReportForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportForm.ForeColor = System.Drawing.Color.Black;
            this.btnReportForm.Image = global::StudentViolationApp.Properties.Resources.menu;
            this.btnReportForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportForm.Location = new System.Drawing.Point(0, 173);
            this.btnReportForm.Name = "btnReportForm";
            this.btnReportForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReportForm.Size = new System.Drawing.Size(267, 40);
            this.btnReportForm.TabIndex = 10;
            this.btnReportForm.Text = "           Reports";
            this.btnReportForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportForm.TextColor = System.Drawing.Color.Black;
            this.btnReportForm.UseVisualStyleBackColor = false;
            this.btnReportForm.Click += new System.EventHandler(this.btnReportForm_Click);
            // 
            // btnStudentsForm
            // 
            this.btnStudentsForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentsForm.BackColor = System.Drawing.Color.White;
            this.btnStudentsForm.BackgroundColor = System.Drawing.Color.White;
            this.btnStudentsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentsForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnStudentsForm.BorderRadius = 5;
            this.btnStudentsForm.BorderSize = 1;
            this.btnStudentsForm.FlatAppearance.BorderSize = 0;
            this.btnStudentsForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnStudentsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStudentsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentsForm.ForeColor = System.Drawing.Color.Black;
            this.btnStudentsForm.Image = global::StudentViolationApp.Properties.Resources.menu;
            this.btnStudentsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentsForm.Location = new System.Drawing.Point(0, 81);
            this.btnStudentsForm.Name = "btnStudentsForm";
            this.btnStudentsForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStudentsForm.Size = new System.Drawing.Size(267, 40);
            this.btnStudentsForm.TabIndex = 8;
            this.btnStudentsForm.Text = "           Students";
            this.btnStudentsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentsForm.TextColor = System.Drawing.Color.Black;
            this.btnStudentsForm.UseVisualStyleBackColor = false;
            this.btnStudentsForm.Click += new System.EventHandler(this.btnStudentsForm_Click);
            // 
            // btnViolationsForm
            // 
            this.btnViolationsForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViolationsForm.BackColor = System.Drawing.Color.White;
            this.btnViolationsForm.BackgroundColor = System.Drawing.Color.White;
            this.btnViolationsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViolationsForm.BorderColor = System.Drawing.Color.Transparent;
            this.btnViolationsForm.BorderRadius = 5;
            this.btnViolationsForm.BorderSize = 1;
            this.btnViolationsForm.FlatAppearance.BorderSize = 0;
            this.btnViolationsForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnViolationsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnViolationsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViolationsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViolationsForm.ForeColor = System.Drawing.Color.Black;
            this.btnViolationsForm.Image = global::StudentViolationApp.Properties.Resources.menu;
            this.btnViolationsForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolationsForm.Location = new System.Drawing.Point(0, 127);
            this.btnViolationsForm.Name = "btnViolationsForm";
            this.btnViolationsForm.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnViolationsForm.Size = new System.Drawing.Size(267, 40);
            this.btnViolationsForm.TabIndex = 9;
            this.btnViolationsForm.Text = "           Violations";
            this.btnViolationsForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViolationsForm.TextColor = System.Drawing.Color.Black;
            this.btnViolationsForm.UseVisualStyleBackColor = false;
            this.btnViolationsForm.Click += new System.EventHandler(this.btnViolationsForm_Click);
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1438, 749);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1250, 750);
            this.Name = "DefaultForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelAppName.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelAccountConainer.ResumeLayout(false);
            this.panelProfile_Logout.ResumeLayout(false);
            this.panelLblAccountDisp.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelSideMenu2.ResumeLayout(false);
            this.panelSide_logo.ResumeLayout(false);
            this.panel_ID_Role.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panelSideMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUserAccount)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelAppName;
        private System.Windows.Forms.TextBox txtBoxSearchAll;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnUserAccount;
        private System.Windows.Forms.Panel panelAccountConainer;
        private System.Windows.Forms.Label lblMyAccount;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Panel panelLblAccountDisp;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelProfile_Logout;
        private System.Windows.Forms.Panel panelSide_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_ID_Role;
        private System.Windows.Forms.Label lbl_Role;
        private CustomButton btnProfile;
        private CustomButton btnLogout;
        private System.Windows.Forms.Panel panelSideMenu2;
        private CustomButton btnDashboardForm;
        private CustomButton btnStudentsForm;
        private CustomButton btnViolationsForm;
        private CustomButton btnReportForm;
        private CustomButton btnSettingForm;
        private System.Windows.Forms.Panel panelSideMenu1;
        private System.Windows.Forms.Panel verticalLinePanel;
        private System.Windows.Forms.PictureBox btnSearchIcon;
        private System.Windows.Forms.Panel panelMain;
    }
}