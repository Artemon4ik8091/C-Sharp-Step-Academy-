namespace WinForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void mi_Theme_light_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itlight = (ToolStripMenuItem)sender;
            if(itlight.Checked == true)
            {
                this.BackColor = Color.White;
            }
            mi_Theme_dark.Checked = false;
        }      
        private void mi_Theme_dark_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem itdark = (ToolStripMenuItem)sender;
            if (itdark.Checked == true)
            {
                this.BackColor = Color.Gray;
            }
            mi_Theme_light.Checked = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}