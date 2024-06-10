using System;
using System.Windows.Forms;

namespace CulturalCenterManagement
{
    public partial class MainForm : Form
    {
        private TextBox txtEventName;
        private ComboBox cboEventType;
        private DateTimePicker dtpEventStart;
        private DateTimePicker dtpEventEnd;
        private Button btnAddEvent;
        private DataGridView dataGridViewEvent;
        private TextBox txtEmployeeName;
        private ComboBox cboEmployeeType;
        private DateTimePicker dtpEmployeeStart;
        private DateTimePicker dtpEmployeeEnd;
        private Button btnAddEmployee;
        private DataGridView dataGridViewEmployee;

        private void InitializeComponent()
        {
            txtEventName = new TextBox();
            cboEventType = new ComboBox();
            dtpEventStart = new DateTimePicker();
            dtpEventEnd = new DateTimePicker();
            btnAddEvent = new Button();
            dataGridViewEvent = new DataGridView();
            txtEmployeeName = new TextBox();
            cboEmployeeType = new ComboBox();
            dtpEmployeeStart = new DateTimePicker();
            dtpEmployeeEnd = new DateTimePicker();
            btnAddEmployee = new Button();
            dataGridViewEmployee = new DataGridView();
            btnDeleteEvent = new Button();
            btnDeleteEmployee = new Button();
            dataGridViewResult = new DataGridView();
            btnAddResult = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(12, 40);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(200, 23);
            txtEventName.TabIndex = 0;
            // 
            // cboEventType
            // 
            cboEventType.Location = new Point(12, 84);
            cboEventType.Name = "cboEventType";
            cboEventType.Size = new Size(200, 23);
            cboEventType.TabIndex = 1;
            // 
            // dtpEventStart
            // 
            dtpEventStart.Location = new Point(12, 128);
            dtpEventStart.Name = "dtpEventStart";
            dtpEventStart.Size = new Size(200, 23);
            dtpEventStart.TabIndex = 2;
            // 
            // dtpEventEnd
            // 
            dtpEventEnd.Location = new Point(12, 172);
            dtpEventEnd.Name = "dtpEventEnd";
            dtpEventEnd.Size = new Size(200, 23);
            dtpEventEnd.TabIndex = 3;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(12, 201);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(200, 23);
            btnAddEvent.TabIndex = 4;
            btnAddEvent.Text = "Додати подію";
            // 
            // dataGridViewEvent
            // 
            dataGridViewEvent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvent.Location = new Point(218, 40);
            dataGridViewEvent.Name = "dataGridViewEvent";
            dataGridViewEvent.RowTemplate.Height = 24;
            dataGridViewEvent.Size = new Size(493, 150);
            dataGridViewEvent.TabIndex = 5;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(12, 281);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(200, 23);
            txtEmployeeName.TabIndex = 6;
            // 
            // cboEmployeeType
            // 
            cboEmployeeType.Location = new Point(12, 329);
            cboEmployeeType.Name = "cboEmployeeType";
            cboEmployeeType.Size = new Size(200, 23);
            cboEmployeeType.TabIndex = 7;
            // 
            // dtpEmployeeStart
            // 
            dtpEmployeeStart.Location = new Point(12, 373);
            dtpEmployeeStart.Name = "dtpEmployeeStart";
            dtpEmployeeStart.Size = new Size(200, 23);
            dtpEmployeeStart.TabIndex = 8;
            // 
            // dtpEmployeeEnd
            // 
            dtpEmployeeEnd.Location = new Point(12, 417);
            dtpEmployeeEnd.Name = "dtpEmployeeEnd";
            dtpEmployeeEnd.Size = new Size(200, 23);
            dtpEmployeeEnd.TabIndex = 9;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(12, 446);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(200, 23);
            btnAddEmployee.TabIndex = 10;
            btnAddEmployee.Text = "Додати співробітника";
            // 
            // dataGridViewEmployee
            // 
            dataGridViewEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployee.Location = new Point(218, 281);
            dataGridViewEmployee.Name = "dataGridViewEmployee";
            dataGridViewEmployee.RowTemplate.Height = 24;
            dataGridViewEmployee.Size = new Size(493, 150);
            dataGridViewEmployee.TabIndex = 11;
            // 
            // btnDeleteEvent
            // 
            btnDeleteEvent.Location = new Point(717, 84);
            btnDeleteEvent.Name = "btnDeleteEvent";
            btnDeleteEvent.Size = new Size(168, 23);
            btnDeleteEvent.TabIndex = 12;
            btnDeleteEvent.Text = "Видалити подію";
            btnDeleteEvent.UseVisualStyleBackColor = true;
            btnDeleteEvent.Click += btnDeleteEvent_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(717, 329);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(168, 23);
            btnDeleteEmployee.TabIndex = 13;
            btnDeleteEmployee.Text = "Видалити співробітника";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(160, 475);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowTemplate.Height = 24;
            dataGridViewResult.Size = new Size(606, 150);
            dataGridViewResult.TabIndex = 14;
            // 
            // btnAddResult
            // 
            btnAddResult.Location = new Point(379, 631);
            btnAddResult.Name = "btnAddResult";
            btnAddResult.Size = new Size(168, 23);
            btnAddResult.TabIndex = 15;
            btnAddResult.Text = "Побачити результат";
            btnAddResult.UseVisualStyleBackColor = true;
            btnAddResult.Click += btnAddResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 16;
            label1.Text = "Додати назву події";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(12, 311);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 17;
            label2.Text = "Обрати посаду співробітника";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 224, 192);
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 18;
            label3.Text = "Початок події";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 224, 192);
            label4.Location = new Point(12, 66);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 19;
            label4.Text = "Обрати тип події";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 224, 192);
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 20;
            label5.Text = "Кінець події";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 224, 192);
            label6.Location = new Point(12, 263);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 21;
            label6.Text = "Додати ім'я співробітника";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 224, 192);
            label7.Location = new Point(12, 355);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 22;
            label7.Text = "Початок зміни";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 224, 192);
            label8.Location = new Point(12, 399);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 23;
            label8.Text = "Кінець зміни";
            // 
            // MainForm
            // 
            ClientSize = new Size(959, 724);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddResult);
            Controls.Add(dataGridViewResult);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnDeleteEvent);
            Controls.Add(txtEventName);
            Controls.Add(cboEventType);
            Controls.Add(dtpEventStart);
            Controls.Add(dtpEventEnd);
            Controls.Add(btnAddEvent);
            Controls.Add(dataGridViewEvent);
            Controls.Add(txtEmployeeName);
            Controls.Add(cboEmployeeType);
            Controls.Add(dtpEmployeeStart);
            Controls.Add(dtpEmployeeEnd);
            Controls.Add(btnAddEmployee);
            Controls.Add(dataGridViewEmployee);
            Name = "MainForm";
            Text = "Програма для курсової";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnDeleteEvent;
        private Button btnDeleteEmployee;
        private DataGridView dataGridViewResult;
        private Button btnAddResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}