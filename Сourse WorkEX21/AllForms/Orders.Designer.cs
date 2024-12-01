namespace Сourse_WorkEX21.AllForms
{
    partial class Orders
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
            this.gbBasket = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbIdDeleteOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataGridOrdersPanel = new System.Windows.Forms.DataGridView();
            this.btDeleteOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btEditOrderStatus = new Guna.UI2.WinForms.Guna2Button();
            this.btUpdateTableOrders = new Guna.UI2.WinForms.Guna2Button();
            this.gbBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrdersPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBasket
            // 
            this.gbBasket.BorderRadius = 20;
            this.gbBasket.Controls.Add(this.tbIdDeleteOrder);
            this.gbBasket.Controls.Add(this.DataGridOrdersPanel);
            this.gbBasket.Controls.Add(this.btDeleteOrder);
            this.gbBasket.Controls.Add(this.btEditOrderStatus);
            this.gbBasket.Controls.Add(this.btUpdateTableOrders);
            this.gbBasket.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.gbBasket.FillColor = System.Drawing.Color.Silver;
            this.gbBasket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbBasket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBasket.Location = new System.Drawing.Point(12, 12);
            this.gbBasket.Name = "gbBasket";
            this.gbBasket.Size = new System.Drawing.Size(793, 473);
            this.gbBasket.TabIndex = 2;
            this.gbBasket.Text = "Список замовлень";
            this.gbBasket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbIdDeleteOrder
            // 
            this.tbIdDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.tbIdDeleteOrder.BorderRadius = 12;
            this.tbIdDeleteOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdDeleteOrder.DefaultText = "";
            this.tbIdDeleteOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIdDeleteOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIdDeleteOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdDeleteOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdDeleteOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIdDeleteOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbIdDeleteOrder.Location = new System.Drawing.Point(471, 431);
            this.tbIdDeleteOrder.Name = "tbIdDeleteOrder";
            this.tbIdDeleteOrder.PasswordChar = '\0';
            this.tbIdDeleteOrder.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbIdDeleteOrder.PlaceholderText = "id ";
            this.tbIdDeleteOrder.SelectedText = "";
            this.tbIdDeleteOrder.Size = new System.Drawing.Size(114, 26);
            this.tbIdDeleteOrder.TabIndex = 5;
            // 
            // DataGridOrdersPanel
            // 
            this.DataGridOrdersPanel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridOrdersPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridOrdersPanel.Location = new System.Drawing.Point(0, 43);
            this.DataGridOrdersPanel.Name = "DataGridOrdersPanel";
            this.DataGridOrdersPanel.Size = new System.Drawing.Size(790, 359);
            this.DataGridOrdersPanel.TabIndex = 3;
            // 
            // btDeleteOrder
            // 
            this.btDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btDeleteOrder.BorderRadius = 25;
            this.btDeleteOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btDeleteOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btDeleteOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btDeleteOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btDeleteOrder.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btDeleteOrder.Location = new System.Drawing.Point(591, 419);
            this.btDeleteOrder.Name = "btDeleteOrder";
            this.btDeleteOrder.Size = new System.Drawing.Size(165, 49);
            this.btDeleteOrder.TabIndex = 2;
            this.btDeleteOrder.Text = "Видалити";
            this.btDeleteOrder.Click += new System.EventHandler(this.btDeleteOrder_Click);
            // 
            // btEditOrderStatus
            // 
            this.btEditOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.btEditOrderStatus.BorderRadius = 25;
            this.btEditOrderStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEditOrderStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEditOrderStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEditOrderStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEditOrderStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btEditOrderStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btEditOrderStatus.ForeColor = System.Drawing.Color.White;
            this.btEditOrderStatus.Location = new System.Drawing.Point(195, 419);
            this.btEditOrderStatus.Name = "btEditOrderStatus";
            this.btEditOrderStatus.Size = new System.Drawing.Size(165, 49);
            this.btEditOrderStatus.TabIndex = 2;
            this.btEditOrderStatus.Text = "Змінити статус замовлення";
            this.btEditOrderStatus.Click += new System.EventHandler(this.btEditOrderStatus_Click);
            // 
            // btUpdateTableOrders
            // 
            this.btUpdateTableOrders.BackColor = System.Drawing.Color.Transparent;
            this.btUpdateTableOrders.BorderRadius = 25;
            this.btUpdateTableOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpdateTableOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUpdateTableOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUpdateTableOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpdateTableOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btUpdateTableOrders.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btUpdateTableOrders.ForeColor = System.Drawing.Color.White;
            this.btUpdateTableOrders.Location = new System.Drawing.Point(24, 419);
            this.btUpdateTableOrders.Name = "btUpdateTableOrders";
            this.btUpdateTableOrders.Size = new System.Drawing.Size(165, 49);
            this.btUpdateTableOrders.TabIndex = 2;
            this.btUpdateTableOrders.Text = "Оновити таблицю замовлень";
            this.btUpdateTableOrders.Click += new System.EventHandler(this.btUpdateTableOrders_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.gbBasket);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.gbBasket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrdersPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbBasket;
        private Guna.UI2.WinForms.Guna2Button btEditOrderStatus;
        private Guna.UI2.WinForms.Guna2Button btUpdateTableOrders;
        private System.Windows.Forms.DataGridView DataGridOrdersPanel;
        private Guna.UI2.WinForms.Guna2Button btDeleteOrder;
        private Guna.UI2.WinForms.Guna2TextBox tbIdDeleteOrder;
    }
}