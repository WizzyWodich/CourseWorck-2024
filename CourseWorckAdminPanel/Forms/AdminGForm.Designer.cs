namespace CourseWorckAdminPanel.Forms
{
    partial class AdminGForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGForm));
            this.pnTopAGForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btMinimizeAGForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btCloseAGForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbNameApp = new System.Windows.Forms.Label();
            this.pnAForm = new Guna.UI2.WinForms.Guna2Panel();
            this.pnBarAForm = new Guna.UI2.WinForms.Guna2Panel();
            this.pnSettingPersonalsAGF = new Guna.UI2.WinForms.Guna2Panel();
            this.ibSettingPersonalsAGF = new FontAwesome.Sharp.IconButton();
            this.pnSettingPersonalsSmalAGF = new Guna.UI2.WinForms.Guna2Panel();
            this.pnAdminsAdminForm = new Guna.UI2.WinForms.Guna2Panel();
            this.ibAdminAdminForm = new FontAwesome.Sharp.IconButton();
            this.pnAdminSmallAF = new Guna.UI2.WinForms.Guna2Panel();
            this.pnExitMainAGF = new Guna.UI2.WinForms.Guna2Panel();
            this.ibtExitAGForm = new FontAwesome.Sharp.IconButton();
            this.pnSettingsMainAG = new Guna.UI2.WinForms.Guna2Panel();
            this.ibtSettingsAGForm = new FontAwesome.Sharp.IconButton();
            this.pnSettingsSmallAGF = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHomeMainAGF = new Guna.UI2.WinForms.Guna2Panel();
            this.ibtHomeAGForm = new FontAwesome.Sharp.IconButton();
            this.pnHomeSmallAGF = new Guna.UI2.WinForms.Guna2Panel();
            this.pbIconAppAGF = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnTopAGForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizeAGForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseAGForm)).BeginInit();
            this.pnAForm.SuspendLayout();
            this.pnBarAForm.SuspendLayout();
            this.pnSettingPersonalsAGF.SuspendLayout();
            this.pnAdminsAdminForm.SuspendLayout();
            this.pnExitMainAGF.SuspendLayout();
            this.pnSettingsMainAG.SuspendLayout();
            this.pnHomeMainAGF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAppAGF)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTopAGForm
            // 
            this.pnTopAGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnTopAGForm.Controls.Add(this.btMinimizeAGForm);
            this.pnTopAGForm.Controls.Add(this.btCloseAGForm);
            this.pnTopAGForm.Controls.Add(this.lbNameApp);
            this.pnTopAGForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopAGForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnTopAGForm.Location = new System.Drawing.Point(0, 0);
            this.pnTopAGForm.Name = "pnTopAGForm";
            this.pnTopAGForm.Size = new System.Drawing.Size(1045, 30);
            this.pnTopAGForm.TabIndex = 0;
            this.pnTopAGForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopGForm_MouseDown);
            this.pnTopAGForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopGForm_MouseMove);
            this.pnTopAGForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopGForm_MouseUp);
            // 
            // btMinimizeAGForm
            // 
            this.btMinimizeAGForm.FillColor = System.Drawing.Color.Transparent;
            this.btMinimizeAGForm.Image = global::CourseWorckAdminPanel.Properties.Resources.MinimizeIcon;
            this.btMinimizeAGForm.ImageRotate = 0F;
            this.btMinimizeAGForm.Location = new System.Drawing.Point(988, 0);
            this.btMinimizeAGForm.Name = "btMinimizeAGForm";
            this.btMinimizeAGForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btMinimizeAGForm.Size = new System.Drawing.Size(30, 30);
            this.btMinimizeAGForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btMinimizeAGForm.TabIndex = 10;
            this.btMinimizeAGForm.TabStop = false;
            this.btMinimizeAGForm.Click += new System.EventHandler(this.btMinimizeGForm_Click);
            // 
            // btCloseAGForm
            // 
            this.btCloseAGForm.FillColor = System.Drawing.Color.Transparent;
            this.btCloseAGForm.Image = global::CourseWorckAdminPanel.Properties.Resources.CloseIcon;
            this.btCloseAGForm.ImageRotate = 0F;
            this.btCloseAGForm.Location = new System.Drawing.Point(1016, 0);
            this.btCloseAGForm.Name = "btCloseAGForm";
            this.btCloseAGForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btCloseAGForm.Size = new System.Drawing.Size(30, 30);
            this.btCloseAGForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCloseAGForm.TabIndex = 9;
            this.btCloseAGForm.TabStop = false;
            this.btCloseAGForm.Click += new System.EventHandler(this.btCloseGForm_Click);
            // 
            // lbNameApp
            // 
            this.lbNameApp.AutoSize = true;
            this.lbNameApp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbNameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNameApp.Location = new System.Drawing.Point(523, 9);
            this.lbNameApp.Name = "lbNameApp";
            this.lbNameApp.Size = new System.Drawing.Size(90, 16);
            this.lbNameApp.TabIndex = 9;
            this.lbNameApp.Text = "Fast Admin";
            // 
            // pnAForm
            // 
            this.pnAForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnAForm.BorderRadius = 25;
            this.pnAForm.Controls.Add(this.pnBarAForm);
            this.pnAForm.Controls.Add(this.pnTopAGForm);
            this.pnAForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAForm.Location = new System.Drawing.Point(0, 0);
            this.pnAForm.Name = "pnAForm";
            this.pnAForm.Size = new System.Drawing.Size(1045, 534);
            this.pnAForm.TabIndex = 1;
            // 
            // pnBarAForm
            // 
            this.pnBarAForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnBarAForm.Controls.Add(this.pnSettingPersonalsAGF);
            this.pnBarAForm.Controls.Add(this.pnAdminsAdminForm);
            this.pnBarAForm.Controls.Add(this.label1);
            this.pnBarAForm.Controls.Add(this.pnExitMainAGF);
            this.pnBarAForm.Controls.Add(this.pnSettingsMainAG);
            this.pnBarAForm.Controls.Add(this.pnHomeMainAGF);
            this.pnBarAForm.Controls.Add(this.pbIconAppAGF);
            this.pnBarAForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBarAForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnBarAForm.Location = new System.Drawing.Point(0, 30);
            this.pnBarAForm.Name = "pnBarAForm";
            this.pnBarAForm.ShadowDecoration.Enabled = true;
            this.pnBarAForm.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnBarAForm.Size = new System.Drawing.Size(217, 504);
            this.pnBarAForm.TabIndex = 1;
            // 
            // pnSettingPersonalsAGF
            // 
            this.pnSettingPersonalsAGF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnSettingPersonalsAGF.Controls.Add(this.ibSettingPersonalsAGF);
            this.pnSettingPersonalsAGF.Controls.Add(this.pnSettingPersonalsSmalAGF);
            this.pnSettingPersonalsAGF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnSettingPersonalsAGF.Location = new System.Drawing.Point(0, 279);
            this.pnSettingPersonalsAGF.Name = "pnSettingPersonalsAGF";
            this.pnSettingPersonalsAGF.Size = new System.Drawing.Size(217, 45);
            this.pnSettingPersonalsAGF.TabIndex = 12;
            // 
            // ibSettingPersonalsAGF
            // 
            this.ibSettingPersonalsAGF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibSettingPersonalsAGF.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibSettingPersonalsAGF.FlatAppearance.BorderSize = 0;
            this.ibSettingPersonalsAGF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSettingPersonalsAGF.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibSettingPersonalsAGF.ForeColor = System.Drawing.Color.Silver;
            this.ibSettingPersonalsAGF.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.ibSettingPersonalsAGF.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibSettingPersonalsAGF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSettingPersonalsAGF.IconSize = 36;
            this.ibSettingPersonalsAGF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSettingPersonalsAGF.Location = new System.Drawing.Point(7, 0);
            this.ibSettingPersonalsAGF.Name = "ibSettingPersonalsAGF";
            this.ibSettingPersonalsAGF.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibSettingPersonalsAGF.Size = new System.Drawing.Size(210, 45);
            this.ibSettingPersonalsAGF.TabIndex = 10;
            this.ibSettingPersonalsAGF.Text = "Налаштування персоналу";
            this.ibSettingPersonalsAGF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSettingPersonalsAGF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSettingPersonalsAGF.UseVisualStyleBackColor = false;
            this.ibSettingPersonalsAGF.Click += new System.EventHandler(this.ibSettingPersonalsAGF_Click);
            // 
            // pnSettingPersonalsSmalAGF
            // 
            this.pnSettingPersonalsSmalAGF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSettingPersonalsSmalAGF.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSettingPersonalsSmalAGF.ForeColor = System.Drawing.Color.Transparent;
            this.pnSettingPersonalsSmalAGF.Location = new System.Drawing.Point(0, 0);
            this.pnSettingPersonalsSmalAGF.Name = "pnSettingPersonalsSmalAGF";
            this.pnSettingPersonalsSmalAGF.Size = new System.Drawing.Size(7, 45);
            this.pnSettingPersonalsSmalAGF.TabIndex = 2;
            this.pnSettingPersonalsSmalAGF.Visible = false;
            // 
            // pnAdminsAdminForm
            // 
            this.pnAdminsAdminForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnAdminsAdminForm.Controls.Add(this.ibAdminAdminForm);
            this.pnAdminsAdminForm.Controls.Add(this.pnAdminSmallAF);
            this.pnAdminsAdminForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnAdminsAdminForm.Location = new System.Drawing.Point(0, 228);
            this.pnAdminsAdminForm.Name = "pnAdminsAdminForm";
            this.pnAdminsAdminForm.Size = new System.Drawing.Size(217, 45);
            this.pnAdminsAdminForm.TabIndex = 12;
            // 
            // ibAdminAdminForm
            // 
            this.ibAdminAdminForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibAdminAdminForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibAdminAdminForm.FlatAppearance.BorderSize = 0;
            this.ibAdminAdminForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibAdminAdminForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibAdminAdminForm.ForeColor = System.Drawing.Color.Silver;
            this.ibAdminAdminForm.IconChar = FontAwesome.Sharp.IconChar.Artstation;
            this.ibAdminAdminForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibAdminAdminForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibAdminAdminForm.IconSize = 36;
            this.ibAdminAdminForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAdminAdminForm.Location = new System.Drawing.Point(7, 0);
            this.ibAdminAdminForm.Name = "ibAdminAdminForm";
            this.ibAdminAdminForm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibAdminAdminForm.Size = new System.Drawing.Size(210, 45);
            this.ibAdminAdminForm.TabIndex = 10;
            this.ibAdminAdminForm.Text = "Панель \r\nадміністратора";
            this.ibAdminAdminForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibAdminAdminForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibAdminAdminForm.UseVisualStyleBackColor = false;
            this.ibAdminAdminForm.Click += new System.EventHandler(this.ibAdminAdminForm_Click);
            // 
            // pnAdminSmallAF
            // 
            this.pnAdminSmallAF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnAdminSmallAF.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAdminSmallAF.ForeColor = System.Drawing.Color.Transparent;
            this.pnAdminSmallAF.Location = new System.Drawing.Point(0, 0);
            this.pnAdminSmallAF.Name = "pnAdminSmallAF";
            this.pnAdminSmallAF.Size = new System.Drawing.Size(7, 45);
            this.pnAdminSmallAF.TabIndex = 2;
            this.pnAdminSmallAF.Visible = false;
            // 
            // pnExitMainAGF
            // 
            this.pnExitMainAGF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnExitMainAGF.Controls.Add(this.ibtExitAGForm);
            this.pnExitMainAGF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnExitMainAGF.Location = new System.Drawing.Point(0, 442);
            this.pnExitMainAGF.Name = "pnExitMainAGF";
            this.pnExitMainAGF.Size = new System.Drawing.Size(214, 45);
            this.pnExitMainAGF.TabIndex = 11;
            // 
            // ibtExitAGForm
            // 
            this.ibtExitAGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibtExitAGForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtExitAGForm.FlatAppearance.BorderSize = 0;
            this.ibtExitAGForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtExitAGForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtExitAGForm.ForeColor = System.Drawing.Color.Silver;
            this.ibtExitAGForm.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ibtExitAGForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtExitAGForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtExitAGForm.IconSize = 36;
            this.ibtExitAGForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtExitAGForm.Location = new System.Drawing.Point(0, 0);
            this.ibtExitAGForm.Name = "ibtExitAGForm";
            this.ibtExitAGForm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibtExitAGForm.Size = new System.Drawing.Size(214, 45);
            this.ibtExitAGForm.TabIndex = 9;
            this.ibtExitAGForm.Text = "Вихід";
            this.ibtExitAGForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtExitAGForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtExitAGForm.UseVisualStyleBackColor = false;
            this.ibtExitAGForm.Click += new System.EventHandler(this.ibtExitGForm_Click);
            // 
            // pnSettingsMainAG
            // 
            this.pnSettingsMainAG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnSettingsMainAG.Controls.Add(this.ibtSettingsAGForm);
            this.pnSettingsMainAG.Controls.Add(this.pnSettingsSmallAGF);
            this.pnSettingsMainAG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnSettingsMainAG.Location = new System.Drawing.Point(0, 177);
            this.pnSettingsMainAG.Name = "pnSettingsMainAG";
            this.pnSettingsMainAG.Size = new System.Drawing.Size(217, 45);
            this.pnSettingsMainAG.TabIndex = 10;
            // 
            // ibtSettingsAGForm
            // 
            this.ibtSettingsAGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibtSettingsAGForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtSettingsAGForm.FlatAppearance.BorderSize = 0;
            this.ibtSettingsAGForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtSettingsAGForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtSettingsAGForm.ForeColor = System.Drawing.Color.Silver;
            this.ibtSettingsAGForm.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.ibtSettingsAGForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtSettingsAGForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtSettingsAGForm.IconSize = 36;
            this.ibtSettingsAGForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtSettingsAGForm.Location = new System.Drawing.Point(7, 0);
            this.ibtSettingsAGForm.Name = "ibtSettingsAGForm";
            this.ibtSettingsAGForm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibtSettingsAGForm.Size = new System.Drawing.Size(210, 45);
            this.ibtSettingsAGForm.TabIndex = 9;
            this.ibtSettingsAGForm.Text = "Налаштування";
            this.ibtSettingsAGForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtSettingsAGForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtSettingsAGForm.UseVisualStyleBackColor = false;
            this.ibtSettingsAGForm.Click += new System.EventHandler(this.ibtSettingsGForm_Click);
            // 
            // pnSettingsSmallAGF
            // 
            this.pnSettingsSmallAGF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSettingsSmallAGF.ForeColor = System.Drawing.Color.Transparent;
            this.pnSettingsSmallAGF.Location = new System.Drawing.Point(0, 0);
            this.pnSettingsSmallAGF.Name = "pnSettingsSmallAGF";
            this.pnSettingsSmallAGF.Size = new System.Drawing.Size(7, 45);
            this.pnSettingsSmallAGF.TabIndex = 1;
            this.pnSettingsSmallAGF.Visible = false;
            // 
            // pnHomeMainAGF
            // 
            this.pnHomeMainAGF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnHomeMainAGF.Controls.Add(this.ibtHomeAGForm);
            this.pnHomeMainAGF.Controls.Add(this.pnHomeSmallAGF);
            this.pnHomeMainAGF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnHomeMainAGF.Location = new System.Drawing.Point(0, 126);
            this.pnHomeMainAGF.Name = "pnHomeMainAGF";
            this.pnHomeMainAGF.Size = new System.Drawing.Size(214, 45);
            this.pnHomeMainAGF.TabIndex = 0;
            // 
            // ibtHomeAGForm
            // 
            this.ibtHomeAGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibtHomeAGForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtHomeAGForm.FlatAppearance.BorderSize = 0;
            this.ibtHomeAGForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtHomeAGForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtHomeAGForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ibtHomeAGForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibtHomeAGForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtHomeAGForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtHomeAGForm.IconSize = 36;
            this.ibtHomeAGForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHomeAGForm.Location = new System.Drawing.Point(7, 0);
            this.ibtHomeAGForm.Name = "ibtHomeAGForm";
            this.ibtHomeAGForm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibtHomeAGForm.Size = new System.Drawing.Size(207, 45);
            this.ibtHomeAGForm.TabIndex = 9;
            this.ibtHomeAGForm.Text = "Головна";
            this.ibtHomeAGForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHomeAGForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtHomeAGForm.UseVisualStyleBackColor = false;
            this.ibtHomeAGForm.Click += new System.EventHandler(this.ibtHomeGForm_Click);
            // 
            // pnHomeSmallAGF
            // 
            this.pnHomeSmallAGF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnHomeSmallAGF.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHomeSmallAGF.ForeColor = System.Drawing.Color.Transparent;
            this.pnHomeSmallAGF.Location = new System.Drawing.Point(0, 0);
            this.pnHomeSmallAGF.Name = "pnHomeSmallAGF";
            this.pnHomeSmallAGF.Size = new System.Drawing.Size(7, 45);
            this.pnHomeSmallAGF.TabIndex = 1;
            this.pnHomeSmallAGF.Visible = false;
            // 
            // pbIconAppAGF
            // 
            this.pbIconAppAGF.FillColor = System.Drawing.Color.Transparent;
            this.pbIconAppAGF.Image = global::CourseWorckAdminPanel.Properties.Resources.LogoIcon;
            this.pbIconAppAGF.ImageRotate = 0F;
            this.pbIconAppAGF.Location = new System.Drawing.Point(10, 8);
            this.pbIconAppAGF.Name = "pbIconAppAGF";
            this.pbIconAppAGF.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbIconAppAGF.Size = new System.Drawing.Size(44, 53);
            this.pbIconAppAGF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIconAppAGF.TabIndex = 8;
            this.pbIconAppAGF.TabStop = false;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.BorderRadius = 25;
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "ast Admin\r\n  Panel\r\n";
            // 
            // AdminGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 534);
            this.Controls.Add(this.pnAForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminGForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGForm";
            this.pnTopAGForm.ResumeLayout(false);
            this.pnTopAGForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizeAGForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseAGForm)).EndInit();
            this.pnAForm.ResumeLayout(false);
            this.pnBarAForm.ResumeLayout(false);
            this.pnBarAForm.PerformLayout();
            this.pnSettingPersonalsAGF.ResumeLayout(false);
            this.pnAdminsAdminForm.ResumeLayout(false);
            this.pnExitMainAGF.ResumeLayout(false);
            this.pnSettingsMainAG.ResumeLayout(false);
            this.pnHomeMainAGF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAppAGF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnAForm;
        private Guna.UI2.WinForms.Guna2Panel pnTopAGForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btMinimizeAGForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btCloseAGForm;
        private System.Windows.Forms.Label lbNameApp;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnBarAForm;
        private Guna.UI2.WinForms.Guna2Panel pnSettingPersonalsAGF;
        private FontAwesome.Sharp.IconButton ibSettingPersonalsAGF;
        private Guna.UI2.WinForms.Guna2Panel pnSettingPersonalsSmalAGF;
        private Guna.UI2.WinForms.Guna2Panel pnAdminsAdminForm;
        private FontAwesome.Sharp.IconButton ibAdminAdminForm;
        private Guna.UI2.WinForms.Guna2Panel pnAdminSmallAF;
        private Guna.UI2.WinForms.Guna2Panel pnExitMainAGF;
        private FontAwesome.Sharp.IconButton ibtExitAGForm;
        private Guna.UI2.WinForms.Guna2Panel pnSettingsMainAG;
        private FontAwesome.Sharp.IconButton ibtSettingsAGForm;
        private Guna.UI2.WinForms.Guna2Panel pnSettingsSmallAGF;
        private Guna.UI2.WinForms.Guna2Panel pnHomeMainAGF;
        private FontAwesome.Sharp.IconButton ibtHomeAGForm;
        private Guna.UI2.WinForms.Guna2Panel pnHomeSmallAGF;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbIconAppAGF;
        private System.Windows.Forms.Label label1;
    }
}