namespace _12122022_Filip_test
{
    public partial class Form1 : Form
    {
        List<Employee> employees;
        SqlRepository sqlRepository = new SqlRepository();
        public Form1()
        {
            InitializeComponent();
            employees = sqlRepository.GetEmployees();
            RefreshGUI();
        }

        private void RefreshGUI()
        {
            listView1.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    employee.Id.ToString(),
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

        }
    }
}