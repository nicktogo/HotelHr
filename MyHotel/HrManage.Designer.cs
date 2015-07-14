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
            this.employPerform = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.submitButton = new System.Windows.Forms.Button();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.nagetiveRadio = new System.Windows.Forms.RadioButton();
            this.positiveRadio = new System.Windows.Forms.RadioButton();
            this.rateTypeLabel = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.employeeIdBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.showAll = new System.Windows.Forms.Button();
            this.submitButton2 = new System.Windows.Forms.Button();
            this.employeeIdBox2 = new System.Windows.Forms.TextBox();
            this.employeeIdLabel2 = new System.Windows.Forms.Label();
            this.employeeJobTitle = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.employeeSalary = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeInfo = new System.Windows.Forms.DataGridView();
            this.jobTitleMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.promoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employPerform.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).BeginInit();
            this.jobTitleMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // employPerform
            // 
            this.employPerform.Controls.Add(this.tabPage1);
            this.employPerform.Controls.Add(this.tabPage2);
            this.employPerform.Controls.Add(this.tabPage3);
            this.employPerform.Controls.Add(this.tabPage4);
            this.employPerform.Location = new System.Drawing.Point(1, 0);
            this.employPerform.Margin = new System.Windows.Forms.Padding(4);
            this.employPerform.Name = "employPerform";
            this.employPerform.SelectedIndex = 0;
            this.employPerform.Size = new System.Drawing.Size(1240, 599);
            this.employPerform.TabIndex = 2;
            this.employPerform.SelectedIndexChanged += new System.EventHandler(this.employPerform_SelectedIndexChanged);
            this.employPerform.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.employPerform_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.submitButton);
            this.tabPage1.Controls.Add(this.reasonBox);
            this.tabPage1.Controls.Add(this.reasonLabel);
            this.tabPage1.Controls.Add(this.nagetiveRadio);
            this.tabPage1.Controls.Add(this.positiveRadio);
            this.tabPage1.Controls.Add(this.rateTypeLabel);
            this.tabPage1.Controls.Add(this.employeeIdLabel);
            this.tabPage1.Controls.Add(this.employeeIdBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1232, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employ Perform";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(277, 208);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 29);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(159, 139);
            this.reasonBox.Margin = new System.Windows.Forms.Padding(4);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(415, 25);
            this.reasonBox.TabIndex = 6;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(51, 150);
            this.reasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(63, 15);
            this.reasonLabel.TabIndex = 5;
            this.reasonLabel.Text = "Reason:";
            // 
            // nagetiveRadio
            // 
            this.nagetiveRadio.AutoSize = true;
            this.nagetiveRadio.Location = new System.Drawing.Point(277, 92);
            this.nagetiveRadio.Margin = new System.Windows.Forms.Padding(4);
            this.nagetiveRadio.Name = "nagetiveRadio";
            this.nagetiveRadio.Size = new System.Drawing.Size(92, 19);
            this.nagetiveRadio.TabIndex = 4;
            this.nagetiveRadio.TabStop = true;
            this.nagetiveRadio.Text = "Negative";
            this.nagetiveRadio.UseVisualStyleBackColor = true;
            // 
            // positiveRadio
            // 
            this.positiveRadio.AutoSize = true;
            this.positiveRadio.Location = new System.Drawing.Point(159, 92);
            this.positiveRadio.Margin = new System.Windows.Forms.Padding(4);
            this.positiveRadio.Name = "positiveRadio";
            this.positiveRadio.Size = new System.Drawing.Size(92, 19);
            this.positiveRadio.TabIndex = 3;
            this.positiveRadio.TabStop = true;
            this.positiveRadio.Text = "Positive";
            this.positiveRadio.UseVisualStyleBackColor = true;
            // 
            // rateTypeLabel
            // 
            this.rateTypeLabel.AutoSize = true;
            this.rateTypeLabel.Location = new System.Drawing.Point(51, 95);
            this.rateTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateTypeLabel.Name = "rateTypeLabel";
            this.rateTypeLabel.Size = new System.Drawing.Size(87, 15);
            this.rateTypeLabel.TabIndex = 2;
            this.rateTypeLabel.Text = "Rate type:";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(48, 38);
            this.employeeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(103, 15);
            this.employeeIdLabel.TabIndex = 1;
            this.employeeIdLabel.Text = "Employee id:";
            // 
            // employeeIdBox
            // 
            this.employeeIdBox.Location = new System.Drawing.Point(159, 34);
            this.employeeIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeeIdBox.Name = "employeeIdBox";
            this.employeeIdBox.Size = new System.Drawing.Size(35, 25);
            this.employeeIdBox.TabIndex = 0;
            this.employeeIdBox.TextChanged += new System.EventHandler(this.employeeIdBox_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.showAll);
            this.tabPage2.Controls.Add(this.submitButton2);
            this.tabPage2.Controls.Add(this.employeeIdBox2);
            this.tabPage2.Controls.Add(this.employeeIdLabel2);
            this.tabPage2.Controls.Add(this.employeeJobTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1232, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Job Title";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.employeeIdBox2.Size = new System.Drawing.Size(100, 25);
            this.employeeIdBox2.TabIndex = 2;
            // 
            // employeeIdLabel2
            // 
            this.employeeIdLabel2.AutoSize = true;
            this.employeeIdLabel2.Location = new System.Drawing.Point(54, 16);
            this.employeeIdLabel2.Name = "employeeIdLabel2";
            this.employeeIdLabel2.Size = new System.Drawing.Size(103, 15);
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
            this.employeeJobTitle.Location = new System.Drawing.Point(4, 35);
            this.employeeJobTitle.Margin = new System.Windows.Forms.Padding(4);
            this.employeeJobTitle.Name = "employeeJobTitle";
            this.employeeJobTitle.RowTemplate.Height = 23;
            this.employeeJobTitle.Size = new System.Drawing.Size(1221, 528);
            this.employeeJobTitle.TabIndex = 0;
            this.employeeJobTitle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.employeeJobTitle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeJobTitle_CellEndEdit);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.employeeSalary);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1232, 570);
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
            this.employeeSalary.Location = new System.Drawing.Point(4, 4);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(1224, 562);
            this.employeeSalary.TabIndex = 0;
            this.employeeSalary.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeSalary_CellEndEdit);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.employeeInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1232, 570);
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
            this.employeeInfo.Location = new System.Drawing.Point(5, 32);
            this.employeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.ReadOnly = true;
            this.employeeInfo.RowTemplate.Height = 23;
            this.employeeInfo.Size = new System.Drawing.Size(1224, 530);
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
            this.jobTitleMenuStrip.Size = new System.Drawing.Size(149, 56);
            // 
            // promoteToolStripMenuItem
            // 
            this.promoteToolStripMenuItem.Name = "promoteToolStripMenuItem";
            this.promoteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.promoteToolStripMenuItem.Text = "Promote";
            this.promoteToolStripMenuItem.Click += new System.EventHandler(this.promoteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // HrManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 599);
            this.Controls.Add(this.employPerform);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HrManage";
            this.Text = "HrManage";
            this.employPerform.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).EndInit();
            this.jobTitleMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Label employeeIdLabel2;
        private System.Windows.Forms.TextBox employeeIdBox2;
        private System.Windows.Forms.Button submitButton2;
        private System.Windows.Forms.Button showAll;
        //-K
        
        //-K
        
    }
}

