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
            this.employeePerform = new System.Windows.Forms.DataGridView();
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
            this.submitButton2 = new System.Windows.Forms.Button();
            this.employeeIdBox2 = new System.Windows.Forms.TextBox();
            this.employeeIdLabel2 = new System.Windows.Forms.Label();
            this.employeeJobTitle = new System.Windows.Forms.DataGridView();
            this.salaryPage = new System.Windows.Forms.TabPage();
            this.submitButton3 = new System.Windows.Forms.Button();
            this.employeeIdBox3 = new System.Windows.Forms.TextBox();
            this.showAll2 = new System.Windows.Forms.Button();
            this.employeeIdLabel3 = new System.Windows.Forms.Label();
            this.employeeSalary = new System.Windows.Forms.DataGridView();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.employeeInfo = new System.Windows.Forms.DataGridView();
            this.showAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.performButton = new System.Windows.Forms.Button();
            this.jobButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.employPerform.SuspendLayout();
            this.performPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePerform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.jobPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).BeginInit();
            this.salaryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).BeginInit();
            this.infoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employPerform
            // 
            this.employPerform.Controls.Add(this.performPage);
            this.employPerform.Controls.Add(this.jobPage);
            this.employPerform.Controls.Add(this.salaryPage);
            this.employPerform.Controls.Add(this.infoPage);
            this.employPerform.Controls.Add(this.tabPage1);
            this.employPerform.Controls.Add(this.tabPage2);
            this.employPerform.Location = new System.Drawing.Point(3, -29);
            this.employPerform.Name = "employPerform";
            this.employPerform.SelectedIndex = 0;
            this.employPerform.Size = new System.Drawing.Size(830, 475);
            this.employPerform.TabIndex = 2;
            this.employPerform.SelectedIndexChanged += new System.EventHandler(this.employPerform_SelectedIndexChanged);
            this.employPerform.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.employPerform_Selecting);
            // 
            // performPage
            // 
            this.performPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("performPage.BackgroundImage")));
            this.performPage.Controls.Add(this.employeePerform);
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
            this.performPage.Margin = new System.Windows.Forms.Padding(2);
            this.performPage.Name = "performPage";
            this.performPage.Padding = new System.Windows.Forms.Padding(2);
            this.performPage.Size = new System.Drawing.Size(822, 449);
            this.performPage.TabIndex = 0;
            this.performPage.Text = "Employ Perform";
            this.performPage.UseVisualStyleBackColor = true;
            // 
            // employeePerform
            // 
            this.employeePerform.AllowUserToAddRows = false;
            this.employeePerform.AllowUserToDeleteRows = false;
            this.employeePerform.AllowUserToOrderColumns = true;
            this.employeePerform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeePerform.Location = new System.Drawing.Point(521, 8);
            this.employeePerform.Name = "employeePerform";
            this.employeePerform.RowTemplate.Height = 27;
            this.employeePerform.Size = new System.Drawing.Size(305, 446);
            this.employeePerform.TabIndex = 11;
            this.employeePerform.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeePerform_CellValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(242, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitButton.Location = new System.Drawing.Point(152, 329);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.reasonBox.Location = new System.Drawing.Point(151, 171);
            this.reasonBox.Margin = new System.Windows.Forms.Padding(2);
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
            this.reasonLabel.Location = new System.Drawing.Point(17, 171);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(87, 24);
            this.reasonLabel.TabIndex = 5;
            this.reasonLabel.Text = "Reason:";
            // 
            // nagetiveRadio
            // 
            this.nagetiveRadio.AutoSize = true;
            this.nagetiveRadio.Location = new System.Drawing.Point(226, 125);
            this.nagetiveRadio.Name = "nagetiveRadio";
            this.nagetiveRadio.Size = new System.Drawing.Size(14, 13);
            this.nagetiveRadio.TabIndex = 4;
            this.nagetiveRadio.TabStop = true;
            this.nagetiveRadio.UseVisualStyleBackColor = true;
            // 
            // positiveRadio
            // 
            this.positiveRadio.AutoSize = true;
            this.positiveRadio.Location = new System.Drawing.Point(151, 124);
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
            this.rateTypeLabel.Location = new System.Drawing.Point(17, 116);
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
            // 
            // jobPage
            // 
            this.jobPage.Controls.Add(this.submitButton2);
            this.jobPage.Controls.Add(this.employeeIdBox2);
            this.jobPage.Controls.Add(this.employeeIdLabel2);
            this.jobPage.Controls.Add(this.employeeJobTitle);
            this.jobPage.Location = new System.Drawing.Point(4, 22);
            this.jobPage.Margin = new System.Windows.Forms.Padding(2);
            this.jobPage.Name = "jobPage";
            this.jobPage.Padding = new System.Windows.Forms.Padding(2);
            this.jobPage.Size = new System.Drawing.Size(822, 449);
            this.jobPage.TabIndex = 1;
            this.jobPage.Text = "Job Title";
            this.jobPage.UseVisualStyleBackColor = true;
            // 
            // submitButton2
            // 
            this.submitButton2.Location = new System.Drawing.Point(312, 25);
            this.submitButton2.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton2.Name = "submitButton2";
            this.submitButton2.Size = new System.Drawing.Size(75, 23);
            this.submitButton2.TabIndex = 3;
            this.submitButton2.Text = "submit";
            this.submitButton2.UseVisualStyleBackColor = true;
            this.submitButton2.Click += new System.EventHandler(this.submitButton2_Click);
            // 
            // employeeIdBox2
            // 
            this.employeeIdBox2.Location = new System.Drawing.Point(165, 27);
            this.employeeIdBox2.Margin = new System.Windows.Forms.Padding(2);
            this.employeeIdBox2.Name = "employeeIdBox2";
            this.employeeIdBox2.Size = new System.Drawing.Size(76, 21);
            this.employeeIdBox2.TabIndex = 2;
            // 
            // employeeIdLabel2
            // 
            this.employeeIdLabel2.AutoSize = true;
            this.employeeIdLabel2.Location = new System.Drawing.Point(60, 30);
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
            this.employeeJobTitle.Location = new System.Drawing.Point(76, 73);
            this.employeeJobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.employeeJobTitle.Name = "employeeJobTitle";
            this.employeeJobTitle.RowTemplate.Height = 23;
            this.employeeJobTitle.Size = new System.Drawing.Size(612, 331);
            this.employeeJobTitle.TabIndex = 0;
            this.employeeJobTitle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.employeeJobTitle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeJobTitle_CellEndEdit);
            // 
            // salaryPage
            // 
            this.salaryPage.Controls.Add(this.submitButton3);
            this.salaryPage.Controls.Add(this.employeeIdBox3);
            this.salaryPage.Controls.Add(this.showAll2);
            this.salaryPage.Controls.Add(this.employeeIdLabel3);
            this.salaryPage.Controls.Add(this.employeeSalary);
            this.salaryPage.Location = new System.Drawing.Point(4, 22);
            this.salaryPage.Margin = new System.Windows.Forms.Padding(2);
            this.salaryPage.Name = "salaryPage";
            this.salaryPage.Padding = new System.Windows.Forms.Padding(2);
            this.salaryPage.Size = new System.Drawing.Size(822, 449);
            this.salaryPage.TabIndex = 2;
            this.salaryPage.Text = "Salary";
            this.salaryPage.UseVisualStyleBackColor = true;
            // 
            // submitButton3
            // 
            this.submitButton3.Location = new System.Drawing.Point(393, 18);
            this.submitButton3.Name = "submitButton3";
            this.submitButton3.Size = new System.Drawing.Size(75, 23);
            this.submitButton3.TabIndex = 3;
            this.submitButton3.Text = "Search";
            this.submitButton3.UseVisualStyleBackColor = true;
            this.submitButton3.Click += new System.EventHandler(this.submitButton3_Click);
            // 
            // employeeIdBox3
            // 
            this.employeeIdBox3.Location = new System.Drawing.Point(247, 20);
            this.employeeIdBox3.Name = "employeeIdBox3";
            this.employeeIdBox3.Size = new System.Drawing.Size(100, 21);
            this.employeeIdBox3.TabIndex = 2;
            // 
            // showAll2
            // 
            this.showAll2.Location = new System.Drawing.Point(516, 18);
            this.showAll2.Name = "showAll2";
            this.showAll2.Size = new System.Drawing.Size(82, 23);
            this.showAll2.TabIndex = 4;
            this.showAll2.Text = "Show all";
            this.showAll2.UseVisualStyleBackColor = true;
            this.showAll2.Click += new System.EventHandler(this.showAll2_Click);
            // 
            // employeeIdLabel3
            // 
            this.employeeIdLabel3.AutoSize = true;
            this.employeeIdLabel3.Location = new System.Drawing.Point(122, 24);
            this.employeeIdLabel3.Name = "employeeIdLabel3";
            this.employeeIdLabel3.Size = new System.Drawing.Size(77, 12);
            this.employeeIdLabel3.TabIndex = 1;
            this.employeeIdLabel3.Text = "Employee id:";
            // 
            // employeeSalary
            // 
            this.employeeSalary.AllowUserToAddRows = false;
            this.employeeSalary.AllowUserToDeleteRows = false;
            this.employeeSalary.AllowUserToOrderColumns = true;
            this.employeeSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeSalary.Location = new System.Drawing.Point(70, 64);
            this.employeeSalary.Margin = new System.Windows.Forms.Padding(2);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(612, 351);
            this.employeeSalary.TabIndex = 0;
            this.employeeSalary.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeSalary_CellEndEdit);
            // 
            // infoPage
            // 
            this.infoPage.Controls.Add(this.employeeInfo);
            this.infoPage.Location = new System.Drawing.Point(4, 22);
            this.infoPage.Margin = new System.Windows.Forms.Padding(2);
            this.infoPage.Name = "infoPage";
            this.infoPage.Size = new System.Drawing.Size(822, 449);
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
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(457, 25);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(89, 23);
            this.showAll.TabIndex = 4;
            this.showAll.Text = "show all";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
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
            this.performButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.performButton.ForeColor = System.Drawing.Color.White;
            this.performButton.Location = new System.Drawing.Point(102, 3);
            this.performButton.Margin = new System.Windows.Forms.Padding(2);
            this.performButton.Name = "performButton";
            this.performButton.Size = new System.Drawing.Size(148, 25);
            this.performButton.TabIndex = 4;
            this.performButton.Text = "Employ Perform";
            this.performButton.UseVisualStyleBackColor = true;
            this.performButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // jobButton
            // 
            this.jobButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jobButton.BackgroundImage")));
            this.jobButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobButton.FlatAppearance.BorderSize = 0;
            this.jobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jobButton.ForeColor = System.Drawing.Color.White;
            this.jobButton.Location = new System.Drawing.Point(3, 3);
            this.jobButton.Margin = new System.Windows.Forms.Padding(2);
            this.jobButton.Name = "jobButton";
            this.jobButton.Size = new System.Drawing.Size(98, 25);
            this.jobButton.TabIndex = 5;
            this.jobButton.Text = "Comment";
            this.jobButton.UseVisualStyleBackColor = true;
            this.jobButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // salaryButton
            // 
            this.salaryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salaryButton.BackgroundImage")));
            this.salaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salaryButton.ForeColor = System.Drawing.Color.White;
            this.salaryButton.Location = new System.Drawing.Point(250, 3);
            this.salaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(98, 25);
            this.salaryButton.TabIndex = 6;
            this.salaryButton.Text = "HR switch";
            this.salaryButton.UseVisualStyleBackColor = true;
            this.salaryButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoButton.BackgroundImage")));
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Location = new System.Drawing.Point(347, 3);
            this.infoButton.Margin = new System.Windows.Forms.Padding(2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(98, 25);
            this.infoButton.TabIndex = 7;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 449);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(731, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 25);
            this.button5.TabIndex = 8;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee id：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 21);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "好评数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(181, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "好评率：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(175, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "0%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "差评数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(181, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(60, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "好评率：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(175, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "0%";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 417);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(445, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 25);
            this.button6.TabIndex = 9;
            this.button6.Text = "Pipeline";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            // 
            // HrManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.jobButton);
            this.Controls.Add(this.performButton);
            this.Controls.Add(this.panel1);
            this.Name = "HrManage";
            this.Text = "HR_Manage";
            this.employPerform.ResumeLayout(false);
            this.performPage.ResumeLayout(false);
            this.performPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeePerform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.jobPage.ResumeLayout(false);
            this.jobPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeJobTitle)).EndInit();
            this.salaryPage.ResumeLayout(false);
            this.salaryPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSalary)).EndInit();
            this.infoPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;

        //-K
        
        //-K
        
    }
}

