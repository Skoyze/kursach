using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using CustomControls;

namespace CustomControls.Forms
{
    public partial class FormGearUser : Form
    {
        public FormGearUser()
        {
            InitializeComponent();
        }

        private void RjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }
        private void FormGearUser_Load(object sender, EventArgs e)
        {
            labelLogin.Text = DataBank.TextFio;
            if (labelLogin.Text == "AlexandrovaTA")
            {
                labelNomer.Text = "89371265732";
                labelMail.Text = "yesno@mail.ru";
            }
            else if (labelLogin.Text == "RomanovDI")
            {
                labelNomer.Text = "89171547423";
                labelMail.Text = "donot@mail.ru";
            }
            else if (labelLogin.Text == "ZaxarovaOV")
            {
                labelNomer.Text = "89272685124";
                labelMail.Text = "ohmy@mal.ru";
            }
            else if (labelLogin.Text == "1")
            {
                labelNomer.Text = "89546257998";
                labelMail.Text = "sheesh@mail.ru";
            }
        }

        private void RjButton1_Click(object sender, EventArgs e)
        {
            labelLogin.Text = DataBank.TextFio;
            
            if (labelLogin.Text == "AlexandrovaTA")
            {


                String PassChange = passChangeBox.Texts;

                Datebase db = new Datebase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("UPDATE insurers SET insurers_pass = @iP WHERE id_insurers = 1", db.getConnection());

                command.Parameters.Add("@iP", MySqlDbType.VarChar).Value = PassChange;

                adapter.SelectCommand = command;

                adapter.Fill(table);
                if(passChangeBox.Texts == "")
                {
                    MessageBox.Show(Text = "Введите пароль");
                }
                if (passChangeBox.Texts != "")
                {
                    MessageBox.Show(Text = "Пароль изменен");
                }

            }
            if (labelLogin.Text == "RomanovDI")
            {
                String PassChange = passChangeBox.Texts;

                Datebase db = new Datebase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("UPDATE insurers SET insurers_pass = @iP WHERE id_insurers = 2", db.getConnection());

                command.Parameters.Add("@iP", MySqlDbType.VarChar).Value = PassChange;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (passChangeBox.Texts == "")
                {
                    MessageBox.Show(Text = "Введите пароль");
                }
                if (passChangeBox.Texts != "")
                {
                    MessageBox.Show(Text = "Пароль изменен");
                }
            }
            if (labelLogin.Text == "ZaxarovaOV")
            {
                String PassChange = passChangeBox.Texts;

                Datebase db = new Datebase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("UPDATE insurers SET insurers_pass = @iP WHERE id_insurers = 3", db.getConnection());

                command.Parameters.Add("@iP", MySqlDbType.VarChar).Value = PassChange;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (passChangeBox.Texts == "")
                {
                    MessageBox.Show(Text = "Введите пароль");
                }
                if (passChangeBox.Texts != "")
                {
                    MessageBox.Show(Text = "Пароль изменен");
                }
            }


            if (labelLogin.Text == "1")
            {
                String PassChange = passChangeBox.Texts;

                Datebase db = new Datebase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("UPDATE insurers SET insurers_pass = @iP WHERE id_insurers = 4", db.getConnection());

                command.Parameters.Add("@iP", MySqlDbType.VarChar).Value = PassChange;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (passChangeBox.Texts == "")
                {
                    MessageBox.Show(Text = "Введите пароль");
                }
                if (passChangeBox.Texts != "")
                {
                    MessageBox.Show(Text = "Пароль изменен");
                }
            }



        }



        private void RjTextBox3_Enter(object sender, EventArgs e)
        {
           
        }

        private void RjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void RjTextBox3_Leave(object sender, EventArgs e)
        {
            labelLogin.Visible = true;
        }
    }
}
