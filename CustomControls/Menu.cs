using CustomControls.Forms;
using CustomControls.RJControls;
using CustomControls.Testing;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Menu : Form
    {

        private Form activeForm;

        public Menu()
        {
            InitializeComponent();
            closeFormButton.Hide();
        }



        private void Open_DropdownMenu(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
              => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width, 0);
        }

        private void Open_DropdownMenu2(RJDropdownMenu dropdownMenu, object sender)
        {
            Control control = (Control)sender;
            dropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
              => DropdownMenu_VisibleChanged(sender2, ev, control));
            dropdownMenu.Show(control, control.Width - dropdownMenu.Width, control.Height);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs e, Control ctrl)
        {
            RJDropdownMenu dropdownMenu = (RJDropdownMenu)sender;
            if (!DesignMode)
            {
                if (dropdownMenu.Visible)
                    ctrl.BackColor = Color.FromArgb(72, 52, 183);
                else ctrl.BackColor = Color.FromArgb(24, 24, 36);

            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        Point lastPoint;
        private void Okno_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Okno_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void IconButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


       

        private void OpenNewForm(Form newForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }     
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.None;
            newForm.Location = new Point(0, 0);
            newForm.Size = new Size(814, 467);
            this.panelDesktop.Controls.Add(newForm);
            this.panelDesktop.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
            labelMain.Text = newForm.Text;

        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            OpenNewForm(new FormClear(), sender);
            closeFormButton.Hide();
            labelMain.Text = "Главная";
        }



        private void IconButton1_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Login(), sender);
            closeFormButton.Show();
        }

        private void oknoMal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void OknoMal_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            //OpenNewForm(new qwer(), sender);
            closeFormButton.Show();
        }

        private void iconButtonNews_Click(object sender, EventArgs e)
        {
            OpenNewForm(new FormNews(), sender);
            closeFormButton.Show();
        }

        private void IconButton4_Click(object sender, EventArgs e)
        {

        }

        private void IconButton4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
