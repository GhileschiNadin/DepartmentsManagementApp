using System.Net.Mail;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        EmployeeService employeeService;
        DepartmentService departmentService;
        List<Employee> employeeList;
        List<Department> departmentsList;
        List<Employee> employeesPerDep;
        List<Employee> managersPerDep;

        public Form1()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            employeeService.createConnection();
            departmentService = new DepartmentService();
            departmentService.createConnection();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var employeeList = employeeService.GetEmployees();

            comboBox1.DataSource = employeeList;
            comboBox1.DisplayMember = "employeeName";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var departmentsList = departmentService.GetDepartments();

            comboBox2.DataSource = departmentsList;
            comboBox2.DisplayMember = "departmentName";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                Department selectedDepartment = (Department)comboBox2.SelectedItem;

                int selectedDepartmentId = selectedDepartment.id;

                employeesPerDep = employeeService.GetEmployeesPerDepartment(selectedDepartmentId);

                comboBox3.DataSource = employeesPerDep;
                comboBox3.DisplayMember = "employeeName";
            }
            else
            {
                MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                Department selectedDepartment = (Department)comboBox2.SelectedItem;

                int selectedDepartmentId = selectedDepartment.id;

                managersPerDep = employeeService.GetManagersPerDepartment(selectedDepartmentId);

                comboBox4.DataSource = managersPerDep;
                comboBox4.DisplayMember = "employeeName";
            }
            else
            {
                MessageBox.Show("Please select a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Please select employees to send emails.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the email content from richTextBox1
            string emailContent = richTextBox1.Text;
            string subject = textBox1.Text;

            // Iterate through selected employees in listBox1 and send emails
            foreach (Employee selectedEmployee in listBox1.Items)
            {
                SendEmail(selectedEmployee.email, subject, emailContent);
            }

            richTextBox1.Text = "The email was sent successfully.";

            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee employee = (Employee)comboBox1.SelectedItem;

            listBox1.Items.Add(employee);
            listBox1.DisplayMember = "employeeName";
        }

        private void SendEmail(string to, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("ghileschinadin@gmail.com");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("ghileschinadin@gmail.com", "jfxi uvaa blpg mlku");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log, show error message)
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}