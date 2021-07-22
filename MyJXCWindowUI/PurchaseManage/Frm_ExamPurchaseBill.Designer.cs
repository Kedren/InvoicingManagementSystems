﻿namespace LuQiJing.MyJXCWindowUI.PurchaseManage
{
    partial class Frm_ExamPurchaseBill
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
            this.btnAuditSignature = new System.Windows.Forms.Button();
            this.btnCancelAuditSignature = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSalesman = new System.Windows.Forms.TextBox();
            this.txtAuditor = new System.Windows.Forms.TextBox();
            this.txtStorekeeper = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // txtTotal
            // 
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            // 
            // txtNote
            // 
            this.txtNote.Margin = new System.Windows.Forms.Padding(5);
            this.txtNote.Size = new System.Drawing.Size(315, 119);
            // 
            // lstPurchaseIDList
            // 
            this.lstPurchaseIDList.ItemHeight = 15;
            this.lstPurchaseIDList.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstPurchaseIDList.Click += new System.EventHandler(this.lstPurchaseIDList_Click);
            // 
            // btnAuditSignature
            // 
            this.btnAuditSignature.Location = new System.Drawing.Point(21, 351);
            this.btnAuditSignature.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuditSignature.Name = "btnAuditSignature";
            this.btnAuditSignature.Size = new System.Drawing.Size(197, 29);
            this.btnAuditSignature.TabIndex = 28;
            this.btnAuditSignature.Text = "审核签名";
            this.btnAuditSignature.UseVisualStyleBackColor = true;
            this.btnAuditSignature.Click += new System.EventHandler(this.btnAuditSignature_Click);
            // 
            // btnCancelAuditSignature
            // 
            this.btnCancelAuditSignature.Location = new System.Drawing.Point(227, 351);
            this.btnCancelAuditSignature.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelAuditSignature.Name = "btnCancelAuditSignature";
            this.btnCancelAuditSignature.Size = new System.Drawing.Size(197, 29);
            this.btnCancelAuditSignature.TabIndex = 29;
            this.btnCancelAuditSignature.Text = "取消审核签名";
            this.btnCancelAuditSignature.UseVisualStyleBackColor = true;
            this.btnCancelAuditSignature.Click += new System.EventHandler(this.btnCancelAuditSignature_Click);
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(696, 351);
            this.btnRevoke.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(123, 29);
            this.btnRevoke.TabIndex = 30;
            this.btnRevoke.Text = "撤销";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.Location = new System.Drawing.Point(849, 351);
            this.btnRecovery.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(123, 29);
            this.btnRecovery.TabIndex = 31;
            this.btnRecovery.Text = "恢复";
            this.btnRecovery.UseVisualStyleBackColor = true;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 706);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "业务员";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(357, 706);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "审核员";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(693, 706);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 34;
            this.label16.Text = "保管员";
            // 
            // txtSalesman
            // 
            this.txtSalesman.Location = new System.Drawing.Point(76, 702);
            this.txtSalesman.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalesman.Name = "txtSalesman";
            this.txtSalesman.Size = new System.Drawing.Size(253, 25);
            this.txtSalesman.TabIndex = 35;
            // 
            // txtAuditor
            // 
            this.txtAuditor.Location = new System.Drawing.Point(420, 702);
            this.txtAuditor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuditor.Name = "txtAuditor";
            this.txtAuditor.Size = new System.Drawing.Size(253, 25);
            this.txtAuditor.TabIndex = 36;
            // 
            // txtStorekeeper
            // 
            this.txtStorekeeper.Location = new System.Drawing.Point(756, 702);
            this.txtStorekeeper.Margin = new System.Windows.Forms.Padding(4);
            this.txtStorekeeper.Name = "txtStorekeeper";
            this.txtStorekeeper.Size = new System.Drawing.Size(253, 25);
            this.txtStorekeeper.TabIndex = 37;
            // 
            // Frm_ExamPurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 732);
            this.Controls.Add(this.txtStorekeeper);
            this.Controls.Add(this.txtAuditor);
            this.Controls.Add(this.txtSalesman);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnRevoke);
            this.Controls.Add(this.btnCancelAuditSignature);
            this.Controls.Add(this.btnAuditSignature);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ExamPurchaseBill";
            this.Text = "Frm_ExamPurchaseBill";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lstPurchaseIDList, 0);
            this.Controls.SetChildIndex(this.txtNote, 0);
            this.Controls.SetChildIndex(this.dtpIndentDate, 0);
            this.Controls.SetChildIndex(this.cbSupplier, 0);
            this.Controls.SetChildIndex(this.txtStorageDate, 0);
            this.Controls.SetChildIndex(this.txtPurchaseID, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.btnAuditSignature, 0);
            this.Controls.SetChildIndex(this.btnCancelAuditSignature, 0);
            this.Controls.SetChildIndex(this.btnRevoke, 0);
            this.Controls.SetChildIndex(this.btnRecovery, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txtSalesman, 0);
            this.Controls.SetChildIndex(this.txtAuditor, 0);
            this.Controls.SetChildIndex(this.txtStorekeeper, 0);
            this.Controls.SetChildIndex(this.txtState, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuditSignature;
        private System.Windows.Forms.Button btnCancelAuditSignature;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSalesman;
        private System.Windows.Forms.TextBox txtAuditor;
        private System.Windows.Forms.TextBox txtStorekeeper;
    }
}