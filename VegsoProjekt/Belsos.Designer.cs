namespace VegsoProjekt
{
    partial class Belsos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Belsos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.szakrendelésHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szolgáltatásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Szak1 = new System.Windows.Forms.TextBox();
            this.Szakneve = new System.Windows.Forms.TextBox();
            this.Szakadd = new System.Windows.Forms.Button();
            this.SzakokBox = new System.Windows.Forms.ComboBox();
            this.Szolgneve = new System.Windows.Forms.TextBox();
            this.Sz1 = new System.Windows.Forms.TextBox();
            this.Szolgadd = new System.Windows.Forms.Button();
            this.Sz2 = new System.Windows.Forms.TextBox();
            this.Szolgara = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.D1 = new System.Windows.Forms.TextBox();
            this.Cnp = new System.Windows.Forms.TextBox();
            this.D2 = new System.Windows.Forms.TextBox();
            this.Nev = new System.Windows.Forms.TextBox();
            this.D3 = new System.Windows.Forms.TextBox();
            this.Telefonszam = new System.Windows.Forms.TextBox();
            this.D4 = new System.Windows.Forms.TextBox();
            this.SzakBoxDoki = new System.Windows.Forms.ComboBox();
            this.Doktoradd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szakrendelésHozzáadásaToolStripMenuItem,
            this.szolgáltatásToolStripMenuItem,
            this.doktorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(910, 36);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // szakrendelésHozzáadásaToolStripMenuItem
            // 
            this.szakrendelésHozzáadásaToolStripMenuItem.Name = "szakrendelésHozzáadásaToolStripMenuItem";
            this.szakrendelésHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.szakrendelésHozzáadásaToolStripMenuItem.Text = "Szakrendelés";
            this.szakrendelésHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.szakrendelésHozzáadásaToolStripMenuItem_Click);
            // 
            // szolgáltatásToolStripMenuItem
            // 
            this.szolgáltatásToolStripMenuItem.Name = "szolgáltatásToolStripMenuItem";
            this.szolgáltatásToolStripMenuItem.Size = new System.Drawing.Size(139, 32);
            this.szolgáltatásToolStripMenuItem.Text = "Szolgáltatás";
            this.szolgáltatásToolStripMenuItem.Click += new System.EventHandler(this.szolgáltatásToolStripMenuItem_Click_1);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // Szak1
            // 
            this.Szak1.BackColor = System.Drawing.Color.LightCoral;
            this.Szak1.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szak1.Location = new System.Drawing.Point(245, 139);
            this.Szak1.Name = "Szak1";
            this.Szak1.Size = new System.Drawing.Size(95, 28);
            this.Szak1.TabIndex = 17;
            this.Szak1.Text = "Szak neve";
            // 
            // Szakneve
            // 
            this.Szakneve.BackColor = System.Drawing.Color.RosyBrown;
            this.Szakneve.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szakneve.Location = new System.Drawing.Point(361, 139);
            this.Szakneve.Name = "Szakneve";
            this.Szakneve.Size = new System.Drawing.Size(262, 28);
            this.Szakneve.TabIndex = 18;
            // 
            // Szakadd
            // 
            this.Szakadd.BackColor = System.Drawing.Color.Firebrick;
            this.Szakadd.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szakadd.Location = new System.Drawing.Point(361, 238);
            this.Szakadd.Name = "Szakadd";
            this.Szakadd.Size = new System.Drawing.Size(173, 45);
            this.Szakadd.TabIndex = 31;
            this.Szakadd.Text = "Szak létrehozása";
            this.Szakadd.UseVisualStyleBackColor = false;
            this.Szakadd.Click += new System.EventHandler(this.Szakadd_Click);
            // 
            // SzakokBox
            // 
            this.SzakokBox.BackColor = System.Drawing.Color.RosyBrown;
            this.SzakokBox.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SzakokBox.FormattingEnabled = true;
            this.SzakokBox.Location = new System.Drawing.Point(361, 138);
            this.SzakokBox.Name = "SzakokBox";
            this.SzakokBox.Size = new System.Drawing.Size(262, 29);
            this.SzakokBox.TabIndex = 32;
            this.SzakokBox.Visible = false;
            // 
            // Szolgneve
            // 
            this.Szolgneve.BackColor = System.Drawing.Color.RosyBrown;
            this.Szolgneve.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szolgneve.Location = new System.Drawing.Point(361, 185);
            this.Szolgneve.Name = "Szolgneve";
            this.Szolgneve.Size = new System.Drawing.Size(262, 28);
            this.Szolgneve.TabIndex = 34;
            this.Szolgneve.Visible = false;
            // 
            // Sz1
            // 
            this.Sz1.BackColor = System.Drawing.Color.LightCoral;
            this.Sz1.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sz1.Location = new System.Drawing.Point(182, 185);
            this.Sz1.Name = "Sz1";
            this.Sz1.Size = new System.Drawing.Size(158, 28);
            this.Sz1.TabIndex = 35;
            this.Sz1.Text = "Szolgátatás neve";
            this.Sz1.Visible = false;
            // 
            // Szolgadd
            // 
            this.Szolgadd.BackColor = System.Drawing.Color.Firebrick;
            this.Szolgadd.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szolgadd.Location = new System.Drawing.Point(361, 289);
            this.Szolgadd.Name = "Szolgadd";
            this.Szolgadd.Size = new System.Drawing.Size(237, 45);
            this.Szolgadd.TabIndex = 37;
            this.Szolgadd.Text = "Szolgáltatás létrehozása";
            this.Szolgadd.UseVisualStyleBackColor = false;
            this.Szolgadd.Visible = false;
            this.Szolgadd.Click += new System.EventHandler(this.Szolgadd_Click);
            // 
            // Sz2
            // 
            this.Sz2.BackColor = System.Drawing.Color.LightCoral;
            this.Sz2.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sz2.Location = new System.Drawing.Point(301, 238);
            this.Sz2.Name = "Sz2";
            this.Sz2.Size = new System.Drawing.Size(39, 28);
            this.Sz2.TabIndex = 38;
            this.Sz2.Text = "Ára";
            this.Sz2.Visible = false;
            // 
            // Szolgara
            // 
            this.Szolgara.BackColor = System.Drawing.Color.RosyBrown;
            this.Szolgara.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Szolgara.Location = new System.Drawing.Point(361, 238);
            this.Szolgara.Name = "Szolgara";
            this.Szolgara.Size = new System.Drawing.Size(98, 28);
            this.Szolgara.TabIndex = 39;
            this.Szolgara.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // D1
            // 
            this.D1.BackColor = System.Drawing.Color.LightCoral;
            this.D1.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D1.Location = new System.Drawing.Point(335, 132);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(45, 28);
            this.D1.TabIndex = 42;
            this.D1.Text = "CNP";
            this.D1.Visible = false;
            // 
            // Cnp
            // 
            this.Cnp.BackColor = System.Drawing.Color.RosyBrown;
            this.Cnp.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cnp.Location = new System.Drawing.Point(390, 132);
            this.Cnp.Name = "Cnp";
            this.Cnp.Size = new System.Drawing.Size(210, 28);
            this.Cnp.TabIndex = 41;
            this.Cnp.Visible = false;
            // 
            // D2
            // 
            this.D2.BackColor = System.Drawing.Color.LightCoral;
            this.D2.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D2.Location = new System.Drawing.Point(335, 166);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(45, 28);
            this.D2.TabIndex = 45;
            this.D2.Text = "Nev";
            this.D2.Visible = false;
            // 
            // Nev
            // 
            this.Nev.BackColor = System.Drawing.Color.RosyBrown;
            this.Nev.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nev.Location = new System.Drawing.Point(390, 166);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(210, 28);
            this.Nev.TabIndex = 44;
            this.Nev.Visible = false;
            // 
            // D3
            // 
            this.D3.BackColor = System.Drawing.Color.LightCoral;
            this.D3.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D3.Location = new System.Drawing.Point(272, 202);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(108, 28);
            this.D3.TabIndex = 47;
            this.D3.Text = "Telefonszam";
            this.D3.Visible = false;
            // 
            // Telefonszam
            // 
            this.Telefonszam.BackColor = System.Drawing.Color.RosyBrown;
            this.Telefonszam.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonszam.Location = new System.Drawing.Point(390, 202);
            this.Telefonszam.Name = "Telefonszam";
            this.Telefonszam.Size = new System.Drawing.Size(210, 28);
            this.Telefonszam.TabIndex = 46;
            this.Telefonszam.Visible = false;
            // 
            // D4
            // 
            this.D4.BackColor = System.Drawing.Color.LightCoral;
            this.D4.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D4.Location = new System.Drawing.Point(272, 245);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(108, 28);
            this.D4.TabIndex = 48;
            this.D4.Text = "Szakterület";
            this.D4.Visible = false;
            // 
            // SzakBoxDoki
            // 
            this.SzakBoxDoki.BackColor = System.Drawing.Color.RosyBrown;
            this.SzakBoxDoki.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SzakBoxDoki.FormattingEnabled = true;
            this.SzakBoxDoki.Location = new System.Drawing.Point(390, 245);
            this.SzakBoxDoki.Name = "SzakBoxDoki";
            this.SzakBoxDoki.Size = new System.Drawing.Size(210, 29);
            this.SzakBoxDoki.TabIndex = 49;
            this.SzakBoxDoki.Visible = false;
            // 
            // Doktoradd
            // 
            this.Doktoradd.BackColor = System.Drawing.Color.Firebrick;
            this.Doktoradd.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doktoradd.Location = new System.Drawing.Point(323, 292);
            this.Doktoradd.Name = "Doktoradd";
            this.Doktoradd.Size = new System.Drawing.Size(237, 45);
            this.Doktoradd.TabIndex = 50;
            this.Doktoradd.Text = "Doktor hozáadása";
            this.Doktoradd.UseVisualStyleBackColor = false;
            this.Doktoradd.Visible = false;
            this.Doktoradd.Click += new System.EventHandler(this.Doktoradd_Click);
            // 
            // Belsos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(910, 521);
            this.Controls.Add(this.Doktoradd);
            this.Controls.Add(this.SzakBoxDoki);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.Telefonszam);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.Nev);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.Cnp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Szolgara);
            this.Controls.Add(this.Sz2);
            this.Controls.Add(this.Szolgadd);
            this.Controls.Add(this.Sz1);
            this.Controls.Add(this.Szolgneve);
            this.Controls.Add(this.SzakokBox);
            this.Controls.Add(this.Szakadd);
            this.Controls.Add(this.Szakneve);
            this.Controls.Add(this.Szak1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Belsos";
            this.Text = "Belsos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Belsos_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szakrendelésHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szolgáltatásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.TextBox Szak1;
        private System.Windows.Forms.TextBox Szakneve;
        private System.Windows.Forms.Button Szakadd;
        private System.Windows.Forms.ComboBox SzakokBox;
        private System.Windows.Forms.TextBox Szolgneve;
        private System.Windows.Forms.TextBox Sz1;
        private System.Windows.Forms.Button Szolgadd;
        private System.Windows.Forms.TextBox Sz2;
        private System.Windows.Forms.TextBox Szolgara;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox D1;
        private System.Windows.Forms.TextBox Cnp;
        private System.Windows.Forms.TextBox D2;
        private System.Windows.Forms.TextBox Nev;
        private System.Windows.Forms.TextBox D3;
        private System.Windows.Forms.TextBox Telefonszam;
        private System.Windows.Forms.TextBox D4;
        private System.Windows.Forms.ComboBox SzakBoxDoki;
        private System.Windows.Forms.Button Doktoradd;
    }
}