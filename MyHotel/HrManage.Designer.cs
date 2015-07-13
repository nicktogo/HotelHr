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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.employeeInfo = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobTitleMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.promoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employPerform.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.employPerform.Name = "employPerform";
            this.employPerform.SelectedIndex = 0;
            this.employPerform.Size = new System.Drawing.Size(930, 479);
            this.employPerform.TabIndex = 2;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employ Perform";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(208, 166);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(119, 111);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(312, 21);
            this.reasonBox.TabIndex = 6;
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(38, 120);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(47, 12);
            this.reasonLabel.TabIndex = 5;
            this.reasonLabel.Text = "Reason:";
            // 
            // nagetiveRadio
            // 
            this.nagetiveRadio.AutoSize = true;
            this.nagetiveRadio.Location = new System.Drawing.Point(208, 74);
            this.nagetiveRadio.Name = "nagetiveRadio";
            this.nagetiveRadio.Size = new System.Drawing.Size(71, 16);
            this.nagetiveRadio.TabIndex = 4;
            this.nagetiveRadio.TabStop = true;
            this.nagetiveRadio.Text = "Negative";
            this.nagetiveRadio.UseVisualStyleBackColor = true;
            // 
            // positiveRadio
            // 
            this.positiveRadio.AutoSize = true;
            this.positiveRadio.Location = new System.Drawing.Point(119, 74);
            this.positiveRadio.Name = "positiveRadio";
            this.positiveRadio.Size = new System.Drawing.Size(71, 16);
            this.positiveRadio.TabIndex = 3;
            this.positiveRadio.TabStop = true;
            this.positiveRadio.Text = "Positive";
            this.positiveRadio.UseVisualStyleBackColor = true;
            // 
            // rateTypeLabel
            // 
            this.rateTypeLabel.AutoSize = true;
            this.rateTypeLabel.Location = new System.Drawing.Point(38, 76);
            this.rateTypeLabel.Name = "rateTypeLabel";
            this.rateTypeLabel.Size = new System.Drawing.Size(65, 12);
            this.rateTypeLabel.TabIndex = 2;
            this.rateTypeLabel.Text = "Rate type:";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(36, 30);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(77, 12);
            this.employeeIdLabel.TabIndex = 1;
            this.employeeIdLabel.Text = "Employee id:";
            // 
            // employeeIdBox
            // 
            this.employeeIdBox.Location = new System.Drawing.Point(119, 27);
            this.employeeIdBox.Name = "employeeIdBox";
            this.employeeIdBox.Size = new System.Drawing.Size(27, 21);
            this.employeeIdBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Job Title";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Salary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.employeeInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(922, 453);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // employeeInfo
            // 
            this.employeeInfo.AllowUserToOrderColumns = true;
            this.employeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeInfo.Location = new System.Drawing.Point(4, 26);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.RowTemplate.Height = 23;
            this.employeeInfo.Size = new System.Drawing.Size(918, 424);
            this.employeeInfo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(916, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // jobTitleMenuStrip
            // 
            this.jobTitleMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promoteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.jobTitleMenuStrip.Name = "jobTitleMenuStrip";
            this.jobTitleMenuStrip.Size = new System.Drawing.Size(127, 48);
            // 
            // promoteToolStripMenuItem
            // 
            this.promoteToolStripMenuItem.Name = "promoteToolStripMenuItem";
            this.promoteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.promoteToolStripMenuItem.Text = "Promote";
            this.promoteToolStripMenuItem.Click += new System.EventHandler(this.promoteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // HrManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 479);
            this.Controls.Add(this.employPerform);
            this.Name = "HrManage";
            this.Text = "HrManage";
            this.employPerform.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip jobTitleMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem promoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

