namespace Osk.Forms
{
    partial class FormAddStrx
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
            this.buttonAddStrx = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjTextBoxPass = new CustomControls.RJControls.RJTextBox();
            this.rjTextBoxMail = new CustomControls.RJControls.RJTextBox();
            this.rjTextBoxNomer = new CustomControls.RJControls.RJTextBox();
            this.rjTextBoxLogin = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // buttonAddStrx
            // 
            this.buttonAddStrx.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAddStrx.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAddStrx.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAddStrx.BorderRadius = 20;
            this.buttonAddStrx.BorderSize = 0;
            this.buttonAddStrx.FlatAppearance.BorderSize = 0;
            this.buttonAddStrx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStrx.ForeColor = System.Drawing.Color.White;
            this.buttonAddStrx.Location = new System.Drawing.Point(334, 361);
            this.buttonAddStrx.Name = "buttonAddStrx";
            this.buttonAddStrx.Size = new System.Drawing.Size(150, 40);
            this.buttonAddStrx.TabIndex = 45;
            this.buttonAddStrx.Text = "Добавить страховщика";
            this.buttonAddStrx.TextColor = System.Drawing.Color.White;
            this.buttonAddStrx.UseVisualStyleBackColor = false;
            this.buttonAddStrx.Click += new System.EventHandler(this.ButtonAddStrx_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(452, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 41;
            this.label4.Text = "Почта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(49, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(452, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(49, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "Логин";
            // 
            // rjTextBoxPass
            // 
            this.rjTextBoxPass.BackColor = System.Drawing.Color.GhostWhite;
            this.rjTextBoxPass.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBoxPass.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxPass.BorderRadius = 18;
            this.rjTextBoxPass.BorderSize = 2;
            this.rjTextBoxPass.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxPass.Location = new System.Drawing.Point(40, 257);
            this.rjTextBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxPass.MaxLenght = 100;
            this.rjTextBoxPass.Multiline = false;
            this.rjTextBoxPass.Name = "rjTextBoxPass";
            this.rjTextBoxPass.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBoxPass.PasswordChar = false;
            this.rjTextBoxPass.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxPass.PlaceholderText = "";
            this.rjTextBoxPass.Size = new System.Drawing.Size(331, 40);
            this.rjTextBoxPass.TabIndex = 37;
            this.rjTextBoxPass.Texts = "";
            this.rjTextBoxPass.UnderlinedStyle = false;
            // 
            // rjTextBoxMail
            // 
            this.rjTextBoxMail.BackColor = System.Drawing.Color.GhostWhite;
            this.rjTextBoxMail.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBoxMail.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxMail.BorderRadius = 18;
            this.rjTextBoxMail.BorderSize = 2;
            this.rjTextBoxMail.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxMail.Location = new System.Drawing.Point(444, 257);
            this.rjTextBoxMail.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxMail.MaxLenght = 100;
            this.rjTextBoxMail.Multiline = false;
            this.rjTextBoxMail.Name = "rjTextBoxMail";
            this.rjTextBoxMail.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBoxMail.PasswordChar = false;
            this.rjTextBoxMail.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxMail.PlaceholderText = "";
            this.rjTextBoxMail.Size = new System.Drawing.Size(331, 40);
            this.rjTextBoxMail.TabIndex = 38;
            this.rjTextBoxMail.Texts = "";
            this.rjTextBoxMail.UnderlinedStyle = false;
            // 
            // rjTextBoxNomer
            // 
            this.rjTextBoxNomer.BackColor = System.Drawing.Color.GhostWhite;
            this.rjTextBoxNomer.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBoxNomer.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxNomer.BorderRadius = 18;
            this.rjTextBoxNomer.BorderSize = 2;
            this.rjTextBoxNomer.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxNomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxNomer.Location = new System.Drawing.Point(444, 110);
            this.rjTextBoxNomer.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxNomer.MaxLenght = 11;
            this.rjTextBoxNomer.Multiline = false;
            this.rjTextBoxNomer.Name = "rjTextBoxNomer";
            this.rjTextBoxNomer.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBoxNomer.PasswordChar = false;
            this.rjTextBoxNomer.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxNomer.PlaceholderText = "";
            this.rjTextBoxNomer.Size = new System.Drawing.Size(331, 40);
            this.rjTextBoxNomer.TabIndex = 39;
            this.rjTextBoxNomer.Texts = "";
            this.rjTextBoxNomer.UnderlinedStyle = false;
            this.rjTextBoxNomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RjTextBoxNomer_KeyPress);
            // 
            // rjTextBoxLogin
            // 
            this.rjTextBoxLogin.BackColor = System.Drawing.Color.GhostWhite;
            this.rjTextBoxLogin.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBoxLogin.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBoxLogin.BorderRadius = 18;
            this.rjTextBoxLogin.BorderSize = 2;
            this.rjTextBoxLogin.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBoxLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxLogin.Location = new System.Drawing.Point(40, 110);
            this.rjTextBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBoxLogin.MaxLenght = 100;
            this.rjTextBoxLogin.Multiline = false;
            this.rjTextBoxLogin.Name = "rjTextBoxLogin";
            this.rjTextBoxLogin.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBoxLogin.PasswordChar = false;
            this.rjTextBoxLogin.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBoxLogin.PlaceholderText = "";
            this.rjTextBoxLogin.Size = new System.Drawing.Size(331, 40);
            this.rjTextBoxLogin.TabIndex = 40;
            this.rjTextBoxLogin.Texts = "";
            this.rjTextBoxLogin.UnderlinedStyle = false;
            // 
            // FormAddStrx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(814, 470);
            this.Controls.Add(this.buttonAddStrx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjTextBoxPass);
            this.Controls.Add(this.rjTextBoxMail);
            this.Controls.Add(this.rjTextBoxNomer);
            this.Controls.Add(this.rjTextBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddStrx";
            this.Text = "Добавление страховщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton buttonAddStrx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox rjTextBoxPass;
        private CustomControls.RJControls.RJTextBox rjTextBoxMail;
        private CustomControls.RJControls.RJTextBox rjTextBoxNomer;
        private CustomControls.RJControls.RJTextBox rjTextBoxLogin;
    }
}