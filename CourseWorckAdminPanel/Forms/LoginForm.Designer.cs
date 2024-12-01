namespace CourseWorckAdminPanel.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnTopLoginForm = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNameApp = new System.Windows.Forms.Label();
            this.btMinimize = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btCloseLoginForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.gbLoginForm = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pbIconAppLF = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbResetPassword = new System.Windows.Forms.Label();
            this.lbLoginForm = new System.Windows.Forms.Label();
            this.PassIconLoginForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.UserIconLoginForm = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.cbShowPassLoginForm = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbPasswordLoginForm = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbLoginUserForm = new Guna.UI2.WinForms.Guna2TextBox();
            this.btInputLoginForm = new Guna.UI2.WinForms.Guna2Button();
            this.pnTopLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseLoginForm)).BeginInit();
            this.gbLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAppLF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassIconLoginForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLoginForm)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 25;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pnTopLoginForm
            // 
            this.pnTopLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnTopLoginForm.Controls.Add(this.lbNameApp);
            this.pnTopLoginForm.Controls.Add(this.btMinimize);
            this.pnTopLoginForm.Controls.Add(this.btCloseLoginForm);
            this.pnTopLoginForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopLoginForm.Location = new System.Drawing.Point(0, 0);
            this.pnTopLoginForm.Name = "pnTopLoginForm";
            this.pnTopLoginForm.Size = new System.Drawing.Size(400, 30);
            this.pnTopLoginForm.TabIndex = 0;
            this.pnTopLoginForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopLoginForm_MouseDown);
            this.pnTopLoginForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopLoginForm_MouseMove);
            this.pnTopLoginForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopLoginForm_MouseUp);
            // 
            // lbNameApp
            // 
            this.lbNameApp.AutoSize = true;
            this.lbNameApp.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbNameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNameApp.Location = new System.Drawing.Point(155, 9);
            this.lbNameApp.Name = "lbNameApp";
            this.lbNameApp.Size = new System.Drawing.Size(90, 16);
            this.lbNameApp.TabIndex = 13;
            this.lbNameApp.Text = "Fast Admin";
            // 
            // btMinimize
            // 
            this.btMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btMinimize.Image = global::CourseWorckAdminPanel.Properties.Resources.MinimizeIcon;
            this.btMinimize.ImageRotate = 0F;
            this.btMinimize.Location = new System.Drawing.Point(336, 0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btMinimize.Size = new System.Drawing.Size(30, 30);
            this.btMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btMinimize.TabIndex = 12;
            this.btMinimize.TabStop = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimizeLoginForm_Click);
            // 
            // btCloseLoginForm
            // 
            this.btCloseLoginForm.FillColor = System.Drawing.Color.Transparent;
            this.btCloseLoginForm.Image = global::CourseWorckAdminPanel.Properties.Resources.CloseIcon;
            this.btCloseLoginForm.ImageRotate = 0F;
            this.btCloseLoginForm.Location = new System.Drawing.Point(364, 0);
            this.btCloseLoginForm.Name = "btCloseLoginForm";
            this.btCloseLoginForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btCloseLoginForm.Size = new System.Drawing.Size(30, 30);
            this.btCloseLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btCloseLoginForm.TabIndex = 11;
            this.btCloseLoginForm.TabStop = false;
            this.btCloseLoginForm.Click += new System.EventHandler(this.btCloseLoginForm_Click);
            // 
            // gbLoginForm
            // 
            this.gbLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.gbLoginForm.BorderColor = System.Drawing.Color.Transparent;
            this.gbLoginForm.BorderRadius = 20;
            this.gbLoginForm.Controls.Add(this.pbIconAppLF);
            this.gbLoginForm.Controls.Add(this.lbResetPassword);
            this.gbLoginForm.Controls.Add(this.lbLoginForm);
            this.gbLoginForm.Controls.Add(this.PassIconLoginForm);
            this.gbLoginForm.Controls.Add(this.UserIconLoginForm);
            this.gbLoginForm.Controls.Add(this.cbShowPassLoginForm);
            this.gbLoginForm.Controls.Add(this.tbPasswordLoginForm);
            this.gbLoginForm.Controls.Add(this.tbLoginUserForm);
            this.gbLoginForm.Controls.Add(this.btInputLoginForm);
            this.gbLoginForm.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbLoginForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gbLoginForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbLoginForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbLoginForm.Location = new System.Drawing.Point(12, 40);
            this.gbLoginForm.Name = "gbLoginForm";
            this.gbLoginForm.ShadowDecoration.BorderRadius = 30;
            this.gbLoginForm.ShadowDecoration.Depth = 40;
            this.gbLoginForm.ShadowDecoration.Enabled = true;
            this.gbLoginForm.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(7);
            this.gbLoginForm.Size = new System.Drawing.Size(376, 448);
            this.gbLoginForm.TabIndex = 1;
            // 
            // pbIconAppLF
            // 
            this.pbIconAppLF.BackColor = System.Drawing.Color.Transparent;
            this.pbIconAppLF.FillColor = System.Drawing.Color.Transparent;
            this.pbIconAppLF.Image = global::CourseWorckAdminPanel.Properties.Resources.SmallLogo;
            this.pbIconAppLF.ImageRotate = 0F;
            this.pbIconAppLF.Location = new System.Drawing.Point(169, 17);
            this.pbIconAppLF.Name = "pbIconAppLF";
            this.pbIconAppLF.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbIconAppLF.Size = new System.Drawing.Size(32, 32);
            this.pbIconAppLF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIconAppLF.TabIndex = 11;
            this.pbIconAppLF.TabStop = false;
            this.pbIconAppLF.UseTransparentBackground = true;
            // 
            // lbResetPassword
            // 
            this.lbResetPassword.AutoSize = true;
            this.lbResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbResetPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.lbResetPassword.Location = new System.Drawing.Point(131, 339);
            this.lbResetPassword.Name = "lbResetPassword";
            this.lbResetPassword.Size = new System.Drawing.Size(102, 13);
            this.lbResetPassword.TabIndex = 10;
            this.lbResetPassword.Text = "Забув пароль?";
            this.lbResetPassword.Click += new System.EventHandler(this.lbResetPassword_Click);
            this.lbResetPassword.MouseLeave += new System.EventHandler(this.lbResetPassword_MouseLeave);
            this.lbResetPassword.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbResetPassword_MouseMove);
            // 
            // lbLoginForm
            // 
            this.lbLoginForm.AutoSize = true;
            this.lbLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbLoginForm.Location = new System.Drawing.Point(98, 52);
            this.lbLoginForm.Name = "lbLoginForm";
            this.lbLoginForm.Size = new System.Drawing.Size(186, 56);
            this.lbLoginForm.TabIndex = 8;
            this.lbLoginForm.Text = "Адмін панель \r\n Авторизація\r\n";
            // 
            // PassIconLoginForm
            // 
            this.PassIconLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.PassIconLoginForm.Image = global::CourseWorckAdminPanel.Properties.Resources.PasswordIcon;
            this.PassIconLoginForm.ImageRotate = 0F;
            this.PassIconLoginForm.Location = new System.Drawing.Point(49, 196);
            this.PassIconLoginForm.Name = "PassIconLoginForm";
            this.PassIconLoginForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PassIconLoginForm.Size = new System.Drawing.Size(45, 45);
            this.PassIconLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PassIconLoginForm.TabIndex = 7;
            this.PassIconLoginForm.TabStop = false;
            this.PassIconLoginForm.UseTransparentBackground = true;
            // 
            // UserIconLoginForm
            // 
            this.UserIconLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.UserIconLoginForm.Image = global::CourseWorckAdminPanel.Properties.Resources.UserReg;
            this.UserIconLoginForm.ImageRotate = 0F;
            this.UserIconLoginForm.Location = new System.Drawing.Point(49, 129);
            this.UserIconLoginForm.Name = "UserIconLoginForm";
            this.UserIconLoginForm.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UserIconLoginForm.Size = new System.Drawing.Size(45, 45);
            this.UserIconLoginForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserIconLoginForm.TabIndex = 6;
            this.UserIconLoginForm.TabStop = false;
            this.UserIconLoginForm.UseTransparentBackground = true;
            // 
            // cbShowPassLoginForm
            // 
            this.cbShowPassLoginForm.AutoSize = true;
            this.cbShowPassLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPassLoginForm.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.cbShowPassLoginForm.CheckedState.BorderRadius = 2;
            this.cbShowPassLoginForm.CheckedState.BorderThickness = 0;
            this.cbShowPassLoginForm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cbShowPassLoginForm.CheckMarkColor = System.Drawing.Color.WhiteSmoke;
            this.cbShowPassLoginForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowPassLoginForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbShowPassLoginForm.Location = new System.Drawing.Point(103, 238);
            this.cbShowPassLoginForm.Name = "cbShowPassLoginForm";
            this.cbShowPassLoginForm.Size = new System.Drawing.Size(152, 20);
            this.cbShowPassLoginForm.TabIndex = 5;
            this.cbShowPassLoginForm.Text = "Показати пароль";
            this.cbShowPassLoginForm.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.cbShowPassLoginForm.UncheckedState.BorderRadius = 2;
            this.cbShowPassLoginForm.UncheckedState.BorderThickness = 0;
            this.cbShowPassLoginForm.UncheckedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cbShowPassLoginForm.UseVisualStyleBackColor = false;
            this.cbShowPassLoginForm.CheckedChanged += new System.EventHandler(this.cbShowPassLoginForm_CheckedChanged);
            // 
            // tbPasswordLoginForm
            // 
            this.tbPasswordLoginForm.Animated = true;
            this.tbPasswordLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.tbPasswordLoginForm.BorderColor = System.Drawing.Color.White;
            this.tbPasswordLoginForm.BorderRadius = 15;
            this.tbPasswordLoginForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordLoginForm.DefaultText = "";
            this.tbPasswordLoginForm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPasswordLoginForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPasswordLoginForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordLoginForm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPasswordLoginForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordLoginForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPasswordLoginForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tbPasswordLoginForm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPasswordLoginForm.Location = new System.Drawing.Point(98, 200);
            this.tbPasswordLoginForm.Name = "tbPasswordLoginForm";
            this.tbPasswordLoginForm.PasswordChar = '\0';
            this.tbPasswordLoginForm.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.tbPasswordLoginForm.PlaceholderText = "";
            this.tbPasswordLoginForm.SelectedText = "";
            this.tbPasswordLoginForm.Size = new System.Drawing.Size(200, 32);
            this.tbPasswordLoginForm.TabIndex = 4;
            // 
            // tbLoginUserForm
            // 
            this.tbLoginUserForm.Animated = true;
            this.tbLoginUserForm.BackColor = System.Drawing.Color.Transparent;
            this.tbLoginUserForm.BorderColor = System.Drawing.Color.White;
            this.tbLoginUserForm.BorderRadius = 15;
            this.tbLoginUserForm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLoginUserForm.DefaultText = "";
            this.tbLoginUserForm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLoginUserForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLoginUserForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLoginUserForm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLoginUserForm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLoginUserForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbLoginUserForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.tbLoginUserForm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLoginUserForm.Location = new System.Drawing.Point(98, 135);
            this.tbLoginUserForm.Name = "tbLoginUserForm";
            this.tbLoginUserForm.PasswordChar = '\0';
            this.tbLoginUserForm.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.tbLoginUserForm.PlaceholderText = "";
            this.tbLoginUserForm.SelectedText = "";
            this.tbLoginUserForm.Size = new System.Drawing.Size(200, 32);
            this.tbLoginUserForm.TabIndex = 3;
            // 
            // btInputLoginForm
            // 
            this.btInputLoginForm.BackColor = System.Drawing.Color.Transparent;
            this.btInputLoginForm.BorderRadius = 20;
            this.btInputLoginForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btInputLoginForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btInputLoginForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btInputLoginForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btInputLoginForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btInputLoginForm.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btInputLoginForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btInputLoginForm.Location = new System.Drawing.Point(93, 291);
            this.btInputLoginForm.Name = "btInputLoginForm";
            this.btInputLoginForm.Size = new System.Drawing.Size(180, 45);
            this.btInputLoginForm.TabIndex = 2;
            this.btInputLoginForm.Text = "Увійти";
            this.btInputLoginForm.Click += new System.EventHandler(this.btInputLoginForm_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.gbLoginForm);
            this.Controls.Add(this.pnTopLoginForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast";
            this.pnTopLoginForm.ResumeLayout(false);
            this.pnTopLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCloseLoginForm)).EndInit();
            this.gbLoginForm.ResumeLayout(false);
            this.gbLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAppLF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassIconLoginForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconLoginForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnTopLoginForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btCloseLoginForm;
        private Guna.UI2.WinForms.Guna2GroupBox gbLoginForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox UserIconLoginForm;
        private Guna.UI2.WinForms.Guna2CheckBox cbShowPassLoginForm;
        private Guna.UI2.WinForms.Guna2TextBox tbPasswordLoginForm;
        private Guna.UI2.WinForms.Guna2TextBox tbLoginUserForm;
        private Guna.UI2.WinForms.Guna2Button btInputLoginForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox PassIconLoginForm;
        private System.Windows.Forms.Label lbLoginForm;
        private System.Windows.Forms.Label lbResetPassword;
        private System.Windows.Forms.Label lbNameApp;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbIconAppLF;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btMinimize;
    }
}