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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrManage));
            this.employPerform = new System.Windows.Forms.TabControl();
            this.performPage = new System.Windows.Forms.TabPage();
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
            this.jobPage = new System.Windows.Forms.TabPage();
            this.showAll = new System.Windows.Forms.Button();
            this.submitButton2 = new System.Windows.Forms.Button();
            this.employeeIdBox2 = new System.Windows.Forms.TextBox();
            this.employeeIdLabel2 = new System.Windows.Forms.Label();
            this.employeeJobTitle = new System.Windows.Forms.DataGridView();
            this.salaryPage = new System.Windows.Forms.TabPage();
            this.employeeSalary = new System.Windows.Forms.DataGridView();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.employeeInfo = new System.Windows.Forms.DataGridView();
            this.showAll2 = new System.Windows.Forms.Button();
            this.submitButton3 = new System.Windows.Forms.Button();
            this.employeeIdBox3 = new System.Windows.Forms.TextBox();
            this.employeeIdLabel3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.performButton = new System.Windows.Forms.Button();
            this.jobButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.employeePerform = new System.Windows.Forms.DataGridView();
            this.employPerform.SuspendLayout();
            this.performPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.jobPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).BeginInit();
            this.salaryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).BeginInit();
            this.infoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePerform)).BeginInit();
            this.SuspendLayout();
            // 
            // employPerform
            // 
            this.employPerform.Controls.Add(this.performPage);
            this.employPerform.Controls.Add(this.jobPage);
            this.employPerform.Controls.Add(this.salaryPage);
            this.employPerform.Controls.Add(this.infoPage);
            this.employPerform.Location = new System.Drawing.Point(3, -30);
            this.employPerform.Name = "employPerform";
            this.employPerform.SelectedIndex = 0;
            this.employPerform.Size = new System.Drawing.Size(830, 476);
            this.employPerform.TabIndex = 2;
            this.employPerform.SelectedIndexChanged += new System.EventHandler(this.employPerform_SelectedIndexChanged);
            this.employPerform.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.employPerform_Selecting);
            // 
            // performPage
            // 
            this.performPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("performPage.BackgroundImage")));
            this.performPage.Controls.Add(this.pictureBox2);
            this.performPage.Controls.Add(this.pictureBox1);
            this.performPage.Controls.Add(this.submitButton);
            this.performPage.Controls.Add(this.reasonBox);
            this.performPage.Controls.Add(this.reasonLabel);
            this.performPage.Controls.Add(this.nagetiveRadio);
            this.performPage.Controls.Add(this.positiveRadio);
            this.performPage.Controls.Add(this.rateTypeLabel);
            this.performPage.Controls.Add(this.employeeIdLabel);
            this.performPage.Controls.Add(this.employeeIdBox);
            this.performPage.Location = new System.Drawing.Point(4, 22);
            this.performPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.performPage.Name = "performPage";
            this.performPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.performPage.Size = new System.Drawing.Size(822, 450);
            this.performPage.TabIndex = 0;
            this.performPage.Text = "Employ Perform";
            this.performPage.UseVisualStyleBackColor = true;
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
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.reasonBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reasonLabel.ForeColor = System.Drawing.Color.White;
            this.reasonLabel.Location = new System.Drawing.Point(57, 168);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(87, 24);
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
            this.rateTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateTypeLabel.ForeColor = System.Drawing.Color.White;
            this.rateTypeLabel.Location = new System.Drawing.Point(38, 116);
            this.rateTypeLabel.Name = "rateTypeLabel";
            this.rateTypeLabel.Size = new System.Drawing.Size(103, 24);
            this.rateTypeLabel.TabIndex = 2;
            this.rateTypeLabel.Text = "Rate type:";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.employeeIdLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIdLabel.Location = new System.Drawing.Point(17, 63);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(133, 24);
            this.employeeIdLabel.TabIndex = 1;
            this.employeeIdLabel.Text = "Employee id:";
            // 
            // employeeIdBox
            // 
            this.employeeIdBox.Location = new System.Drawing.Point(152, 63);
            this.employeeIdBox.Name = "employeeIdBox";
            this.employeeIdBox.Size = new System.Drawing.Size(146, 21);
            this.employeeIdBox.TabIndex = 0;
            this.employeeIdBox.TextChanged += new System.EventHandler(this.employeeIdBox_TextChanged);
            // 
            // jobPage
            // 
            this.jobPage.Controls.Add(this.showAll);
            this.jobPage.Controls.Add(this.submitButton2);
            this.jobPage.Controls.Add(this.employeeIdBox2);
            this.jobPage.Controls.Add(this.employeeIdLabel2);
            this.jobPage.Controls.Add(this.employeeJobTitle);
            this.jobPage.Location = new System.Drawing.Point(4, 22);
            this.jobPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobPage.Name = "jobPage";
            this.jobPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobPage.Size = new System.Drawing.Size(822, 450);
            this.jobPage.TabIndex = 1;
            this.jobPage.Text = "Job Title";
            this.jobPage.UseVisualStyleBackColor = true;
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(418, 6);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(89, 23);
            this.showAll.TabIndex = 4;
            this.showAll.Text = "show all";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // submitButton2
            // 
            this.submitButton2.Location = new System.Drawing.Point(294, 7);
            this.submitButton2.Name = "submitButton2";
            this.submitButton2.Size = new System.Drawing.Size(75, 23);
            this.submitButton2.TabIndex = 3;
            this.submitButton2.Text = "submit";
            this.submitButton2.UseVisualStyleBackColor = true;
            this.submitButton2.Click += new System.EventHandler(this.submitButton2_Click);
            // 
            // employeeIdBox2
            // 
            this.employeeIdBox2.Location = new System.Drawing.Point(163, 6);
            this.employeeIdBox2.Name = "employeeIdBox2";
            this.employeeIdBox2.Size = new System.Drawing.Size(100, 21);
            this.employeeIdBox2.TabIndex = 2;
            // 
            // employeeIdLabel2
            // 
            this.employeeIdLabel2.AutoSize = true;
            this.employeeIdLabel2.Location = new System.Drawing.Point(54, 16);
            this.employeeIdLabel2.Name = "employeeIdLabel2";
            this.employeeIdLabel2.Size = new System.Drawing.Size(77, 12);
            this.employeeIdLabel2.TabIndex = 1;
            this.employeeIdLabel2.Text = "Employee id:";
            this.employeeIdLabel2.Click += new System.EventHandler(this.label1_Click);
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
            // salaryPage
            // 
            this.salaryPage.Controls.Add(this.employeeSalary);
            this.salaryPage.Location = new System.Drawing.Point(4, 22);
            this.salaryPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salaryPage.Name = "salaryPage";
            this.salaryPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salaryPage.Size = new System.Drawing.Size(822, 450);
            this.salaryPage.TabIndex = 2;
            this.salaryPage.Text = "Salary";
            this.salaryPage.UseVisualStyleBackColor = true;
            // 
            // employeeSalary
            // 
            this.employeeSalary.AllowUserToAddRows = false;
            this.employeeSalary.AllowUserToDeleteRows = false;
            this.employeeSalary.AllowUserToOrderColumns = true;
            this.employeeSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeSalary.Location = new System.Drawing.Point(3, 46);
            this.employeeSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(818, 404);
            this.employeeSalary.TabIndex = 0;
            this.employeeSalary.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeSalary_CellEndEdit);
            // 
            // infoPage
            // 
            this.infoPage.Controls.Add(this.employeeInfo);
            this.infoPage.Location = new System.Drawing.Point(4, 22);
            this.infoPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoPage.Name = "infoPage";
            this.infoPage.Size = new System.Drawing.Size(822, 450);
            this.infoPage.TabIndex = 3;
            this.infoPage.Text = "Info";
            this.infoPage.UseVisualStyleBackColor = true;
            // 
            // employeeInfo
            // 
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
            // showAll2
            // 
            this.showAll2.Location = new System.Drawing.Point(430, 27);
            this.showAll2.Name = "showAll2";
            this.showAll2.Size = new System.Drawing.Size(82, 23);
            this.showAll2.TabIndex = 4;
            this.showAll2.Text = "show all";
            this.showAll2.UseVisualStyleBackColor = true;
            this.showAll2.Click += new System.EventHandler(this.showAll2_Click);
            // 
            // submitButton3
            // 
            this.submitButton3.Location = new System.Drawing.Point(313, 27);
            this.submitButton3.Name = "submitButton3";
            this.submitButton3.Size = new System.Drawing.Size(75, 23);
            this.submitButton3.TabIndex = 3;
            this.submitButton3.Text = "submit";
            this.submitButton3.UseVisualStyleBackColor = true;
            this.submitButton3.Click += new System.EventHandler(this.submitButton3_Click);
            // 
            // employeeIdBox3
            // 
            this.employeeIdBox3.Location = new System.Drawing.Point(189, 27);
            this.employeeIdBox3.Name = "employeeIdBox3";
            this.employeeIdBox3.Size = new System.Drawing.Size(100, 21);
            this.employeeIdBox3.TabIndex = 2;
            // 
            // employeeIdLabel3
            // 
            this.employeeIdLabel3.AutoSize = true;
            this.employeeIdLabel3.Location = new System.Drawing.Point(80, 37);
            this.employeeIdLabel3.Name = "employeeIdLabel3";
            this.employeeIdLabel3.Size = new System.Drawing.Size(103, 15);
            this.employeeIdLabel3.TabIndex = 1;
            this.employeeIdLabel3.Text = "Employee id:";
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
            // performButton
            // 
            this.performButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("performButton.BackgroundImage")));
            this.performButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.performButton.FlatAppearance.BorderSize = 0;
            this.performButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.performButton.Font = new System.Drawing.Font("STHupo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.performButton.ForeColor = System.Drawing.Color.White;
            this.performButton.Location = new System.Drawing.Point(9, 2);
            this.performButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.performButton.Name = "performButton";
            this.performButton.Size = new System.Drawing.Size(98, 20);
            this.performButton.TabIndex = 4;
            this.performButton.Text = "Employ Perform";
            this.performButton.UseVisualStyleBackColor = true;
            this.performButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // jobButton
            // 
            this.jobButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jobButton.BackgroundImage")));
            this.jobButton.Font = new System.Drawing.Font("STHupo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jobButton.ForeColor = System.Drawing.Color.White;
            this.jobButton.Location = new System.Drawing.Point(126, 2);
            this.jobButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobButton.Name = "jobButton";
            this.jobButton.Size = new System.Drawing.Size(98, 20);
            this.jobButton.TabIndex = 5;
            this.jobButton.Text = "Job Title";
            this.jobButton.UseVisualStyleBackColor = true;
            this.jobButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // salaryButton
            // 
            this.salaryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salaryButton.BackgroundImage")));
            this.salaryButton.Font = new System.Drawing.Font("STHupo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salaryButton.ForeColor = System.Drawing.Color.White;
            this.salaryButton.Location = new System.Drawing.Point(250, 1);
            this.salaryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(98, 20);
            this.salaryButton.TabIndex = 6;
            this.salaryButton.Text = "Salary";
            this.salaryButton.UseVisualStyleBackColor = true;
            this.salaryButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoButton.BackgroundImage")));
            this.infoButton.Font = new System.Drawing.Font("STHupo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Location = new System.Drawing.Point(364, 1);
            this.infoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(98, 20);
            this.infoButton.TabIndex = 7;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // employeePerform
            // 
            this.employeePerform.AllowUserToAddRows = false;
            this.employeePerform.AllowUserToDeleteRows = false;
            this.employeePerform.AllowUserToOrderColumns = true;
            this.employeePerform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeePerform.Location = new System.Drawing.Point(638, 13);
            this.employeePerform.Name = "employeePerform";
            this.employeePerform.RowTemplate.Height = 27;
            this.employeePerform.Size = new System.Drawing.Size(465, 553);
            this.employeePerform.TabIndex = 11;
            // 
            // HrManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 479);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.jobButton);
            this.Controls.Add(this.performButton);
            this.Controls.Add(this.panel1);
            this.Name = "HrManage";
            this.Text = "HrManage";
            this.employPerform.ResumeLayout(false);
            this.performPage.ResumeLayout(false);
            this.performPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.jobPage.ResumeLayout(false);
            this.jobPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).EndInit();
            this.salaryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).EndInit();
            this.infoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeePerform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl employPerform;
        private System.Windows.Forms.TabPage performPage;
        private System.Windows.Forms.TabPage jobPage;
        private System.Windows.Forms.TabPage salaryPage;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.TextBox employeeIdBox;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.RadioButton nagetiveRadio;
        private System.Windows.Forms.RadioButton positiveRadio;
        private System.Windows.Forms.Label rateTypeLabel;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridView employeeInfo;
        private System.Windows.Forms.DataGridView employeeJobTitle;
        private System.Windows.Forms.DataGridView employeeSalary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button performButton;
        private System.Windows.Forms.Button jobButton;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label employeeIdLabel2;
        private System.Windows.Forms.TextBox employeeIdBox2;
        private System.Windows.Forms.Button submitButton2;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.Label employeeIdLabel3;
        private System.Windows.Forms.TextBox employeeIdBox3;
        private System.Windows.Forms.Button submitButton3;
        private System.Windows.Forms.Button showAll2;
        private System.Windows.Forms.DataGridView employeePerform;

        //-K
        
        //-K
        
    }
}

