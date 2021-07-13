using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WFORMHW3
{
    public partial class Form1 : Form
    {
      
        public List<Employee> Employees { get; set; }
        Form2 form2;


        public Employee SelectedEmployee { get; set; }
       
        public Form1()
        {
            InitializeComponent();
            Employees = new List<Employee>();
           form2 = new Form2(this);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));


                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    Employees = (List<Employee>)xmlSerializer.Deserialize(fs);

                }
                for (int i = 0; i < Employees.Count; i++)
                {
                    listBox1.Items.Add(Employees[i].SurName + " " + Employees[i].Name + " " + Employees[i].FatherName + " " + Employees[i].Birthday + " " + Employees[i].BirthPlace + " ");
                }
            }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Txt file(*.txt) |*.txt";
            

           


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
                try
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        xmlSerializer.Serialize(fs, Employees);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("The file cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Clear();
            this.Empty();
        }

        private void Clear() {

            listBox1.Items.Clear();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee Employee = new Employee(StextBox.Text, NtextBox.Text, FtextBox.Text, DateTime.Parse(BDtextBox.Text), BPtextBox.Text);
            Employees.Add(Employee);
            listBox1.Items.Add(Employee.SurName + " " + Employee.Name + " " + Employee.FatherName + " " + Employee.Birthday + " " + Employee.BirthPlace + " ");
            this.Empty();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedEmployee = Employees[listBox1.SelectedIndex];
            StextBox.Text = SelectedEmployee.SurName;
            NtextBox.Text = SelectedEmployee.Name;
            FtextBox.Text = SelectedEmployee.FatherName;
            BDtextBox.Text = SelectedEmployee.Birthday.ToString();
            BPtextBox.Text = SelectedEmployee.BirthPlace;

           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
           Employees.RemoveAt(listBox1.SelectedIndex);
            this.Clear();
            foreach (var item in Employees)
            {
                listBox1.Items.Add(item.SurName + " " + item.Name + " " + item.FatherName + " " + item.Birthday + " " + item.BirthPlace + " ");
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees[listBox1.SelectedIndex]=new Employee(StextBox.Text,NtextBox.Text,FtextBox.Text,DateTime.Parse(BDtextBox.Text),BPtextBox.Text);
            this.Clear();
            foreach (var item in Employees)
            {
                listBox1.Items.Add(item.SurName + " " + item.Name + " " + item.FatherName + " " + item.Birthday + " " + item.BirthPlace + " ");
            }
        }

        private void bullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Clear();

            foreach (var item in Employees) {

                if (item.Birthday.Year.ToString() == "1901") 
                {


                    listBox1.Items.Add(item.SurName + " " + item.Name + " " + item.FatherName + " " + item.Birthday + " " + item.BirthPlace + " ");
                
                }
            }
           
        }
        private void Empty() {

            StextBox.Text = string.Empty;
            NtextBox.Text = string.Empty;
            FtextBox.Text = string.Empty;
            BDtextBox.Text = string.Empty;
            BPtextBox.Text = string.Empty;

        
        }

        private void givenDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
