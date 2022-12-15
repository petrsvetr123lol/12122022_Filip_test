namespace _12122022_Filip_test
{
    public partial class FormMain : Form
    {
        List<Employee> employees;
        SqlRepository sqlRepository = new SqlRepository();
        public FormMain()
        {
            InitializeComponent();
            employees = sqlRepository.GetEmployees();
            RefreshGUI();
        }

        public void RefreshGUI()
        {
            listView1.Items.Clear();

            foreach (Employee employee in employees)
            {
                
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    employee.FirstName.ToString(),
                    employee.LastName.ToString(),
                    employee.Phone.ToString(),
                    employee.Email.ToString(),
                    employee.Birthdate.ToString("dd.MM.yyyy")
                });
                listView1.Items.Add(listViewItem);

                
            }
        }

             

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdd  formAdd = new FormAdd(null);
            formAdd.Show();            


        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                this.Hide();
                FormEdit formEdit = new FormEdit();
                formEdit.Show();
                var selectedRow = listView1.SelectedItems[0];
                var firstname = selectedRow.SubItems[0].Text;
                var lastname = selectedRow.SubItems[1].Text;
                var phone = selectedRow.SubItems[2].Text;
                var email = selectedRow.SubItems[3].Text;
                var birthdate = selectedRow.SubItems[4].Text;
                formEdit.GetData(firstname, lastname, phone, email,birthdate);
            }
            else
            {
                MessageBox.Show("Nebyl vybrát uživatel k editaci");
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nebyl vybrán uživatel ke smazání");
               
            }
            else
            {
                var selectedRow = listView1.SelectedItems[0];
                string lastName = selectedRow.SubItems[1].Text;
                sqlRepository.RemoveEmployees(lastName);
                listView1.SelectedItems[0].Remove();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("V databázi se aktuálně nachází " + sqlRepository.CountEmployee().ToString()+ " uživatelů.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sqlRepository.OldestEmployee();
        }
    }
}