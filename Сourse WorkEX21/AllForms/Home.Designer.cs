namespace Сourse_WorkEX21.AllForms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.gbMain = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DataGridMain = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.clbBasket = new System.Windows.Forms.CheckedListBox();
            this.btDeleteBasket = new Guna.UI2.WinForms.Guna2Button();
            this.btBuy = new Guna.UI2.WinForms.Guna2Button();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMain)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.SystemColors.Control;
            this.gbMain.BorderRadius = 20;
            this.gbMain.Controls.Add(this.DataGridMain);
            this.gbMain.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gbMain.FillColor = System.Drawing.Color.Silver;
            this.gbMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbMain.Location = new System.Drawing.Point(279, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(514, 473);
            this.gbMain.TabIndex = 2;
            this.gbMain.Text = "Меню";
            this.gbMain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataGridMain
            // 
            this.DataGridMain.AllowUserToAddRows = false;
            this.DataGridMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridMain.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridMain.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridMain.Location = new System.Drawing.Point(0, 40);
            this.DataGridMain.Name = "DataGridMain";
            this.DataGridMain.ReadOnly = true;
            this.DataGridMain.RowHeadersVisible = false;
            this.DataGridMain.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DataGridMain.Size = new System.Drawing.Size(514, 433);
            this.DataGridMain.TabIndex = 0;
            this.DataGridMain.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridMain.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridMain.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridMain.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridMain.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridMain.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.DataGridMain.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridMain.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.DataGridMain.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridMain.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DataGridMain.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Silver;
            this.DataGridMain.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridMain.ThemeStyle.HeaderStyle.Height = 25;
            this.DataGridMain.ThemeStyle.ReadOnly = true;
            this.DataGridMain.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridMain.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridMain.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DataGridMain.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridMain.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridMain.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridMain.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMain_CellContentClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.btRefresh);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(15, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(258, 92);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Можливості";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btRefresh.BorderRadius = 20;
            this.btRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btRefresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btRefresh.Location = new System.Drawing.Point(18, 43);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(225, 41);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Оновлення таблиці";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.clbBasket);
            this.guna2GroupBox2.Controls.Add(this.btDeleteBasket);
            this.guna2GroupBox2.Controls.Add(this.btBuy);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Silver;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 110);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(258, 375);
            this.guna2GroupBox2.TabIndex = 5;
            this.guna2GroupBox2.Text = "Ваш кошик";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clbBasket
            // 
            this.clbBasket.BackColor = System.Drawing.Color.Silver;
            this.clbBasket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbBasket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clbBasket.FormattingEnabled = true;
            this.clbBasket.Items.AddRange(new object[] {
            ""});
            this.clbBasket.Location = new System.Drawing.Point(0, 43);
            this.clbBasket.Name = "clbBasket";
            this.clbBasket.Size = new System.Drawing.Size(255, 264);
            this.clbBasket.TabIndex = 5;
            // 
            // btDeleteBasket
            // 
            this.btDeleteBasket.BackColor = System.Drawing.Color.Transparent;
            this.btDeleteBasket.BorderRadius = 20;
            this.btDeleteBasket.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteBasket.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteBasket.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDeleteBasket.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDeleteBasket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btDeleteBasket.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btDeleteBasket.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btDeleteBasket.Location = new System.Drawing.Point(127, 317);
            this.btDeleteBasket.Name = "btDeleteBasket";
            this.btDeleteBasket.Size = new System.Drawing.Size(118, 41);
            this.btDeleteBasket.TabIndex = 4;
            this.btDeleteBasket.Text = "Видалити";
            this.btDeleteBasket.Click += new System.EventHandler(this.btDeleteBasket_Click);
            // 
            // btBuy
            // 
            this.btBuy.BackColor = System.Drawing.Color.Transparent;
            this.btBuy.BorderRadius = 20;
            this.btBuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btBuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btBuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btBuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btBuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btBuy.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btBuy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btBuy.Location = new System.Drawing.Point(3, 317);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(118, 41);
            this.btBuy.TabIndex = 4;
            this.btBuy.Text = "Замовити";
            this.btBuy.Click += new System.EventHandler(this.btBuy_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.guna2GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Form1";
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMain)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbMain;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridMain;
        private Guna.UI2.WinForms.Guna2Button btRefresh;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btBuy;
        private Guna.UI2.WinForms.Guna2Button btDeleteBasket;
        private System.Windows.Forms.CheckedListBox clbBasket;
    }
}