using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12122022_Filip_test
{
    public partial class FormAdd : Form
    {
        private Employee? employee;

        public FormAdd(Employee? employee)
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlRepository sqlRepository = new SqlRepository();
                employee = new Employee(firstNameTxt.Text,lastNameTxt.Text,phoneTxt.Text,emailTxt.Text,birthDatePicker.Value);
                sqlRepository.CreateEmployee(employee);
                FormMain formMain = new FormMain();
                this.Close();
                formMain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nelze přidat více uživatelů stejného příjmení! "+ ex.Message);
            }
         
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Close();
            formMain.Show();
        }
    }
}
