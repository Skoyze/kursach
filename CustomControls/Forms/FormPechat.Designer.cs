namespace CustomControls.Forms
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
            this.rjButtonPechatDgvr = new CustomControls.RJControls.RJButton();
            this.CloseButton = new System.Windows.Forms.Label();
            this.Okno = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.pictureBox1.Image = global::Osk.Properties.Resources.polisIspr;
            this.pictureBox1.Location = new System.Drawing.Point(-43, -43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 1123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.rjButtonPechatDgvr.Location = new System.Drawing.Point(83, 993);
            this.rjButtonPechatDgvr.Name = "rjButtonPechatDgvr";
            this.rjButtonPechatDgvr.Size = new System.Drawing.Size(150, 40);
            this.rjButtonPechatDgvr.TabIndex = 1;
            this.rjButtonPechatDgvr.Text = "Печать";
            this.rjButtonPechatDgvr.TextColor = System.Drawing.Color.White;
            this.rjButtonPechatDgvr.UseVisualStyleBackColor = false;
            this.rjButtonPechatDgvr.Click += new System.EventHandler(this.rjButtonPechatDgvr_Click);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(277, 837);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 17);
            this.panel1.TabIndex = 4;
            // 
            // FormPechat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 1061);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Okno);
            this.Controls.Add(this.rjButtonPechatDgvr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPechat";
            this.Text = "Новый договор";
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
        private System.Windows.Forms.Panel panel1;
    }
}