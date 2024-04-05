using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily family in FontFamily.Families)
            {
                comboBox1.Items.Add(family.Name);
            }

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label6.Text = richTextBox1.Text;
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            textBox1.BackColor = dialog.Color;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
                return;
            string familyName = comboBox1.Text;
            label1.Font = new Font(familyName, 12);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Label'in metin rengini kırmızı yap
                label1.ForeColor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Label'in metnini italik yap
                label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
            }
            else
            {
                // RadioButton seçili değilse, Label'in metnini normal yap
                label1.Font = new System.Drawing.Font(label1.Font, FontStyle.Regular);
            }
        }
    }
}
