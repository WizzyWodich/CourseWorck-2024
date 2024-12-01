using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сourse_WorkEX21.AllForms
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPont;

        private void btCloseInfoPayForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnTopPayForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnTopPayForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPont, new Size(dif));
            }
        }

        private void pnTopPayForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPont = this.Location;
        }
    }
}
