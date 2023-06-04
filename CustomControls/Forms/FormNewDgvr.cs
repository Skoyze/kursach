using MySqlConnector;
using Osk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Forms
{
    public partial class FormNewDgvr : Form
    {
        bool Clicked = false;
        public FormNewDgvr()
        {
            InitializeComponent();
          
        }

        private void ButtonPrimerAdress_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "198095, Россия, г. Санкт-Петербург, Кировский р-н, ул. Севастопольская, д. 19, кв 11");
        }

        private void ButtonSaveDgvrItog_Click(object sender, EventArgs e)
        {
           
           


            //1
            String Dogovor_ImyaSobstv = rjTextBoxImyaSobst.Texts;
            String Dogovor_FamSobstv = rjTextBoxFamSobst.Texts;
            String Dogovor_OtchestvoSobstv = rjTextBoxOtchestSobst.Texts;
            String Dogovor_DateRozhdSobstv = labelDatePickerDateSobst.Text;
            String Dogovor_SnilsSobstv = rjTextBoxSnilsSobst.Texts;
            String Dogovor_Srok = labelrjComboBoxSrokStrx.Text;
            String Dogovor_Period = labelrjComboBoxPeriodStrx.Text;
            //2
            String Dogovor_SeriaPasport = rjTextBoxSeriaDocLichn.Texts;
            String Dogovor_NomerPasport = rjTextBoxNomerDocLichn.Texts;
            String Dogovor_KemVidanPasport = rjTextBoxKemVidanDocLichn.Texts;
            String Dogovor_DatePasport = labelDatePickerDateDocLichn.Text;
            //3
            String Dogovor_KodPodrPasport = rjTextBoxKodDocLichn.Texts;
            String Dogovor_TelephoneSobstv = rjTextBoxTeleKontDan.Texts;
            String Dogovor_PochtaSobstv = rjTextBoxPochtaKontDan.Texts;
            String Dogovor_AdressSobstv = rjTextBoxAdressReg.Texts;
            //4
            String Dogovor_MarkaTS = labelrjComboBoxMarkaTS.Text;
            String Dogovor_ModelTS = rjTextBoxModelTS.Texts;
            String Dogovor_GodTS = labelrjComboBoxGodTS.Text;
            String Dogovor_GosNomerTS = rjTextBoxNomerGosTS.Texts;
            String Dogovor_VINTS = rjTextBoxVINTS.Texts;
            //5
            String Dogovor_MochTS = rjTextBoxMochLsTS.Texts;
            String Dogovor_IspolzTS = labelrjComboBoxIspolTS.Text;
            String Dogovor_ImyaStrx = rjTextBoxImyaVoditel.Texts;
            String Dogovor_FamStrx = rjTextBoxFamVoditel.Texts;
            //6
            String Dogovor_OtchestvoStrx = rjTextBoxOtchestVoditel.Texts;
            String Dogovor_NachaloStazhaStrx = labelDatePickerNachStazhVoditel.Text;
            String Dogovor_SeriaVUStrx = rjTextBoxSeriaVUVoditel.Texts;
            String Dogovor_NomerVUStrx = rjTextBoxNomerVUVoditel.Texts;
            //7
            String Dogovor_MassaTS = rjTextBoxMassaIdenTS.Texts;
            String Dogovor_SeriaDocTS = rjTextBoxSeriaDocTS.Texts;
            String Dogovor_NomerDocTS = rjTextBoxNomerDocTS.Texts;
            String Dogovor_DateDocTS = labelDatePickerDateVidachDocTS.Text;
            String Dogovor_StoimStrx = textBoxStoimOsagoItog.Texts;

            Datebase db = new Datebase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"INSERT INTO Dogovor (Dogovor_ImyaSobstv, Dogovor_FamSobstv, Dogovor_OtchestvoSobstv, Dogovor_DateRozhdSobstv, Dogovor_SnilsSobstv, Dogovor_Srok, Dogovor_Period, Dogovor_SeriaPasport, Dogovor_NomerPasport, Dogovor_KemVidanPasport, Dogovor_DatePasport, Dogovor_KodPodrPasport, Dogovor_TelephoneSobstv, Dogovor_PochtaSobstv, Dogovor_AdressSobstv, Dogovor_MarkaTS, Dogovor_ModelTS, Dogovor_GodTS, Dogovor_GosNomerTS, Dogovor_VINTS, Dogovor_MochTS, Dogovor_IspolzTS, Dogovor_ImyaStrx, Dogovor_FamStrx, Dogovor_OtchestvoStrx, Dogovor_NachaloStazhaStrx, Dogovor_SeriaVUStrx, Dogovor_NomerVUStrx, Dogovor_MassaTS, Dogovor_SeriaDocTS, Dogovor_NomerDocTS, Dogovor_DateDocTS, Dogovor_StoimStrx) VALUES (@Dogovor_ImyaSobstv, @Dogovor_FamSobstv, @Dogovor_OtchestvoSobstv, @Dogovor_DateRozhdSobstv, @Dogovor_SnilsSobstv, @Dogovor_Srok, @Dogovor_Period, @Dogovor_SeriaPasport, @Dogovor_NomerPasport, @Dogovor_KemVidanPasport, @Dogovor_DatePasport, @Dogovor_KodPodrPasport, @Dogovor_TelephoneSobstv, @Dogovor_PochtaSobstv, @Dogovor_AdressSobstv, @Dogovor_MarkaTS, @Dogovor_ModelTS, @Dogovor_GodTS, @Dogovor_GosNomerTS, @Dogovor_VINTS, @Dogovor_MochTS, @Dogovor_IspolzTS, @Dogovor_ImyaStrx, @Dogovor_FamStrx, @Dogovor_OtchestvoStrx, @Dogovor_NachaloStazhaStrx, @Dogovor_SeriaVUStrx, @Dogovor_NomerVUStrx, @Dogovor_MassaTS, @Dogovor_SeriaDocTS, @Dogovor_NomerDocTS, @Dogovor_DateDocTS, @Dogovor_StoimStrx)", db.getConnection());

            command.Parameters.AddWithValue("Dogovor_ImyaSobstv", MySqlDbType.VarChar).Value = Dogovor_ImyaSobstv;
            command.Parameters.AddWithValue("Dogovor_FamSobstv", MySqlDbType.VarChar).Value = Dogovor_FamSobstv;
            command.Parameters.AddWithValue("Dogovor_OtchestvoSobstv", MySqlDbType.VarChar).Value = Dogovor_OtchestvoSobstv;
            command.Parameters.AddWithValue("Dogovor_DateRozhdSobstv", MySqlDbType.Date).Value = Dogovor_DateRozhdSobstv;
            command.Parameters.AddWithValue("Dogovor_SnilsSobstv", MySqlDbType.Int32).Value = Dogovor_SnilsSobstv;
            command.Parameters.AddWithValue("Dogovor_Srok", MySqlDbType.VarChar).Value = Dogovor_Srok;
            command.Parameters.AddWithValue("Dogovor_Period", MySqlDbType.VarChar).Value = Dogovor_Period;
            command.Parameters.AddWithValue("Dogovor_SeriaPasport", MySqlDbType.Int32).Value = Dogovor_SeriaPasport;
            command.Parameters.AddWithValue("Dogovor_NomerPasport", MySqlDbType.Int32).Value = Dogovor_NomerPasport;
            command.Parameters.AddWithValue("Dogovor_KemVidanPasport", MySqlDbType.VarChar).Value = Dogovor_KemVidanPasport;
            command.Parameters.AddWithValue("Dogovor_DatePasport", MySqlDbType.Date).Value = Dogovor_DatePasport;
            command.Parameters.AddWithValue("Dogovor_KodPodrPasport", MySqlDbType.Int32).Value = Dogovor_KodPodrPasport;
            command.Parameters.AddWithValue("Dogovor_TelephoneSobstv", MySqlDbType.Int32).Value = Dogovor_TelephoneSobstv;
            command.Parameters.AddWithValue("Dogovor_PochtaSobstv", MySqlDbType.VarChar).Value = Dogovor_PochtaSobstv;
            command.Parameters.AddWithValue("Dogovor_AdressSobstv", MySqlDbType.VarChar).Value = Dogovor_AdressSobstv;
            command.Parameters.AddWithValue("Dogovor_MarkaTS", MySqlDbType.VarChar).Value = Dogovor_MarkaTS;
            command.Parameters.AddWithValue("Dogovor_ModelTS", MySqlDbType.VarChar).Value = Dogovor_ModelTS;
            command.Parameters.AddWithValue("Dogovor_GodTS", MySqlDbType.Int32).Value = Dogovor_GodTS;
            command.Parameters.AddWithValue("Dogovor_GosNomerTS", MySqlDbType.VarChar).Value = Dogovor_GosNomerTS;
            command.Parameters.AddWithValue("Dogovor_VINTS", MySqlDbType.VarChar).Value = Dogovor_VINTS;
            command.Parameters.AddWithValue("Dogovor_MochTS", MySqlDbType.Int32).Value = Dogovor_MochTS;
            command.Parameters.AddWithValue("Dogovor_IspolzTS", MySqlDbType.VarChar).Value = Dogovor_IspolzTS;
            command.Parameters.AddWithValue("Dogovor_ImyaStrx", MySqlDbType.VarChar).Value = Dogovor_ImyaStrx;
            command.Parameters.AddWithValue("Dogovor_FamStrx", MySqlDbType.VarChar).Value = Dogovor_FamStrx;
            command.Parameters.AddWithValue("Dogovor_OtchestvoStrx", MySqlDbType.VarChar).Value = Dogovor_OtchestvoStrx;
            command.Parameters.AddWithValue("Dogovor_NachaloStazhaStrx", MySqlDbType.VarChar).Value = Dogovor_NachaloStazhaStrx;
            command.Parameters.AddWithValue("Dogovor_SeriaVUStrx", MySqlDbType.Int32).Value = Dogovor_SeriaVUStrx;
            command.Parameters.AddWithValue("Dogovor_NomerVUStrx", MySqlDbType.Int32).Value = Dogovor_NomerVUStrx;
            command.Parameters.AddWithValue("Dogovor_MassaTS", MySqlDbType.Int32).Value = Dogovor_MassaTS;
            command.Parameters.AddWithValue("Dogovor_SeriaDocTS", MySqlDbType.Int32).Value = Dogovor_SeriaDocTS;
            command.Parameters.AddWithValue("Dogovor_NomerDocTS", MySqlDbType.Int32).Value = Dogovor_NomerDocTS;
            command.Parameters.AddWithValue("Dogovor_DateDocTS", MySqlDbType.Date).Value = Dogovor_DateDocTS;
            command.Parameters.AddWithValue("Dogovor_StoimStrx", MySqlDbType.VarChar).Value = Dogovor_StoimStrx;





            if (Clicked == true)
            {
                MessageBox.Show(Text = "Сначало рассчет стоимости страховки");
            }
            if (Clicked == false)
            {
                if (rjTextBoxImyaSobst.Texts == "")
                {
                    MessageBox.Show(Text = "Введите имя собственника");
                }
                else if (rjTextBoxFamSobst.Texts == "")
                {
                    MessageBox.Show(Text = "Введите фамилию собственника");
                }
                else if (rjTextBoxOtchestSobst.Texts == "")
                {
                    MessageBox.Show(Text = "Введите отчество собственника");
                }
                else if (labelDatePickerDateSobst.Text == "")
                {
                    MessageBox.Show(Text = "Выберите дату рождения собственника");
                }
                else if (rjTextBoxSnilsSobst.Texts == "")
                {
                    MessageBox.Show(Text = "Введите СНИЛС собственника");
                }
                else if (labelrjComboBoxSrokStrx.Text == "")
                {
                    MessageBox.Show(Text = "Выберите срок страхования");
                }
                else if (labelrjComboBoxPeriodStrx.Text == "")
                {
                    MessageBox.Show(Text = "Выберите период страхования");
                }
                else if (rjTextBoxSeriaDocLichn.Texts == "")
                {
                    MessageBox.Show(Text = "Введите серию документа, удостоверяющий личность собственника");
                }
                else if (rjTextBoxNomerDocLichn.Texts == "")
                {
                    MessageBox.Show(Text = "Введите номер документа, удостоверяющий личность собственника");
                }
                else if (rjTextBoxKemVidanDocLichn.Texts == "")
                {
                    MessageBox.Show(Text = "Введите кем выдан документ, удостоверяющий личность собственника");
                }
                else if (labelDatePickerDateDocLichn.Text == "")
                {
                    MessageBox.Show(Text = "Выберите дату выдачи документа, удостоверяющий личность собственника");
                }
                else if (rjTextBoxKodDocLichn.Texts == "")
                {
                    MessageBox.Show(Text = "Введите код подразделения документа, удостоверяющий личность собственника");
                }
                else if (rjTextBoxTeleKontDan.Texts == "")
                {
                    MessageBox.Show(Text = "Введите номер телефона");
                }
                else if (rjTextBoxPochtaKontDan.Texts == "")
                {
                    MessageBox.Show(Text = "Введите почту");
                }
                else if (rjTextBoxAdressReg.Texts == "")
                {
                    MessageBox.Show(Text = "Введите адресс");
                }
                else if (labelrjComboBoxMarkaTS.Text == "")
                {
                    MessageBox.Show(Text = "Выберите марку автомобиля");
                }
                else if (rjTextBoxModelTS.Texts == "")
                {
                    MessageBox.Show(Text = "Введите модель автомобиля");
                }
                else if (labelrjComboBoxGodTS.Text == "")
                {
                    MessageBox.Show(Text = "Выберите год производства автомобиля");
                }
                else if (rjTextBoxNomerGosTS.Texts == "")
                {
                    MessageBox.Show(Text = "Введите гос. номер автомобиля");
                }
                else if (rjTextBoxVINTS.Texts == "")
                {
                    MessageBox.Show(Text = "Введите VIN номер автомобиля");
                }
                else if (rjTextBoxMochLsTS.Texts == "")
                {
                    MessageBox.Show(Text = "Введите мощность в л.с");
                }
                else if (labelrjComboBoxIspolTS.Text == "")
                {
                    MessageBox.Show(Text = "Выберите цель использования");
                }
                else if (rjTextBoxImyaVoditel.Texts == "")
                {
                    MessageBox.Show(Text = "Введите имя водителя, который будет вписан в страховку");
                }
                else if (rjTextBoxFamVoditel.Texts == "")
                {
                    MessageBox.Show(Text = "Введите фамилию водителя, который будет вписан в страховку");
                }
                else if (rjTextBoxOtchestVoditel.Texts == "")
                {
                    MessageBox.Show(Text = "Введите отчество водителя, который будет вписан в страховку");
                }
                else if (labelDatePickerNachStazhVoditel.Text == "")
                {
                    MessageBox.Show(Text = "Введите дату начала стажа вождения водителя, который будет вписан в страховку");
                }
                else if (rjTextBoxSeriaVUVoditel.Texts == "")
                {
                    MessageBox.Show(Text = "Введите серию ВУ водителя");
                }
                else if (rjTextBoxNomerVUVoditel.Texts == "")
                {
                    MessageBox.Show(Text = "Введите номер ВУ водителя");
                }
                else if (rjTextBoxMassaIdenTS.Texts == "")
                {
                    MessageBox.Show(Text = "Введите массу авто ");
                }
                else if (rjTextBoxSeriaDocTS.Texts == "")
                {
                    MessageBox.Show(Text = "Введите серию документа на ТС");
                }
                else if (rjTextBoxNomerDocTS.Texts == "")
                {
                    MessageBox.Show(Text = "Введите номер документа на ТС");
                }
                else if (labelDatePickerDateVidachDocTS.Text == "")
                {
                    MessageBox.Show(Text = "Выберите дату выдачи документа на ТС");
                }
                else
                {
                    MessageBox.Show(Text = "Новый страховой договор добавлен!");

                    adapter.SelectCommand = command;

                    adapter.Fill(table);
                }
            }


        }

        private void ButtonPechat_Click(object sender, EventArgs e)
        {

          if (textBoxStoimOsagoItog.Texts == "")
          {
                MessageBox.Show(Text = "Сначала сорханите договор");
          }
          if (textBoxStoimOsagoItog.Texts != "")
            {
                FormPechat formPechat = new FormPechat();
                formPechat.Show();
            }
          
        }

        private void RjDatePickerDateSobst_ValueChanged(object sender, EventArgs e)
        {
            labelDatePickerDateSobst.Text = rjDatePickerDateSobst.Value.ToString("yyyy-MM-dd") + Environment.NewLine;
        }

        private void RjDatePickerDeistStrx_ValueChanged(object sender, EventArgs e)
        {
            labelDatePickerDeistStrx.Text = rjDatePickerDeistStrx.Value.ToString("yyyy-MM-dd") + Environment.NewLine;
        }

        private void RjDatePickerDateDocLichn_ValueChanged(object sender, EventArgs e)
        {
            labelDatePickerDateDocLichn.Text = rjDatePickerDateDocLichn.Value.ToString("yyyy-MM-dd") + Environment.NewLine;
        }

        private void RjDatePickerNachStazhVoditel_ValueChanged(object sender, EventArgs e)
        {
            labelDatePickerNachStazhVoditel.Text = rjDatePickerNachStazhVoditel.Value.ToString("yyyy-MM-dd") + Environment.NewLine;
        }

        private void RjDatePickerDateVidachVoditel_ValueChanged(object sender, EventArgs e)
        {
            labelDatePickerDateVidachVoditel.Text = rjDatePickerDateVidachVoditel.Value.ToString("yyyy-MM-dd") + Environment.NewLine;
        }

        private void RjDatePickerDateVidachDocTS_ValueChanged(object sender, EventArgs e)
        {
            labelDatePickerDateVidachDocTS.Text = rjDatePickerDateVidachDocTS.Value.ToString("yyyy-MM-dd") + Environment.NewLine;
        }

        private void RjComboBoxSrokStrx_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            labelrjComboBoxSrokStrx.Text = rjComboBoxSrokStrx.SelectedItem + Environment.NewLine;
        }

        private void RjComboBoxPeriodStrx_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            labelrjComboBoxPeriodStrx.Text = rjComboBoxPeriodStrx.SelectedItem + Environment.NewLine;
        }

        private void RjComboBoxMarkaTS_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            labelrjComboBoxMarkaTS.Text = rjComboBoxMarkaTS.SelectedItem + Environment.NewLine;
        }

        private void RjComboBoxGodTS_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            labelrjComboBoxGodTS.Text = rjComboBoxGodTS.SelectedItem + Environment.NewLine;
        }

        private void RjComboBoxIspolTS_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            labelrjComboBoxIspolTS.Text = rjComboBoxIspolTS.SelectedItem + Environment.NewLine;
        }


        private void ButtonRachetItog_Click(object sender, EventArgs e)
        {
           
            DateDifferenceData dateDifferenceData = new DateDifferenceData(rjDatePickerNachStazhVoditel.Value, rjDatePickerDateSobst.Value);
            labelAge.Text = dateDifferenceData.ToString();
            int kbm1 = 1;
            double kbm2 = 1.5;
            double kbm3 = 1.9;
            double kbm4 = 0.5;
            int bzstv = 7537;

            if (labelAge.Text == "0")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm3 * bzstv);
            }

            if (labelAge.Text == "1")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm3 * bzstv);
            }

            if (labelAge.Text == "2")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm2 * bzstv);
            }

            if (labelAge.Text == "3")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm1 * bzstv);
            }

            if (labelAge.Text == "4")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "5")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "6")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "7")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "8")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "9")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "10")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "11")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "4")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "12")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "13")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "13")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "15")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "16")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "17")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "18")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "19")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }
            if (labelAge.Text == "20")
            {
                textBoxStoimOsagoItog.Texts = Convert.ToString(kbm4 * bzstv);
            }

        }


        private void RjTextBoxImyaSobst_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void RjTextBoxSnilsSobst_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        
            
            
            
           
            
            
            
           
           
            
           
           

        private void RjTextBoxImyaSobst__TextChanged(object sender, EventArgs e)
        {
            DataStrx.IMYASOBST = rjTextBoxImyaSobst.Texts;
        }

        private void RjTextBoxFamSobst__TextChanged(object sender, EventArgs e)
        {
            DataStrx.FAMSOBST = rjTextBoxFamSobst.Texts;
        }

        private void RjTextBoxOtchestSobst__TextChanged(object sender, EventArgs e)
        {
            DataStrx.OTCHESTVOSOBST = rjTextBoxOtchestSobst.Texts;
        }

        private void RjTextBoxVINTS__TextChanged(object sender, EventArgs e)
        {
            DataStrx.VIN = rjTextBoxVINTS.Texts;
        }

        private void RjTextBoxImyaVoditel__TextChanged(object sender, EventArgs e)
        {
            DataStrx.IMYASTRX = rjTextBoxImyaVoditel.Texts;
        }

        private void RjTextBoxFamVoditel__TextChanged(object sender, EventArgs e)
        {
            DataStrx.FAMSTRX = rjTextBoxFamVoditel.Texts;
        }

        private void RjTextBoxOtchestVoditel__TextChanged(object sender, EventArgs e)
        {
            DataStrx.OTCHESTVOSTRX = rjTextBoxOtchestVoditel.Texts;
        }

        private void RjTextBoxSeriaVUVoditel__TextChanged(object sender, EventArgs e)
        {
            DataStrx.VUSERIA = rjTextBoxSeriaVUVoditel.Texts;
        }

        private void RjTextBoxNomerVUVoditel__TextChanged(object sender, EventArgs e)
        {
            DataStrx.VUNOMER = rjTextBoxNomerVUVoditel.Texts;
        }

        private void RjComboBoxTipDocTS_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataStrx.VIDDOCTS = rjComboBoxTipDocTS.Texts;
        }

        private void RjTextBoxSeriaDocTS__TextChanged(object sender, EventArgs e)
        {
            DataStrx.DOCSERIA = rjTextBoxSeriaDocTS.Texts;
        }

        private void RjTextBoxNomerDocTS__TextChanged(object sender, EventArgs e)
        {
            DataStrx.DOCNOMER = rjTextBoxNomerDocTS.Texts;
        }

        private void TextBoxStoimOsagoItog__TextChanged(object sender, EventArgs e)
        {
            DataStrx.STOIM = textBoxStoimOsagoItog.Texts;
        }

        private void RjTextBoxMarkaModelPtsTS__TextChanged(object sender, EventArgs e)
        {
            DataStrx.MARKAMODEL = rjTextBoxMarkaModelPtsTS.Texts;
        }

        private void RjTextBoxNomerGosTS__TextChanged(object sender, EventArgs e)
        {
            DataStrx.GOSNOMER = rjTextBoxNomerGosTS.Texts;
        }

        private void LabelDatePickerDeistStrx_TextChanged(object sender, EventArgs e)
        {
            DataStrx.DEISTDATA = labelDatePickerDeistStrx.Text;
        }
    }

    public class DateDifferenceData
    {
        public int Years;
        public int Days;

        public DateDifferenceData(DateTime rjDatePickerNachStazhVoditelValue,DateTime rjDatePickerDateSobstValue)
        {
            var difference = rjDatePickerNachStazhVoditelValue - rjDatePickerDateSobstValue;
            Days = (int)difference.TotalDays;
            Years = Days / 365;
        }

        public override string ToString()
        {
            return $"{Years}";
        }

    }
}
