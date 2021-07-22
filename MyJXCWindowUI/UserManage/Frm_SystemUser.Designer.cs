namespace LuQiJing.MyJXCWindowUI.UserManage
{
    partial class Frm_SystemUser
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
            this.lstUserList = new System.Windows.Forms.ListBox();
            this.btnVastSelectPurview = new System.Windows.Forms.Button();
            this.btnVastClearPurview = new System.Windows.Forms.Button();
            this.btnVastRestorePurview = new System.Windows.Forms.Button();
            this.btnAccSelectPurview = new System.Windows.Forms.Button();
            this.btnAccClearPurview = new System.Windows.Forms.Button();
            this.btnAccRestorePurview = new System.Windows.Forms.Button();
            this.btnSellSelectPurview = new System.Windows.Forms.Button();
            this.btnSellClearPurview = new System.Windows.Forms.Button();
            this.btnSellRestorePurview = new System.Windows.Forms.Button();
            this.btnUserSelectPurview = new System.Windows.Forms.Button();
            this.btnUserClearPurview = new System.Windows.Forms.Button();
            this.btnUserRestorePurview = new System.Windows.Forms.Button();
            this.btnRestoreAllPurview = new System.Windows.Forms.Button();
            this.btnClearAllPurview = new System.Windows.Forms.Button();
            this.btnSelectAllPurview = new System.Windows.Forms.Button();
            this.gbVast = new System.Windows.Forms.GroupBox();
            this.chkSupplierInformation = new System.Windows.Forms.CheckBox();
            this.chkProductInformation = new System.Windows.Forms.CheckBox();
            this.chkEmployeeInformation = new System.Windows.Forms.CheckBox();
            this.chkClentInformation = new System.Windows.Forms.CheckBox();
            this.chkProductManager = new System.Windows.Forms.CheckBox();
            this.gbAcc = new System.Windows.Forms.GroupBox();
            this.chkWriteBill = new System.Windows.Forms.CheckBox();
            this.chkCheckBill = new System.Windows.Forms.CheckBox();
            this.chkCheckCargo = new System.Windows.Forms.CheckBox();
            this.gbSell = new System.Windows.Forms.GroupBox();
            this.chkForeSell = new System.Windows.Forms.CheckBox();
            this.chkSellReturn = new System.Windows.Forms.CheckBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.chkUpdatePassWord = new System.Windows.Forms.CheckBox();
            this.chkUserManage = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.gbVast.SuspendLayout();
            this.gbAcc.SuspendLayout();
            this.gbSell.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户列表";
            // 
            // lstUserList
            // 
            this.lstUserList.FormattingEnabled = true;
            this.lstUserList.ItemHeight = 12;
            this.lstUserList.Location = new System.Drawing.Point(11, 33);
            this.lstUserList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstUserList.Name = "lstUserList";
            this.lstUserList.Size = new System.Drawing.Size(148, 508);
            this.lstUserList.TabIndex = 1;
            this.lstUserList.Click += new System.EventHandler(this.lstUserList_Click);
            // 
            // btnVastSelectPurview
            // 
            this.btnVastSelectPurview.Location = new System.Drawing.Point(177, 186);
            this.btnVastSelectPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVastSelectPurview.Name = "btnVastSelectPurview";
            this.btnVastSelectPurview.Size = new System.Drawing.Size(74, 18);
            this.btnVastSelectPurview.TabIndex = 2;
            this.btnVastSelectPurview.Text = "选择权限";
            this.btnVastSelectPurview.UseVisualStyleBackColor = true;
            this.btnVastSelectPurview.Click += new System.EventHandler(this.btnVastSelectPurview_Click);
            // 
            // btnVastClearPurview
            // 
            this.btnVastClearPurview.Location = new System.Drawing.Point(177, 209);
            this.btnVastClearPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVastClearPurview.Name = "btnVastClearPurview";
            this.btnVastClearPurview.Size = new System.Drawing.Size(74, 18);
            this.btnVastClearPurview.TabIndex = 3;
            this.btnVastClearPurview.Text = "清除权限";
            this.btnVastClearPurview.UseVisualStyleBackColor = true;
            this.btnVastClearPurview.Click += new System.EventHandler(this.btnVastClearPurview_Click);
            // 
            // btnVastRestorePurview
            // 
            this.btnVastRestorePurview.Enabled = false;
            this.btnVastRestorePurview.Location = new System.Drawing.Point(177, 232);
            this.btnVastRestorePurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVastRestorePurview.Name = "btnVastRestorePurview";
            this.btnVastRestorePurview.Size = new System.Drawing.Size(74, 18);
            this.btnVastRestorePurview.TabIndex = 4;
            this.btnVastRestorePurview.Text = "恢复权限";
            this.btnVastRestorePurview.UseVisualStyleBackColor = true;
            this.btnVastRestorePurview.Click += new System.EventHandler(this.btnVastRestorePurview_Click);
            // 
            // btnAccSelectPurview
            // 
            this.btnAccSelectPurview.Location = new System.Drawing.Point(177, 279);
            this.btnAccSelectPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccSelectPurview.Name = "btnAccSelectPurview";
            this.btnAccSelectPurview.Size = new System.Drawing.Size(74, 18);
            this.btnAccSelectPurview.TabIndex = 5;
            this.btnAccSelectPurview.Text = "选择权限";
            this.btnAccSelectPurview.UseVisualStyleBackColor = true;
            this.btnAccSelectPurview.Click += new System.EventHandler(this.btnAccSelectPurview_Click);
            // 
            // btnAccClearPurview
            // 
            this.btnAccClearPurview.Location = new System.Drawing.Point(177, 302);
            this.btnAccClearPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccClearPurview.Name = "btnAccClearPurview";
            this.btnAccClearPurview.Size = new System.Drawing.Size(74, 18);
            this.btnAccClearPurview.TabIndex = 6;
            this.btnAccClearPurview.Text = "清除权限";
            this.btnAccClearPurview.UseVisualStyleBackColor = true;
            this.btnAccClearPurview.Click += new System.EventHandler(this.btnAccClearPurview_Click);
            // 
            // btnAccRestorePurview
            // 
            this.btnAccRestorePurview.Enabled = false;
            this.btnAccRestorePurview.Location = new System.Drawing.Point(177, 326);
            this.btnAccRestorePurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccRestorePurview.Name = "btnAccRestorePurview";
            this.btnAccRestorePurview.Size = new System.Drawing.Size(74, 18);
            this.btnAccRestorePurview.TabIndex = 7;
            this.btnAccRestorePurview.Text = "恢复权限";
            this.btnAccRestorePurview.UseVisualStyleBackColor = true;
            this.btnAccRestorePurview.Click += new System.EventHandler(this.btnAccRestorePurview_Click);
            // 
            // btnSellSelectPurview
            // 
            this.btnSellSelectPurview.Location = new System.Drawing.Point(177, 380);
            this.btnSellSelectPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSellSelectPurview.Name = "btnSellSelectPurview";
            this.btnSellSelectPurview.Size = new System.Drawing.Size(74, 18);
            this.btnSellSelectPurview.TabIndex = 8;
            this.btnSellSelectPurview.Text = "选择权限";
            this.btnSellSelectPurview.UseVisualStyleBackColor = true;
            this.btnSellSelectPurview.Click += new System.EventHandler(this.btnSellSelectPurview_Click);
            // 
            // btnSellClearPurview
            // 
            this.btnSellClearPurview.Location = new System.Drawing.Point(177, 403);
            this.btnSellClearPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSellClearPurview.Name = "btnSellClearPurview";
            this.btnSellClearPurview.Size = new System.Drawing.Size(74, 18);
            this.btnSellClearPurview.TabIndex = 9;
            this.btnSellClearPurview.Text = "清除权限";
            this.btnSellClearPurview.UseVisualStyleBackColor = true;
            this.btnSellClearPurview.Click += new System.EventHandler(this.btnSellClearPurview_Click);
            // 
            // btnSellRestorePurview
            // 
            this.btnSellRestorePurview.Enabled = false;
            this.btnSellRestorePurview.Location = new System.Drawing.Point(177, 426);
            this.btnSellRestorePurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSellRestorePurview.Name = "btnSellRestorePurview";
            this.btnSellRestorePurview.Size = new System.Drawing.Size(74, 18);
            this.btnSellRestorePurview.TabIndex = 10;
            this.btnSellRestorePurview.Text = "恢复权限";
            this.btnSellRestorePurview.UseVisualStyleBackColor = true;
            this.btnSellRestorePurview.Click += new System.EventHandler(this.btnSellRestorePurview_Click);
            // 
            // btnUserSelectPurview
            // 
            this.btnUserSelectPurview.Location = new System.Drawing.Point(177, 475);
            this.btnUserSelectPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserSelectPurview.Name = "btnUserSelectPurview";
            this.btnUserSelectPurview.Size = new System.Drawing.Size(74, 18);
            this.btnUserSelectPurview.TabIndex = 11;
            this.btnUserSelectPurview.Text = "选择权限";
            this.btnUserSelectPurview.UseVisualStyleBackColor = true;
            this.btnUserSelectPurview.Click += new System.EventHandler(this.btnUserSelectPurview_Click);
            // 
            // btnUserClearPurview
            // 
            this.btnUserClearPurview.Location = new System.Drawing.Point(177, 498);
            this.btnUserClearPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserClearPurview.Name = "btnUserClearPurview";
            this.btnUserClearPurview.Size = new System.Drawing.Size(74, 18);
            this.btnUserClearPurview.TabIndex = 12;
            this.btnUserClearPurview.Text = "清除权限";
            this.btnUserClearPurview.UseVisualStyleBackColor = true;
            this.btnUserClearPurview.Click += new System.EventHandler(this.btnUserClearPurview_Click);
            // 
            // btnUserRestorePurview
            // 
            this.btnUserRestorePurview.Enabled = false;
            this.btnUserRestorePurview.Location = new System.Drawing.Point(177, 522);
            this.btnUserRestorePurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserRestorePurview.Name = "btnUserRestorePurview";
            this.btnUserRestorePurview.Size = new System.Drawing.Size(74, 18);
            this.btnUserRestorePurview.TabIndex = 13;
            this.btnUserRestorePurview.Text = "恢复权限";
            this.btnUserRestorePurview.UseVisualStyleBackColor = true;
            this.btnUserRestorePurview.Click += new System.EventHandler(this.btnUserRestorePurview_Click);
            // 
            // btnRestoreAllPurview
            // 
            this.btnRestoreAllPurview.Enabled = false;
            this.btnRestoreAllPurview.Location = new System.Drawing.Point(588, 139);
            this.btnRestoreAllPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestoreAllPurview.Name = "btnRestoreAllPurview";
            this.btnRestoreAllPurview.Size = new System.Drawing.Size(111, 26);
            this.btnRestoreAllPurview.TabIndex = 14;
            this.btnRestoreAllPurview.Text = "恢复全部权限";
            this.btnRestoreAllPurview.UseVisualStyleBackColor = true;
            this.btnRestoreAllPurview.Click += new System.EventHandler(this.btnRestoreAllPurview_Click);
            // 
            // btnClearAllPurview
            // 
            this.btnClearAllPurview.Location = new System.Drawing.Point(443, 139);
            this.btnClearAllPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearAllPurview.Name = "btnClearAllPurview";
            this.btnClearAllPurview.Size = new System.Drawing.Size(111, 26);
            this.btnClearAllPurview.TabIndex = 15;
            this.btnClearAllPurview.Text = "清除全部权限";
            this.btnClearAllPurview.UseVisualStyleBackColor = true;
            this.btnClearAllPurview.Click += new System.EventHandler(this.btnClearAllPurview_Click);
            // 
            // btnSelectAllPurview
            // 
            this.btnSelectAllPurview.Location = new System.Drawing.Point(300, 139);
            this.btnSelectAllPurview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectAllPurview.Name = "btnSelectAllPurview";
            this.btnSelectAllPurview.Size = new System.Drawing.Size(111, 26);
            this.btnSelectAllPurview.TabIndex = 16;
            this.btnSelectAllPurview.Text = "选择全部权限";
            this.btnSelectAllPurview.UseVisualStyleBackColor = true;
            this.btnSelectAllPurview.Click += new System.EventHandler(this.btnSelectAllPurview_Click);
            // 
            // gbVast
            // 
            this.gbVast.Controls.Add(this.chkSupplierInformation);
            this.gbVast.Controls.Add(this.chkProductInformation);
            this.gbVast.Controls.Add(this.chkEmployeeInformation);
            this.gbVast.Controls.Add(this.chkClentInformation);
            this.gbVast.Controls.Add(this.chkProductManager);
            this.gbVast.Location = new System.Drawing.Point(255, 186);
            this.gbVast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbVast.Name = "gbVast";
            this.gbVast.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbVast.Size = new System.Drawing.Size(472, 86);
            this.gbVast.TabIndex = 17;
            this.gbVast.TabStop = false;
            this.gbVast.Text = "基础信息管理";
            // 
            // chkSupplierInformation
            // 
            this.chkSupplierInformation.AutoSize = true;
            this.chkSupplierInformation.Location = new System.Drawing.Point(22, 40);
            this.chkSupplierInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSupplierInformation.Name = "chkSupplierInformation";
            this.chkSupplierInformation.Size = new System.Drawing.Size(108, 16);
            this.chkSupplierInformation.TabIndex = 4;
            this.chkSupplierInformation.Text = "供应商信息管理";
            this.chkSupplierInformation.UseVisualStyleBackColor = true;
            // 
            // chkProductInformation
            // 
            this.chkProductInformation.AutoSize = true;
            this.chkProductInformation.Location = new System.Drawing.Point(309, 19);
            this.chkProductInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkProductInformation.Name = "chkProductInformation";
            this.chkProductInformation.Size = new System.Drawing.Size(96, 16);
            this.chkProductInformation.TabIndex = 3;
            this.chkProductInformation.Text = "产品信息管理";
            this.chkProductInformation.UseVisualStyleBackColor = true;
            // 
            // chkEmployeeInformation
            // 
            this.chkEmployeeInformation.AutoSize = true;
            this.chkEmployeeInformation.Location = new System.Drawing.Point(22, 60);
            this.chkEmployeeInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEmployeeInformation.Name = "chkEmployeeInformation";
            this.chkEmployeeInformation.Size = new System.Drawing.Size(96, 16);
            this.chkEmployeeInformation.TabIndex = 2;
            this.chkEmployeeInformation.Text = "员工信息管理";
            this.chkEmployeeInformation.UseVisualStyleBackColor = true;
            // 
            // chkClentInformation
            // 
            this.chkClentInformation.AutoSize = true;
            this.chkClentInformation.Location = new System.Drawing.Point(310, 50);
            this.chkClentInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkClentInformation.Name = "chkClentInformation";
            this.chkClentInformation.Size = new System.Drawing.Size(96, 16);
            this.chkClentInformation.TabIndex = 1;
            this.chkClentInformation.Text = "客户信息管理";
            this.chkClentInformation.UseVisualStyleBackColor = true;
            // 
            // chkProductManager
            // 
            this.chkProductManager.AutoSize = true;
            this.chkProductManager.Location = new System.Drawing.Point(22, 20);
            this.chkProductManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkProductManager.Name = "chkProductManager";
            this.chkProductManager.Size = new System.Drawing.Size(96, 16);
            this.chkProductManager.TabIndex = 0;
            this.chkProductManager.Text = "产品分类管理";
            this.chkProductManager.UseVisualStyleBackColor = true;
            // 
            // gbAcc
            // 
            this.gbAcc.Controls.Add(this.chkWriteBill);
            this.gbAcc.Controls.Add(this.chkCheckBill);
            this.gbAcc.Controls.Add(this.chkCheckCargo);
            this.gbAcc.Location = new System.Drawing.Point(255, 279);
            this.gbAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAcc.Name = "gbAcc";
            this.gbAcc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAcc.Size = new System.Drawing.Size(472, 78);
            this.gbAcc.TabIndex = 18;
            this.gbAcc.TabStop = false;
            this.gbAcc.Text = "进货管理";
            // 
            // chkWriteBill
            // 
            this.chkWriteBill.AutoSize = true;
            this.chkWriteBill.Location = new System.Drawing.Point(22, 26);
            this.chkWriteBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkWriteBill.Name = "chkWriteBill";
            this.chkWriteBill.Size = new System.Drawing.Size(84, 16);
            this.chkWriteBill.TabIndex = 5;
            this.chkWriteBill.Text = "填写进货单";
            this.chkWriteBill.UseVisualStyleBackColor = true;
            // 
            // chkCheckBill
            // 
            this.chkCheckBill.AutoSize = true;
            this.chkCheckBill.Location = new System.Drawing.Point(310, 26);
            this.chkCheckBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCheckBill.Name = "chkCheckBill";
            this.chkCheckBill.Size = new System.Drawing.Size(84, 16);
            this.chkCheckBill.TabIndex = 4;
            this.chkCheckBill.Text = "审核进货单";
            this.chkCheckBill.UseVisualStyleBackColor = true;
            // 
            // chkCheckCargo
            // 
            this.chkCheckCargo.AutoSize = true;
            this.chkCheckCargo.Location = new System.Drawing.Point(22, 50);
            this.chkCheckCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCheckCargo.Name = "chkCheckCargo";
            this.chkCheckCargo.Size = new System.Drawing.Size(72, 16);
            this.chkCheckCargo.TabIndex = 3;
            this.chkCheckCargo.Text = "检验货物";
            this.chkCheckCargo.UseVisualStyleBackColor = true;
            // 
            // gbSell
            // 
            this.gbSell.Controls.Add(this.chkForeSell);
            this.gbSell.Controls.Add(this.chkSellReturn);
            this.gbSell.Location = new System.Drawing.Point(255, 375);
            this.gbSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSell.Name = "gbSell";
            this.gbSell.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSell.Size = new System.Drawing.Size(472, 85);
            this.gbSell.TabIndex = 18;
            this.gbSell.TabStop = false;
            this.gbSell.Text = "销售管理";
            // 
            // chkForeSell
            // 
            this.chkForeSell.AutoSize = true;
            this.chkForeSell.Location = new System.Drawing.Point(22, 35);
            this.chkForeSell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkForeSell.Name = "chkForeSell";
            this.chkForeSell.Size = new System.Drawing.Size(96, 16);
            this.chkForeSell.TabIndex = 4;
            this.chkForeSell.Text = "前台销售管理";
            this.chkForeSell.UseVisualStyleBackColor = true;
            // 
            // chkSellReturn
            // 
            this.chkSellReturn.AutoSize = true;
            this.chkSellReturn.Location = new System.Drawing.Point(310, 35);
            this.chkSellReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSellReturn.Name = "chkSellReturn";
            this.chkSellReturn.Size = new System.Drawing.Size(72, 16);
            this.chkSellReturn.TabIndex = 3;
            this.chkSellReturn.Text = "销售退货";
            this.chkSellReturn.UseVisualStyleBackColor = true;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.chkUpdatePassWord);
            this.gbUser.Controls.Add(this.chkUserManage);
            this.gbUser.Location = new System.Drawing.Point(255, 475);
            this.gbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUser.Name = "gbUser";
            this.gbUser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUser.Size = new System.Drawing.Size(472, 80);
            this.gbUser.TabIndex = 18;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "用户管理";
            // 
            // chkUpdatePassWord
            // 
            this.chkUpdatePassWord.AutoSize = true;
            this.chkUpdatePassWord.Location = new System.Drawing.Point(22, 39);
            this.chkUpdatePassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkUpdatePassWord.Name = "chkUpdatePassWord";
            this.chkUpdatePassWord.Size = new System.Drawing.Size(72, 16);
            this.chkUpdatePassWord.TabIndex = 4;
            this.chkUpdatePassWord.Text = "修改密码";
            this.chkUpdatePassWord.UseVisualStyleBackColor = true;
            // 
            // chkUserManage
            // 
            this.chkUserManage.AutoSize = true;
            this.chkUserManage.Location = new System.Drawing.Point(310, 39);
            this.chkUserManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkUserManage.Name = "chkUserManage";
            this.chkUserManage.Size = new System.Drawing.Size(72, 16);
            this.chkUserManage.TabIndex = 3;
            this.chkUserManage.Text = "用户管理";
            this.chkUserManage.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(59, 568);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(293, 26);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(382, 568);
            this.btnCencel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(293, 26);
            this.btnCencel.TabIndex = 20;
            this.btnCencel.Text = "取消";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "密  码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "姓名：";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(298, 30);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(161, 21);
            this.txtUserID.TabIndex = 24;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(298, 78);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(161, 21);
            this.txtPassWord.TabIndex = 25;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(547, 30);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(161, 21);
            this.txtUserName.TabIndex = 26;
            // 
            // Frm_SystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 605);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCencel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbSell);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbAcc);
            this.Controls.Add(this.gbVast);
            this.Controls.Add(this.btnSelectAllPurview);
            this.Controls.Add(this.btnClearAllPurview);
            this.Controls.Add(this.btnRestoreAllPurview);
            this.Controls.Add(this.btnUserRestorePurview);
            this.Controls.Add(this.btnUserClearPurview);
            this.Controls.Add(this.btnUserSelectPurview);
            this.Controls.Add(this.btnSellRestorePurview);
            this.Controls.Add(this.btnSellClearPurview);
            this.Controls.Add(this.btnSellSelectPurview);
            this.Controls.Add(this.btnAccRestorePurview);
            this.Controls.Add(this.btnAccClearPurview);
            this.Controls.Add(this.btnAccSelectPurview);
            this.Controls.Add(this.btnVastRestorePurview);
            this.Controls.Add(this.btnVastClearPurview);
            this.Controls.Add(this.btnVastSelectPurview);
            this.Controls.Add(this.lstUserList);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_SystemUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SystemUser";
            this.Load += new System.EventHandler(this.Frm_SystemUser_Load);
            this.gbVast.ResumeLayout(false);
            this.gbVast.PerformLayout();
            this.gbAcc.ResumeLayout(false);
            this.gbAcc.PerformLayout();
            this.gbSell.ResumeLayout(false);
            this.gbSell.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstUserList;
        private System.Windows.Forms.Button btnVastSelectPurview;
        private System.Windows.Forms.Button btnVastClearPurview;
        private System.Windows.Forms.Button btnVastRestorePurview;
        private System.Windows.Forms.Button btnAccSelectPurview;
        private System.Windows.Forms.Button btnAccClearPurview;
        private System.Windows.Forms.Button btnAccRestorePurview;
        private System.Windows.Forms.Button btnSellSelectPurview;
        private System.Windows.Forms.Button btnSellClearPurview;
        private System.Windows.Forms.Button btnSellRestorePurview;
        private System.Windows.Forms.Button btnUserSelectPurview;
        private System.Windows.Forms.Button btnUserClearPurview;
        private System.Windows.Forms.Button btnUserRestorePurview;
        private System.Windows.Forms.Button btnRestoreAllPurview;
        private System.Windows.Forms.Button btnClearAllPurview;
        private System.Windows.Forms.Button btnSelectAllPurview;
        private System.Windows.Forms.GroupBox gbVast;
        private System.Windows.Forms.GroupBox gbAcc;
        private System.Windows.Forms.GroupBox gbSell;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.CheckBox chkSupplierInformation;
        private System.Windows.Forms.CheckBox chkProductInformation;
        private System.Windows.Forms.CheckBox chkEmployeeInformation;
        private System.Windows.Forms.CheckBox chkClentInformation;
        private System.Windows.Forms.CheckBox chkProductManager;
        private System.Windows.Forms.CheckBox chkWriteBill;
        private System.Windows.Forms.CheckBox chkCheckBill;
        private System.Windows.Forms.CheckBox chkCheckCargo;
        private System.Windows.Forms.CheckBox chkForeSell;
        private System.Windows.Forms.CheckBox chkSellReturn;
        private System.Windows.Forms.CheckBox chkUpdatePassWord;
        private System.Windows.Forms.CheckBox chkUserManage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
    }
}