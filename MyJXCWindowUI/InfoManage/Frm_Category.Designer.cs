namespace LuQiJing.MyJXCWindowUI.InfoManage
{
    partial class Frm_Category
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
            this.dgCategoryInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoryInfo)).BeginInit();
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
            this.gbInfo.Controls.Add(this.txtCategoryName);
            this.gbInfo.Controls.Add(this.txtCategoryID);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.SetChildIndex(this.btnCencel, 0);
            this.gbInfo.Controls.SetChildIndex(this.btnSave, 0);
            this.gbInfo.Controls.SetChildIndex(this.label1, 0);
            this.gbInfo.Controls.SetChildIndex(this.label2, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCategoryID, 0);
            this.gbInfo.Controls.SetChildIndex(this.txtCategoryName, 0);
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
            this.lblID.Location = new System.Drawing.Point(37, 15);
            this.lblID.Size = new System.Drawing.Size(89, 12);
            this.lblID.Text = "产品类别编号：";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(324, 15);
            this.lblName.Size = new System.Drawing.Size(89, 12);
            this.lblName.Text = "产品类别名称：";
            // 
            // dgCategoryInfo
            // 
            this.dgCategoryInfo.AllowUserToAddRows = false;
            this.dgCategoryInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoryInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgCategoryInfo.Location = new System.Drawing.Point(9, 43);
            this.dgCategoryInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgCategoryInfo.Name = "dgCategoryInfo";
            this.dgCategoryInfo.RowTemplate.Height = 27;
            this.dgCategoryInfo.Size = new System.Drawing.Size(752, 230);
            this.dgCategoryInfo.TabIndex = 8;
            this.dgCategoryInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoryInfo_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CateID";
            this.Column1.HeaderText = "产品类别编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 475;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CateName";
            this.Column2.HeaderText = "产品类别名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 485;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "产品类别编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "产品类别名称：";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(292, 95);
            this.txtCategoryID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(166, 21);
            this.txtCategoryID.TabIndex = 8;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(292, 166);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(166, 21);
            this.txtCategoryName.TabIndex = 9;
            // 
            // Frm_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 586);
            this.Controls.Add(this.dgCategoryInfo);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Frm_Category";
            this.Text = "产品分类管理";
            this.Load += new System.EventHandler(this.Frm_Category_Load);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.lblID, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.btnQuery, 0);
            this.Controls.SetChildIndex(this.gbInfo, 0);
            this.Controls.SetChildIndex(this.btnNewInsert, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.dgCategoryInfo, 0);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoryInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategoryInfo;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}