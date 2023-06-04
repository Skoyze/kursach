using CustomControls;
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

namespace Osk.Forms
{
    public partial class FormAddStrx : Form
    {
        public FormAddStrx()
        {
            InitializeComponent();
        }

        private void ButtonAddStrx_Click(object sender, EventArgs e)
        {
            String insurers_login = rjTextBoxLogin.Texts;
            String insurers_pass = rjTextBoxPass.Texts;
            String insurers_number = rjTextBoxNomer.Texts;
            String insurers_email = rjTextBoxMail.Texts;

            Datebase db = new Datebase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"INSERT INTO insurers (insurers_login, insurers_pass, insurers_number, insurers_email) VALUES (@insurers_login, @insurers_pass, @insurers_number, @insurers_email)", db.getConnection());

            command.Parameters.AddWithValue("insurers_login", MySqlDbType.VarChar).Value = insurers_login;
            command.Parameters.AddWithValue("insurers_pass", MySqlDbType.VarChar).Value = insurers_pass;
            command.Parameters.AddWithValue("insurers_number", MySqlDbType.Int64).Value = insurers_number;
            command.Parameters.AddWithValue("insurers_email", MySqlDbType.VarChar).Value = insurers_email;

            if (rjTextBoxLogin.Texts == "")
            {
                MessageBox.Show(Text = "Введите логин");
            }
            else if (rjTextBoxPass.Texts == "")
            {
                MessageBox.Show(Text = "Введите пароль");
            }
            else if (rjTextBoxNomer.Texts == "")
            {
                MessageBox.Show(Text = "Введите номер");
            }
            else if (rjTextBoxMail.Texts == "")
            {
                MessageBox.Show(Text = "Введите почту");
            }
            else
            {
                MessageBox.Show(Text = "Новый страховщик добавлен!");

                adapter.SelectCommand = command;

                adapter.Fill(table);
            }
        }

        private void RjTextBoxNomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
