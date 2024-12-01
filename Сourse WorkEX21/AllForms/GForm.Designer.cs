namespace Сourse_WorkEX21
{
    partial class GForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnGForm = new Guna.UI2.WinForms.Guna2Panel();
            this.pnBarGForm = new Guna.UI2.WinForms.Guna2Panel();
            this.idUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnOrders = new Guna.UI2.WinForms.Guna2Panel();
            this.ibOrdersGF = new FontAwesome.Sharp.IconButton();
            this.pnOrdersSmalGF = new Guna.UI2.WinForms.Guna2Panel();
            this.pnExitMain = new Guna.UI2.WinForms.Guna2Panel();
            this.ibtExitGForm = new FontAwesome.Sharp.IconButton();
            this.pnSettingsMain = new Guna.UI2.WinForms.Guna2Panel();
            this.ibtSettingsGForm = new FontAwesome.Sharp.IconButton();
            this.pnSettingsSmallGF = new Guna.UI2.WinForms.Guna2Panel();
            this.pnHomeMain = new Guna.UI2.WinForms.Guna2Panel();
            this.ibtHomeGForm = new FontAwesome.Sharp.IconButton();
            this.pnHomeSmallGF = new Guna.UI2.WinForms.Guna2Panel();
            this.pbIconAppGF = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnTopGForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btMinimizeGForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btCloseGForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbNameApp = new System.Windows.Forms.Label();
            this.pnGForm.SuspendLayout();
            this.pnBarGForm.SuspendLayout();
            this.pnOrders.SuspendLayout();
            this.pnExitMain.SuspendLayout();
            this.pnSettingsMain.SuspendLayout();
            this.pnHomeMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAppGF)).BeginInit();
            this.pnTopGForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizeGForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseGForm)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnGForm
            // 
            this.pnGForm.BackColor = System.Drawing.SystemColors.Control;
            this.pnGForm.BorderRadius = 25;
            this.pnGForm.Controls.Add(this.pnBarGForm);
            this.pnGForm.Controls.Add(this.pnTopGForm);
            this.pnGForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnGForm.Location = new System.Drawing.Point(0, 0);
            this.pnGForm.Name = "pnGForm";
            this.pnGForm.Size = new System.Drawing.Size(1050, 550);
            this.pnGForm.TabIndex = 0;
            // 
            // pnBarGForm
            // 
            this.pnBarGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnBarGForm.Controls.Add(this.idUser);
            this.pnBarGForm.Controls.Add(this.label1);
            this.pnBarGForm.Controls.Add(this.pnOrders);
            this.pnBarGForm.Controls.Add(this.pnExitMain);
            this.pnBarGForm.Controls.Add(this.pnSettingsMain);
            this.pnBarGForm.Controls.Add(this.pnHomeMain);
            this.pnBarGForm.Controls.Add(this.pbIconAppGF);
            this.pnBarGForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBarGForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnBarGForm.Location = new System.Drawing.Point(0, 30);
            this.pnBarGForm.Name = "pnBarGForm";
            this.pnBarGForm.ShadowDecoration.Enabled = true;
            this.pnBarGForm.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pnBarGForm.Size = new System.Drawing.Size(217, 520);
            this.pnBarGForm.TabIndex = 1;
            // 
            // idUser
            // 
            this.idUser.AutoSize = true;
            this.idUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.idUser.ForeColor = System.Drawing.Color.Silver;
            this.idUser.Location = new System.Drawing.Point(48, 495);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(0, 16);
            this.idUser.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // pnOrders
            // 
            this.pnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnOrders.Controls.Add(this.ibOrdersGF);
            this.pnOrders.Controls.Add(this.pnOrdersSmalGF);
            this.pnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnOrders.Location = new System.Drawing.Point(0, 228);
            this.pnOrders.Name = "pnOrders";
            this.pnOrders.Size = new System.Drawing.Size(214, 45);
            this.pnOrders.TabIndex = 12;
            this.pnOrders.Visible = false;
            // 
            // ibOrdersGF
            // 
            this.ibOrdersGF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibOrdersGF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOrdersGF.FlatAppearance.BorderSize = 0;
            this.ibOrdersGF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibOrdersGF.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibOrdersGF.ForeColor = System.Drawing.Color.Silver;
            this.ibOrdersGF.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.ibOrdersGF.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibOrdersGF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibOrdersGF.IconSize = 36;
            this.ibOrdersGF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibOrdersGF.Location = new System.Drawing.Point(7, 0);
            this.ibOrdersGF.Name = "ibOrdersGF";
            this.ibOrdersGF.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibOrdersGF.Size = new System.Drawing.Size(207, 45);
            this.ibOrdersGF.TabIndex = 9;
            this.ibOrdersGF.Text = "Доставка";
            this.ibOrdersGF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibOrdersGF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibOrdersGF.UseVisualStyleBackColor = false;
            this.ibOrdersGF.Click += new System.EventHandler(this.ibOrdersGF_Click);
            // 
            // pnOrdersSmalGF
            // 
            this.pnOrdersSmalGF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnOrdersSmalGF.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnOrdersSmalGF.ForeColor = System.Drawing.Color.Transparent;
            this.pnOrdersSmalGF.Location = new System.Drawing.Point(0, 0);
            this.pnOrdersSmalGF.Name = "pnOrdersSmalGF";
            this.pnOrdersSmalGF.Size = new System.Drawing.Size(7, 45);
            this.pnOrdersSmalGF.TabIndex = 1;
            this.pnOrdersSmalGF.Visible = false;
            // 
            // pnExitMain
            // 
            this.pnExitMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnExitMain.Controls.Add(this.ibtExitGForm);
            this.pnExitMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnExitMain.Location = new System.Drawing.Point(0, 442);
            this.pnExitMain.Name = "pnExitMain";
            this.pnExitMain.Size = new System.Drawing.Size(214, 45);
            this.pnExitMain.TabIndex = 11;
            // 
            // ibtExitGForm
            // 
            this.ibtExitGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibtExitGForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtExitGForm.FlatAppearance.BorderSize = 0;
            this.ibtExitGForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtExitGForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtExitGForm.ForeColor = System.Drawing.Color.Silver;
            this.ibtExitGForm.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ibtExitGForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtExitGForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtExitGForm.IconSize = 36;
            this.ibtExitGForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtExitGForm.Location = new System.Drawing.Point(0, 0);
            this.ibtExitGForm.Name = "ibtExitGForm";
            this.ibtExitGForm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibtExitGForm.Size = new System.Drawing.Size(214, 45);
            this.ibtExitGForm.TabIndex = 9;
            this.ibtExitGForm.Text = "Вихід";
            this.ibtExitGForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtExitGForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtExitGForm.UseVisualStyleBackColor = false;
            this.ibtExitGForm.Click += new System.EventHandler(this.ibtExitGForm_Click);
            // 
            // pnSettingsMain
            // 
            this.pnSettingsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnSettingsMain.Controls.Add(this.ibtSettingsGForm);
            this.pnSettingsMain.Controls.Add(this.pnSettingsSmallGF);
            this.pnSettingsMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnSettingsMain.Location = new System.Drawing.Point(0, 177);
            this.pnSettingsMain.Name = "pnSettingsMain";
            this.pnSettingsMain.Size = new System.Drawing.Size(217, 45);
            this.pnSettingsMain.TabIndex = 10;
            // 
            // ibtSettingsGForm
            // 
            this.ibtSettingsGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibtSettingsGForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtSettingsGForm.FlatAppearance.BorderSize = 0;
            this.ibtSettingsGForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtSettingsGForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtSettingsGForm.ForeColor = System.Drawing.Color.Silver;
            this.ibtSettingsGForm.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.ibtSettingsGForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtSettingsGForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtSettingsGForm.IconSize = 36;
            this.ibtSettingsGForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtSettingsGForm.Location = new System.Drawing.Point(7, 0);
            this.ibtSettingsGForm.Name = "ibtSettingsGForm";
            this.ibtSettingsGForm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibtSettingsGForm.Size = new System.Drawing.Size(210, 45);
            this.ibtSettingsGForm.TabIndex = 9;
            this.ibtSettingsGForm.Text = "Налаштування";
            this.ibtSettingsGForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtSettingsGForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtSettingsGForm.UseVisualStyleBackColor = false;
            this.ibtSettingsGForm.Click += new System.EventHandler(this.ibtSettingsGForm_Click);
            // 
            // pnSettingsSmallGF
            // 
            this.pnSettingsSmallGF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnSettingsSmallGF.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSettingsSmallGF.ForeColor = System.Drawing.Color.Transparent;
            this.pnSettingsSmallGF.Location = new System.Drawing.Point(0, 0);
            this.pnSettingsSmallGF.Name = "pnSettingsSmallGF";
            this.pnSettingsSmallGF.Size = new System.Drawing.Size(7, 45);
            this.pnSettingsSmallGF.TabIndex = 1;
            this.pnSettingsSmallGF.Visible = false;
            // 
            // pnHomeMain
            // 
            this.pnHomeMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnHomeMain.Controls.Add(this.ibtHomeGForm);
            this.pnHomeMain.Controls.Add(this.pnHomeSmallGF);
            this.pnHomeMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.pnHomeMain.Location = new System.Drawing.Point(0, 126);
            this.pnHomeMain.Name = "pnHomeMain";
            this.pnHomeMain.Size = new System.Drawing.Size(214, 45);
            this.pnHomeMain.TabIndex = 0;
            // 
            // ibtHomeGForm
            // 
            this.ibtHomeGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ibtHomeGForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibtHomeGForm.FlatAppearance.BorderSize = 0;
            this.ibtHomeGForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtHomeGForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.ibtHomeGForm.ForeColor = System.Drawing.Color.Silver;
            this.ibtHomeGForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ibtHomeGForm.IconColor = System.Drawing.Color.WhiteSmoke;
            this.ibtHomeGForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtHomeGForm.IconSize = 36;
            this.ibtHomeGForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHomeGForm.Location = new System.Drawing.Point(7, 0);
            this.ibtHomeGForm.Name = "ibtHomeGForm";
            this.ibtHomeGForm.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ibtHomeGForm.Size = new System.Drawing.Size(207, 45);
            this.ibtHomeGForm.TabIndex = 9;
            this.ibtHomeGForm.Text = "Головна";
            this.ibtHomeGForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtHomeGForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtHomeGForm.UseVisualStyleBackColor = false;
            this.ibtHomeGForm.Click += new System.EventHandler(this.ibtHomeGForm_Click);
            // 
            // pnHomeSmallGF
            // 
            this.pnHomeSmallGF.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnHomeSmallGF.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnHomeSmallGF.ForeColor = System.Drawing.Color.Transparent;
            this.pnHomeSmallGF.Location = new System.Drawing.Point(0, 0);
            this.pnHomeSmallGF.Name = "pnHomeSmallGF";
            this.pnHomeSmallGF.Size = new System.Drawing.Size(7, 45);
            this.pnHomeSmallGF.TabIndex = 1;
            this.pnHomeSmallGF.Visible = false;
            // 
            // pbIconAppGF
            // 
            this.pbIconAppGF.FillColor = System.Drawing.Color.Transparent;
            this.pbIconAppGF.Image = global::Сourse_WorkEX21.Properties.Resources.LogoIcon;
            this.pbIconAppGF.ImageRotate = 0F;
            this.pbIconAppGF.Location = new System.Drawing.Point(70, 27);
            this.pbIconAppGF.Name = "pbIconAppGF";
            this.pbIconAppGF.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbIconAppGF.Size = new System.Drawing.Size(64, 64);
            this.pbIconAppGF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIconAppGF.TabIndex = 8;
            this.pbIconAppGF.TabStop = false;
            // 
            // pnTopGForm
            // 
            this.pnTopGForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnTopGForm.Controls.Add(this.btMinimizeGForm);
            this.pnTopGForm.Controls.Add(this.btCloseGForm);
            this.pnTopGForm.Controls.Add(this.lbNameApp);
            this.pnTopGForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopGForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnTopGForm.Location = new System.Drawing.Point(0, 0);
            this.pnTopGForm.Name = "pnTopGForm";
            this.pnTopGForm.Size = new System.Drawing.Size(1050, 30);
            this.pnTopGForm.TabIndex = 0;
            this.pnTopGForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopGForm_MouseDown);
            this.pnTopGForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopGForm_MouseMove);
            this.pnTopGForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopGForm_MouseUp);
            // 
            // btMinimizeGForm
            // 
            this.btMinimizeGForm.FillColor = System.Drawing.Color.Transparent;
            this.btMinimizeGForm.Image = global::Сourse_WorkEX21.Properties.Resources.MinimizeIcon;
            this.btMinimizeGForm.ImageRotate = 0F;
            this.btMinimizeGForm.Location = new System.Drawing.Point(988, 0);
            this.btMinimizeGForm.Name = "btMinimizeGForm";
            this.btMinimizeGForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btMinimizeGForm.Size = new System.Drawing.Size(30, 30);
            this.btMinimizeGForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btMinimizeGForm.TabIndex = 10;
            this.btMinimizeGForm.TabStop = false;
            this.btMinimizeGForm.Click += new System.EventHandler(this.btMinimizeGForm_Click);
            // 
            // btCloseGForm
            // 
            this.btCloseGForm.FillColor = System.Drawing.Color.Transparent;
            this.btCloseGForm.Image = global::Сourse_WorkEX21.Properties.Resources.CloseIcon;
            this.btCloseGForm.ImageRotate = 0F;
            this.btCloseGForm.Location = new System.Drawing.Point(1016, 0);
            this.btCloseGForm.Name = "btCloseGForm";
            this.btCloseGForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btCloseGForm.Size = new System.Drawing.Size(30, 30);
            this.btCloseGForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCloseGForm.TabIndex = 9;
            this.btCloseGForm.TabStop = false;
            this.btCloseGForm.Click += new System.EventHandler(this.btCloseGForm_Click);
            // 
            // lbNameApp
            // 
            this.lbNameApp.AutoSize = true;
            this.lbNameApp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbNameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNameApp.Location = new System.Drawing.Point(525, 9);
            this.lbNameApp.Name = "lbNameApp";
            this.lbNameApp.Size = new System.Drawing.Size(40, 16);
            this.lbNameApp.TabIndex = 9;
            this.lbNameApp.Text = "Fast";
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.Controls.Add(this.pnGForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GForm";
            this.Text = "Fast";
            this.pnGForm.ResumeLayout(false);
            this.pnBarGForm.ResumeLayout(false);
            this.pnBarGForm.PerformLayout();
            this.pnOrders.ResumeLayout(false);
            this.pnExitMain.ResumeLayout(false);
            this.pnSettingsMain.ResumeLayout(false);
            this.pnHomeMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAppGF)).EndInit();
            this.pnTopGForm.ResumeLayout(false);
            this.pnTopGForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimizeGForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseGForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnGForm;
        private Guna.UI2.WinForms.Guna2Panel pnTopGForm;
        private Guna.UI2.WinForms.Guna2Panel pnBarGForm;
        private Guna.UI2.WinForms.Guna2Panel pnHomeSmallGF;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbIconAppGF;
        private System.Windows.Forms.Label lbNameApp;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btMinimizeGForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btCloseGForm;
        private Guna.UI2.WinForms.Guna2Panel pnHomeMain;
        private FontAwesome.Sharp.IconButton ibtHomeGForm;
        private Guna.UI2.WinForms.Guna2Panel pnExitMain;
        private FontAwesome.Sharp.IconButton ibtExitGForm;
        private Guna.UI2.WinForms.Guna2Panel pnSettingsMain;
        private FontAwesome.Sharp.IconButton ibtSettingsGForm;
        private Guna.UI2.WinForms.Guna2Panel pnSettingsSmallGF;
        private Guna.UI2.WinForms.Guna2Panel pnOrders;
        private FontAwesome.Sharp.IconButton ibOrdersGF;
        private Guna.UI2.WinForms.Guna2Panel pnOrdersSmalGF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idUser;
    }
}