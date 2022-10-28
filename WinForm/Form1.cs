using System.Drawing.Text;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("Форма без переключения");
            f.PubText = "Привет от материнской формы";
            f.ShowDialog("Привет от ShowDialog");
            f.Close();
            Form2 f2 = new Form2("Форма с переключем");
            f2.Show();
            f2.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2("");
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(frm2.PubText);
            }
        }
    }
}

