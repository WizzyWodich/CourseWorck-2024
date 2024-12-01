namespace CourseWorckAdminPanel.Forms
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataGridAdminPanel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.tbIdDeleteProd = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.gbMain.Location = new System.Drawing.Point(301, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(492, 473);
            this.gbMain.TabIndex = 2;
            this.gbMain.Text = "Меню";
            this.gbMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGridAdminPanel
            // 
            this.DataGridAdminPanel.AllowUserToAddRows = false;
            this.DataGridAdminPanel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridAdminPanel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridAdminPanel.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAdminPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridAdminPanel.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridAdminPanel.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.guna2GroupBox1.Controls.Add(this.tbDescription);
            this.guna2GroupBox1.Controls.Add(this.tbIdDeleteProd);
            this.guna2GroupBox1.Controls.Add(this.tbName);
            this.guna2GroupBox1.Controls.Add(this.btDelete);
            this.guna2GroupBox1.Controls.Add(this.btAdd);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(263, 473);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Можливості";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescription.BackColor = System.Drawing.Color.Transparent;
            this.tbDescription.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescription.BorderRadius = 12;
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.DefaultText = "";
            this.tbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDescription.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbDescription.Location = new System.Drawing.Point(32, 110);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PasswordChar = '\0';
            this.tbDescription.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbDescription.PlaceholderText = "Опис";
            this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDescription.SelectedText = "";
            this.tbDescription.Size = new System.Drawing.Size(191, 166);
            this.tbDescription.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderRadius = 12;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.Location = new System.Drawing.Point(32, 63);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbName.PlaceholderText = "Назва";
            this.tbName.SelectedText = "";
            this.tbName.Size = new System.Drawing.Size(191, 26);
            this.tbName.TabIndex = 4;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Transparent;
            this.btDelete.BorderRadius = 20;
            this.btDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btDelete.Location = new System.Drawing.Point(32, 412);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(139, 45);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Видалити";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.BorderRadius = 20;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btAdd.Location = new System.Drawing.Point(32, 286);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(191, 45);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Додати до ассортименту";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbIdDeleteProd
            // 
            this.tbIdDeleteProd.BackColor = System.Drawing.Color.Transparent;
            this.tbIdDeleteProd.BorderRadius = 12;
            this.tbIdDeleteProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdDeleteProd.DefaultText = "";
            this.tbIdDeleteProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIdDeleteProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIdDeleteProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdDeleteProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdDeleteProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdDeleteProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIdDeleteProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdDeleteProd.Location = new System.Drawing.Point(32, 380);
            this.tbIdDeleteProd.Name = "tbIdDeleteProd";
            this.tbIdDeleteProd.PasswordChar = '\0';
            this.tbIdDeleteProd.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbIdDeleteProd.PlaceholderText = "id ";
            this.tbIdDeleteProd.SelectedText = "";
            this.tbIdDeleteProd.Size = new System.Drawing.Size(191, 26);
            this.tbIdDeleteProd.TabIndex = 4;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "AdminPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAdminPanel)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridAdminPanel;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2TextBox tbDescription;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2Button btDelete;
        private Guna.UI2.WinForms.Guna2TextBox tbIdDeleteProd;
    }
}