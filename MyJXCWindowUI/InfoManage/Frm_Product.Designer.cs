namespace LuQiJing.MyJXCWindowUI.InfoManage
{
    partial class Frm_Product
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
            this.dgProductInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtSpellingCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbCategoryID = new System.Windows.Forms.ComboBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).BeginInit();
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
            this.gbInfo.Controls.Add(this.cbCategoryID);
            this.gbInfo.Controls.Add(this.txtQuantity);
            this.gbInfo.Controls.Add(this.txtSalePrice);
            this.gbInfo.Controls.Add(this.txtPurchasePrice);
            this.gbInfo.Controls.Add(this.txtProductName);
            this.gbInfo.Controls.Add(this.txtSpellingCode);
            this.gbInfo.Controls.Add(this.txtBarcode);
            this.gbInfo.Controls.Add(this.txtSpecial);
            this.gbInfo.Controls.Add(this.txtOrigin);
            this.gbInfo.Controls.Add(this.txtUnit);
            this.gbInfo.Controls.Add(this.txtProductID);
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
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.SetChildIndex(this.btnCencel, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
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
            this.gbInfo.Controls.SetChildIndex(this.txtProductID, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtUnit, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtOrigin, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSpecial, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtBarcode, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSpellingCode, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtProductName, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtPurchasePrice, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtSalePrice, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtQuantity, 0);
            this.gbInfo.Controls.SetChildIndex(this.cbCategoryID, 0);
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
            this.lblID.Text = "产品编号：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(342, 15);
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.Text = "产品名称：";
            // 
            // dgProductInfo
            // 
            this.dgProductInfo.AllowUserToAddRows = false;
            this.dgProductInfo.AllowUserToResizeColumns = false;
            this.dgProductInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.categoryID,
            this.Column9,
            this.Column10,
            this.Column8});
            this.dgProductInfo.Location = new System.Drawing.Point(10, 43);
            this.dgProductInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgProductInfo.Name = "dgProductInfo";
            this.dgProductInfo.RowTemplate.Height = 27;
            this.dgProductInfo.Size = new System.Drawing.Size(751, 230);
            this.dgProductInfo.TabIndex = 8;
            this.dgProductInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductInfo_CellClick);
            this.dgProductInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgProductInfo_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductID";
            this.Column1.HeaderText = "产品编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "产品名称";
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
            this.Column4.DataPropertyName = "Barcode";
            this.Column4.HeaderText = "条形码";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Special";
            this.Column5.HeaderText = "规格";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Unit";
            this.Column6.HeaderText = "计量单位";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Origin";
            this.Column7.HeaderText = "产地";
            this.Column7.Name = "Column7";
            // 
            // categoryID
            // 
            this.categoryID.DataPropertyName = "CategoryID";
            this.categoryID.HeaderText = "产品类别";
            this.categoryID.Name = "categoryID";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PurchasePrice";
            this.Column9.HeaderText = "购买价格";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SalePrice";
            this.Column10.HeaderText = "销售价格";
            this.Column10.Name = "Column10";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Quantity";
            this.Column8.HeaderText = "数量";
            this.Column8.Name = "Column8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "产品名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "拼 音 码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "条 形 码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "产品类别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "购买价格：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "计量单位：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "产    地：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "销售价格：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "数    量：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "产品编号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "规    格：";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(87, 40);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(140, 21);
            this.txtProductID.TabIndex = 17;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(325, 91);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(145, 21);
            this.txtUnit.TabIndex = 19;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(325, 135);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(145, 21);
            this.txtOrigin.TabIndex = 20;
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(325, 38);
            this.txtSpecial.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(145, 21);
            this.txtSpecial.TabIndex = 21;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(88, 182);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(139, 21);
            this.txtBarcode.TabIndex = 22;
            // 
            // txtSpellingCode
            // 
            this.txtSpellingCode.Enabled = false;
            this.txtSpellingCode.Location = new System.Drawing.Point(87, 135);
            this.txtSpellingCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpellingCode.Name = "txtSpellingCode";
            this.txtSpellingCode.Size = new System.Drawing.Size(140, 21);
            this.txtSpellingCode.TabIndex = 23;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(87, 91);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(140, 21);
            this.txtProductName.TabIndex = 24;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(577, 41);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(151, 21);
            this.txtPurchasePrice.TabIndex = 25;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(577, 86);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(152, 21);
            this.txtSalePrice.TabIndex = 26;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(577, 135);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(151, 21);
            this.txtQuantity.TabIndex = 27;
            // 
            // cbCategoryID
            // 
            this.cbCategoryID.FormattingEnabled = true;
            this.cbCategoryID.Location = new System.Drawing.Point(331, 178);
            this.cbCategoryID.Name = "cbCategoryID";
            this.cbCategoryID.Size = new System.Drawing.Size(139, 20);
            this.cbCategoryID.TabIndex = 28;
            // 
            // Frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 586);
            this.Controls.Add(this.dgProductInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Product";
            this.Text = "产品信息管理";
            this.Load += new System.EventHandler(this.Frm_Product_Load);
            this.Controls.SetChildIndex(this.btnQuery, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lblID, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.btnNewInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.dgProductInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProductInfo;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSpellingCode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtProductID;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}