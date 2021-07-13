using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFORMHW3
{
    public partial class Form2 : Form
    {
        Form1 Form1;
        public Form2(Form1 form1 )
        {
            InitializeComponent();
            Form1 = form1;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            foreach (var item in Form1.Employees)
            {
                if (textBox1.Text == item.Birthday.Year.ToString())
                {

                    listBox1.Items.Add(item.SurName + " " + item.Name + " " + item.FatherName + " " + item.Birthday + " " + item.BirthPlace + " ");
                }
               
            }
            if (listBox1.Items == null) 
            {
                MessageBox.Show("No Match");
            }
        }
    }
}
