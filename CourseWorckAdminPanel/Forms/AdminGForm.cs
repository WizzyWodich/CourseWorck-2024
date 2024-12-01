using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWorckAdminPanel.Forms
{
    public partial class AdminGForm : Form
    {
        public AdminGForm()
        {
            InitializeComponent();
        }
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPont;

        private Color defaultBackgroundColorButton = Color.FromArgb(31, 31, 31);
        private Color defaultForeColorColorButton = Color.WhiteSmoke;

        private Color activeBackgroundColorButton = Color.FromArgb(72, 72, 72);
        private Color activeForeColorButton = Color.LightCoral;

        private Form activeForm = null;

        private void openForm(Form childForm)
        {
            try
            {
                if (activeForm != null)
                    activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnAForm.Controls.Add(childForm);
                pnAForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка\n {ex.Message}", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetButtonColor(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void pnTopGForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPont, new Size(dif));
            }
        }

        private void pnTopGForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnTopGForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPont = this.Location;
        }

        private void ibtExitGForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btCloseGForm_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btMinimizeGForm_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void ibtHomeGForm_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColor(activeButton, activeBackgroundColorButton, activeForeColorButton);

            pnHomeSmallAGF.Visible = true; // Вкл. белую подсветку

            SetButtonColor(ibtSettingsAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtExitAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibAdminAdminForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibSettingPersonalsAGF, defaultBackgroundColorButton, defaultForeColorColorButton);

            pnSettingsSmallAGF.Visible = false;
            pnAdminSmallAF.Visible = false;
            pnSettingPersonalsSmalAGF.Visible = false;


            openForm(new Home());
        }

        private void ibtSettingsGForm_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColor(activeButton, activeBackgroundColorButton, activeForeColorButton);

            pnSettingsSmallAGF.Visible = true; // Вкл. белую подсветку

            SetButtonColor(ibtHomeAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtExitAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibAdminAdminForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibSettingPersonalsAGF, defaultBackgroundColorButton, defaultForeColorColorButton);

            pnHomeSmallAGF.Visible = false;
            pnAdminSmallAF.Visible = false;
            pnSettingPersonalsSmalAGF.Visible = false;

            openForm(new SetingsForm());
        }

        private void ibAdminAdminForm_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColor(activeButton, activeBackgroundColorButton, activeForeColorButton);

            pnAdminSmallAF.Visible = true; // Вкл. белую подсветку

            SetButtonColor(ibtHomeAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtExitAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtSettingsAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibSettingPersonalsAGF, defaultBackgroundColorButton, defaultForeColorColorButton);

            pnHomeSmallAGF.Visible = false;
            pnSettingsSmallAGF.Visible = false;
            pnSettingPersonalsSmalAGF.Visible = false;

            openForm(new AdminPanel());
        }

        private void ibSettingPersonalsAGF_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColor(activeButton, activeBackgroundColorButton, activeForeColorButton);

            pnSettingPersonalsSmalAGF.Visible = true; // Вкл. белую подсветку

            SetButtonColor(ibtHomeAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtExitAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibAdminAdminForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtSettingsAGForm, defaultBackgroundColorButton, defaultForeColorColorButton);

            pnHomeSmallAGF.Visible = false;
            pnAdminSmallAF.Visible = false;
            pnSettingsSmallAGF.Visible = false;

            openForm(new SetingPersonal());
        }
    }
}
