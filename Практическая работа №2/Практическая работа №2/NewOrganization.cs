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
    public partial class NewOrganization : Form
    {

        public static string connectionPathOrg = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Organization.accdb";
        private OleDbConnection dbConnectionOrg;

        public NewOrganization()
        {
            InitializeComponent();
            dbConnectionOrg = new OleDbConnection(connectionPathOrg);
            dbConnectionOrg.Open();
        }

        private void NewOrganization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "organizationDataSet.Организации". При необходимости она может быть перемещена или удалена.
            this.организацииTableAdapter.Fill(this.organizationDataSet.Организации);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dbConnectionOrg.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите наименование организации!");
                textBox1.Focus();
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Введите адрес организации!");
                textBox2.Focus();
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Введите номер телефона организации!");
                textBox3.Focus();
                return;
            }
            else if (textBox3.Text != "")
            {
                if (textBox3.Text.Length != 8)
                {
                    MessageBox.Show("Длина введенного номера телефона не соответсвует длине в 8 символов!");
                    textBox3.Text = "";
                    textBox3.Focus();
                    return;
                }
                else
                {
                    string digital_chars = textBox3.Text;
                    foreach (char digital_ch in digital_chars)
                    {
                        if (!(char.IsNumber(digital_ch)))
                        {
                            MessageBox.Show("Номер телефона должен состоять из цифровых символов!");
                            textBox3.Text = "";
                            textBox3.Focus();
                            return;
                        }
                    }
                }
            }

            string nameOrganization = textBox1.Text;
            string addressOrganization = textBox2.Text;
            int tellNumOrganization = Convert.ToInt32(textBox3.Text);

            string queryOrg = "INSERT INTO Организации ([Наименование организации], [Адрес], [Телефон]) VALUES (" + "'" + nameOrganization + "','" + addressOrganization + "'," + tellNumOrganization + ")";
            OleDbCommand cmd = new OleDbCommand(queryOrg, dbConnectionOrg);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Данные организации добавлены!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.организацииTableAdapter.Fill(this.organizationDataSet.Организации);
        }
    }
}
