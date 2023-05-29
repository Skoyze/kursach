namespace CustomControls
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMain = new System.Windows.Forms.Panel();
            this.closeFormButton = new FontAwesome.Sharp.IconButton();
            this.labelMain = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.nameCl = new System.Windows.Forms.Label();
            this.panelMenuDown = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.oknoMal = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButtonNews = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.okno = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Privet = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.rjDropdownMenu1 = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            this.panelMenuDown.SuspendLayout();
            this.oknoMal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.okno.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(55)))));
            this.panelMain.Controls.Add(this.closeFormButton);
            this.panelMain.Controls.Add(this.labelMain);
            this.panelMain.Location = new System.Drawing.Point(220, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(814, 50);
            this.panelMain.TabIndex = 25;
            // 
            // closeFormButton
            // 
            this.closeFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.closeFormButton.FlatAppearance.BorderSize = 0;
            this.closeFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(183)))));
            this.closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormButton.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.closeFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.closeFormButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.closeFormButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.closeFormButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeFormButton.IconSize = 35;
            this.closeFormButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.closeFormButton.Location = new System.Drawing.Point(0, 0);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.closeFormButton.Size = new System.Drawing.Size(64, 50);
            this.closeFormButton.TabIndex = 5;
            this.closeFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.closeFormButton.UseVisualStyleBackColor = false;
            this.closeFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // labelMain
            // 
            this.labelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.labelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMain.Font = new System.Drawing.Font("Georgia", 20.25F);
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.labelMain.Location = new System.Drawing.Point(0, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(814, 50);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Главная";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(183)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.iconButton4.Location = new System.Drawing.Point(162, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton4.Size = new System.Drawing.Size(58, 50);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.IconButton4_Click);
            // 
            // nameCl
            // 
            this.nameCl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.nameCl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.nameCl.Location = new System.Drawing.Point(0, 23);
            this.nameCl.Name = "nameCl";
            this.nameCl.Size = new System.Drawing.Size(156, 27);
            this.nameCl.TabIndex = 7;
            this.nameCl.Text = "Дмитрий!";
            this.nameCl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nameCl.Click += new System.EventHandler(this.NameCl_Click);
            // 
            // panelMenuDown
            // 
            this.panelMenuDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panelMenuDown.Controls.Add(this.labelMenu);
            this.panelMenuDown.Controls.Add(this.oknoMal);
            this.panelMenuDown.Controls.Add(this.iconButton3);
            this.panelMenuDown.Controls.Add(this.iconButtonNews);
            this.panelMenuDown.Controls.Add(this.iconButton2);
            this.panelMenuDown.Controls.Add(this.iconButton1);
            this.panelMenuDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuDown.Location = new System.Drawing.Point(0, 0);
            this.panelMenuDown.Name = "panelMenuDown";
            this.panelMenuDown.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panelMenuDown.Size = new System.Drawing.Size(220, 560);
            this.panelMenuDown.TabIndex = 26;
            // 
            // labelMenu
            // 
            this.labelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.labelMenu.Font = new System.Drawing.Font("Georgia", 20.25F);
            this.labelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.labelMenu.Location = new System.Drawing.Point(3, 90);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(220, 54);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Меню";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oknoMal
            // 
            this.oknoMal.BackColor = System.Drawing.Color.White;
            this.oknoMal.Controls.Add(this.pictureBox3);
            this.oknoMal.Location = new System.Drawing.Point(0, 0);
            this.oknoMal.Name = "oknoMal";
            this.oknoMal.Size = new System.Drawing.Size(220, 40);
            this.oknoMal.TabIndex = 44;
            this.oknoMal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OknoMal_MouseDown);
            this.oknoMal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oknoMal_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Osk.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(159, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox3_MouseMove);
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(183)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 510);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(220, 50);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "          Выйти";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.IconButton3_Click_1);
            // 
            // iconButtonNews
            // 
            this.iconButtonNews.FlatAppearance.BorderSize = 0;
            this.iconButtonNews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(183)))));
            this.iconButtonNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNews.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.iconButtonNews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButtonNews.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas;
            this.iconButtonNews.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButtonNews.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNews.IconSize = 35;
            this.iconButtonNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNews.Location = new System.Drawing.Point(0, 309);
            this.iconButtonNews.Name = "iconButtonNews";
            this.iconButtonNews.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButtonNews.Size = new System.Drawing.Size(220, 50);
            this.iconButtonNews.TabIndex = 3;
            this.iconButtonNews.Text = "         Новости";
            this.iconButtonNews.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNews.UseVisualStyleBackColor = true;
            this.iconButtonNews.Click += new System.EventHandler(this.iconButtonNews_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(183)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Georgia", 11.25F);
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 226);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(220, 50);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "    Оформленные       договора";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.IconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(183)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 147);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 50);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "      Новый полис";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // okno
            // 
            this.okno.BackColor = System.Drawing.Color.White;
            this.okno.Controls.Add(this.CloseButton);
            this.okno.Dock = System.Windows.Forms.DockStyle.Top;
            this.okno.Location = new System.Drawing.Point(220, 0);
            this.okno.Name = "okno";
            this.okno.Size = new System.Drawing.Size(814, 40);
            this.okno.TabIndex = 35;
            this.okno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Okno_MouseDown);
            this.okno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Okno_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(74)))), ((int)(((byte)(76)))));
            this.CloseButton.Location = new System.Drawing.Point(776, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            this.CloseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseUp);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.panelMenu.Controls.Add(this.Privet);
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.nameCl);
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 50);
            this.panelMenu.TabIndex = 43;
            // 
            // Privet
            // 
            this.Privet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.Privet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(149)))), ((int)(((byte)(183)))));
            this.Privet.Location = new System.Drawing.Point(3, 3);
            this.Privet.Name = "Privet";
            this.Privet.Size = new System.Drawing.Size(123, 23);
            this.Privet.TabIndex = 8;
            this.Privet.Text = "Приветсвуем";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(814, 470);
            this.panelDesktop.TabIndex = 44;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(52)))));
            this.rjDropdownMenu1.IsMainMenu = false;
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.rjDropdownMenu1.MenuItemHeight = 25;
            this.rjDropdownMenu1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.PrimaryColor = System.Drawing.Color.Empty;
            this.rjDropdownMenu1.Size = new System.Drawing.Size(135, 26);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Image = global::Osk.Properties.Resources.gear20;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.НастройкиToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(1034, 560);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.okno);
            this.Controls.Add(this.panelMenuDown);
            this.Controls.Add(this.panelMain);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Controls";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMenuDown.ResumeLayout(false);
            this.oknoMal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.okno.ResumeLayout(false);
            this.okno.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Panel panelMenuDown;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel okno;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelMenu;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButtonNews;
        private FontAwesome.Sharp.IconButton closeFormButton;
        private System.Windows.Forms.Panel oknoMal;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label nameCl;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label Privet;
        private RJControls.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
    }
}