using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form2 : Form
    {
        public string PubText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                lb_outText.Text = value;
            }
        }
        public Form2(string s)
        {
            InitializeComponent();
            this.Text = s;
        }
        public DialogResult ShowDialog(string s)
        {
            lb_DRText.Text = s;
            return ShowDialog();
        }
        //private void button_Click1(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.OK;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
