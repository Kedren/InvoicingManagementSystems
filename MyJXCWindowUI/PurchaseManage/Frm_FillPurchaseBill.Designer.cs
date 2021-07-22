namespace LuQiJing.MyJXCWindowUI.PurchaseManage
{
    partial class Frm_FillPurchaseBill
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
            this.btnAddInformation = new System.Windows.Forms.Button();
            this.btnDeleteInformation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnNewInsert = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpIndentDate
            // 
            this.dtpIndentDate.ValueChanged += new System.EventHandler(this.dtpIndentDate_ValueChanged);
            // 
            // txtStorageDate
            // 
            this.txtStorageDate.Margin = new System.Windows.Forms.Padding(5);
            // 
            // txtState
            // 
            this.txtState.Margin = new System.Windows.Forms.Padding(5);
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Margin = new System.Windows.Forms.Padding(5);
            this.txtPurchaseID.TextChanged += new System.EventHandler(this.txtPurchaseID_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            // 
            // txtNote
            // 
            this.txtNote.Margin = new System.Windows.Forms.Padding(5);
            this.txtNote.Size = new System.Drawing.Size(315, 120);
            // 
            // lstPurchaseIDList
            // 
            this.lstPurchaseIDList.ItemHeight = 15;
            this.lstPurchaseIDList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstPurchaseIDList.Size = new System.Drawing.Size(263, 229);
            // 
            // btnAddInformation
            // 
            this.btnAddInformation.Enabled = false;
            this.btnAddInformation.Location = new System.Drawing.Point(36, 695);
            this.btnAddInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddInformation.Name = "btnAddInformation";
            this.btnAddInformation.Size = new System.Drawing.Size(453, 29);
            this.btnAddInformation.TabIndex = 22;
            this.btnAddInformation.Text = "增加明细信息";
            this.btnAddInformation.UseVisualStyleBackColor = true;
            this.btnAddInformation.Click += new System.EventHandler(this.btnAddInformation_Click);
            // 
            // btnDeleteInformation
            // 
            this.btnDeleteInformation.Enabled = false;
            this.btnDeleteInformation.Location = new System.Drawing.Point(539, 695);
            this.btnDeleteInformation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteInformation.Name = "btnDeleteInformation";
            this.btnDeleteInformation.Size = new System.Drawing.Size(453, 29);
            this.btnDeleteInformation.TabIndex = 23;
            this.btnDeleteInformation.Text = "删除明细信息";
            this.btnDeleteInformation.UseVisualStyleBackColor = true;
            this.btnDeleteInformation.Click += new System.EventHandler(this.btnDeleteInformation_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(888, 352);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(744, 352);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 29);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "存盘";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(147, 352);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 29);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(255, 352);
            this.btnRevoke.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(100, 29);
            this.btnRevoke.TabIndex = 29;
            this.btnRevoke.Text = "撤销";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnNewInsert
            // 
            this.btnNewInsert.Location = new System.Drawing.Point(39, 352);
            this.btnNewInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewInsert.Name = "btnNewInsert";
            this.btnNewInsert.Size = new System.Drawing.Size(100, 29);
            this.btnNewInsert.TabIndex = 28;
            this.btnNewInsert.Text = "新增";
            this.btnNewInsert.UseVisualStyleBackColor = true;
            this.btnNewInsert.Click += new System.EventHandler(this.btnNewInsert_Click);
            // 
            // Frm_FillPurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 732);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnNewInsert);
            this.Controls.Add(this.btnDeleteInformation);
            this.Controls.Add(this.btnAddInformation);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_FillPurchaseBill";
            this.Text = "填写进货单";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lstPurchaseIDList, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.dtpIndentDate, 0);
            this.Controls.SetChildIndex(this.cbSupplier, 0);
            this.Controls.SetChildIndex(this.txtStorageDate, 0);
            this.Controls.SetChildIndex(this.txtState, 0);
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.btnAddInformation, 0);
            this.Controls.SetChildIndex(this.btnDeleteInformation, 0);
            this.Controls.SetChildIndex(this.btnNewInsert, 0);
            this.Controls.SetChildIndex(this.btnRevoke, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddInformation;
        private System.Windows.Forms.Button btnDeleteInformation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnNewInsert;
    }
}