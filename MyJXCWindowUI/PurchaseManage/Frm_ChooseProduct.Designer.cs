namespace LuQiJing.MyJXCWindowUI.PurchaseManage
{
    partial class Frm_ChooseProduct
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
            this.txtSpellingCode = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "拼音码：";
            // 
            // txtSpellingCode
            // 
            this.txtSpellingCode.Location = new System.Drawing.Point(97, 27);
            this.txtSpellingCode.Name = "txtSpellingCode";
            this.txtSpellingCode.Size = new System.Drawing.Size(288, 25);
            this.txtSpellingCode.TabIndex = 1;
            this.txtSpellingCode.TextChanged += new System.EventHandler(this.txtSpellingCode_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(833, 20);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 35);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.dgProductInfo.Location = new System.Drawing.Point(12, 73);
            this.dgProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProductInfo.Name = "dgProductInfo";
            this.dgProductInfo.RowTemplate.Height = 27;
            this.dgProductInfo.Size = new System.Drawing.Size(1001, 578);
            this.dgProductInfo.TabIndex = 9;
            this.dgProductInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductInfo_CellClick);
            this.dgProductInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductInfo_CellDoubleClick);
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
            // Frm_ChooseProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 662);
            this.Controls.Add(this.dgProductInfo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtSpellingCode);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ChooseProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChooseProduct";
            this.Load += new System.EventHandler(this.Frm_ChooseProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpellingCode;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgProductInfo;
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