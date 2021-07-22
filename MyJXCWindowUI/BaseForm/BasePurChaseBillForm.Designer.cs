namespace LuQiJing.MyJXCWindowUI.BaseForm
{
    partial class BasePurChaseBillForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbQueryValue = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbQueryCondition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpIndentDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.txtStorageDate = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgDetailInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstPurchaseIDList = new System.Windows.Forms.ListBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "进货单列表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbQueryValue);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.cbQueryCondition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(228, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // cbQueryValue
            // 
            this.cbQueryValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbQueryValue.FormattingEnabled = true;
            this.cbQueryValue.Items.AddRange(new object[] {
            "执行",
            "撤销",
            "完成"});
            this.cbQueryValue.Location = new System.Drawing.Point(316, 18);
            this.cbQueryValue.Margin = new System.Windows.Forms.Padding(2);
            this.cbQueryValue.Name = "cbQueryValue";
            this.cbQueryValue.Size = new System.Drawing.Size(200, 17);
            this.cbQueryValue.TabIndex = 9;
            // 
            // btnQuery
            // 
            this.btnQuery.ForeColor = System.Drawing.Color.Red;
            this.btnQuery.Location = new System.Drawing.Point(452, 51);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(64, 23);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(288, 50);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(158, 21);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Location = new System.Drawing.Point(65, 50);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(158, 21);
            this.dtpStartDate.TabIndex = 5;
            // 
            // cbQueryCondition
            // 
            this.cbQueryCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQueryCondition.FormattingEnabled = true;
            this.cbQueryCondition.Items.AddRange(new object[] {
            "安单据编号查询",
            "按业务员的名字查询",
            "安审核员的名字查询",
            "按完成状态查询",
            "按订单日期查询"});
            this.cbQueryCondition.Location = new System.Drawing.Point(65, 18);
            this.cbQueryCondition.Name = "cbQueryCondition";
            this.cbQueryCondition.Size = new System.Drawing.Size(199, 20);
            this.cbQueryCondition.TabIndex = 4;
            this.cbQueryCondition.SelectedIndexChanged += new System.EventHandler(this.cbQueryCondition_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "查询值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "结束日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "开始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "查询条件";
            // 
            // dtpIndentDate
            // 
            this.dtpIndentDate.Enabled = false;
            this.dtpIndentDate.Location = new System.Drawing.Point(293, 106);
            this.dtpIndentDate.Name = "dtpIndentDate";
            this.dtpIndentDate.Size = new System.Drawing.Size(158, 21);
            this.dtpIndentDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "订单日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "完成状态";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "供 应 商";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "入库日期";
            // 
            // cbSupplier
            // 
            this.cbSupplier.Enabled = false;
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(293, 150);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(158, 20);
            this.cbSupplier.TabIndex = 11;
            // 
            // txtStorageDate
            // 
            this.txtStorageDate.Enabled = false;
            this.txtStorageDate.Location = new System.Drawing.Point(293, 192);
            this.txtStorageDate.Name = "txtStorageDate";
            this.txtStorageDate.Size = new System.Drawing.Size(158, 21);
            this.txtStorageDate.TabIndex = 12;
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(293, 237);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(158, 21);
            this.txtState.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "订单编号";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Enabled = false;
            this.txtPurchaseID.Location = new System.Drawing.Point(564, 109);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(180, 21);
            this.txtPurchaseID.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "备  注";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(13, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "进货单明细";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(516, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "总价";
            // 
            // dgDetailInfo
            // 
            this.dgDetailInfo.AllowUserToAddRows = false;
            this.dgDetailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetailInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgDetailInfo.Location = new System.Drawing.Point(12, 350);
            this.dgDetailInfo.Name = "dgDetailInfo";
            this.dgDetailInfo.RowTemplate.Height = 23;
            this.dgDetailInfo.Size = new System.Drawing.Size(746, 200);
            this.dgDetailInfo.TabIndex = 20;
            this.dgDetailInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetailInfo_CellClick);
            this.dgDetailInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgDetailInfo_CellFormatting);
            this.dgDetailInfo.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgDetailInfo_CellValidating);
            this.dgDetailInfo.CurrentCellChanged += new System.EventHandler(this.dgDetailInfo_CurrentCellChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PurchaseID";
            this.Column1.HeaderText = "订单编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PurchaseDetailID";
            this.Column2.HeaderText = "明细编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductID";
            this.Column3.HeaderText = "产品";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PurchasePrice";
            this.Column4.HeaderText = "购入单价";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Quantity";
            this.Column5.HeaderText = "数量";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Account";
            this.Column6.HeaderText = "金额";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(564, 317);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(179, 21);
            this.txtTotal.TabIndex = 27;
            // 
            // lstPurchaseIDList
            // 
            this.lstPurchaseIDList.FormattingEnabled = true;
            this.lstPurchaseIDList.ItemHeight = 12;
            this.lstPurchaseIDList.Location = new System.Drawing.Point(16, 37);
            this.lstPurchaseIDList.Margin = new System.Windows.Forms.Padding(2);
            this.lstPurchaseIDList.Name = "lstPurchaseIDList";
            this.lstPurchaseIDList.Size = new System.Drawing.Size(198, 232);
            this.lstPurchaseIDList.TabIndex = 28;
            this.lstPurchaseIDList.Click += new System.EventHandler(this.lstPurchaseIDList_Click);
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(507, 178);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(237, 90);
            this.txtNote.TabIndex = 29;
            // 
            // BasePurChaseBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 586);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lstPurchaseIDList);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgDetailInfo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPurchaseID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtStorageDate);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpIndentDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "BasePurChaseBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasePurChaseBillForm";
            this.Load += new System.EventHandler(this.BasePurChaseBillForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetailInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        protected System.Windows.Forms.ComboBox cbQueryCondition;
        protected System.Windows.Forms.Button btnQuery;
        protected System.Windows.Forms.DateTimePicker dtpEndDate;
        protected System.Windows.Forms.DateTimePicker dtpStartDate;
        protected System.Windows.Forms.DateTimePicker dtpIndentDate;
        protected System.Windows.Forms.ComboBox cbSupplier;
        protected System.Windows.Forms.TextBox txtStorageDate;
        protected System.Windows.Forms.TextBox txtState;
        protected System.Windows.Forms.TextBox txtPurchaseID;
        protected System.Windows.Forms.DataGridView dgDetailInfo;
        protected System.Windows.Forms.TextBox txtTotal;
        protected System.Windows.Forms.TextBox txtNote;
        protected System.Windows.Forms.ListBox lstPurchaseIDList;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.ComboBox cbQueryValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}