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
    public partial class NewEmployee : Form
    {
        // Создание подключения к БД, в которой будет содержаться информация о сотрудниках

        public static string connectionPath = "Provider = Microsoft.ACE.OLEDB.16.0;Data Source = Employees.accdb";
        private OleDbConnection dbConnetion;

        public NewEmployee()
        {
            InitializeComponent();
            dbConnetion = new OleDbConnection(connectionPath);
            dbConnetion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dbConnetion.Close();
            Form1 form_1 = new Form1();
            form_1.Show();

        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeesDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.employeesDataSet.Сотрудники);

        }

        // Основная работа
        // Проверка на заполняемость полей
        // При возникновении пустных полей, будет выводится предупреждение

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите ФИО!");
                textBox1.Focus();
                return;
            }
            else if (textBox1.Text != "")
            {
                string personal_initials = textBox1.Text.ToLower();
                foreach (char ch_1 in personal_initials)
                {
                    if ((int)ch_1 >= 97 && (int)ch_1 <= 122)
                    {
                        MessageBox.Show("ФИО должно состоять только из символов кириллицы!");
                        textBox1.Text = "";
                        textBox1.Focus();
                        return;
                    }
                }
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Введите название отдела!");
                textBox2.Focus();
                return;
            }
            else if (textBox2.Text != "")
            {
                string department = textBox2.Text.ToLower();
                foreach (char ch_2 in department)
                {
                    if ((int)ch_2 >= 97 && (int)ch_2 <= 122)
                    {
                        MessageBox.Show("Название отдела должно состоять из символов кириллицы!");
                        textBox2.Text = "";
                        textBox2.Focus();
                        return;
                    }
                }
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Введите название должности!");
                textBox3.Focus();
                return;
            }
            else if (textBox3.Text != "")
            {
                string post = textBox3.Text.ToLower();
                foreach (char ch_3 in post)
                {
                    if ((int)ch_3 >= 97 && (int)ch_3 <= 122)
                    {
                        MessageBox.Show("Название должности должно состоять из символов кириллицы!");
                        textBox3.Text = "";
                        textBox3.Focus();
                        return;
                    }
                }
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Введите номер телефона!");
                textBox4.Focus();
                return;
            }
            else if (textBox4.Text != "")
            {
                if (textBox4.Text.Length != 8)
                {
                    MessageBox.Show("Длина введенного номера телефона не соответсвует длине в 8 символов!");
                    textBox4.Text = "";
                    textBox4.Focus();
                    return;
                }
                else
                {
                    string digital_chars = textBox4.Text;
                    foreach (char digital_ch in digital_chars)
                    {
                        if (!(char.IsNumber(digital_ch)))
                        {
                            MessageBox.Show("Номер телефона должен состоять из цифровых символов!");
                            textBox4.Text = "";
                            textBox4.Focus();
                            return;
                        }
                    }
                }
            }

            // При помощи SQL запроса мы добавляем введенный данный в БД сотрудников

            try
            {
                string fioInfo = textBox1.Text;
                string departmentInfo = textBox2.Text;
                string positionInfo = textBox3.Text;
                int tellNumInfo = Convert.ToInt32(textBox4.Text);

                string query = "INSERT INTO Сотрудники ([ФИО], [Отдел], [Должность], [Номер телефона]) VALUES (" + "'" + fioInfo + "','" + departmentInfo + "','" + positionInfo + "'," + tellNumInfo + ")";
                OleDbCommand cmd = new OleDbCommand(query, dbConnetion);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные сотрудника добавлены!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.employeesDataSet.Сотрудники);
        }
    }
}
