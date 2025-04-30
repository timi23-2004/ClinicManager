namespace VegsoProjekt
{
    partial class FoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.információkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szakrendelésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programálásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.belsősAdatokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Infok = new System.Windows.Forms.TextBox();
            this.SzolgLista = new System.Windows.Forms.ListBox();
            this.SzakCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kep = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.információkToolStripMenuItem,
            this.szakrendelésekToolStripMenuItem,
            this.programálásToolStripMenuItem,
            this.belsősAdatokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 43);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // információkToolStripMenuItem
            // 
            this.információkToolStripMenuItem.Name = "információkToolStripMenuItem";
            this.információkToolStripMenuItem.Size = new System.Drawing.Size(105, 37);
            this.információkToolStripMenuItem.Text = "Rólunk";
            this.információkToolStripMenuItem.Click += new System.EventHandler(this.információkToolStripMenuItem_Click);
            // 
            // szakrendelésekToolStripMenuItem
            // 
            this.szakrendelésekToolStripMenuItem.Name = "szakrendelésekToolStripMenuItem";
            this.szakrendelésekToolStripMenuItem.Size = new System.Drawing.Size(210, 37);
            this.szakrendelésekToolStripMenuItem.Text = "Szakrendelések";
            this.szakrendelésekToolStripMenuItem.Click += new System.EventHandler(this.szakrendelésekToolStripMenuItem_Click);
            // 
            // programálásToolStripMenuItem
            // 
            this.programálásToolStripMenuItem.Name = "programálásToolStripMenuItem";
            this.programálásToolStripMenuItem.Size = new System.Drawing.Size(165, 37);
            this.programálásToolStripMenuItem.Text = "Programálás";
            this.programálásToolStripMenuItem.Click += new System.EventHandler(this.programálásToolStripMenuItem_Click);
            // 
            // belsősAdatokToolStripMenuItem
            // 
            this.belsősAdatokToolStripMenuItem.Name = "belsősAdatokToolStripMenuItem";
            this.belsősAdatokToolStripMenuItem.Size = new System.Drawing.Size(185, 37);
            this.belsősAdatokToolStripMenuItem.Text = "Belsős adatok";
            this.belsősAdatokToolStripMenuItem.Click += new System.EventHandler(this.belsősAdatokToolStripMenuItem_Click);
            // 
            // Infok
            // 
            this.Infok.BackColor = System.Drawing.Color.RosyBrown;
            this.Infok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Infok.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infok.Location = new System.Drawing.Point(36, 80);
            this.Infok.Margin = new System.Windows.Forms.Padding(4);
            this.Infok.Multiline = true;
            this.Infok.Name = "Infok";
            this.Infok.ReadOnly = true;
            this.Infok.Size = new System.Drawing.Size(848, 417);
            this.Infok.TabIndex = 10;
            this.Infok.Text = resources.GetString("Infok.Text");
            // 
            // SzolgLista
            // 
            this.SzolgLista.BackColor = System.Drawing.Color.RosyBrown;
            this.SzolgLista.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SzolgLista.FormattingEnabled = true;
            this.SzolgLista.ItemHeight = 32;
            this.SzolgLista.Location = new System.Drawing.Point(36, 102);
            this.SzolgLista.Margin = new System.Windows.Forms.Padding(4);
            this.SzolgLista.Name = "SzolgLista";
            this.SzolgLista.Size = new System.Drawing.Size(848, 324);
            this.SzolgLista.TabIndex = 11;
            this.SzolgLista.Visible = false;
            // 
            // SzakCombo
            // 
            this.SzakCombo.FormattingEnabled = true;
            this.SzakCombo.Location = new System.Drawing.Point(235, 66);
            this.SzakCombo.Name = "SzakCombo";
            this.SzakCombo.Size = new System.Drawing.Size(121, 32);
            this.SzakCombo.TabIndex = 12;
            this.SzakCombo.Visible = false;
            this.SzakCombo.SelectedIndexChanged += new System.EventHandler(this.SzakCombo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Válassza ki a szakot";
            this.label1.Visible = false;
            // 
            // kep
            // 
            this.kep.Image = global::VegsoProjekt.Properties.Resources._51;
            this.kep.Location = new System.Drawing.Point(488, 269);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(375, 205);
            this.kep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kep.TabIndex = 42;
            this.kep.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(764, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(955, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1098, 521);
            this.Controls.Add(this.kep);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SzakCombo);
            this.Controls.Add(this.SzolgLista);
            this.Controls.Add(this.Infok);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FoForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem információkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szakrendelésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programálásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem belsősAdatokToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Infok;
        private System.Windows.Forms.ListBox SzolgLista;
        private System.Windows.Forms.ComboBox SzakCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox kep;
    }
}

