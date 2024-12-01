namespace Сourse_WorkEX21.AllForms
{
    partial class EditStatusOrder
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.rbAcept = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbDelivered = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(265, 30);
            this.guna2Panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fast";
            // 
            // btClose
            // 
            this.btClose.FillColor = System.Drawing.Color.Transparent;
            this.btClose.Image = global::Сourse_WorkEX21.Properties.Resources.CloseIcon;
            this.btClose.ImageRotate = 0F;
            this.btClose.Location = new System.Drawing.Point(229, 0);
            this.btClose.Name = "btClose";
            this.btClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btClose.Size = new System.Drawing.Size(30, 30);
            this.btClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btClose.TabIndex = 11;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // rbAcept
            // 
            this.rbAcept.AutoSize = true;
            this.rbAcept.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAcept.CheckedState.BorderThickness = 0;
            this.rbAcept.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAcept.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAcept.CheckedState.InnerOffset = -4;
            this.rbAcept.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAcept.Location = new System.Drawing.Point(5, 55);
            this.rbAcept.Name = "rbAcept";
            this.rbAcept.Size = new System.Drawing.Size(146, 20);
            this.rbAcept.TabIndex = 14;
            this.rbAcept.Text = "Прийнято курером";
            this.rbAcept.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAcept.UncheckedState.BorderThickness = 2;
            this.rbAcept.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAcept.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbDelivered
            // 
            this.rbDelivered.AutoSize = true;
            this.rbDelivered.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDelivered.CheckedState.BorderThickness = 0;
            this.rbDelivered.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbDelivered.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbDelivered.CheckedState.InnerOffset = -4;
            this.rbDelivered.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbDelivered.Location = new System.Drawing.Point(157, 55);
            this.rbDelivered.Name = "rbDelivered";
            this.rbDelivered.Size = new System.Drawing.Size(101, 20);
            this.rbDelivered.TabIndex = 14;
            this.rbDelivered.Text = "Доставлено";
            this.rbDelivered.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbDelivered.UncheckedState.BorderThickness = 2;
            this.rbDelivered.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbDelivered.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.Transparent;
            this.btEdit.BorderRadius = 15;
            this.btEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(78, 83);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(115, 35);
            this.btEdit.TabIndex = 15;
            this.btEdit.Text = "Змінити";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // EditStatusOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(265, 130);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.rbDelivered);
            this.Controls.Add(this.rbAcept);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditStatusOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditStatusOrder";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btClose;
        private Guna.UI2.WinForms.Guna2RadioButton rbDelivered;
        private Guna.UI2.WinForms.Guna2RadioButton rbAcept;
        private Guna.UI2.WinForms.Guna2Button btEdit;
    }
}