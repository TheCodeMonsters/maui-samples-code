using System;

using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormEmployeeDetails : Form
    {
        public FormEmployeeDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Con esto cerramos la ventana 
        }
    }
}
