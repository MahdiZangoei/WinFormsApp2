using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int i = 0;
        int sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int num = int.Parse(textBox1.Text);
                if (i <= 19)
                {
                    listBox1.Items.Add(num);
                    i++;
                    sum = sum + num;
                    label1.Text = (sum / i).ToString();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("qad 20 nafaro vared kardi.");
                    textBox1.Text = "";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter a Number... \n["+ textBox1.Text +"] Not Number");
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            sum = 0;
            label1.Text = sum.ToString();
            MessageBox.Show("The list box is empty.");

        }
    }
}
