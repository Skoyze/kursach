namespace CustomControls.Forms
{
    partial class FormGearUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.passChange = new CustomControls.RJControls.RJButton();
            this.passChangeBox = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.label2.Location = new System.Drawing.Point(50, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.label1.Location = new System.Drawing.Point(50, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.GhostWhite;
            this.labelLogin.Font = new System.Drawing.Font("Verdana", 15F);
            this.labelLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.labelLogin.Location = new System.Drawing.Point(49, 149);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 25);
            this.labelLogin.TabIndex = 37;
            // 
            // passChange
            // 
            this.passChange.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.passChange.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.passChange.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.passChange.BorderRadius = 20;
            this.passChange.BorderSize = 0;
            this.passChange.FlatAppearance.BorderSize = 0;
            this.passChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passChange.ForeColor = System.Drawing.Color.White;
            this.passChange.Location = new System.Drawing.Point(222, 369);
            this.passChange.Name = "passChange";
            this.passChange.Size = new System.Drawing.Size(150, 40);
            this.passChange.TabIndex = 36;
            this.passChange.Text = "Изменить пароль";
            this.passChange.TextColor = System.Drawing.Color.White;
            this.passChange.UseVisualStyleBackColor = false;
            this.passChange.Click += new System.EventHandler(this.RjButton1_Click);
            // 
            // passChangeBox
            // 
            this.passChangeBox.BackColor = System.Drawing.Color.GhostWhite;
            this.passChangeBox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.passChangeBox.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.passChangeBox.BorderRadius = 18;
            this.passChangeBox.BorderSize = 2;
            this.passChangeBox.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passChangeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.passChangeBox.Location = new System.Drawing.Point(41, 289);
            this.passChangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.passChangeBox.Multiline = false;
            this.passChangeBox.Name = "passChangeBox";
            this.passChangeBox.Padding = new System.Windows.Forms.Padding(7);
            this.passChangeBox.PasswordChar = false;
            this.passChangeBox.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.passChangeBox.PlaceholderText = "";
            this.passChangeBox.Size = new System.Drawing.Size(331, 40);
            this.passChangeBox.TabIndex = 28;
            this.passChangeBox.Texts = "";
            this.passChangeBox.UnderlinedStyle = false;
            this.passChangeBox._TextChanged += new System.EventHandler(this.RjTextBox4__TextChanged);
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.rjTextBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderRadius = 18;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Enabled = false;
            this.rjTextBox3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBox3.Location = new System.Drawing.Point(41, 142);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(331, 40);
            this.rjTextBox3.TabIndex = 28;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            this.rjTextBox3._TextChanged += new System.EventHandler(this.RjTextBox3__TextChanged);
            this.rjTextBox3.Enter += new System.EventHandler(this.RjTextBox3_Enter);
            this.rjTextBox3.Leave += new System.EventHandler(this.RjTextBox3_Leave);
            // 
            // FormGearUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(814, 470);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.passChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passChangeBox);
            this.Controls.Add(this.rjTextBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGearUser";
            this.Text = "Редактирование профиля";
            this.Load += new System.EventHandler(this.FormGearUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.Label label2;
        private RJControls.RJTextBox passChangeBox;
        private System.Windows.Forms.Label label1;
        private RJControls.RJButton passChange;
        private System.Windows.Forms.Label labelLogin;
    }
}