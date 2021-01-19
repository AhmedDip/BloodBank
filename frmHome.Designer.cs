namespace BloodBankManagementSystem
{
    partial class frmHome
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
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.panelOpositive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOpositiveCount = new System.Windows.Forms.Label();
            this.lblBloodGroup = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.lblOnegative = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnegativeCount = new System.Windows.Forms.Label();
            this.lblAnegative = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApositiveCount = new System.Windows.Forms.Label();
            this.lblApositive = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABnegativeCount = new System.Windows.Forms.Label();
            this.lblABnegative = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblABpositiveCount = new System.Windows.Forms.Label();
            this.lblABpositive = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBnegativeCount = new System.Windows.Forms.Label();
            this.lblBnegative = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBpositiveCount = new System.Windows.Forms.Label();
            this.lblBpositive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripTop.SuspendLayout();
            this.panelOpositive.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(1087, 47);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // panelOpositive
            // 
            this.panelOpositive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpositive.Controls.Add(this.lblName);
            this.panelOpositive.Controls.Add(this.lblOpositiveCount);
            this.panelOpositive.Controls.Add(this.lblBloodGroup);
            this.panelOpositive.Location = new System.Drawing.Point(890, 260);
            this.panelOpositive.Name = "panelOpositive";
            this.panelOpositive.Size = new System.Drawing.Size(110, 120);
            this.panelOpositive.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(15, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Bags";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblOpositiveCount
            // 
            this.lblOpositiveCount.AutoSize = true;
            this.lblOpositiveCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpositiveCount.ForeColor = System.Drawing.Color.Red;
            this.lblOpositiveCount.Location = new System.Drawing.Point(24, 55);
            this.lblOpositiveCount.Name = "lblOpositiveCount";
            this.lblOpositiveCount.Size = new System.Drawing.Size(54, 30);
            this.lblOpositiveCount.TabIndex = 1;
            this.lblOpositiveCount.Text = "100";
            // 
            // lblBloodGroup
            // 
            this.lblBloodGroup.AutoSize = true;
            this.lblBloodGroup.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodGroup.ForeColor = System.Drawing.Color.Red;
            this.lblBloodGroup.Location = new System.Drawing.Point(11, 3);
            this.lblBloodGroup.Name = "lblBloodGroup";
            this.lblBloodGroup.Size = new System.Drawing.Size(74, 50);
            this.lblBloodGroup.TabIndex = 0;
            this.lblBloodGroup.Text = "O+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOnegativeCount);
            this.panel1.Controls.Add(this.lblOnegative);
            this.panel1.Location = new System.Drawing.Point(890, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 120);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bags";
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.Red;
            this.lblOnegativeCount.Location = new System.Drawing.Point(24, 55);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(54, 30);
            this.lblOnegativeCount.TabIndex = 1;
            this.lblOnegativeCount.Text = "100";
            // 
            // lblOnegative
            // 
            this.lblOnegative.AutoSize = true;
            this.lblOnegative.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegative.ForeColor = System.Drawing.Color.Red;
            this.lblOnegative.Location = new System.Drawing.Point(20, 3);
            this.lblOnegative.Name = "lblOnegative";
            this.lblOnegative.Size = new System.Drawing.Size(63, 50);
            this.lblOnegative.TabIndex = 0;
            this.lblOnegative.Text = "O-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAnegativeCount);
            this.panel2.Controls.Add(this.lblAnegative);
            this.panel2.Location = new System.Drawing.Point(542, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 120);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bags";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAnegativeCount
            // 
            this.lblAnegativeCount.AutoSize = true;
            this.lblAnegativeCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegativeCount.ForeColor = System.Drawing.Color.Red;
            this.lblAnegativeCount.Location = new System.Drawing.Point(21, 55);
            this.lblAnegativeCount.Name = "lblAnegativeCount";
            this.lblAnegativeCount.Size = new System.Drawing.Size(54, 30);
            this.lblAnegativeCount.TabIndex = 1;
            this.lblAnegativeCount.Text = "100";
            // 
            // lblAnegative
            // 
            this.lblAnegative.AutoSize = true;
            this.lblAnegative.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegative.ForeColor = System.Drawing.Color.Red;
            this.lblAnegative.Location = new System.Drawing.Point(17, 5);
            this.lblAnegative.Name = "lblAnegative";
            this.lblAnegative.Size = new System.Drawing.Size(61, 50);
            this.lblAnegative.TabIndex = 0;
            this.lblAnegative.Text = "A-";
            this.lblAnegative.Click += new System.EventHandler(this.lblAnegative_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblApositiveCount);
            this.panel3.Controls.Add(this.lblApositive);
            this.panel3.Location = new System.Drawing.Point(542, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 120);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(21, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bags";
            // 
            // lblApositiveCount
            // 
            this.lblApositiveCount.AutoSize = true;
            this.lblApositiveCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositiveCount.ForeColor = System.Drawing.Color.Red;
            this.lblApositiveCount.Location = new System.Drawing.Point(21, 55);
            this.lblApositiveCount.Name = "lblApositiveCount";
            this.lblApositiveCount.Size = new System.Drawing.Size(54, 30);
            this.lblApositiveCount.TabIndex = 1;
            this.lblApositiveCount.Text = "100";
            this.lblApositiveCount.Click += new System.EventHandler(this.lblApositiveCount_Click);
            // 
            // lblApositive
            // 
            this.lblApositive.AutoSize = true;
            this.lblApositive.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApositive.ForeColor = System.Drawing.Color.Red;
            this.lblApositive.Location = new System.Drawing.Point(13, 6);
            this.lblApositive.Name = "lblApositive";
            this.lblApositive.Size = new System.Drawing.Size(76, 52);
            this.lblApositive.TabIndex = 0;
            this.lblApositive.Text = "A+";
            this.lblApositive.Click += new System.EventHandler(this.lblApositive_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblABnegativeCount);
            this.panel4.Controls.Add(this.lblABnegative);
            this.panel4.Location = new System.Drawing.Point(774, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 120);
            this.panel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(8, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "Bags";
            // 
            // lblABnegativeCount
            // 
            this.lblABnegativeCount.AutoSize = true;
            this.lblABnegativeCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegativeCount.ForeColor = System.Drawing.Color.Red;
            this.lblABnegativeCount.Location = new System.Drawing.Point(8, 53);
            this.lblABnegativeCount.Name = "lblABnegativeCount";
            this.lblABnegativeCount.Size = new System.Drawing.Size(54, 30);
            this.lblABnegativeCount.TabIndex = 1;
            this.lblABnegativeCount.Text = "100";
            this.lblABnegativeCount.Click += new System.EventHandler(this.lblABnegativeCount_Click);
            // 
            // lblABnegative
            // 
            this.lblABnegative.AutoSize = true;
            this.lblABnegative.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegative.ForeColor = System.Drawing.Color.Red;
            this.lblABnegative.Location = new System.Drawing.Point(3, 3);
            this.lblABnegative.Name = "lblABnegative";
            this.lblABnegative.Size = new System.Drawing.Size(88, 50);
            this.lblABnegative.TabIndex = 0;
            this.lblABnegative.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblABpositiveCount);
            this.panel5.Controls.Add(this.lblABpositive);
            this.panel5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(774, 260);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 120);
            this.panel5.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(17, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 27);
            this.label13.TabIndex = 2;
            this.label13.Text = "Bags";
            // 
            // lblABpositiveCount
            // 
            this.lblABpositiveCount.AutoSize = true;
            this.lblABpositiveCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositiveCount.ForeColor = System.Drawing.Color.Red;
            this.lblABpositiveCount.Location = new System.Drawing.Point(22, 55);
            this.lblABpositiveCount.Name = "lblABpositiveCount";
            this.lblABpositiveCount.Size = new System.Drawing.Size(54, 30);
            this.lblABpositiveCount.TabIndex = 1;
            this.lblABpositiveCount.Text = "100";
            this.lblABpositiveCount.Click += new System.EventHandler(this.lblABpositiveCount_Click);
            // 
            // lblABpositive
            // 
            this.lblABpositive.AutoSize = true;
            this.lblABpositive.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABpositive.ForeColor = System.Drawing.Color.Red;
            this.lblABpositive.Location = new System.Drawing.Point(4, 3);
            this.lblABpositive.Name = "lblABpositive";
            this.lblABpositive.Size = new System.Drawing.Size(99, 50);
            this.lblABpositive.TabIndex = 0;
            this.lblABpositive.Text = "AB+";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.lblBnegativeCount);
            this.panel6.Controls.Add(this.lblBnegative);
            this.panel6.Location = new System.Drawing.Point(658, 386);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 120);
            this.panel6.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(22, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 27);
            this.label16.TabIndex = 2;
            this.label16.Text = "Bags";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblBnegativeCount
            // 
            this.lblBnegativeCount.AutoSize = true;
            this.lblBnegativeCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegativeCount.ForeColor = System.Drawing.Color.Red;
            this.lblBnegativeCount.Location = new System.Drawing.Point(26, 53);
            this.lblBnegativeCount.Name = "lblBnegativeCount";
            this.lblBnegativeCount.Size = new System.Drawing.Size(54, 30);
            this.lblBnegativeCount.TabIndex = 1;
            this.lblBnegativeCount.Text = "100";
            // 
            // lblBnegative
            // 
            this.lblBnegative.AutoSize = true;
            this.lblBnegative.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegative.ForeColor = System.Drawing.Color.Red;
            this.lblBnegative.Location = new System.Drawing.Point(15, 5);
            this.lblBnegative.Name = "lblBnegative";
            this.lblBnegative.Size = new System.Drawing.Size(61, 50);
            this.lblBnegative.TabIndex = 0;
            this.lblBnegative.Text = "B-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblBpositiveCount);
            this.panel7.Controls.Add(this.lblBpositive);
            this.panel7.Location = new System.Drawing.Point(658, 260);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(110, 120);
            this.panel7.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(22, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 27);
            this.label19.TabIndex = 2;
            this.label19.Text = "Bags";
            // 
            // lblBpositiveCount
            // 
            this.lblBpositiveCount.AutoSize = true;
            this.lblBpositiveCount.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositiveCount.ForeColor = System.Drawing.Color.Red;
            this.lblBpositiveCount.Location = new System.Drawing.Point(22, 55);
            this.lblBpositiveCount.Name = "lblBpositiveCount";
            this.lblBpositiveCount.Size = new System.Drawing.Size(54, 30);
            this.lblBpositiveCount.TabIndex = 1;
            this.lblBpositiveCount.Text = "100";
            // 
            // lblBpositive
            // 
            this.lblBpositive.AutoSize = true;
            this.lblBpositive.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBpositive.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBpositive.ForeColor = System.Drawing.Color.Red;
            this.lblBpositive.Location = new System.Drawing.Point(18, 8);
            this.lblBpositive.Name = "lblBpositive";
            this.lblBpositive.Size = new System.Drawing.Size(72, 50);
            this.lblBpositive.TabIndex = 0;
            this.lblBpositive.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(12, 147);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.Size = new System.Drawing.Size(495, 359);
            this.dgvDonors.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 90);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(127, 19);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search a Donor";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(495, 29);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUserTitle.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitle.Location = new System.Drawing.Point(831, 14);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(144, 23);
            this.lblUserTitle.TabIndex = 14;
            this.lblUserTitle.Text = "Logged In As: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblUser.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUser.Location = new System.Drawing.Point(970, 14);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(16, 22);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Welcome to Blood Bank Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BloodBankManagementSystem.Properties.Resources.animasi_darah_png_2;
            this.pictureBox1.Location = new System.Drawing.Point(542, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::BloodBankManagementSystem.Properties.Resources._2;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(169, 27);
            this.usersToolStripMenuItem.Text = "Users Module";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donorsToolStripMenuItem.Image = global::BloodBankManagementSystem.Properties.Resources._3;
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.donorsToolStripMenuItem.Text = "Donors Module";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Image = global::BloodBankManagementSystem.Properties.Resources._1;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(121, 27);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpositive);
            this.Controls.Add(this.menuStripTop);
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelOpositive.ResumeLayout(false);
            this.panelOpositive.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelOpositive;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOpositiveCount;
        private System.Windows.Forms.Label lblBloodGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.Label lblOnegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnegativeCount;
        private System.Windows.Forms.Label lblAnegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApositiveCount;
        private System.Windows.Forms.Label lblApositive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABnegativeCount;
        private System.Windows.Forms.Label lblABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblABpositiveCount;
        private System.Windows.Forms.Label lblABpositive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBnegativeCount;
        private System.Windows.Forms.Label lblBnegative;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBpositiveCount;
        private System.Windows.Forms.Label lblBpositive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

