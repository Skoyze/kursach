﻿namespace CustomControls.Forms
{
    partial class FormPechat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPechat));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Okno = new System.Windows.Forms.Panel();
            this.vin = new System.Windows.Forms.Label();
            this.imya = new System.Windows.Forms.Label();
            this.fam = new System.Windows.Forms.Label();
            this.otchestvo = new System.Windows.Forms.Label();
            this.famStrx = new System.Windows.Forms.Label();
            this.imyaSrtx = new System.Windows.Forms.Label();
            this.otchestvoStrx = new System.Windows.Forms.Label();
            this.seriaVu = new System.Windows.Forms.Label();
            this.nomerVu = new System.Windows.Forms.Label();
            this.stoim = new System.Windows.Forms.Label();
            this.imyaSobst = new System.Windows.Forms.Label();
            this.famSobst = new System.Windows.Forms.Label();
            this.otchestvoSobst = new System.Windows.Forms.Label();
            this.seriaDoc = new System.Windows.Forms.Label();
            this.nomerDoc = new System.Windows.Forms.Label();
            this.vidDoc = new System.Windows.Forms.Label();
            this.markModel = new System.Windows.Forms.Label();
            this.gosNomer = new System.Windows.Forms.Label();
            this.dataDeist = new System.Windows.Forms.Label();
            this.rjButtonPechatDgvr = new CustomControls.RJControls.RJButton();
            this.dataDeist1 = new System.Windows.Forms.Label();
            this.stoim1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Okno.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Osk.Properties.Resources.polisnorm;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 1123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(74)))), ((int)(((byte)(76)))));
            this.CloseButton.Location = new System.Drawing.Point(913, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(39, 38);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.Label1_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.Label1_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.Label1_MouseLeave);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp);
            // 
            // Okno
            // 
            this.Okno.Controls.Add(this.CloseButton);
            this.Okno.Location = new System.Drawing.Point(0, 0);
            this.Okno.Name = "Okno";
            this.Okno.Size = new System.Drawing.Size(952, 32);
            this.Okno.TabIndex = 3;
            this.Okno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Okno_MouseDown);
            this.Okno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Okno_MouseMove);
            // 
            // vin
            // 
            this.vin.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vin.Location = new System.Drawing.Point(415, 474);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(284, 27);
            this.vin.TabIndex = 5;
            this.vin.Text = "VIN";
            this.vin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imya
            // 
            this.imya.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imya.Location = new System.Drawing.Point(157, 362);
            this.imya.Name = "imya";
            this.imya.Size = new System.Drawing.Size(87, 18);
            this.imya.TabIndex = 6;
            this.imya.Text = "IMYA";
            this.imya.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fam
            // 
            this.fam.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fam.Location = new System.Drawing.Point(64, 362);
            this.fam.Name = "fam";
            this.fam.Size = new System.Drawing.Size(87, 18);
            this.fam.TabIndex = 6;
            this.fam.Text = "FAM";
            this.fam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // otchestvo
            // 
            this.otchestvo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchestvo.Location = new System.Drawing.Point(250, 362);
            this.otchestvo.Name = "otchestvo";
            this.otchestvo.Size = new System.Drawing.Size(87, 18);
            this.otchestvo.TabIndex = 6;
            this.otchestvo.Text = "OTCHESTVO";
            this.otchestvo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // famStrx
            // 
            this.famStrx.BackColor = System.Drawing.Color.White;
            this.famStrx.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.famStrx.Location = new System.Drawing.Point(82, 682);
            this.famStrx.Name = "famStrx";
            this.famStrx.Size = new System.Drawing.Size(89, 15);
            this.famStrx.TabIndex = 7;
            this.famStrx.Text = "famStrx";
            // 
            // imyaSrtx
            // 
            this.imyaSrtx.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imyaSrtx.Location = new System.Drawing.Point(177, 682);
            this.imyaSrtx.Name = "imyaSrtx";
            this.imyaSrtx.Size = new System.Drawing.Size(89, 15);
            this.imyaSrtx.TabIndex = 7;
            this.imyaSrtx.Text = "imyaSrtx";
            // 
            // otchestvoStrx
            // 
            this.otchestvoStrx.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchestvoStrx.Location = new System.Drawing.Point(272, 682);
            this.otchestvoStrx.Name = "otchestvoStrx";
            this.otchestvoStrx.Size = new System.Drawing.Size(89, 15);
            this.otchestvoStrx.TabIndex = 7;
            this.otchestvoStrx.Text = "otchestvoStrx";
            // 
            // seriaVu
            // 
            this.seriaVu.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seriaVu.Location = new System.Drawing.Point(580, 682);
            this.seriaVu.Name = "seriaVu";
            this.seriaVu.Size = new System.Drawing.Size(47, 15);
            this.seriaVu.TabIndex = 7;
            this.seriaVu.Text = "seriaVu";
            // 
            // nomerVu
            // 
            this.nomerVu.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomerVu.Location = new System.Drawing.Point(633, 682);
            this.nomerVu.Name = "nomerVu";
            this.nomerVu.Size = new System.Drawing.Size(54, 15);
            this.nomerVu.TabIndex = 7;
            this.nomerVu.Text = "nomerVu";
            // 
            // stoim
            // 
            this.stoim.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoim.Location = new System.Drawing.Point(832, 889);
            this.stoim.Name = "stoim";
            this.stoim.Size = new System.Drawing.Size(62, 15);
            this.stoim.TabIndex = 7;
            this.stoim.Text = "stoim";
            // 
            // imyaSobst
            // 
            this.imyaSobst.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imyaSobst.Location = new System.Drawing.Point(157, 399);
            this.imyaSobst.Name = "imyaSobst";
            this.imyaSobst.Size = new System.Drawing.Size(87, 18);
            this.imyaSobst.TabIndex = 6;
            this.imyaSobst.Text = "IMYA";
            this.imyaSobst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imyaSobst.Click += new System.EventHandler(this.ImyaSobst_Click);
            // 
            // famSobst
            // 
            this.famSobst.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.famSobst.Location = new System.Drawing.Point(64, 399);
            this.famSobst.Name = "famSobst";
            this.famSobst.Size = new System.Drawing.Size(87, 18);
            this.famSobst.TabIndex = 6;
            this.famSobst.Text = "FAM";
            this.famSobst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.famSobst.Click += new System.EventHandler(this.FamSobst_Click);
            // 
            // otchestvoSobst
            // 
            this.otchestvoSobst.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchestvoSobst.Location = new System.Drawing.Point(250, 399);
            this.otchestvoSobst.Name = "otchestvoSobst";
            this.otchestvoSobst.Size = new System.Drawing.Size(87, 18);
            this.otchestvoSobst.TabIndex = 6;
            this.otchestvoSobst.Text = "OTCHESTVO";
            this.otchestvoSobst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seriaDoc
            // 
            this.seriaDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seriaDoc.Location = new System.Drawing.Point(610, 524);
            this.seriaDoc.Name = "seriaDoc";
            this.seriaDoc.Size = new System.Drawing.Size(89, 15);
            this.seriaDoc.TabIndex = 7;
            this.seriaDoc.Text = "seriaDoc";
            // 
            // nomerDoc
            // 
            this.nomerDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nomerDoc.Location = new System.Drawing.Point(762, 524);
            this.nomerDoc.Name = "nomerDoc";
            this.nomerDoc.Size = new System.Drawing.Size(89, 15);
            this.nomerDoc.TabIndex = 7;
            this.nomerDoc.Text = "nomerDoc";
            // 
            // vidDoc
            // 
            this.vidDoc.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vidDoc.Location = new System.Drawing.Point(144, 524);
            this.vidDoc.Name = "vidDoc";
            this.vidDoc.Size = new System.Drawing.Size(346, 14);
            this.vidDoc.TabIndex = 7;
            this.vidDoc.Text = "vidDoc";
            // 
            // markModel
            // 
            this.markModel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markModel.Location = new System.Drawing.Point(131, 474);
            this.markModel.Name = "markModel";
            this.markModel.Size = new System.Drawing.Size(175, 27);
            this.markModel.TabIndex = 6;
            this.markModel.Text = "markModel";
            this.markModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.markModel.Click += new System.EventHandler(this.FamSobst_Click);
            // 
            // gosNomer
            // 
            this.gosNomer.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gosNomer.Location = new System.Drawing.Point(728, 478);
            this.gosNomer.Name = "gosNomer";
            this.gosNomer.Size = new System.Drawing.Size(175, 25);
            this.gosNomer.TabIndex = 6;
            this.gosNomer.Text = "gosNomer";
            this.gosNomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gosNomer.Click += new System.EventHandler(this.FamSobst_Click);
            // 
            // dataDeist
            // 
            this.dataDeist.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDeist.Location = new System.Drawing.Point(278, 1020);
            this.dataDeist.Name = "dataDeist";
            this.dataDeist.Size = new System.Drawing.Size(89, 15);
            this.dataDeist.TabIndex = 7;
            this.dataDeist.Text = "dataDeist";
            // 
            // rjButtonPechatDgvr
            // 
            this.rjButtonPechatDgvr.BackColor = System.Drawing.Color.Gray;
            this.rjButtonPechatDgvr.BackgroundColor = System.Drawing.Color.Gray;
            this.rjButtonPechatDgvr.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonPechatDgvr.BorderRadius = 20;
            this.rjButtonPechatDgvr.BorderSize = 0;
            this.rjButtonPechatDgvr.FlatAppearance.BorderSize = 0;
            this.rjButtonPechatDgvr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonPechatDgvr.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonPechatDgvr.ForeColor = System.Drawing.Color.White;
            this.rjButtonPechatDgvr.Location = new System.Drawing.Point(603, 127);
            this.rjButtonPechatDgvr.Name = "rjButtonPechatDgvr";
            this.rjButtonPechatDgvr.Size = new System.Drawing.Size(150, 40);
            this.rjButtonPechatDgvr.TabIndex = 1;
            this.rjButtonPechatDgvr.Text = "Печать";
            this.rjButtonPechatDgvr.TextColor = System.Drawing.Color.White;
            this.rjButtonPechatDgvr.UseVisualStyleBackColor = false;
            this.rjButtonPechatDgvr.Click += new System.EventHandler(this.rjButtonPechatDgvr_Click);
            // 
            // dataDeist1
            // 
            this.dataDeist1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDeist1.Location = new System.Drawing.Point(250, 942);
            this.dataDeist1.Name = "dataDeist1";
            this.dataDeist1.Size = new System.Drawing.Size(89, 15);
            this.dataDeist1.TabIndex = 7;
            this.dataDeist1.Text = "dataDeist";
            // 
            // stoim1
            // 
            this.stoim1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoim1.Location = new System.Drawing.Point(740, 74);
            this.stoim1.Name = "stoim1";
            this.stoim1.Size = new System.Drawing.Size(96, 20);
            this.stoim1.TabIndex = 8;
            this.stoim1.Text = "stoim1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(833, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "руб";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // FormPechat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stoim1);
            this.Controls.Add(this.nomerVu);
            this.Controls.Add(this.seriaVu);
            this.Controls.Add(this.otchestvoStrx);
            this.Controls.Add(this.dataDeist1);
            this.Controls.Add(this.dataDeist);
            this.Controls.Add(this.stoim);
            this.Controls.Add(this.imyaSrtx);
            this.Controls.Add(this.nomerDoc);
            this.Controls.Add(this.vidDoc);
            this.Controls.Add(this.seriaDoc);
            this.Controls.Add(this.famStrx);
            this.Controls.Add(this.otchestvoSobst);
            this.Controls.Add(this.gosNomer);
            this.Controls.Add(this.markModel);
            this.Controls.Add(this.famSobst);
            this.Controls.Add(this.otchestvo);
            this.Controls.Add(this.imyaSobst);
            this.Controls.Add(this.fam);
            this.Controls.Add(this.imya);
            this.Controls.Add(this.vin);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.rjButtonPechatDgvr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPechat";
            this.Text = "Новый договор";
            this.Load += new System.EventHandler(this.FormPechat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Okno.ResumeLayout(false);
            this.Okno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private RJControls.RJButton rjButtonPechatDgvr;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel Okno;
        private System.Windows.Forms.Label vin;
        private System.Windows.Forms.Label imya;
        private System.Windows.Forms.Label fam;
        private System.Windows.Forms.Label otchestvo;
        private System.Windows.Forms.Label famStrx;
        private System.Windows.Forms.Label imyaSrtx;
        private System.Windows.Forms.Label otchestvoStrx;
        private System.Windows.Forms.Label seriaVu;
        private System.Windows.Forms.Label nomerVu;
        private System.Windows.Forms.Label stoim;
        private System.Windows.Forms.Label imyaSobst;
        private System.Windows.Forms.Label famSobst;
        private System.Windows.Forms.Label otchestvoSobst;
        private System.Windows.Forms.Label seriaDoc;
        private System.Windows.Forms.Label nomerDoc;
        private System.Windows.Forms.Label vidDoc;
        private System.Windows.Forms.Label markModel;
        private System.Windows.Forms.Label gosNomer;
        private System.Windows.Forms.Label dataDeist;
        private System.Windows.Forms.Label dataDeist1;
        private System.Windows.Forms.Label stoim1;
        private System.Windows.Forms.Label label1;
    }
}