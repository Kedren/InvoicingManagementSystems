namespace LuQiJing.MyJXCWindowUI.InfoManage
{
    partial class Frm_Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtBrief = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dgEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewInsert
            // 
            this.btnNewInsert.Click += new System.EventHandler(this.btnNewInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dtpBirthday);
            this.gbInfo.Controls.Add(this.cbSex);
            this.gbInfo.Controls.Add(this.txtBrief);
            this.gbInfo.Controls.Add(this.txtEmployeeName);
            this.gbInfo.Controls.Add(this.txtEmployeeID);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.SetChildIndex(this.btnCencel, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.label3, 0);
            this.gbInfo.Controls.SetChildIndex(this.label4, 0);
            this.gbInfo.Controls.SetChildIndex(this.label5, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmployeeID, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmployeeName, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtBrief, 0);
            this.gbInfo.Controls.SetChildIndex(this.cbSex, 0);
            this.gbInfo.Controls.SetChildIndex(this.dtpBirthday, 0);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtName
            // 
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            // 
            // txtID
            // 
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(62, 15);
            this.lblID.Size = new System.Drawing.Size(65, 12);
            this.lblID.Text = "员工编号：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(343, 15);
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.Text = "员工姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "员工编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "员工姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "性    别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "出生日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "简历：";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(85, 33);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(145, 21);
            this.txtEmployeeID.TabIndex = 10;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(85, 79);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(145, 21);
            this.txtEmployeeName.TabIndex = 11;
            // 
            // txtBrief
            // 
            this.txtBrief.Location = new System.Drawing.Point(363, 33);
            this.txtBrief.Multiline = true;
            this.txtBrief.Name = "txtBrief";
            this.txtBrief.Size = new System.Drawing.Size(366, 197);
            this.txtBrief.TabIndex = 12;
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(85, 129);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(145, 20);
            this.cbSex.TabIndex = 13;
            // 
            // dgEmployeeInfo
            // 
            this.dgEmployeeInfo.AllowUserToAddRows = false;
            this.dgEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.sex,
            this.Column4,
            this.Column5});
            this.dgEmployeeInfo.Location = new System.Drawing.Point(13, 44);
            this.dgEmployeeInfo.Name = "dgEmployeeInfo";
            this.dgEmployeeInfo.RowTemplate.Height = 23;
            this.dgEmployeeInfo.Size = new System.Drawing.Size(745, 229);
            this.dgEmployeeInfo.TabIndex = 8;
            this.dgEmployeeInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployeeInfo_CellClick);
            this.dgEmployeeInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgEmployeeInfo_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeID";
            this.Column1.HeaderText = "员工编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "EmployeeName";
            this.Column2.HeaderText = "员工姓名";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Birthday";
            this.Column4.HeaderText = "出生日期";
            this.Column4.Name = "Column4";
            this.Column4.Width = 165;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Brief";
            this.Column5.HeaderText = "简历";
            this.Column5.Name = "Column5";
            this.Column5.Width = 400;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(85, 172);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(145, 21);
            this.dtpBirthday.TabIndex = 14;
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 586);
            this.Controls.Add(this.dgEmployeeInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Employee";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            this.Controls.SetChildIndex(this.btnQuery, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lblID, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.btnNewInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.dgEmployeeInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtBrief;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgEmployeeInfo;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}