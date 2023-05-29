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

namespace CustomControls.Forms
{
    enum RoWState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class FormReadyDgvr : Form
    {
        Datebase db = new Datebase();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        int selectedRow;
        public FormReadyDgvr()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("Dogovor_ImyaSobstv", "Имя собственника");
            dataGridView1.Columns.Add("Dogovor_FamSobstv", "Фамилия собственника");
            dataGridView1.Columns.Add("Dogovor_OtchestvoSobstv", "Отчество собственника");
            dataGridView1.Columns.Add("Dogovor_DateRozhdSobstv", "Дата рождения собственника");
            dataGridView1.Columns.Add("Dogovor_SnilsSobstv", "СНИЛС собственника");
            dataGridView1.Columns.Add("Dogovor_Srok", "Срок страхования");
            dataGridView1.Columns.Add("Dogovor_Period", "Период страхования");
            dataGridView1.Columns.Add("Dogovor_SeriaPasport", "Серия паспорта");
            dataGridView1.Columns.Add("Dogovor_NomerPasport", "Номер паспорта");
            dataGridView1.Columns.Add("Dogovor_KemVidanPasport", "Кем выдан паспорт");
            dataGridView1.Columns.Add("Dogovor_DatePasport", "Дата выдачи паспорта");
            dataGridView1.Columns.Add("Dogovor_KodPodrPasport", "Код подр. паспорта");
            dataGridView1.Columns.Add("Dogovor_TelephoneSobstv", "Телефон");
            dataGridView1.Columns.Add("Dogovor_PochtaSobstv", "почта");
            dataGridView1.Columns.Add("Dogovor_AdressSobstv", "Адрес");
            dataGridView1.Columns.Add("Dogovor_MarkaTS", "Марка");
            dataGridView1.Columns.Add("Dogovor_ModelTS", "Модель");
            dataGridView1.Columns.Add("Dogovor_GodTS", "Год");
            dataGridView1.Columns.Add("Dogovor_GosNomerTS", "Гос. Номер");
            dataGridView1.Columns.Add("Dogovor_VINTS", "VIN");
            dataGridView1.Columns.Add("Dogovor_MochTS", "Мощность");
            dataGridView1.Columns.Add("Dogovor_IspolzTS", "Цель использования");
            dataGridView1.Columns.Add("Dogovor_ImyaStrx", "Имя страхователя");
            dataGridView1.Columns.Add("Dogovor_FamStrx", "Фамилия страхователя");
            dataGridView1.Columns.Add("Dogovor_OtchestvoStrx", "Отчество страхователя");
            dataGridView1.Columns.Add("Dogovor_NachaloStazhaStrx", "Начало стажа вождения страхователя");
            dataGridView1.Columns.Add("Dogovor_SeriaVUStrx", "Серия ВУ страхователя");
            dataGridView1.Columns.Add("Dogovor_NomerVUStrx", "Номер ВУ страхователя");
            dataGridView1.Columns.Add("Dogovor_MassaTS", "Масса ТС");
            dataGridView1.Columns.Add("Dogovor_SeriaDocTS", "Серия документа на ТС");
            dataGridView1.Columns.Add("Dogovor_NomerDocTS", "Номер документа на ТС");
            dataGridView1.Columns.Add("Dogovor_DateDocTS", "Дата выдачи документа на ТС");
            dataGridView1.Columns.Add("Dogovor_StoimStrx", "Стоимость страховки");
            dataGridView1.Columns.Add("", string.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDateTime(4), record.GetInt32(5), record.GetString(6), record.GetString(7), record.GetInt32(8), record.GetInt32(9), record.GetString(10), record.GetDateTime(11), record.GetInt32(12), record.GetInt32(13), record.GetString(14), record.GetString(15), record.GetString(16), record.GetString(17), record.GetInt32(18), record.GetString(19), record.GetString(20), record.GetInt32(21), record.GetString(22), record.GetString(23), record.GetString(24), record.GetString(25), record.GetDateTime(26), record.GetInt32(27), record.GetInt32(28), record.GetInt32(29), record.GetInt32(30), record.GetInt32(31), record.GetDateTime(32), record.GetString(33), RoWState.ModifiedNew);

        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from Dogovor";

            MySqlCommand command = new MySqlCommand(queryString, db.getConnection());

            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void FormReadyDgvr_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 26, 52);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumSlateBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(26, 26, 52);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(83, 55, 122);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.FromArgb(34, 33, 60);
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 26, 52);


            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[6].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[7].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[8].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[9].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[10].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[11].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[12].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[13].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[14].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[15].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[16].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[17].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[18].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[19].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[20].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[21].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[22].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[23].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[24].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[25].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[26].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[27].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[28].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[29].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[30].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[31].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[32].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[33].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns[34].Visible = false;


            dataGridView1.Columns["Dogovor_ImyaSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_FamSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_OtchestvoSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_DateRozhdSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_SnilsSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_Srok"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_Period"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_SeriaPasport"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_NomerPasport"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_KemVidanPasport"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_DatePasport"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_KodPodrPasport"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_TelephoneSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_PochtaSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_AdressSobstv"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_MarkaTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_ModelTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_GodTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_GosNomerTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_VINTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_MochTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_IspolzTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_ImyaStrx"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_FamStrx"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_OtchestvoStrx"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_NachaloStazhaStrx"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_SeriaVUStrx"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_NomerVUStrx"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_MassaTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_SeriaDocTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_NomerDocTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_DateDocTS"].DefaultCellStyle.Font = new Font("Verdana", 10);
            dataGridView1.Columns["Dogovor_StoimStrx"].DefaultCellStyle.Font = new Font("Verdana", 10);


        }
        

        private void RjButton3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Dogovor where concat (idDogovor, Dogovor_ImyaSobstv, Dogovor_FamSobstv, Dogovor_OtchestvoSobstv, Dogovor_DateRozhdSobstv, Dogovor_SnilsSobstv, Dogovor_Srok, Dogovor_Period, Dogovor_SeriaPasport, Dogovor_NomerPasport, Dogovor_KemVidanPasport, Dogovor_DatePasport, Dogovor_KodPodrPasport, Dogovor_KodPodrPasport, Dogovor_PochtaSobstv, Dogovor_AdressSobstv, Dogovor_MarkaTS, Dogovor_ModelTS, Dogovor_GodTS, Dogovor_GosNomerTS, Dogovor_VINTS, Dogovor_MochTS, Dogovor_IspolzTS, Dogovor_ImyaStrx) like '%" + rjTextBoxSearch.Texts + "%'";

            MySqlCommand com = new MySqlCommand(searchString, db.getConnection());

            db.openConnection();

            MySqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void RjTextBox1__TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
            }
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[34].Value = RoWState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[34].Value = RoWState.Deleted;
        }

        private void Update1()
        {

            Datebase db = new Datebase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RoWState)dataGridView1.Rows[index].Cells[34].Value;

                if (rowState == RoWState.Existed)
                    continue;

                if(rowState == RoWState.Deleted) 
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Dogovor where idDogovor = {id}";

                    var command = new MySqlCommand(deleteQuery, db.getConnection());

                    command.ExecuteNonQuery();

                    adapter.SelectCommand = command;

                    adapter.Fill(table);
                }
            }
            db.closeConnection();

        }

        private void RjButton1_Click(object sender, EventArgs e)
        {

            DeleteRow();
        }

        private void RjButton2_Click(object sender, EventArgs e)
        {
            Update1();
        }

       
    }
}

