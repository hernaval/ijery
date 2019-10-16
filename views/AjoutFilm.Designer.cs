namespace ijery.views
{
    partial class AjoutFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutFilm));
            this.metroIdFilm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bunifu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.metroTitre = new MetroFramework.Controls.MetroTextBox();
            this.metroQualite = new MetroFramework.Controls.MetroTextBox();
            this.metroPrix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroIdFilm
            // 
            // 
            // 
            // 
            this.metroIdFilm.CustomButton.Image = null;
            this.metroIdFilm.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.metroIdFilm.CustomButton.Name = "";
            this.metroIdFilm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroIdFilm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroIdFilm.CustomButton.TabIndex = 1;
            this.metroIdFilm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroIdFilm.CustomButton.UseSelectable = true;
            this.metroIdFilm.CustomButton.Visible = false;
            this.metroIdFilm.Lines = new string[] {
        "metroTextBox1"};
            this.metroIdFilm.Location = new System.Drawing.Point(371, 114);
            this.metroIdFilm.MaxLength = 32767;
            this.metroIdFilm.Name = "metroIdFilm";
            this.metroIdFilm.PasswordChar = '\0';
            this.metroIdFilm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroIdFilm.SelectedText = "";
            this.metroIdFilm.SelectionLength = 0;
            this.metroIdFilm.SelectionStart = 0;
            this.metroIdFilm.ShortcutsEnabled = true;
            this.metroIdFilm.Size = new System.Drawing.Size(162, 23);
            this.metroIdFilm.TabIndex = 0;
            this.metroIdFilm.Text = "metroTextBox1";
            this.metroIdFilm.UseSelectable = true;
            this.metroIdFilm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroIdFilm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(223, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "IdFilm";
            // 
            // bunifu
            // 
            this.bunifu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifu.BorderRadius = 0;
            this.bunifu.ButtonText = "bunifuFlatButton1";
            this.bunifu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifu.DisabledColor = System.Drawing.Color.Gray;
            this.bunifu.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifu.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifu.Iconimage")));
            this.bunifu.Iconimage_right = null;
            this.bunifu.Iconimage_right_Selected = null;
            this.bunifu.Iconimage_Selected = null;
            this.bunifu.IconMarginLeft = 0;
            this.bunifu.IconMarginRight = 0;
            this.bunifu.IconRightVisible = true;
            this.bunifu.IconRightZoom = 0D;
            this.bunifu.IconVisible = true;
            this.bunifu.IconZoom = 90D;
            this.bunifu.IsTab = false;
            this.bunifu.Location = new System.Drawing.Point(371, 302);
            this.bunifu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bunifu.Name = "bunifu";
            this.bunifu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifu.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifu.selected = false;
            this.bunifu.Size = new System.Drawing.Size(241, 48);
            this.bunifu.TabIndex = 2;
            this.bunifu.Text = "bunifuFlatButton1";
            this.bunifu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifu.Textcolor = System.Drawing.Color.White;
            this.bunifu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifu.Click += new System.EventHandler(this.bunifu_Click);
            // 
            // metroTitre
            // 
            // 
            // 
            // 
            this.metroTitre.CustomButton.Image = null;
            this.metroTitre.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.metroTitre.CustomButton.Name = "";
            this.metroTitre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTitre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTitre.CustomButton.TabIndex = 1;
            this.metroTitre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTitre.CustomButton.UseSelectable = true;
            this.metroTitre.CustomButton.Visible = false;
            this.metroTitre.Lines = new string[] {
        "metroTextBox1"};
            this.metroTitre.Location = new System.Drawing.Point(371, 143);
            this.metroTitre.MaxLength = 32767;
            this.metroTitre.Name = "metroTitre";
            this.metroTitre.PasswordChar = '\0';
            this.metroTitre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTitre.SelectedText = "";
            this.metroTitre.SelectionLength = 0;
            this.metroTitre.SelectionStart = 0;
            this.metroTitre.ShortcutsEnabled = true;
            this.metroTitre.Size = new System.Drawing.Size(162, 23);
            this.metroTitre.TabIndex = 0;
            this.metroTitre.Text = "metroTextBox1";
            this.metroTitre.UseSelectable = true;
            this.metroTitre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTitre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroQualite
            // 
            // 
            // 
            // 
            this.metroQualite.CustomButton.Image = null;
            this.metroQualite.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.metroQualite.CustomButton.Name = "";
            this.metroQualite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroQualite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroQualite.CustomButton.TabIndex = 1;
            this.metroQualite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroQualite.CustomButton.UseSelectable = true;
            this.metroQualite.CustomButton.Visible = false;
            this.metroQualite.Lines = new string[] {
        "metroTextBox1"};
            this.metroQualite.Location = new System.Drawing.Point(371, 172);
            this.metroQualite.MaxLength = 32767;
            this.metroQualite.Name = "metroQualite";
            this.metroQualite.PasswordChar = '\0';
            this.metroQualite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroQualite.SelectedText = "";
            this.metroQualite.SelectionLength = 0;
            this.metroQualite.SelectionStart = 0;
            this.metroQualite.ShortcutsEnabled = true;
            this.metroQualite.Size = new System.Drawing.Size(162, 23);
            this.metroQualite.TabIndex = 0;
            this.metroQualite.Text = "metroTextBox1";
            this.metroQualite.UseSelectable = true;
            this.metroQualite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroQualite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPrix
            // 
            // 
            // 
            // 
            this.metroPrix.CustomButton.Image = null;
            this.metroPrix.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.metroPrix.CustomButton.Name = "";
            this.metroPrix.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroPrix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPrix.CustomButton.TabIndex = 1;
            this.metroPrix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPrix.CustomButton.UseSelectable = true;
            this.metroPrix.CustomButton.Visible = false;
            this.metroPrix.Lines = new string[] {
        "metroT"};
            this.metroPrix.Location = new System.Drawing.Point(371, 201);
            this.metroPrix.MaxLength = 32767;
            this.metroPrix.Name = "metroPrix";
            this.metroPrix.PasswordChar = '\0';
            this.metroPrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroPrix.SelectedText = "";
            this.metroPrix.SelectionLength = 0;
            this.metroPrix.SelectionStart = 0;
            this.metroPrix.ShortcutsEnabled = true;
            this.metroPrix.Size = new System.Drawing.Size(162, 23);
            this.metroPrix.TabIndex = 0;
            this.metroPrix.Text = "metroT";
            this.metroPrix.UseSelectable = true;
            this.metroPrix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroPrix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(223, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Titre";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(223, 176);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Qualité";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(227, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Prix";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(227, 251);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Nombres";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(371, 250);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // AjoutFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 455);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.bunifu);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPrix);
            this.Controls.Add(this.metroQualite);
            this.Controls.Add(this.metroTitre);
            this.Controls.Add(this.metroIdFilm);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AjoutFilm";
            this.Text = "Ajout Film";
            this.Load += new System.EventHandler(this.AjoutFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroIdFilm;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifu;
        private MetroFramework.Controls.MetroTextBox metroTitre;
        private MetroFramework.Controls.MetroTextBox metroQualite;
        private MetroFramework.Controls.MetroTextBox metroPrix;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}