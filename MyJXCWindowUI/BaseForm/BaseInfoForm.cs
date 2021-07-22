using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuQiJing.MyJXCWindowUI.BaseForm
{
    public partial class BaseInfoForm : Form
    {
        protected Operation op;
        protected string qID="",qName="";
        public BaseInfoForm()
        {
            InitializeComponent();
            op = Operation.None;
        }

        private void btnNewInsert_Click(object sender, EventArgs e)
        {
            op = Operation.Insert;
            gbInfo.Visible = true;
            gbInfo.Text = "新增记录信息";
            btnNewInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            op = Operation.Update;
            gbInfo.Visible = true;
            gbInfo.Text = "修改记录信息";
            btnNewInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            op = Operation.Delete;
            gbInfo.Visible = true;
            gbInfo.Text = "删除记录信息";
            btnNewInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            op = Operation.None;
            gbInfo.Text = "";
            gbInfo.Visible = false;
            btnNewInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            qID = txtID.Text.Trim();
            qName = txtName.Text.Trim();

        }
    }
}
