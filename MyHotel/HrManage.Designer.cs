namespace HotelHR
{
    partial class HrManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrManage));
            this.employPerform = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.nagetiveRadio = new System.Windows.Forms.RadioButton();
            this.positiveRadio = new System.Windows.Forms.RadioButton();
            this.rateTypeLabel = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.employeeIdBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.employeeJobTitle = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.employeeSalary = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeInfo = new System.Windows.Forms.DataGridView();
            this.jobTitleMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.promoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.employPerform.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).BeginInit();
            this.jobTitleMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employPerform
            // 
            this.employPerform.Controls.Add(this.tabPage1);
            this.employPerform.Controls.Add(this.tabPage2);
            this.employPerform.Controls.Add(this.tabPage3);
            this.employPerform.Controls.Add(this.tabPage4);
            this.employPerform.Location = new System.Drawing.Point(3, -30);
            this.employPerform.Name = "employPerform";
            this.employPerform.SelectedIndex = 0;
            this.employPerform.Size = new System.Drawing.Size(830, 476);
            this.employPerform.TabIndex = 2;
            this.employPerform.SelectedIndexChanged += new System.EventHandler(this.employPerform_SelectedIndexChanged);
            this.employPerform.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.employPerform_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.submitButton);
            this.tabPage1.Controls.Add(this.reasonBox);
            this.tabPage1.Controls.Add(this.reasonLabel);
            this.tabPage1.Controls.Add(this.nagetiveRadio);
            this.tabPage1.Controls.Add(this.positiveRadio);
            this.tabPage1.Controls.Add(this.rateTypeLabel);
            this.tabPage1.Controls.Add(this.employeeIdLabel);
            this.tabPage1.Controls.Add(this.employeeIdBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employ Perform";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(226, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitButton.Location = new System.Drawing.Point(135, 333);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(89, 34);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reasonBox.Location = new System.Drawing.Point(135, 169);
            this.reasonBox.Multiline = true;
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(321, 140);
            this.reasonBox.TabIndex = 6;
            this.reasonBox.Tag = "";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("华文隶书", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reasonLabel.ForeColor = System.Drawing.Color.White;
            this.reasonLabel.Location = new System.Drawing.Point(57, 168);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(69, 19);
            this.reasonLabel.TabIndex = 5;
            this.reasonLabel.Text = "Reason:";
            // 
            // nagetiveRadio
            // 
            this.nagetiveRadio.AutoSize = true;
            this.nagetiveRadio.Location = new System.Drawing.Point(210, 120);
            this.nagetiveRadio.Name = "nagetiveRadio";
            this.nagetiveRadio.Size = new System.Drawing.Size(14, 13);
            this.nagetiveRadio.TabIndex = 4;
            this.nagetiveRadio.TabStop = true;
            this.nagetiveRadio.UseVisualStyleBackColor = true;
            // 
            // positiveRadio
            // 
            this.positiveRadio.AutoSize = true;
            this.positiveRadio.Location = new System.Drawing.Point(135, 119);
            this.positiveRadio.Name = "positiveRadio";
            this.positiveRadio.Size = new System.Drawing.Size(14, 13);
            this.positiveRadio.TabIndex = 3;
            this.positiveRadio.TabStop = true;
            this.positiveRadio.UseVisualStyleBackColor = true;
            // 
            // rateTypeLabel
            // 
            this.rateTypeLabel.AutoSize = true;
            this.rateTypeLabel.Font = new System.Drawing.Font("华文隶书", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateTypeLabel.ForeColor = System.Drawing.Color.White;
            this.rateTypeLabel.Location = new System.Drawing.Point(38, 116);
            this.rateTypeLabel.Name = "rateTypeLabel";
            this.rateTypeLabel.Size = new System.Drawing.Size(88, 19);
            this.rateTypeLabel.TabIndex = 2;
            this.rateTypeLabel.Text = "Rate type:";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Font = new System.Drawing.Font("华文隶书", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.employeeIdLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIdLabel.Location = new System.Drawing.Point(17, 63);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(109, 19);
            this.employeeIdLabel.TabIndex = 1;
            this.employeeIdLabel.Text = "Employee id:";
            // 
            // employeeIdBox
            // 
            this.employeeIdBox.Location = new System.Drawing.Point(135, 61);
            this.employeeIdBox.Name = "employeeIdBox";
            this.employeeIdBox.Size = new System.Drawing.Size(146, 21);
            this.employeeIdBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.employeeJobTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Job Title";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // employeeJobTitle
            // 
            this.employeeJobTitle.AllowUserToAddRows = false;
            this.employeeJobTitle.AllowUserToDeleteRows = false;
            this.employeeJobTitle.AllowUserToOrderColumns = true;
            this.employeeJobTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeJobTitle.Location = new System.Drawing.Point(3, 28);
            this.employeeJobTitle.Name = "employeeJobTitle";
            this.employeeJobTitle.RowTemplate.Height = 23;
            this.employeeJobTitle.Size = new System.Drawing.Size(816, 422);
            this.employeeJobTitle.TabIndex = 0;
            this.employeeJobTitle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.employeeJobTitle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeJobTitle_CellEndEdit);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.employeeSalary);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(822, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Salary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // employeeSalary
            // 
            this.employeeSalary.AllowUserToAddRows = false;
            this.employeeSalary.AllowUserToDeleteRows = false;
            this.employeeSalary.AllowUserToOrderColumns = true;
            this.employeeSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeSalary.Location = new System.Drawing.Point(3, 3);
            this.employeeSalary.Margin = new System.Windows.Forms.Padding(2);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(816, 444);
            this.employeeSalary.TabIndex = 0;
            this.employeeSalary.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeSalary_CellEndEdit);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.employeeInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(822, 450);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // employeeInfo
            // 
            this.employeeInfo.AllowUserToAddRows = false;
            this.employeeInfo.AllowUserToDeleteRows = false;
            this.employeeInfo.AllowUserToOrderColumns = true;
            this.employeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeInfo.Location = new System.Drawing.Point(4, 26);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.ReadOnly = true;
            this.employeeInfo.RowTemplate.Height = 23;
            this.employeeInfo.Size = new System.Drawing.Size(818, 424);
            this.employeeInfo.TabIndex = 0;
            this.employeeInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeInfo_CellContentClick);
            // 
            // jobTitleMenuStrip
            // 
            this.jobTitleMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.jobTitleMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.jobTitleMenuStrip.Name = "jobTitleMenuStrip";
            this.jobTitleMenuStrip.Size = new System.Drawing.Size(127, 48);
            this.jobTitleMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.jobTitleMenuStrip_Opening);
            // 
            // promoteToolStripMenuItem
            // 
            this.promoteToolStripMenuItem.Name = "promoteToolStripMenuItem";
            this.promoteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.promoteToolStripMenuItem.Text = "Promote";
            this.promoteToolStripMenuItem.Click += new System.EventHandler(this.promoteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.employPerform);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 449);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Employ Perform";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(130, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Job Title";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(260, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Salary";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(390, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 25);
            this.button4.TabIndex = 7;
            this.button4.Text = "Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // HrManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 479);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "HrManage";
            this.Text = "HrManage";
            this.employPerform.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).EndInit();
            this.jobTitleMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl employPerform;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.TextBox employeeIdBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton nagetiveRadio;
        private System.Windows.Forms.RadioButton positiveRadio;
        private System.Windows.Forms.Label rateTypeLabel;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView employeeInfo;
        private System.Windows.Forms.DataGridView employeeJobTitle;
        private System.Windows.Forms.ContextMenuStrip jobTitleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem promoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView employeeSalary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        //-K
        
        //-K
        
    }
}

