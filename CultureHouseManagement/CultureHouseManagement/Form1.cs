using System;
using System.Windows.Forms;

namespace CulturalCenterManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeEventComponents();
            InitializeEmployeeComponents();
            InitializeResultComponents();
        }

        private void InitializeEventComponents()
        {
            cboEventType.Items.AddRange(new string[] { "Лекція", "Виставка", "Семінар", "Музейний тур", "Прогулянка" });

            dataGridViewEvent.Columns.Add("EventName", "Назва події");
            dataGridViewEvent.Columns.Add("EventType", "Тип події");
            dataGridViewEvent.Columns.Add("EventStart", "Дата початку");
            dataGridViewEvent.Columns.Add("EventEnd", "Дата кінця");

            btnAddEvent.Click += BtnAddEvent_Click;
            btnDeleteEvent.Click += BtnDeleteEvent_Click;
        }
        private void InitializeEmployeeComponents()
        {
            cboEmployeeType.Items.AddRange(new string[] { "Викладач", "Громадський діяч", "Гід" });

            dataGridViewEmployee.Columns.Add("EmployeeName", "Ім'я співробітника");
            dataGridViewEmployee.Columns.Add("EmployeeType", "Посада");
            dataGridViewEmployee.Columns.Add("EmployeeStart", "Дата початку зміни");
            dataGridViewEmployee.Columns.Add("EmployeeEnd", "Дата кінця зміни");

            btnAddEmployee.Click += BtnAddEmployee_Click;
            btnDeleteEmployee.Click += BtnDeleteEmployee_Click;
        }
        private void InitializeResultComponents()
        {
            dataGridViewResult.Columns.Add("EventName", "Назва події");
            dataGridViewResult.Columns.Add("EventType", "Тип події");
            dataGridViewResult.Columns.Add("EventStart", "Дата початку");
            dataGridViewResult.Columns.Add("EventEnd", "Дата кінця");
            dataGridViewResult.Columns.Add("EmployeeName", "Ім'я співробітника");
            dataGridViewResult.Columns.Add("EmployeeType", "Посада");

            btnAddResult.Click += BtnAddResult_Click;
        }
        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            string eventType = cboEventType.SelectedItem?.ToString() ?? "Не вказано";
            string eventStart = dtpEventStart.Value.ToString("yyyy-MM-dd");
            string eventEnd = dtpEventEnd.Value.ToString("yyyy-MM-dd");

            dataGridViewEvent.Rows.Add(eventName, eventType, eventStart, eventEnd);
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            string employeeName = txtEmployeeName.Text;
            string employeeType = cboEmployeeType.SelectedItem?.ToString() ?? "Не вказано";
            string employeeStart = dtpEmployeeStart.Value.ToString("yyyy-MM-dd");
            string employeeEnd = dtpEmployeeEnd.Value.ToString("yyyy-MM-dd");

            dataGridViewEmployee.Rows.Add(employeeName, employeeType, employeeStart, employeeEnd);
        }
        private void BtnAddResult_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvent.SelectedRows.Count > 0)
            {
                var selectedEventRow = dataGridViewEvent.SelectedRows[0];
                string eventName = selectedEventRow.Cells["EventName"].Value.ToString();
                string eventType = selectedEventRow.Cells["EventType"].Value.ToString();
                DateTime eventStart = DateTime.Parse(selectedEventRow.Cells["EventStart"].Value.ToString());
                DateTime eventEnd = DateTime.Parse(selectedEventRow.Cells["EventEnd"].Value.ToString());

                bool employeeFound = false;

                foreach (DataGridViewRow employeeRow in dataGridViewEmployee.Rows)
                {
                    if (employeeRow.IsNewRow) continue;

                    string employeeName = employeeRow.Cells["EmployeeName"].Value.ToString();
                    string employeeType = employeeRow.Cells["EmployeeType"].Value.ToString();
                    DateTime employeeStart = DateTime.Parse(employeeRow.Cells["EmployeeStart"].Value.ToString());
                    DateTime employeeEnd = DateTime.Parse(employeeRow.Cells["EmployeeEnd"].Value.ToString());

                    if (employeeStart <= eventEnd && employeeEnd >= eventStart && IsEmployeeSuitable(eventType, employeeType))
                    {
                        dataGridViewResult.Rows.Add(eventName, eventType, eventStart.ToString("yyyy-MM-dd"), eventEnd.ToString("yyyy-MM-dd"), employeeName, employeeType);
                        employeeFound = true;
                    }
                }

                if (!employeeFound)
                {
                    MessageBox.Show("Співробітник не підходить", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private bool IsEmployeeSuitable(string eventType, string employeeType)
        {
            switch (eventType)
            {
                case "Лекція":
                    return employeeType == "Викладач";
                case "Виставка":
                    return employeeType == "Громадський діяч";
                case "Семінар":
                    return employeeType == "Громадський діяч" || employeeType == "Викладач";
                case "Музейний тур":
                    return employeeType == "Викладач" || employeeType == "Гід";
                case "Прогулянка":
                    return employeeType == "Гід";
                default:
                    return false;
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e){}
        private void btnDeleteEmployee_Click(object sender, EventArgs e){} 
        private void btnAddResult_Click(object sender, EventArgs e) {}

        private void BtnDeleteEvent_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEvent.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridViewEvent.Rows.Remove(row);
                }
            }
        }
        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEmployee.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridViewEmployee.Rows.Remove(row);
                }
            }
        }
 
    }
}