using MySqlConnector;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void RjButton1_Click(object sender, EventArgs e)
        {
            /// создаем переменную с обращением в текстбокс для записи в бд
            String LoginUser = LoginLB.Texts;
            String PassUser = PassLB.Texts;
           
            Datebase db = new Datebase();

            DataTable table = new DataTable();
          
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM insurers WHERE insurers_login = @iU AND insurers_pass = @iP", db.getConnection());
            
            command.Parameters.Add("@iU", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@iP", MySqlDbType.VarChar).Value = PassUser;
            
            adapter.SelectCommand = command;
           
            adapter.Fill(table);
            
            if (table.Rows.Count > 0)
            {
                
                DataBank.TextFio = LoginLB.Texts;
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
       
            else
                MessageBox.Show("Cancel");
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(20, Color.Silver);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(65, 74, 76);
        }

        private void CloseButton_MouseUp(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(41, 49, 51);
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(41, 49, 51);
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            PassLB.PasswordChar = false;
        }

        private void IconButton2_Click(object sender, EventArgs e)
        {
            PassLB.PasswordChar = true;
        }

        private void IconPictureBox1_Click(object sender, EventArgs e)
        {
            PassLB.PasswordChar = true;
            iconPictureBox1.Visible = false;
            iconPictureBox2.Visible = true;
        }

        private void IconPictureBox2_Click(object sender, EventArgs e)
        {
            PassLB.PasswordChar = false;
            iconPictureBox1.Visible = true;
            iconPictureBox2.Visible = false;
        }
    }
}
