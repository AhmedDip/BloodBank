namespace BloodBankManagementSystem.UI
{
    partial class frmSplash
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelBG = new System.Windows.Forms.Panel();
            this.panelMovable = new System.Windows.Forms.Panel();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(337, 94);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BLOOD BANK";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(268, 144);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(386, 50);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Management System";
            this.lblSubTitle.Click += new System.EventHandler(this.lblSubTitle_Click);
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBG.Controls.Add(this.panelMovable);
            this.panelBG.Location = new System.Drawing.Point(277, 249);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(366, 39);
            this.panelBG.TabIndex = 3;
            // 
            // panelMovable
            // 
            this.panelMovable.BackColor = System.Drawing.Color.Red;
            this.panelMovable.ForeColor = System.Drawing.Color.Red;
            this.panelMovable.Location = new System.Drawing.Point(8, 7);
            this.panelMovable.Name = "panelMovable";
            this.panelMovable.Size = new System.Drawing.Size(10, 25);
            this.panelMovable.TabIndex = 0;
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodBankManagementSystem.Properties.Resources._31;
            this.pictureBox1.Location = new System.Drawing.Point(153, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loading";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 430);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBG);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.panelBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.Panel panelMovable;
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}