namespace LuQiJing.MyJXCWindowUI.InfoManage
{
    partial class Frm_Customer
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
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContacter = new System.Windows.Forms.TextBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankAccount = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSpellingCode = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dgCustomerInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerInfo)).BeginInit();
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
            this.gbInfo.Controls.Add(this.txtCustomerName);
            this.gbInfo.Controls.Add(this.txtSpellingCode);
            this.gbInfo.Controls.Add(this.txtAddress);
            this.gbInfo.Controls.Add(this.txtBankAccount);
            this.gbInfo.Controls.Add(this.txtBankName);
            this.gbInfo.Controls.Add(this.txtContacter);
            this.gbInfo.Controls.Add(this.txtEmail);
            this.gbInfo.Controls.Add(this.txtZipCode);
            this.gbInfo.Controls.Add(this.txtFax);
            this.gbInfo.Controls.Add(this.txtTel);
            this.gbInfo.Controls.Add(this.label11);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.txtCustomerID);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.SetChildIndex(this.btnCencel, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerID, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.label3, 0);
            this.gbInfo.Controls.SetChildIndex(this.label4, 0);
            this.gbInfo.Controls.SetChildIndex(this.label5, 0);
            this.gbInfo.Controls.SetChildIndex(this.label6, 0);
            this.gbInfo.Controls.SetChildIndex(this.label7, 0);
            this.gbInfo.Controls.SetChildIndex(this.label8, 0);
            this.gbInfo.Controls.SetChildIndex(this.label9, 0);
            this.gbInfo.Controls.SetChildIndex(this.label10, 0);
            this.gbInfo.Controls.SetChildIndex(this.label11, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtTel, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtFax, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtZipCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtEmail, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtContacter, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtBankName, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtBankAccount, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtAddress, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSpellingCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCustomerName, 0);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(61, 15);
            this.lblID.Size = new System.Drawing.Size(65, 12);
            this.lblID.Text = "客户编号：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(342, 15);
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.Text = "客户名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "客户编号：";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(79, 31);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(136, 21);
            this.txtCustomerID.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "拼 音 码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "客户名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "邮编：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "电话：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "传真：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "银行账户：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(533, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "开户银行：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "联系人：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Email：";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(331, 131);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(136, 21);
            this.txtTel.TabIndex = 18;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(331, 188);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(136, 21);
            this.txtFax.TabIndex = 19;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(331, 79);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(136, 21);
            this.txtZipCode.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(596, 182);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 21);
            this.txtEmail.TabIndex = 21;
            // 
            // txtContacter
            // 
            this.txtContacter.Location = new System.Drawing.Point(596, 126);
            this.txtContacter.Name = "txtContacter";
            this.txtContacter.Size = new System.Drawing.Size(136, 21);
            this.txtContacter.TabIndex = 22;
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(596, 30);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(136, 21);
            this.txtBankName.TabIndex = 23;
            // 
            // txtBankAccount
            // 
            this.txtBankAccount.Location = new System.Drawing.Point(596, 79);
            this.txtBankAccount.Name = "txtBankAccount";
            this.txtBankAccount.Size = new System.Drawing.Size(136, 21);
            this.txtBankAccount.TabIndex = 24;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(331, 27);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(136, 21);
            this.txtAddress.TabIndex = 25;
            // 
            // txtSpellingCode
            // 
            this.txtSpellingCode.Enabled = false;
            this.txtSpellingCode.Location = new System.Drawing.Point(79, 132);
            this.txtSpellingCode.Name = "txtSpellingCode";
            this.txtSpellingCode.Size = new System.Drawing.Size(136, 21);
            this.txtSpellingCode.TabIndex = 26;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(79, 80);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(136, 21);
            this.txtCustomerName.TabIndex = 27;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // dgCustomerInfo
            // 
            this.dgCustomerInfo.AllowUserToAddRows = false;
            this.dgCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.bankName,
            this.Column9,
            this.Column10,
            this.Column8});
            this.dgCustomerInfo.Location = new System.Drawing.Point(8, 43);
            this.dgCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgCustomerInfo.Name = "dgCustomerInfo";
            this.dgCustomerInfo.RowTemplate.Height = 27;
            this.dgCustomerInfo.Size = new System.Drawing.Size(751, 231);
            this.dgCustomerInfo.TabIndex = 9;
            this.dgCustomerInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductInfo_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerID";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerName";
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SpellingCode";
            this.Column3.HeaderText = "拼音码";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "地址";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ZipCode";
            this.Column5.HeaderText = "邮编";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Tel";
            this.Column6.HeaderText = "电话";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Fax";
            this.Column7.HeaderText = "传真";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // bankName
            // 
            this.bankName.DataPropertyName = "BankName";
            this.bankName.HeaderText = "开户银行";
            this.bankName.Name = "bankName";
            this.bankName.Width = 200;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "BankAccount";
            this.Column9.HeaderText = "银行账户";
            this.Column9.Name = "Column9";
            this.Column9.Width = 200;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Contacter";
            this.Column10.HeaderText = "联系人";
            this.Column10.Name = "Column10";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Email";
            this.Column8.HeaderText = "Eamil";
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Frm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 593);
            this.Controls.Add(this.dgCustomerInfo);
            this.Name = "Frm_Customer";
            this.Text = "客户信息管理";
            this.Load += new System.EventHandler(this.Frm_Customer_Load);
            this.Controls.SetChildIndex(this.btnQuery, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lblID, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.btnNewInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.dgCustomerInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtSpellingCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBankAccount;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtContacter;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.DataGridView dgCustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}