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
    public partial class FormEdit : Form

    {
        Employee employee;
        SqlRepository sqlRepository = new SqlRepository();
        public FormEdit()
        {
            InitializeComponent();
            LnameTxt.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Close();
            formMain.Show();
        }

         public void GetData(string firstname, string lastname,string phone, string email, string birthdate)
         {
            nameTxt.Text = firstname;
            LnameTxt.Text = lastname;
            phoneTxt.Text = phone;
            emailTxt.Text = email;
            bDayPicker.Text = birthdate;

         }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlRepository sqlRepository = new SqlRepository();
            employee = new Employee(nameTxt.Text, LnameTxt.Text, phoneTxt.Text, emailTxt.Text, bDayPicker.Value);
            sqlRepository.EditEmployee(employee);
            FormMain formMain = new FormMain();
            this.Close();
            formMain.Show();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
