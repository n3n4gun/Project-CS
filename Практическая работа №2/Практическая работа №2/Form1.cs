using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы хотите выйти из приложения?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewEmployee new_employee = new NewEmployee();
            new_employee.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewOrganization newOrganization = new NewOrganization();
            newOrganization.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BusinessTrips businessTrips = new BusinessTrips();
            businessTrips.Show();
        }
    }
}
