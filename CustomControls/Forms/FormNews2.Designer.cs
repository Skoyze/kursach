namespace CustomControls.Forms
{
    partial class FormNews2
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
            this.cards1 = new CustomControls.RJControls.Cards();
            this.cards2 = new CustomControls.RJControls.Cards();
            this.cards3 = new CustomControls.RJControls.Cards();
            this.SuspendLayout();
            // 
            // cards1
            // 
            this.cards1.BackColor = System.Drawing.Color.White;
            this.cards1.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.cards1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cards1.Font = new System.Drawing.Font("Georgia", 14F);
            this.cards1.FontDescrition = new System.Drawing.Font("Georgia", 16F);
            this.cards1.FontHeader = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards1.ForeColorDescrition = System.Drawing.Color.Black;
            this.cards1.ForeColorHeader = System.Drawing.Color.White;
            this.cards1.Location = new System.Drawing.Point(2, 1);
            this.cards1.Name = "cards1";
            this.cards1.Size = new System.Drawing.Size(743, 202);
            this.cards1.TabIndex = 0;
            this.cards1.TextDescrition = "График работы тех. поддержки в праздничные дни: 22 Февраля - 9:00 до 18:00; 23,24" +
    ",25,26 - Выходные; С 27 февраля в обычном режиме";
            this.cards1.TextHeader = "Режим работы в феврале 2023";
            this.cards1.Click += new System.EventHandler(this.Cards1_Click);
            // 
            // cards2
            // 
            this.cards2.BackColor = System.Drawing.Color.White;
            this.cards2.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.cards2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cards2.Font = new System.Drawing.Font("Georgia", 14F);
            this.cards2.FontDescrition = new System.Drawing.Font("Georgia", 16F);
            this.cards2.FontHeader = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards2.ForeColorDescrition = System.Drawing.Color.Black;
            this.cards2.ForeColorHeader = System.Drawing.Color.White;
            this.cards2.Location = new System.Drawing.Point(-7, 224);
            this.cards2.Name = "cards2";
            this.cards2.Size = new System.Drawing.Size(752, 200);
            this.cards2.TabIndex = 1;
            this.cards2.TextDescrition = "График работы тех. поддержки в праздничные дни: 22 Февраля - 9:00 до 18:00; 23,24" +
    ",25,26 - Выходные; С 27 февраля в обычном режиме";
            this.cards2.TextHeader = "Режим работы в феврале 2023";
            // 
            // cards3
            // 
            this.cards3.BackColor = System.Drawing.Color.White;
            this.cards3.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.cards3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cards3.Font = new System.Drawing.Font("Georgia", 14F);
            this.cards3.FontDescrition = new System.Drawing.Font("Georgia", 16F);
            this.cards3.FontHeader = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards3.ForeColorDescrition = System.Drawing.Color.Black;
            this.cards3.ForeColorHeader = System.Drawing.Color.White;
            this.cards3.Location = new System.Drawing.Point(-7, 460);
            this.cards3.Name = "cards3";
            this.cards3.Size = new System.Drawing.Size(743, 212);
            this.cards3.TabIndex = 2;
            this.cards3.TextDescrition = "График работы тех. поддержки в праздничные дни: 22 Февраля - 9:00 до 18:00; 23,24" +
    ",25,26 - Выходные; С 27 февраля в обычном режиме";
            this.cards3.TextHeader = "Режим работы в феврале 2023";
            // 
            // FormNews2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(50, 20);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(814, 467);
            this.Controls.Add(this.cards3);
            this.Controls.Add(this.cards2);
            this.Controls.Add(this.cards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNews2";
            this.Text = "FormNews2";
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.Cards cards1;
        private RJControls.Cards cards2;
        private RJControls.Cards cards3;
    }
}