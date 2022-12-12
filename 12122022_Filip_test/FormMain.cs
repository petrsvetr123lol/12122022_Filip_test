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
            //if not selected, tak se to neotevre
            var formEdit = new FormEdit();
            formEdit.Show(this);
            return;
            //else otevre
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V databázi se aktuálně nachází " + sqlRepository.CountEmployee().ToString()+ " uživatelů.");
        }
    }
}