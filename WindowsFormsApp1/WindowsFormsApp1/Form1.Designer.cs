
namespace WindowsFormsApp1
{
    partial class CityTime
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
            this.BtnBaku = new System.Windows.Forms.Button();
            this.BtnLondon = new System.Windows.Forms.Button();
            this.cityPic = new System.Windows.Forms.PictureBox();
            this.Datecurrent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBaku
            // 
            this.BtnBaku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBaku.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBaku.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBaku.Location = new System.Drawing.Point(39, 212);
            this.BtnBaku.Name = "BtnBaku";
            this.BtnBaku.Size = new System.Drawing.Size(310, 43);
            this.BtnBaku.TabIndex = 1;
            this.BtnBaku.Text = "Baku";
            this.BtnBaku.UseVisualStyleBackColor = false;
            this.BtnBaku.Click += new System.EventHandler(this.BtnBaku_Click);
            // 
            // BtnLondon
            // 
            this.BtnLondon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLondon.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnLondon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLondon.Location = new System.Drawing.Point(411, 212);
            this.BtnLondon.Name = "BtnLondon";
            this.BtnLondon.Size = new System.Drawing.Size(310, 43);
            this.BtnLondon.TabIndex = 2;
            this.BtnLondon.Text = "London";
            this.BtnLondon.UseVisualStyleBackColor = false;
            this.BtnLondon.Click += new System.EventHandler(this.BtnLondon_Click);
            // 
            // cityPic
            // 
            this.cityPic.Image = global::WindowsFormsApp1.Properties.Resources.baku;
            this.cityPic.Location = new System.Drawing.Point(-6, -6);
            this.cityPic.Name = "cityPic";
            this.cityPic.Size = new System.Drawing.Size(810, 462);
            this.cityPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cityPic.TabIndex = 0;
            this.cityPic.TabStop = false;
            this.cityPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Datecurrent
            // 
            this.Datecurrent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Datecurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Datecurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datecurrent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Datecurrent.Location = new System.Drawing.Point(339, 124);
            this.Datecurrent.Name = "Datecurrent";
            this.Datecurrent.Size = new System.Drawing.Size(87, 35);
            this.Datecurrent.TabIndex = 3;
            this.Datecurrent.Text = "12:00";
            this.Datecurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CityTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Datecurrent);
            this.Controls.Add(this.BtnLondon);
            this.Controls.Add(this.BtnBaku);
            this.Controls.Add(this.cityPic);
            this.Name = "CityTime";
            this.Text = "CityTime";
            ((System.ComponentModel.ISupportInitialize)(this.cityPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnBaku;
        private System.Windows.Forms.Button BtnLondon;
        private System.Windows.Forms.PictureBox cityPic;
        private System.Windows.Forms.Label Datecurrent;
    }
}

