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
            this.showAll = new System.Windows.Forms.Button();
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
            this.btn_infoDelete = new System.Windows.Forms.Button();
            this.tb_infoEMPLOY_ID2 = new System.Windows.Forms.TextBox();
            this.l_infoEMPLOY_ID2 = new System.Windows.Forms.Label();
            this.tb_infoPASSWORD = new System.Windows.Forms.TextBox();
            this.tb_infoSTATUS = new System.Windows.Forms.TextBox();
            this.tb_infoWORK_YEAR = new System.Windows.Forms.TextBox();
            this.tb_infoIN_DATE = new System.Windows.Forms.TextBox();
            this.tb_infoCITIZEN_ID = new System.Windows.Forms.TextBox();
            this.tb_infoADDRESS = new System.Windows.Forms.TextBox();
            this.tb_infoGENDER = new System.Windows.Forms.TextBox();
            this.tb_infoEMPLOY_NAME = new System.Windows.Forms.TextBox();
            this.tb_infoEMPLOY_ID = new System.Windows.Forms.TextBox();
            this.btn_newInfo = new System.Windows.Forms.Button();
            this.l_infoPASSWORD = new System.Windows.Forms.Label();
            this.l_infoSTATUS = new System.Windows.Forms.Label();
            this.l_infoWORK_YEAR = new System.Windows.Forms.Label();
            this.l_infoIN_DATE = new System.Windows.Forms.Label();
            this.l_infoCITIZEN_ID = new System.Windows.Forms.Label();
            this.l_infoADDRESS = new System.Windows.Forms.Label();
            this.l_infoGENDER = new System.Windows.Forms.Label();
            this.l_infoEMPLOY_NAME = new System.Windows.Forms.Label();
            this.l_infoEMPLOY_ID = new System.Windows.Forms.Label();
            this.employeeInfo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.performButton = new System.Windows.Forms.Button();
            this.jobButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
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
            this.SuspendLayout();
            // 
            // employPerform
            // 
            this.employPerform.Controls.Add(this.performPage);
            this.employPerform.Controls.Add(this.jobPage);
            this.employPerform.Controls.Add(this.salaryPage);
            this.employPerform.Controls.Add(this.infoPage);
            this.employPerform.Location = new System.Drawing.Point(4, -38);
            this.employPerform.Margin = new System.Windows.Forms.Padding(4);
            this.employPerform.Name = "employPerform";
            this.employPerform.SelectedIndex = 0;
            this.employPerform.Size = new System.Drawing.Size(1107, 595);
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
            this.performPage.Location = new System.Drawing.Point(4, 25);
            this.performPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.performPage.Name = "performPage";
            this.performPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.performPage.Size = new System.Drawing.Size(1099, 566);
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
            this.employeePerform.Location = new System.Drawing.Point(695, 10);
            this.employeePerform.Margin = new System.Windows.Forms.Padding(4);
            this.employeePerform.Name = "employeePerform";
            this.employeePerform.RowTemplate.Height = 27;
            this.employeePerform.Size = new System.Drawing.Size(407, 558);
            this.employeePerform.TabIndex = 11;
            this.employeePerform.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeePerform_CellValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 142);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 39);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.submitButton.Location = new System.Drawing.Point(203, 411);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(119, 42);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // reasonBox
            // 
            this.reasonBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reasonBox.Location = new System.Drawing.Point(201, 214);
            this.reasonBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reasonBox.Multiline = true;
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(427, 174);
            this.reasonBox.TabIndex = 6;
            this.reasonBox.Tag = "";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reasonLabel.ForeColor = System.Drawing.Color.White;
            this.reasonLabel.Location = new System.Drawing.Point(23, 214);
            this.reasonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(109, 29);
            this.reasonLabel.TabIndex = 5;
            this.reasonLabel.Text = "Reason:";
            // 
            // nagetiveRadio
            // 
            this.nagetiveRadio.AutoSize = true;
            this.nagetiveRadio.Location = new System.Drawing.Point(301, 156);
            this.nagetiveRadio.Margin = new System.Windows.Forms.Padding(4);
            this.nagetiveRadio.Name = "nagetiveRadio";
            this.nagetiveRadio.Size = new System.Drawing.Size(17, 16);
            this.nagetiveRadio.TabIndex = 4;
            this.nagetiveRadio.TabStop = true;
            this.nagetiveRadio.UseVisualStyleBackColor = true;
            // 
            // positiveRadio
            // 
            this.positiveRadio.AutoSize = true;
            this.positiveRadio.Location = new System.Drawing.Point(201, 155);
            this.positiveRadio.Margin = new System.Windows.Forms.Padding(4);
            this.positiveRadio.Name = "positiveRadio";
            this.positiveRadio.Size = new System.Drawing.Size(17, 16);
            this.positiveRadio.TabIndex = 3;
            this.positiveRadio.TabStop = true;
            this.positiveRadio.UseVisualStyleBackColor = true;
            // 
            // rateTypeLabel
            // 
            this.rateTypeLabel.AutoSize = true;
            this.rateTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rateTypeLabel.ForeColor = System.Drawing.Color.White;
            this.rateTypeLabel.Location = new System.Drawing.Point(23, 145);
            this.rateTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rateTypeLabel.Name = "rateTypeLabel";
            this.rateTypeLabel.Size = new System.Drawing.Size(130, 29);
            this.rateTypeLabel.TabIndex = 2;
            this.rateTypeLabel.Text = "Rate type:";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.employeeIdLabel.ForeColor = System.Drawing.Color.White;
            this.employeeIdLabel.Location = new System.Drawing.Point(23, 79);
            this.employeeIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(166, 29);
            this.employeeIdLabel.TabIndex = 1;
            this.employeeIdLabel.Text = "Employee id:";
            // 
            // employeeIdBox
            // 
            this.employeeIdBox.Location = new System.Drawing.Point(203, 79);
            this.employeeIdBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeeIdBox.Name = "employeeIdBox";
            this.employeeIdBox.Size = new System.Drawing.Size(193, 25);
            this.employeeIdBox.TabIndex = 0;
            // 
            // jobPage
            // 
            this.jobPage.Controls.Add(this.submitButton2);
            this.jobPage.Controls.Add(this.showAll);
            this.jobPage.Controls.Add(this.employeeIdBox2);
            this.jobPage.Controls.Add(this.employeeIdLabel2);
            this.jobPage.Controls.Add(this.employeeJobTitle);
            this.jobPage.Location = new System.Drawing.Point(4, 25);
            this.jobPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobPage.Name = "jobPage";
            this.jobPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobPage.Size = new System.Drawing.Size(1099, 566);
            this.jobPage.TabIndex = 1;
            this.jobPage.Text = "Job Title";
            this.jobPage.UseVisualStyleBackColor = true;
            // 
            // submitButton2
            // 
            this.submitButton2.Location = new System.Drawing.Point(416, 31);
            this.submitButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton2.Name = "submitButton2";
            this.submitButton2.Size = new System.Drawing.Size(100, 29);
            this.submitButton2.TabIndex = 3;
            this.submitButton2.Text = "submit";
            this.submitButton2.UseVisualStyleBackColor = true;
            this.submitButton2.Click += new System.EventHandler(this.submitButton2_Click);
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
            // employeeIdBox2
            // 
            this.employeeIdBox2.Location = new System.Drawing.Point(220, 34);
            this.employeeIdBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeIdBox2.Name = "employeeIdBox2";
            this.employeeIdBox2.Size = new System.Drawing.Size(100, 25);
            this.employeeIdBox2.TabIndex = 2;
            // 
            // employeeIdLabel2
            // 
            this.employeeIdLabel2.AutoSize = true;
            this.employeeIdLabel2.Location = new System.Drawing.Point(80, 38);
            this.employeeIdLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.employeeJobTitle.Location = new System.Drawing.Point(101, 91);
            this.employeeJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeJobTitle.Name = "employeeJobTitle";
            this.employeeJobTitle.RowTemplate.Height = 23;
            this.employeeJobTitle.Size = new System.Drawing.Size(816, 414);
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
            this.salaryPage.Location = new System.Drawing.Point(4, 25);
            this.salaryPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryPage.Name = "salaryPage";
            this.salaryPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryPage.Size = new System.Drawing.Size(1099, 566);
            this.salaryPage.TabIndex = 2;
            this.salaryPage.Text = "Salary";
            this.salaryPage.UseVisualStyleBackColor = true;
            // 
            // submitButton3
            // 
            this.submitButton3.Location = new System.Drawing.Point(409, 22);
            this.submitButton3.Margin = new System.Windows.Forms.Padding(4);
            this.submitButton3.Name = "submitButton3";
            this.submitButton3.Size = new System.Drawing.Size(100, 29);
            this.submitButton3.TabIndex = 3;
            this.submitButton3.Text = "Search";
            this.submitButton3.UseVisualStyleBackColor = true;
            this.submitButton3.Click += new System.EventHandler(this.submitButton3_Click);
            // 
            // employeeIdBox3
            // 
            this.employeeIdBox3.Location = new System.Drawing.Point(219, 28);
            this.employeeIdBox3.Margin = new System.Windows.Forms.Padding(4);
            this.employeeIdBox3.Name = "employeeIdBox3";
            this.employeeIdBox3.Size = new System.Drawing.Size(132, 25);
            this.employeeIdBox3.TabIndex = 2;
            // 
            // showAll2
            // 
            this.showAll2.Location = new System.Drawing.Point(553, 22);
            this.showAll2.Margin = new System.Windows.Forms.Padding(4);
            this.showAll2.Name = "showAll2";
            this.showAll2.Size = new System.Drawing.Size(109, 29);
            this.showAll2.TabIndex = 4;
            this.showAll2.Text = "Show all";
            this.showAll2.UseVisualStyleBackColor = true;
            this.showAll2.Click += new System.EventHandler(this.showAll2_Click);
            // 
            // employeeIdLabel3
            // 
            this.employeeIdLabel3.AutoSize = true;
            this.employeeIdLabel3.Location = new System.Drawing.Point(163, 30);
            this.employeeIdLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeIdLabel3.Name = "employeeIdLabel3";
            this.employeeIdLabel3.Size = new System.Drawing.Size(103, 15);
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
            this.employeeSalary.Location = new System.Drawing.Point(92, 69);
            this.employeeSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.Size = new System.Drawing.Size(816, 439);
            this.employeeSalary.TabIndex = 0;
            this.employeeSalary.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeSalary_CellEndEdit);
            // 
            // infoPage
            // 
            this.infoPage.Controls.Add(this.btn_infoDelete);
            this.infoPage.Controls.Add(this.tb_infoEMPLOY_ID2);
            this.infoPage.Controls.Add(this.l_infoEMPLOY_ID2);
            this.infoPage.Controls.Add(this.tb_infoPASSWORD);
            this.infoPage.Controls.Add(this.tb_infoSTATUS);
            this.infoPage.Controls.Add(this.tb_infoWORK_YEAR);
            this.infoPage.Controls.Add(this.tb_infoIN_DATE);
            this.infoPage.Controls.Add(this.tb_infoCITIZEN_ID);
            this.infoPage.Controls.Add(this.tb_infoADDRESS);
            this.infoPage.Controls.Add(this.tb_infoGENDER);
            this.infoPage.Controls.Add(this.tb_infoEMPLOY_NAME);
            this.infoPage.Controls.Add(this.tb_infoEMPLOY_ID);
            this.infoPage.Controls.Add(this.btn_newInfo);
            this.infoPage.Controls.Add(this.l_infoPASSWORD);
            this.infoPage.Controls.Add(this.l_infoSTATUS);
            this.infoPage.Controls.Add(this.l_infoWORK_YEAR);
            this.infoPage.Controls.Add(this.l_infoIN_DATE);
            this.infoPage.Controls.Add(this.l_infoCITIZEN_ID);
            this.infoPage.Controls.Add(this.l_infoADDRESS);
            this.infoPage.Controls.Add(this.l_infoGENDER);
            this.infoPage.Controls.Add(this.l_infoEMPLOY_NAME);
            this.infoPage.Controls.Add(this.l_infoEMPLOY_ID);
            this.infoPage.Controls.Add(this.employeeInfo);
            this.infoPage.Location = new System.Drawing.Point(4, 25);
            this.infoPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoPage.Name = "infoPage";
            this.infoPage.Size = new System.Drawing.Size(1099, 566);
            this.infoPage.TabIndex = 3;
            this.infoPage.Text = "Info";
            this.infoPage.UseVisualStyleBackColor = true;
            // 
            // btn_infoDelete
            // 
            this.btn_infoDelete.Location = new System.Drawing.Point(981, 56);
            this.btn_infoDelete.Name = "btn_infoDelete";
            this.btn_infoDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_infoDelete.TabIndex = 22;
            this.btn_infoDelete.Text = "delete";
            this.btn_infoDelete.UseVisualStyleBackColor = true;
            this.btn_infoDelete.Click += new System.EventHandler(this.btn_infoDelete_Click);
            // 
            // tb_infoEMPLOY_ID2
            // 
            this.tb_infoEMPLOY_ID2.Location = new System.Drawing.Point(899, 57);
            this.tb_infoEMPLOY_ID2.Name = "tb_infoEMPLOY_ID2";
            this.tb_infoEMPLOY_ID2.Size = new System.Drawing.Size(76, 25);
            this.tb_infoEMPLOY_ID2.TabIndex = 21;
            // 
            // l_infoEMPLOY_ID2
            // 
            this.l_infoEMPLOY_ID2.AutoSize = true;
            this.l_infoEMPLOY_ID2.Location = new System.Drawing.Point(896, 28);
            this.l_infoEMPLOY_ID2.Name = "l_infoEMPLOY_ID2";
            this.l_infoEMPLOY_ID2.Size = new System.Drawing.Size(79, 15);
            this.l_infoEMPLOY_ID2.TabIndex = 20;
            this.l_infoEMPLOY_ID2.Text = "EMPLOY_ID";
            // 
            // tb_infoPASSWORD
            // 
            this.tb_infoPASSWORD.Location = new System.Drawing.Point(652, 58);
            this.tb_infoPASSWORD.Name = "tb_infoPASSWORD";
            this.tb_infoPASSWORD.Size = new System.Drawing.Size(68, 25);
            this.tb_infoPASSWORD.TabIndex = 19;
            // 
            // tb_infoSTATUS
            // 
            this.tb_infoSTATUS.Location = new System.Drawing.Point(591, 58);
            this.tb_infoSTATUS.Name = "tb_infoSTATUS";
            this.tb_infoSTATUS.Size = new System.Drawing.Size(52, 25);
            this.tb_infoSTATUS.TabIndex = 18;
            // 
            // tb_infoWORK_YEAR
            // 
            this.tb_infoWORK_YEAR.Location = new System.Drawing.Point(506, 58);
            this.tb_infoWORK_YEAR.Name = "tb_infoWORK_YEAR";
            this.tb_infoWORK_YEAR.Size = new System.Drawing.Size(76, 25);
            this.tb_infoWORK_YEAR.TabIndex = 17;
            // 
            // tb_infoIN_DATE
            // 
            this.tb_infoIN_DATE.Location = new System.Drawing.Point(437, 58);
            this.tb_infoIN_DATE.Name = "tb_infoIN_DATE";
            this.tb_infoIN_DATE.Size = new System.Drawing.Size(60, 25);
            this.tb_infoIN_DATE.TabIndex = 16;
            // 
            // tb_infoCITIZEN_ID
            // 
            this.tb_infoCITIZEN_ID.Location = new System.Drawing.Point(344, 58);
            this.tb_infoCITIZEN_ID.Name = "tb_infoCITIZEN_ID";
            this.tb_infoCITIZEN_ID.Size = new System.Drawing.Size(84, 25);
            this.tb_infoCITIZEN_ID.TabIndex = 15;
            // 
            // tb_infoADDRESS
            // 
            this.tb_infoADDRESS.Location = new System.Drawing.Point(275, 58);
            this.tb_infoADDRESS.Name = "tb_infoADDRESS";
            this.tb_infoADDRESS.Size = new System.Drawing.Size(60, 25);
            this.tb_infoADDRESS.TabIndex = 14;
            // 
            // tb_infoGENDER
            // 
            this.tb_infoGENDER.Location = new System.Drawing.Point(214, 58);
            this.tb_infoGENDER.Name = "tb_infoGENDER";
            this.tb_infoGENDER.Size = new System.Drawing.Size(52, 25);
            this.tb_infoGENDER.TabIndex = 13;
            // 
            // tb_infoEMPLOY_NAME
            // 
            this.tb_infoEMPLOY_NAME.Location = new System.Drawing.Point(113, 58);
            this.tb_infoEMPLOY_NAME.Name = "tb_infoEMPLOY_NAME";
            this.tb_infoEMPLOY_NAME.Size = new System.Drawing.Size(88, 25);
            this.tb_infoEMPLOY_NAME.TabIndex = 12;
            // 
            // tb_infoEMPLOY_ID
            // 
            this.tb_infoEMPLOY_ID.Location = new System.Drawing.Point(28, 58);
            this.tb_infoEMPLOY_ID.Name = "tb_infoEMPLOY_ID";
            this.tb_infoEMPLOY_ID.Size = new System.Drawing.Size(76, 25);
            this.tb_infoEMPLOY_ID.TabIndex = 11;
            // 
            // btn_newInfo
            // 
            this.btn_newInfo.Location = new System.Drawing.Point(726, 58);
            this.btn_newInfo.Name = "btn_newInfo";
            this.btn_newInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_newInfo.TabIndex = 10;
            this.btn_newInfo.Text = "new";
            this.btn_newInfo.UseVisualStyleBackColor = true;
            this.btn_newInfo.Click += new System.EventHandler(this.btn_newInfo_Click);
            // 
            // l_infoPASSWORD
            // 
            this.l_infoPASSWORD.AutoSize = true;
            this.l_infoPASSWORD.Location = new System.Drawing.Point(649, 28);
            this.l_infoPASSWORD.Name = "l_infoPASSWORD";
            this.l_infoPASSWORD.Size = new System.Drawing.Size(71, 15);
            this.l_infoPASSWORD.TabIndex = 9;
            this.l_infoPASSWORD.Text = "PASSWORD";
            // 
            // l_infoSTATUS
            // 
            this.l_infoSTATUS.AutoSize = true;
            this.l_infoSTATUS.Location = new System.Drawing.Point(588, 28);
            this.l_infoSTATUS.Name = "l_infoSTATUS";
            this.l_infoSTATUS.Size = new System.Drawing.Size(55, 15);
            this.l_infoSTATUS.TabIndex = 8;
            this.l_infoSTATUS.Text = "STATUS";
            // 
            // l_infoWORK_YEAR
            // 
            this.l_infoWORK_YEAR.AutoSize = true;
            this.l_infoWORK_YEAR.Location = new System.Drawing.Point(503, 28);
            this.l_infoWORK_YEAR.Name = "l_infoWORK_YEAR";
            this.l_infoWORK_YEAR.Size = new System.Drawing.Size(79, 15);
            this.l_infoWORK_YEAR.TabIndex = 7;
            this.l_infoWORK_YEAR.Text = "WORK_YEAR";
            // 
            // l_infoIN_DATE
            // 
            this.l_infoIN_DATE.AutoSize = true;
            this.l_infoIN_DATE.Location = new System.Drawing.Point(434, 28);
            this.l_infoIN_DATE.Name = "l_infoIN_DATE";
            this.l_infoIN_DATE.Size = new System.Drawing.Size(63, 15);
            this.l_infoIN_DATE.TabIndex = 6;
            this.l_infoIN_DATE.Text = "IN_DATE";
            // 
            // l_infoCITIZEN_ID
            // 
            this.l_infoCITIZEN_ID.AutoSize = true;
            this.l_infoCITIZEN_ID.Location = new System.Drawing.Point(341, 28);
            this.l_infoCITIZEN_ID.Name = "l_infoCITIZEN_ID";
            this.l_infoCITIZEN_ID.Size = new System.Drawing.Size(87, 15);
            this.l_infoCITIZEN_ID.TabIndex = 5;
            this.l_infoCITIZEN_ID.Text = "CITIZEN_ID";
            // 
            // l_infoADDRESS
            // 
            this.l_infoADDRESS.AutoSize = true;
            this.l_infoADDRESS.Location = new System.Drawing.Point(272, 28);
            this.l_infoADDRESS.Name = "l_infoADDRESS";
            this.l_infoADDRESS.Size = new System.Drawing.Size(63, 15);
            this.l_infoADDRESS.TabIndex = 4;
            this.l_infoADDRESS.Text = "ADDRESS";
            // 
            // l_infoGENDER
            // 
            this.l_infoGENDER.AutoSize = true;
            this.l_infoGENDER.Location = new System.Drawing.Point(211, 28);
            this.l_infoGENDER.Name = "l_infoGENDER";
            this.l_infoGENDER.Size = new System.Drawing.Size(55, 15);
            this.l_infoGENDER.TabIndex = 3;
            this.l_infoGENDER.Text = "GENDER";
            // 
            // l_infoEMPLOY_NAME
            // 
            this.l_infoEMPLOY_NAME.AutoSize = true;
            this.l_infoEMPLOY_NAME.Location = new System.Drawing.Point(110, 28);
            this.l_infoEMPLOY_NAME.Name = "l_infoEMPLOY_NAME";
            this.l_infoEMPLOY_NAME.Size = new System.Drawing.Size(95, 15);
            this.l_infoEMPLOY_NAME.TabIndex = 2;
            this.l_infoEMPLOY_NAME.Text = "EMPLOY_NAME";
            // 
            // l_infoEMPLOY_ID
            // 
            this.l_infoEMPLOY_ID.AutoSize = true;
            this.l_infoEMPLOY_ID.Location = new System.Drawing.Point(25, 28);
            this.l_infoEMPLOY_ID.Name = "l_infoEMPLOY_ID";
            this.l_infoEMPLOY_ID.Size = new System.Drawing.Size(79, 15);
            this.l_infoEMPLOY_ID.TabIndex = 1;
            this.l_infoEMPLOY_ID.Text = "EMPLOY_ID";
            // 
            // employeeInfo
            // 
            this.employeeInfo.AllowUserToAddRows = false;
            this.employeeInfo.AllowUserToOrderColumns = true;
            this.employeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeInfo.Location = new System.Drawing.Point(5, 106);
            this.employeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.employeeInfo.Name = "employeeInfo";
            this.employeeInfo.RowTemplate.Height = 23;
            this.employeeInfo.Size = new System.Drawing.Size(1091, 456);
            this.employeeInfo.TabIndex = 0;
            this.employeeInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeInfo_CellContentClick);
            this.employeeInfo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeInfo_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.employPerform);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 561);
            this.panel1.TabIndex = 3;
            // 
            // performButton
            // 
            this.performButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("performButton.BackgroundImage")));
            this.performButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.performButton.FlatAppearance.BorderSize = 0;
            this.performButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.performButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.performButton.ForeColor = System.Drawing.Color.White;
            this.performButton.Location = new System.Drawing.Point(12, 2);
            this.performButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.performButton.Name = "performButton";
            this.performButton.Size = new System.Drawing.Size(197, 31);
            this.performButton.TabIndex = 4;
            this.performButton.Text = "Employ Perform";
            this.performButton.UseVisualStyleBackColor = true;
            this.performButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // jobButton
            // 
            this.jobButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jobButton.BackgroundImage")));
            this.jobButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jobButton.ForeColor = System.Drawing.Color.White;
            this.jobButton.Location = new System.Drawing.Point(241, 5);
            this.jobButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jobButton.Name = "jobButton";
            this.jobButton.Size = new System.Drawing.Size(131, 29);
            this.jobButton.TabIndex = 5;
            this.jobButton.Text = "Job Title";
            this.jobButton.UseVisualStyleBackColor = true;
            this.jobButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // salaryButton
            // 
            this.salaryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salaryButton.BackgroundImage")));
            this.salaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.salaryButton.ForeColor = System.Drawing.Color.White;
            this.salaryButton.Location = new System.Drawing.Point(407, 2);
            this.salaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryButton.Name = "salaryButton";
            this.salaryButton.Size = new System.Drawing.Size(131, 31);
            this.salaryButton.TabIndex = 6;
            this.salaryButton.Text = "Salary";
            this.salaryButton.UseVisualStyleBackColor = true;
            this.salaryButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoButton.BackgroundImage")));
            this.infoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoButton.ForeColor = System.Drawing.Color.White;
            this.infoButton.Location = new System.Drawing.Point(607, 2);
            this.infoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(131, 31);
            this.infoButton.TabIndex = 7;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // HrManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 601);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.jobButton);
            this.Controls.Add(this.performButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HrManage";
            this.Text = "HrManage";
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
            this.infoPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfo)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label l_infoPASSWORD;
        private System.Windows.Forms.Label l_infoSTATUS;
        private System.Windows.Forms.Label l_infoWORK_YEAR;
        private System.Windows.Forms.Label l_infoIN_DATE;
        private System.Windows.Forms.Label l_infoCITIZEN_ID;
        private System.Windows.Forms.Label l_infoADDRESS;
        private System.Windows.Forms.Label l_infoGENDER;
        private System.Windows.Forms.Label l_infoEMPLOY_NAME;
        private System.Windows.Forms.Label l_infoEMPLOY_ID;
        private System.Windows.Forms.TextBox tb_infoPASSWORD;
        private System.Windows.Forms.TextBox tb_infoSTATUS;
        private System.Windows.Forms.TextBox tb_infoWORK_YEAR;
        private System.Windows.Forms.TextBox tb_infoIN_DATE;
        private System.Windows.Forms.TextBox tb_infoCITIZEN_ID;
        private System.Windows.Forms.TextBox tb_infoADDRESS;
        private System.Windows.Forms.TextBox tb_infoGENDER;
        private System.Windows.Forms.TextBox tb_infoEMPLOY_NAME;
        private System.Windows.Forms.TextBox tb_infoEMPLOY_ID;
        private System.Windows.Forms.Button btn_newInfo;
        private System.Windows.Forms.Button btn_infoDelete;
        private System.Windows.Forms.TextBox tb_infoEMPLOY_ID2;
        private System.Windows.Forms.Label l_infoEMPLOY_ID2;

        //-K
        
        //-K
        
    }
}

