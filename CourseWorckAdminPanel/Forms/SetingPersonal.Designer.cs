namespace CourseWorckAdminPanel.Forms
{
    partial class SetingPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataGridAdminPanel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbOrder = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbUser = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btEditStatus = new Guna.UI2.WinForms.Guna2Button();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAdminPanel)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.SystemColors.Control;
            this.gbMain.BorderRadius = 20;
            this.gbMain.Controls.Add(this.DataGridAdminPanel);
            this.gbMain.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gbMain.FillColor = System.Drawing.Color.Silver;
            this.gbMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbMain.Location = new System.Drawing.Point(298, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(492, 473);
            this.gbMain.TabIndex = 4;
            this.gbMain.Text = "Користувачі та персонал";
            this.gbMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGridAdminPanel
            // 
            this.DataGridAdminPanel.AllowUserToAddRows = false;
            this.DataGridAdminPanel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridAdminPanel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridAdminPanel.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAdminPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridAdminPanel.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridAdminPanel.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridAdminPanel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridAdminPanel.Location = new System.Drawing.Point(0, 40);
            this.DataGridAdminPanel.Name = "DataGridAdminPanel";
            this.DataGridAdminPanel.ReadOnly = true;
            this.DataGridAdminPanel.RowHeadersVisible = false;
            this.DataGridAdminPanel.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DataGridAdminPanel.Size = new System.Drawing.Size(492, 433);
            this.DataGridAdminPanel.TabIndex = 0;
            this.DataGridAdminPanel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridAdminPanel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridAdminPanel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridAdminPanel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridAdminPanel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridAdminPanel.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridAdminPanel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridAdminPanel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DataGridAdminPanel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridAdminPanel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DataGridAdminPanel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Silver;
            this.DataGridAdminPanel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridAdminPanel.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGridAdminPanel.ThemeStyle.ReadOnly = true;
            this.DataGridAdminPanel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridAdminPanel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridAdminPanel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DataGridAdminPanel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridAdminPanel.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridAdminPanel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridAdminPanel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.rbOrder);
            this.guna2GroupBox1.Controls.Add(this.rbAdmin);
            this.guna2GroupBox1.Controls.Add(this.rbUser);
            this.guna2GroupBox1.Controls.Add(this.btEditStatus);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(263, 473);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Зміна статусу";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbOrder
            // 
            this.rbOrder.AutoSize = true;
            this.rbOrder.BackColor = System.Drawing.Color.Transparent;
            this.rbOrder.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOrder.CheckedState.BorderThickness = 0;
            this.rbOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOrder.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOrder.CheckedState.InnerOffset = -4;
            this.rbOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.rbOrder.Location = new System.Drawing.Point(36, 217);
            this.rbOrder.Name = "rbOrder";
            this.rbOrder.Size = new System.Drawing.Size(74, 25);
            this.rbOrder.TabIndex = 4;
            this.rbOrder.Text = "Курєр";
            this.rbOrder.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbOrder.UncheckedState.BorderThickness = 2;
            this.rbOrder.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOrder.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbOrder.UseVisualStyleBackColor = false;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rbAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAdmin.CheckedState.BorderThickness = 0;
            this.rbAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAdmin.CheckedState.InnerOffset = -4;
            this.rbAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.rbAdmin.Location = new System.Drawing.Point(36, 170);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(143, 25);
            this.rbAdmin.TabIndex = 4;
            this.rbAdmin.Text = "Адміністратор";
            this.rbAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAdmin.UncheckedState.BorderThickness = 2;
            this.rbAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAdmin.UseVisualStyleBackColor = false;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.BackColor = System.Drawing.Color.Transparent;
            this.rbUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbUser.CheckedState.BorderThickness = 0;
            this.rbUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbUser.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbUser.CheckedState.InnerOffset = -4;
            this.rbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.rbUser.Location = new System.Drawing.Point(36, 118);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(120, 25);
            this.rbUser.TabIndex = 4;
            this.rbUser.Text = "Користувач";
            this.rbUser.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbUser.UncheckedState.BorderThickness = 2;
            this.rbUser.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbUser.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbUser.UseVisualStyleBackColor = false;
            // 
            // btEditStatus
            // 
            this.btEditStatus.BackColor = System.Drawing.Color.Transparent;
            this.btEditStatus.BorderRadius = 20;
            this.btEditStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEditStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEditStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btEditStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btEditStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btEditStatus.Location = new System.Drawing.Point(36, 414);
            this.btEditStatus.Name = "btEditStatus";
            this.btEditStatus.Size = new System.Drawing.Size(180, 45);
            this.btEditStatus.TabIndex = 3;
            this.btEditStatus.Text = "Змінити статус";
            this.btEditStatus.Click += new System.EventHandler(this.btEditStatus_Click);
            // 
            // SetingPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "SetingPersonal";
            this.Text = "SetingPersonal";
            this.Load += new System.EventHandler(this.SetingPersonal_Load);
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAdminPanel)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridAdminPanel;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btEditStatus;
        private Guna.UI2.WinForms.Guna2RadioButton rbOrder;
        private Guna.UI2.WinForms.Guna2RadioButton rbAdmin;
        private Guna.UI2.WinForms.Guna2RadioButton rbUser;
    }
}