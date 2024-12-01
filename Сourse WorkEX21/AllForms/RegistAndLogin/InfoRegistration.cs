using System;
using System.Drawing;
using System.Windows.Forms;

namespace Сourse_WorkEX21.AllForms
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPont;

        private void btCloseInfoRegistrationForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnTopInfoRegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPont = this.Location;
        }

        private void pnTopInfoRegistrationForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnTopInfoRegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPont, new Size(dif));
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
