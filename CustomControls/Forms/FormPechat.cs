using Osk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls.Forms
{
    public partial class FormPechat : Form
    {
        Bitmap memoryImage;

        public FormPechat()
        {
            InitializeComponent();
        }

       
        private void rjButtonPechatDgvr_Click(object sender, EventArgs e)
        {
            rjButtonPechatDgvr.Visible = false;
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
               e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(20, Color.Silver);
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(65, 74, 76);
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(41, 49, 51);
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(41, 49, 51);
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

        private void FamSobst_Click(object sender, EventArgs e)
        {

        }

        private void ImyaSobst_Click(object sender, EventArgs e)
        {
            
        }

        private void FormPechat_Load(object sender, EventArgs e)
        {
            imyaSobst.Text = DataStrx.IMYASOBST;
            famSobst.Text = DataStrx.FAMSOBST;
            otchestvoSobst.Text = DataStrx.OTCHESTVOSOBST;
            imyaSrtx.Text = DataStrx.IMYASTRX;
            famStrx.Text = DataStrx.FAMSTRX;
            otchestvoStrx.Text = DataStrx.OTCHESTVOSTRX;
            imya.Text = DataStrx.IMYASTRX;
            fam.Text = DataStrx.FAMSTRX;
            otchestvo.Text = DataStrx.OTCHESTVOSTRX;
            vin.Text = DataStrx.VIN;
            vidDoc.Text = DataStrx.VIDDOCTS;
            markModel.Text = DataStrx.MARKAMODEL;
            gosNomer.Text = DataStrx.GOSNOMER;
            seriaDoc.Text = DataStrx.DOCSERIA;
            nomerDoc.Text = DataStrx.DOCNOMER;
            seriaVu.Text = DataStrx.VUSERIA;
            nomerVu.Text = DataStrx.VUNOMER;
            stoim.Text = DataStrx.STOIM;
            dataDeist.Text = DataStrx.DEISTDATA;
        }
    }
}
