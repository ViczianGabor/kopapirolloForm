namespace kopapirolloForm
{
    partial class frmfo
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
            this.Label1 = new System.Windows.Forms.Label();
            this.lbljatekos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblszamitogep = new System.Windows.Forms.Label();
            this.pbjatekos = new System.Windows.Forms.PictureBox();
            this.pbszamitogep = new System.Windows.Forms.PictureBox();
            this.lblgyoztes = new System.Windows.Forms.Label();
            this.btnko = new System.Windows.Forms.Button();
            this.btnpapir = new System.Windows.Forms.Button();
            this.btnollo = new System.Windows.Forms.Button();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.btnszabaly = new System.Windows.Forms.Button();
            this.btnujjatek = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbjatekos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbszamitogep)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(47, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Játékos:";
            // 
            // lbljatekos
            // 
            this.lbljatekos.AutoSize = true;
            this.lbljatekos.Location = new System.Drawing.Point(86, 27);
            this.lbljatekos.Name = "lbljatekos";
            this.lbljatekos.Size = new System.Drawing.Size(35, 13);
            this.lbljatekos.TabIndex = 1;
            this.lbljatekos.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Számítógép";
            // 
            // lblszamitogep
            // 
            this.lblszamitogep.AutoSize = true;
            this.lblszamitogep.Location = new System.Drawing.Point(384, 27);
            this.lblszamitogep.Name = "lblszamitogep";
            this.lblszamitogep.Size = new System.Drawing.Size(35, 13);
            this.lblszamitogep.TabIndex = 3;
            this.lblszamitogep.Text = "label3";
            // 
            // pbjatekos
            // 
            this.pbjatekos.Location = new System.Drawing.Point(11, 74);
            this.pbjatekos.Name = "pbjatekos";
            this.pbjatekos.Size = new System.Drawing.Size(200, 200);
            this.pbjatekos.TabIndex = 4;
            this.pbjatekos.TabStop = false;
            // 
            // pbszamitogep
            // 
            this.pbszamitogep.Location = new System.Drawing.Point(268, 74);
            this.pbszamitogep.Name = "pbszamitogep";
            this.pbszamitogep.Size = new System.Drawing.Size(200, 200);
            this.pbszamitogep.TabIndex = 5;
            this.pbszamitogep.TabStop = false;
            this.pbszamitogep.Click += new System.EventHandler(this.pbszamitogep_Click);
            // 
            // lblgyoztes
            // 
            this.lblgyoztes.AutoSize = true;
            this.lblgyoztes.Location = new System.Drawing.Point(225, 309);
            this.lblgyoztes.Name = "lblgyoztes";
            this.lblgyoztes.Size = new System.Drawing.Size(35, 13);
            this.lblgyoztes.TabIndex = 6;
            this.lblgyoztes.Text = "label3";
            // 
            // btnko
            // 
            this.btnko.Location = new System.Drawing.Point(25, 15);
            this.btnko.Name = "btnko";
            this.btnko.Size = new System.Drawing.Size(75, 23);
            this.btnko.TabIndex = 7;
            this.btnko.Text = "Kő";
            this.btnko.UseVisualStyleBackColor = true;
            // 
            // btnpapir
            // 
            this.btnpapir.Location = new System.Drawing.Point(211, 15);
            this.btnpapir.Name = "btnpapir";
            this.btnpapir.Size = new System.Drawing.Size(75, 23);
            this.btnpapir.TabIndex = 8;
            this.btnpapir.Text = "papír";
            this.btnpapir.UseVisualStyleBackColor = true;
            // 
            // btnollo
            // 
            this.btnollo.Location = new System.Drawing.Point(441, 15);
            this.btnollo.Name = "btnollo";
            this.btnollo.Size = new System.Drawing.Size(75, 23);
            this.btnollo.TabIndex = 9;
            this.btnollo.Text = "olló";
            this.btnollo.UseVisualStyleBackColor = true;
            // 
            // btnkilepes
            // 
            this.btnkilepes.Location = new System.Drawing.Point(23, 426);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(75, 23);
            this.btnkilepes.TabIndex = 10;
            this.btnkilepes.Text = "Kilépés";
            this.btnkilepes.UseVisualStyleBackColor = true;
            // 
            // btnszabaly
            // 
            this.btnszabaly.Location = new System.Drawing.Point(224, 426);
            this.btnszabaly.Name = "btnszabaly";
            this.btnszabaly.Size = new System.Drawing.Size(75, 23);
            this.btnszabaly.TabIndex = 11;
            this.btnszabaly.Text = "Szabályok";
            this.btnszabaly.UseVisualStyleBackColor = true;
            // 
            // btnujjatek
            // 
            this.btnujjatek.Location = new System.Drawing.Point(454, 426);
            this.btnujjatek.Name = "btnujjatek";
            this.btnujjatek.Size = new System.Drawing.Size(75, 23);
            this.btnujjatek.TabIndex = 12;
            this.btnujjatek.Text = "Új játék";
            this.btnujjatek.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lblgyoztes);
            this.panel1.Controls.Add(this.pbszamitogep);
            this.panel1.Controls.Add(this.pbjatekos);
            this.panel1.Controls.Add(this.lblszamitogep);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbljatekos);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(21, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 336);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.btnollo);
            this.panel2.Controls.Add(this.btnpapir);
            this.panel2.Controls.Add(this.btnko);
            this.panel2.Location = new System.Drawing.Point(13, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 61);
            this.panel2.TabIndex = 14;
            // 
            // frmfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnujjatek);
            this.Controls.Add(this.btnszabaly);
            this.Controls.Add(this.btnkilepes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kő , papír, olló";
            ((System.ComponentModel.ISupportInitialize)(this.pbjatekos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbszamitogep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lbljatekos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblszamitogep;
        private System.Windows.Forms.PictureBox pbjatekos;
        private System.Windows.Forms.PictureBox pbszamitogep;
        private System.Windows.Forms.Label lblgyoztes;
        private System.Windows.Forms.Button btnko;
        private System.Windows.Forms.Button btnpapir;
        private System.Windows.Forms.Button btnollo;
        private System.Windows.Forms.Button btnkilepes;
        private System.Windows.Forms.Button btnszabaly;
        private System.Windows.Forms.Button btnujjatek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

