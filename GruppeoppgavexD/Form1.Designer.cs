﻿namespace GruppeoppgavexD
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bildested = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Neste = new System.Windows.Forms.Button();
            this.Sjekk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Alt2 = new System.Windows.Forms.RadioButton();
            this.Alt1 = new System.Windows.Forms.RadioButton();
            this.Alt3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bildested)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bildested);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sjekk);
            this.groupBox1.Controls.Add(this.Neste);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 644);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Bildested
            // 
            this.Bildested.Dock = System.Windows.Forms.DockStyle.Left;
            this.Bildested.Location = new System.Drawing.Point(3, 22);
            this.Bildested.Name = "Bildested";
            this.Bildested.Size = new System.Drawing.Size(724, 619);
            this.Bildested.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bildested.TabIndex = 1;
            this.Bildested.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spørsmål 1";
            // 
            // Neste
            // 
            this.Neste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neste.Location = new System.Drawing.Point(762, 312);
            this.Neste.Name = "Neste";
            this.Neste.Size = new System.Drawing.Size(157, 39);
            this.Neste.TabIndex = 1;
            this.Neste.Text = "Neste";
            this.Neste.UseVisualStyleBackColor = true;
            this.Neste.Click += new System.EventHandler(this.Neste_Click);
            // 
            // Sjekk
            // 
            this.Sjekk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sjekk.Location = new System.Drawing.Point(762, 357);
            this.Sjekk.Name = "Sjekk";
            this.Sjekk.Size = new System.Drawing.Size(157, 43);
            this.Sjekk.TabIndex = 5;
            this.Sjekk.Text = "Sjekk svar";
            this.Sjekk.UseVisualStyleBackColor = true;
            this.Sjekk.Click += new System.EventHandler(this.Sjekk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hvilket land er dette?";
            // 
            // Alt2
            // 
            this.Alt2.AutoSize = true;
            this.Alt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alt2.Location = new System.Drawing.Point(3, 63);
            this.Alt2.Name = "Alt2";
            this.Alt2.Size = new System.Drawing.Size(21, 20);
            this.Alt2.TabIndex = 2;
            this.Alt2.TabStop = true;
            this.Alt2.UseVisualStyleBackColor = true;
            // 
            // Alt1
            // 
            this.Alt1.AutoSize = true;
            this.Alt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alt1.Location = new System.Drawing.Point(3, 23);
            this.Alt1.Name = "Alt1";
            this.Alt1.Size = new System.Drawing.Size(21, 20);
            this.Alt1.TabIndex = 2;
            this.Alt1.TabStop = true;
            this.Alt1.UseVisualStyleBackColor = true;
            // 
            // Alt3
            // 
            this.Alt3.AutoSize = true;
            this.Alt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alt3.Location = new System.Drawing.Point(3, 107);
            this.Alt3.Name = "Alt3";
            this.Alt3.Size = new System.Drawing.Size(21, 20);
            this.Alt3.TabIndex = 3;
            this.Alt3.TabStop = true;
            this.Alt3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Alt3);
            this.panel1.Controls.Add(this.Alt1);
            this.panel1.Controls.Add(this.Alt2);
            this.panel1.Location = new System.Drawing.Point(744, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 175);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 644);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bildested)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Bildested;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Alt3;
        private System.Windows.Forms.RadioButton Alt1;
        private System.Windows.Forms.RadioButton Alt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sjekk;
        private System.Windows.Forms.Button Neste;
        private System.Windows.Forms.Label label1;
    }
}

