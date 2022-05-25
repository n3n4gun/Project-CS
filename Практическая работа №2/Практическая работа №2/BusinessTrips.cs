using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Практическая_работа__2
{
    public partial class BusinessTrips : Form

    {

        public static string connectionPathBusinessTrips = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Business trips.accdb";
        private OleDbConnection dbConnectionBusinessTrips;

        public BusinessTrips()
        {
            InitializeComponent();
            dbConnectionBusinessTrips = new OleDbConnection(connectionPathBusinessTrips);
            dbConnectionBusinessTrips.Open();
        }

        private void BusinessTrips_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "business_tripsDataSet.Командировки". При необходимости она может быть перемещена или удалена.
            this.командировкиTableAdapter.Fill(this.business_tripsDataSet.Командировки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "organizationDataSetTrips.Организации". При необходимости она может быть перемещена или удалена.
            this.организацииTableAdapter.Fill(this.organizationDataSetTrips.Организации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.employeesDataSet1.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dbConnectionBusinessTrips.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите количество отпускных дней!");
                textBox1.Focus();
                return;
            }
            else
            {
                if (Convert.ToInt32(textBox1.Text) < 0)
                {
                    MessageBox.Show("Данные не могу быть отрицательными!");
                    textBox1.Text = "";
                    textBox1.Focus();
                    return;
                }
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите суточное значение!");
                textBox2.Focus();
                return;
            }
            else
            {
                if (Convert.ToInt32(textBox2.Text) < 0)
                {
                    MessageBox.Show("Данные не могу быть отрицательными!");
                    textBox2.Text = "";
                    textBox2.Focus();
                    return;
                }
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Укажите стоимость билетов!");
                textBox3.Focus();
                return;
            }
            else
            {
                if (Convert.ToInt32(textBox3.Text) < 0)
                {
                    MessageBox.Show("Данные не могу быть отрицательными!");
                    textBox3.Text = "";
                    textBox3.Focus();
                    return;
                }
            }

            int count_day = Convert.ToInt32(textBox1.Text);
            int daily_allowance = Convert.ToInt32(textBox2.Text);
            int cost_ticket = Convert.ToInt32(textBox3.Text);

            int total_amount;

            total_amount = count_day * daily_allowance + 2 * cost_ticket;

            textBox4.Text = Convert.ToString(total_amount);


            string dateBusinessTrip = Convert.ToString(dateTimePicker1.Value);
            string nameEmployee = comboBox1.Text;
            string nameOrganization = comboBox2.Text;
            int countDay = Convert.ToInt32(textBox1.Text);
            int dailyAllowance = Convert.ToInt32(textBox2.Text);
            int costTicket = Convert.ToInt32(textBox3.Text);
            int totalAmount = total_amount;

            string queryBusinessTrip = "INSERT INTO Командировки ([Дата выезда], [ФИО сотрудника], [Наименование организации], [Количество дней], [Суточные], [Стоимость билетов], [Общая сумма]) VALUES (" + "'" + dateBusinessTrip + "','" + nameEmployee + "','" + nameOrganization + "'," + countDay + "," + dailyAllowance + "," + costTicket + "," + totalAmount + ")";
            OleDbCommand cmd = new OleDbCommand(queryBusinessTrip, dbConnectionBusinessTrips);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные командировки добавлены!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.командировкиTableAdapter.Fill(this.business_tripsDataSet.Командировки);

        }
    }
}
