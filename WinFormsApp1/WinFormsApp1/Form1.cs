using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmployeeName = textName.Text;
            employeeDetails.EmployeeAge = Convert.ToInt32(textAge.Text);
            employeeDetails.EmployeePosition = textPosition.Text;
            FormEmployeeDetails frm = new FormEmployeeDetails();
            frm.label1.Text = employeeDetails.EmployeeName;
            frm.label2.Text = employeeDetails.EmployeeAge.ToString();
            frm.label3.Text = employeeDetails.EmployeePosition;
            frm.ShowDialog();
        }
    }
}
