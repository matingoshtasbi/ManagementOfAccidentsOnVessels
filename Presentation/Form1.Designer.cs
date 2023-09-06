namespace ManagementOfAccidentsOnVessels
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.vesselMenuBtn = new System.Windows.Forms.Button();
            this.vesselManagementGb = new System.Windows.Forms.GroupBox();
            this.isActiveChk = new System.Windows.Forms.CheckBox();
            this.vesselIdLbl = new System.Windows.Forms.Label();
            this.vesselIdTextLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.portCombo = new System.Windows.Forms.ComboBox();
            this.vesselTypeCombo = new System.Windows.Forms.ComboBox();
            this.vesselManagementGv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bodyMaterialTxt = new System.Windows.Forms.TextBox();
            this.manufacturerNameTxt = new System.Windows.Forms.TextBox();
            this.capacityTxt = new System.Windows.Forms.TextBox();
            this.manufacturerCountryTxt = new System.Windows.Forms.TextBox();
            this.engineModelTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maxSpeedTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.serialNumberTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.accidentMenuBtn = new System.Windows.Forms.Button();
            this.accidentPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.accidentCombo = new System.Windows.Forms.ComboBox();
            this.gulfPic = new System.Windows.Forms.PictureBox();
            this.vesselManagementGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vesselManagementGv)).BeginInit();
            this.accidentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gulfPic)).BeginInit();
            this.SuspendLayout();
            // 
            // vesselMenuBtn
            // 
            this.vesselMenuBtn.Location = new System.Drawing.Point(1109, 27);
            this.vesselMenuBtn.Name = "vesselMenuBtn";
            this.vesselMenuBtn.Size = new System.Drawing.Size(235, 60);
            this.vesselMenuBtn.TabIndex = 0;
            this.vesselMenuBtn.Text = "مدیریت شناوران";
            this.vesselMenuBtn.UseVisualStyleBackColor = true;
            this.vesselMenuBtn.Click += new System.EventHandler(this.vesselMenuBtn_Click);
            // 
            // vesselManagementGb
            // 
            this.vesselManagementGb.Controls.Add(this.isActiveChk);
            this.vesselManagementGb.Controls.Add(this.vesselIdLbl);
            this.vesselManagementGb.Controls.Add(this.vesselIdTextLbl);
            this.vesselManagementGb.Controls.Add(this.updateBtn);
            this.vesselManagementGb.Controls.Add(this.deleteBtn);
            this.vesselManagementGb.Controls.Add(this.portCombo);
            this.vesselManagementGb.Controls.Add(this.vesselTypeCombo);
            this.vesselManagementGb.Controls.Add(this.vesselManagementGv);
            this.vesselManagementGb.Controls.Add(this.label6);
            this.vesselManagementGb.Controls.Add(this.label7);
            this.vesselManagementGb.Controls.Add(this.label8);
            this.vesselManagementGb.Controls.Add(this.label9);
            this.vesselManagementGb.Controls.Add(this.label10);
            this.vesselManagementGb.Controls.Add(this.bodyMaterialTxt);
            this.vesselManagementGb.Controls.Add(this.manufacturerNameTxt);
            this.vesselManagementGb.Controls.Add(this.capacityTxt);
            this.vesselManagementGb.Controls.Add(this.manufacturerCountryTxt);
            this.vesselManagementGb.Controls.Add(this.engineModelTxt);
            this.vesselManagementGb.Controls.Add(this.label5);
            this.vesselManagementGb.Controls.Add(this.label4);
            this.vesselManagementGb.Controls.Add(this.label3);
            this.vesselManagementGb.Controls.Add(this.label2);
            this.vesselManagementGb.Controls.Add(this.label1);
            this.vesselManagementGb.Controls.Add(this.maxSpeedTxt);
            this.vesselManagementGb.Controls.Add(this.nameTxt);
            this.vesselManagementGb.Controls.Add(this.serialNumberTxt);
            this.vesselManagementGb.Controls.Add(this.saveBtn);
            this.vesselManagementGb.Location = new System.Drawing.Point(45, 17);
            this.vesselManagementGb.Name = "vesselManagementGb";
            this.vesselManagementGb.Size = new System.Drawing.Size(1035, 694);
            this.vesselManagementGb.TabIndex = 1;
            this.vesselManagementGb.TabStop = false;
            this.vesselManagementGb.Text = "مدیریت شناوران";
            // 
            // isActiveChk
            // 
            this.isActiveChk.AutoSize = true;
            this.isActiveChk.Location = new System.Drawing.Point(858, 645);
            this.isActiveChk.Name = "isActiveChk";
            this.isActiveChk.Size = new System.Drawing.Size(166, 24);
            this.isActiveChk.TabIndex = 28;
            this.isActiveChk.Text = "آیا شناور فعال است ؟";
            this.isActiveChk.UseVisualStyleBackColor = false;
            this.isActiveChk.Visible = false;
            // 
            // vesselIdLbl
            // 
            this.vesselIdLbl.AutoSize = true;
            this.vesselIdLbl.Location = new System.Drawing.Point(597, 645);
            this.vesselIdLbl.Name = "vesselIdLbl";
            this.vesselIdLbl.Size = new System.Drawing.Size(17, 20);
            this.vesselIdLbl.TabIndex = 27;
            this.vesselIdLbl.Text = "0";
            // 
            // vesselIdTextLbl
            // 
            this.vesselIdTextLbl.AutoSize = true;
            this.vesselIdTextLbl.Location = new System.Drawing.Point(620, 645);
            this.vesselIdTextLbl.Name = "vesselIdTextLbl";
            this.vesselIdTextLbl.Size = new System.Drawing.Size(152, 20);
            this.vesselIdTextLbl.TabIndex = 26;
            this.vesselIdTextLbl.Text = "شناسه شناور انتخابی : ";
            this.vesselIdTextLbl.Visible = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Location = new System.Drawing.Point(344, 627);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(144, 57);
            this.updateBtn.TabIndex = 25;
            this.updateBtn.Text = "تغییر";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(194, 627);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(144, 57);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "حذف";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // portCombo
            // 
            this.portCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portCombo.FormattingEnabled = true;
            this.portCombo.Location = new System.Drawing.Point(44, 473);
            this.portCombo.Name = "portCombo";
            this.portCombo.Size = new System.Drawing.Size(183, 28);
            this.portCombo.TabIndex = 23;
            // 
            // vesselTypeCombo
            // 
            this.vesselTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vesselTypeCombo.FormattingEnabled = true;
            this.vesselTypeCombo.Location = new System.Drawing.Point(407, 473);
            this.vesselTypeCombo.Name = "vesselTypeCombo";
            this.vesselTypeCombo.Size = new System.Drawing.Size(207, 28);
            this.vesselTypeCombo.TabIndex = 22;
            // 
            // vesselManagementGv
            // 
            this.vesselManagementGv.AllowUserToAddRows = false;
            this.vesselManagementGv.AllowUserToDeleteRows = false;
            this.vesselManagementGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vesselManagementGv.Location = new System.Drawing.Point(44, 26);
            this.vesselManagementGv.MultiSelect = false;
            this.vesselManagementGv.Name = "vesselManagementGv";
            this.vesselManagementGv.ReadOnly = true;
            this.vesselManagementGv.RowHeadersVisible = false;
            this.vesselManagementGv.RowHeadersWidth = 51;
            this.vesselManagementGv.RowTemplate.Height = 29;
            this.vesselManagementGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vesselManagementGv.Size = new System.Drawing.Size(980, 369);
            this.vesselManagementGv.TabIndex = 21;
            this.vesselManagementGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vesselManagementGv_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "جنس بدنه ی شناور";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "شرکت سازنده ی شناور";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "ظرفیت خدمه شناور";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(680, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "کشور سازنده ی شناور";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(908, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "مدل موتور شناور";
            // 
            // bodyMaterialTxt
            // 
            this.bodyMaterialTxt.Location = new System.Drawing.Point(44, 558);
            this.bodyMaterialTxt.Name = "bodyMaterialTxt";
            this.bodyMaterialTxt.Size = new System.Drawing.Size(183, 27);
            this.bodyMaterialTxt.TabIndex = 15;
            // 
            // manufacturerNameTxt
            // 
            this.manufacturerNameTxt.Location = new System.Drawing.Point(407, 558);
            this.manufacturerNameTxt.Name = "manufacturerNameTxt";
            this.manufacturerNameTxt.Size = new System.Drawing.Size(207, 27);
            this.manufacturerNameTxt.TabIndex = 14;
            // 
            // capacityTxt
            // 
            this.capacityTxt.Location = new System.Drawing.Point(233, 558);
            this.capacityTxt.Name = "capacityTxt";
            this.capacityTxt.PlaceholderText = "مثلا 10 (نفر)";
            this.capacityTxt.Size = new System.Drawing.Size(168, 27);
            this.capacityTxt.TabIndex = 13;
            // 
            // manufacturerCountryTxt
            // 
            this.manufacturerCountryTxt.Location = new System.Drawing.Point(620, 558);
            this.manufacturerCountryTxt.Name = "manufacturerCountryTxt";
            this.manufacturerCountryTxt.Size = new System.Drawing.Size(206, 27);
            this.manufacturerCountryTxt.TabIndex = 12;
            // 
            // engineModelTxt
            // 
            this.engineModelTxt.Location = new System.Drawing.Point(832, 558);
            this.engineModelTxt.Name = "engineModelTxt";
            this.engineModelTxt.Size = new System.Drawing.Size(192, 27);
            this.engineModelTxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "بندر *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "نوع شناور *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "حداکثر سرعت شناور *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(749, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام شناور *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "شماره سریال شناور *";
            // 
            // maxSpeedTxt
            // 
            this.maxSpeedTxt.Location = new System.Drawing.Point(233, 473);
            this.maxSpeedTxt.Name = "maxSpeedTxt";
            this.maxSpeedTxt.PlaceholderText = "مثلا 100 (KPH)";
            this.maxSpeedTxt.Size = new System.Drawing.Size(168, 27);
            this.maxSpeedTxt.TabIndex = 3;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(620, 473);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(206, 27);
            this.nameTxt.TabIndex = 2;
            // 
            // serialNumberTxt
            // 
            this.serialNumberTxt.Location = new System.Drawing.Point(832, 473);
            this.serialNumberTxt.Name = "serialNumberTxt";
            this.serialNumberTxt.Size = new System.Drawing.Size(192, 27);
            this.serialNumberTxt.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(44, 627);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(144, 57);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "ثبت";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // accidentMenuBtn
            // 
            this.accidentMenuBtn.Location = new System.Drawing.Point(1109, 117);
            this.accidentMenuBtn.Name = "accidentMenuBtn";
            this.accidentMenuBtn.Size = new System.Drawing.Size(235, 60);
            this.accidentMenuBtn.TabIndex = 2;
            this.accidentMenuBtn.Text = "مدیریت حوادث";
            this.accidentMenuBtn.UseVisualStyleBackColor = true;
            this.accidentMenuBtn.Click += new System.EventHandler(this.accidentMenuBtn_Click);
            // 
            // accidentPanel
            // 
            this.accidentPanel.Controls.Add(this.label11);
            this.accidentPanel.Controls.Add(this.accidentCombo);
            this.accidentPanel.Controls.Add(this.gulfPic);
            this.accidentPanel.Location = new System.Drawing.Point(37, 12);
            this.accidentPanel.Name = "accidentPanel";
            this.accidentPanel.Size = new System.Drawing.Size(1045, 718);
            this.accidentPanel.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(757, 661);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "لطفا نوع ماموریت مورد نظر را انتخاب کنید";
            // 
            // accidentCombo
            // 
            this.accidentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accidentCombo.FormattingEnabled = true;
            this.accidentCombo.Location = new System.Drawing.Point(415, 661);
            this.accidentCombo.Name = "accidentCombo";
            this.accidentCombo.Size = new System.Drawing.Size(325, 28);
            this.accidentCombo.TabIndex = 1;
            // 
            // gulfPic
            // 
            this.gulfPic.Location = new System.Drawing.Point(8, 15);
            this.gulfPic.Name = "gulfPic";
            this.gulfPic.Size = new System.Drawing.Size(1024, 623);
            this.gulfPic.TabIndex = 0;
            this.gulfPic.TabStop = false;
            this.gulfPic.Click += new System.EventHandler(this.gulfPic_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 759);
            this.Controls.Add(this.accidentMenuBtn);
            this.Controls.Add(this.vesselMenuBtn);
            this.Controls.Add(this.vesselManagementGb);
            this.Controls.Add(this.accidentPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت حوادث شناوران";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.vesselManagementGb.ResumeLayout(false);
            this.vesselManagementGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vesselManagementGv)).EndInit();
            this.accidentPanel.ResumeLayout(false);
            this.accidentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gulfPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button vesselMenuBtn;
        private GroupBox vesselManagementGb;
        private TextBox maxSpeedTxt;
        private TextBox nameTxt;
        private TextBox serialNumberTxt;
        private Button saveBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox bodyMaterialTxt;
        private TextBox manufacturerNameTxt;
        private TextBox capacityTxt;
        private TextBox manufacturerCountryTxt;
        private TextBox engineModelTxt;
        private DataGridView vesselManagementGv;
        private Button accidentMenuBtn;
        private Panel accidentPanel;
        private PictureBox gulfPic;
        private Label label11;
        private ComboBox accidentCombo;
        private ComboBox portCombo;
        private ComboBox vesselTypeCombo;
        private Button updateBtn;
        private Button deleteBtn;
        private Label vesselIdLbl;
        private Label vesselIdTextLbl;
        private CheckBox isActiveChk;
    }
}