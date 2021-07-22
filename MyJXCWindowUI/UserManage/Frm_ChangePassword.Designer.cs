namespace LuQiJing.MyJXCWindowUI.UserManage
{
    partial class Frm_ChangePassword
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
            this.btnCancelF = new System.Windows.Forms.Button();
            this.btnConfirmF = new System.Windows.Forms.Button();
            this.txtConfirmPWD = new System.Windows.Forms.TextBox();
            this.txtNewPWD = new System.Windows.Forms.TextBox();
            this.txtOriginalPWD = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelF
            // 
            this.btnCancelF.Location = new System.Drawing.Point(576, 525);
            this.btnCancelF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelF.Name = "btnCancelF";
            this.btnCancelF.Size = new System.Drawing.Size(132, 45);
            this.btnCancelF.TabIndex = 15;
            this.btnCancelF.Text = "取消";
            this.btnCancelF.UseVisualStyleBackColor = true;
            this.btnCancelF.Click += new System.EventHandler(this.btnCancelF_Click);
            // 
            // btnConfirmF
            // 
            this.btnConfirmF.Location = new System.Drawing.Point(273, 525);
            this.btnConfirmF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmF.Name = "btnConfirmF";
            this.btnConfirmF.Size = new System.Drawing.Size(132, 45);
            this.btnConfirmF.TabIndex = 14;
            this.btnConfirmF.Text = "确定";
            this.btnConfirmF.UseVisualStyleBackColor = true;
            this.btnConfirmF.Click += new System.EventHandler(this.btnConfirmF_Click);
            // 
            // txtConfirmPWD
            // 
            this.txtConfirmPWD.Location = new System.Drawing.Point(433, 366);
            this.txtConfirmPWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPWD.Name = "txtConfirmPWD";
            this.txtConfirmPWD.PasswordChar = '*';
            this.txtConfirmPWD.Size = new System.Drawing.Size(132, 25);
            this.txtConfirmPWD.TabIndex = 13;
            // 
            // txtNewPWD
            // 
            this.txtNewPWD.Location = new System.Drawing.Point(433, 272);
            this.txtNewPWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPWD.Name = "txtNewPWD";
            this.txtNewPWD.PasswordChar = '*';
            this.txtNewPWD.Size = new System.Drawing.Size(132, 25);
            this.txtNewPWD.TabIndex = 12;
            // 
            // txtOriginalPWD
            // 
            this.txtOriginalPWD.Location = new System.Drawing.Point(433, 171);
            this.txtOriginalPWD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOriginalPWD.Name = "txtOriginalPWD";
            this.txtOriginalPWD.PasswordChar = '*';
            this.txtOriginalPWD.Size = new System.Drawing.Size(132, 25);
            this.txtOriginalPWD.TabIndex = 11;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(339, 370);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(82, 15);
            this.label39.TabIndex = 10;
            this.label39.Text = "确认密码：";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(339, 276);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(82, 15);
            this.label38.TabIndex = 9;
            this.label38.Text = "修改密码：";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(339, 175);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(82, 15);
            this.label37.TabIndex = 8;
            this.label37.Text = "原始密码：";
            // 
            // Frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 756);
            this.Controls.Add(this.btnCancelF);
            this.Controls.Add(this.btnConfirmF);
            this.Controls.Add(this.txtConfirmPWD);
            this.Controls.Add(this.txtNewPWD);
            this.Controls.Add(this.txtOriginalPWD);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelF;
        private System.Windows.Forms.Button btnConfirmF;
        private System.Windows.Forms.TextBox txtConfirmPWD;
        private System.Windows.Forms.TextBox txtNewPWD;
        private System.Windows.Forms.TextBox txtOriginalPWD;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
    }
}