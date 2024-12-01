using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;
using Сourse_WorkEX21.AllForms;
using Сourse_WorkEX21.SupportingFiles.Methods;

namespace Сourse_WorkEX21
{
    public partial class GForm : Form
    {
        PersonalData personalData;
        public GForm()
        {
            InitializeComponent();
            personalData = new PersonalData();
            idUser.Text = personalData.getUserID().ToString();

        }
        // перетаскивание окна
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
                pnGForm.Controls.Add(childForm);
                pnGForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка\n {ex.Message}", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для изменения фона и текста кнопок
        private void SetButtonColor(IconButton button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.IconColor = foreColor;
        }

        private void btCloseGForm_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btMinimizeGForm_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        private void ibtHomeGForm_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColor(activeButton, activeBackgroundColorButton, activeForeColorButton);

            pnHomeSmallGF.Visible = true; // Вкл. белую подсветку

            SetButtonColor(ibtSettingsGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtExitGForm, defaultBackgroundColorButton, defaultForeColorColorButton);

            pnSettingsSmallGF.Visible = false;
            pnOrdersSmalGF.Visible = false;

            openForm(new Home());
        }

        private void ibtSettingsGForm_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColor(activeButton, activeBackgroundColorButton, activeForeColorButton);

            pnSettingsSmallGF.Visible = true; // Вкл. белую подсветку

            SetButtonColor(ibtHomeGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtExitGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibOrdersGF, defaultBackgroundColorButton, defaultForeColorColorButton);

            pnHomeSmallGF.Visible = false;
            pnOrdersSmalGF.Visible = false;

            openForm(new SetingsForm());
        }

        private void ibtExitGForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        
        private void pnTopGForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPont = this.Location;
        }

        private void pnTopGForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnTopGForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPont, new Size(dif));
            }
        }

        private void ibOrdersGF_Click(object sender, EventArgs e)
        {
            IconButton activeButton = (IconButton)sender;
            SetButtonColor(activeButton, activeBackgroundColorButton, activeForeColorButton);

            pnOrdersSmalGF.Visible = true; // Вкл. белую подсветку

            SetButtonColor(ibtHomeGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtExitGForm, defaultBackgroundColorButton, defaultForeColorColorButton);
            SetButtonColor(ibtSettingsGForm, defaultBackgroundColorButton, defaultForeColorColorButton);

            pnHomeSmallGF.Visible = false;
            pnSettingsSmallGF.Visible = false;

            openForm(new Orders());
        }

        public bool pnOrderGFVise
        {
            get { return pnOrders.Visible; }
            set { pnOrders.Visible = value; }
        }
    }
}
