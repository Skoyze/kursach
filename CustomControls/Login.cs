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
            /// выделяем память под бд
            Datebase db = new Datebase();

            DataTable table = new DataTable();
            /// через адаптер можно обращаться к командам
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            /// создаем объект, который позволит прописать команду для выборки данных и бд
            MySqlCommand command = new MySqlCommand("SELECT * FROM insurers WHERE insurers_login = @iU AND insurers_pass = @iP", db.getConnection());
            /// создаем заглушки для безопастности (выше) и делаем из них переменные 
            command.Parameters.Add("@iU", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@iP", MySqlDbType.VarChar).Value = PassUser;
            /// указываем, какую команду выполнять
            adapter.SelectCommand = command;
            /// служит для заполнения таблиц (данных для бд)
            adapter.Fill(table);
            /// если рядов больше чем 0, то данные есть в бд
            if (table.Rows.Count > 0)
            {
                /// прячет данное окно и открывает окно меню
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            /// если нету логина и пароля, то отказ в доступе
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
    }
}
