namespace Практическая_работа__2
{
    partial class BusinessTrips
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.employeesDataSet1 = new Практическая_работа__2.EmployeesDataSet1();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Практическая_работа__2.EmployeesDataSet1TableAdapters.СотрудникиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.organizationDataSetTrips = new Практическая_работа__2.OrganizationDataSetTrips();
            this.организацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.организацииTableAdapter = new Практическая_работа__2.OrganizationDataSetTripsTableAdapters.ОрганизацииTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.business_tripsDataSet = new Практическая_работа__2.Business_tripsDataSet();
            this.командировкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.командировкиTableAdapter = new Практическая_работа__2.Business_tripsDataSetTableAdapters.КомандировкиTableAdapter();
            this.датаВыездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОрганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДнейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суточныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьБилетовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.общаяСуммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationDataSetTrips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.business_tripsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.командировкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаВыездаDataGridViewTextBoxColumn,
            this.фИОСотрудникаDataGridViewTextBoxColumn,
            this.наименованиеОрганизацииDataGridViewTextBoxColumn,
            this.количествоДнейDataGridViewTextBoxColumn,
            this.суточныеDataGridViewTextBoxColumn,
            this.стоимостьБилетовDataGridViewTextBoxColumn,
            this.общаяСуммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.командировкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.сотрудникиBindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 364);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(282, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ФИО";
            // 
            // employeesDataSet1
            // 
            this.employeesDataSet1.DataSetName = "EmployeesDataSet1";
            this.employeesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.employeesDataSet1;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1091, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.организацииBindingSource;
            this.comboBox2.DisplayMember = "Наименование организации";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(18, 425);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(282, 28);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Наименование организации";
            // 
            // organizationDataSetTrips
            // 
            this.organizationDataSetTrips.DataSetName = "OrganizationDataSetTrips";
            this.organizationDataSetTrips.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // организацииBindingSource
            // 
            this.организацииBindingSource.DataMember = "Организации";
            this.организацииBindingSource.DataSource = this.organizationDataSetTrips;
            // 
            // организацииTableAdapter
            // 
            this.организацииTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(333, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "ФИО сотрудника";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(333, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Наименование организации";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(333, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Дата командировки";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 489);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 26);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 548);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(282, 26);
            this.textBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(333, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество дней";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(333, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "Суточные";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(638, 298);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 26);
            this.textBox3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(943, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Стоимость билетов";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(638, 358);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(282, 26);
            this.textBox4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(943, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 36);
            this.label7.TabIndex = 18;
            this.label7.Text = "Общая сумма";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1091, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 63);
            this.button2.TabIndex = 19;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1091, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 63);
            this.button3.TabIndex = 20;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // business_tripsDataSet
            // 
            this.business_tripsDataSet.DataSetName = "Business_tripsDataSet";
            this.business_tripsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // командировкиBindingSource
            // 
            this.командировкиBindingSource.DataMember = "Командировки";
            this.командировкиBindingSource.DataSource = this.business_tripsDataSet;
            // 
            // командировкиTableAdapter
            // 
            this.командировкиTableAdapter.ClearBeforeFill = true;
            // 
            // датаВыездаDataGridViewTextBoxColumn
            // 
            this.датаВыездаDataGridViewTextBoxColumn.DataPropertyName = "Дата выезда";
            this.датаВыездаDataGridViewTextBoxColumn.HeaderText = "Дата выезда";
            this.датаВыездаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.датаВыездаDataGridViewTextBoxColumn.Name = "датаВыездаDataGridViewTextBoxColumn";
            this.датаВыездаDataGridViewTextBoxColumn.Width = 150;
            // 
            // фИОСотрудникаDataGridViewTextBoxColumn
            // 
            this.фИОСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ФИО сотрудника";
            this.фИОСотрудникаDataGridViewTextBoxColumn.HeaderText = "ФИО сотрудника";
            this.фИОСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.фИОСотрудникаDataGridViewTextBoxColumn.Name = "фИОСотрудникаDataGridViewTextBoxColumn";
            this.фИОСотрудникаDataGridViewTextBoxColumn.Width = 150;
            // 
            // наименованиеОрганизацииDataGridViewTextBoxColumn
            // 
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование организации";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.HeaderText = "Наименование организации";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.Name = "наименованиеОрганизацииDataGridViewTextBoxColumn";
            this.наименованиеОрганизацииDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествоДнейDataGridViewTextBoxColumn
            // 
            this.количествоДнейDataGridViewTextBoxColumn.DataPropertyName = "Количество дней";
            this.количествоДнейDataGridViewTextBoxColumn.HeaderText = "Количество дней";
            this.количествоДнейDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.количествоДнейDataGridViewTextBoxColumn.Name = "количествоДнейDataGridViewTextBoxColumn";
            this.количествоДнейDataGridViewTextBoxColumn.Width = 150;
            // 
            // суточныеDataGridViewTextBoxColumn
            // 
            this.суточныеDataGridViewTextBoxColumn.DataPropertyName = "Суточные";
            this.суточныеDataGridViewTextBoxColumn.HeaderText = "Суточные";
            this.суточныеDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.суточныеDataGridViewTextBoxColumn.Name = "суточныеDataGridViewTextBoxColumn";
            this.суточныеDataGridViewTextBoxColumn.Width = 150;
            // 
            // стоимостьБилетовDataGridViewTextBoxColumn
            // 
            this.стоимостьБилетовDataGridViewTextBoxColumn.DataPropertyName = "Стоимость билетов";
            this.стоимостьБилетовDataGridViewTextBoxColumn.HeaderText = "Стоимость билетов";
            this.стоимостьБилетовDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.стоимостьБилетовDataGridViewTextBoxColumn.Name = "стоимостьБилетовDataGridViewTextBoxColumn";
            this.стоимостьБилетовDataGridViewTextBoxColumn.Width = 150;
            // 
            // общаяСуммаDataGridViewTextBoxColumn
            // 
            this.общаяСуммаDataGridViewTextBoxColumn.DataPropertyName = "Общая сумма";
            this.общаяСуммаDataGridViewTextBoxColumn.HeaderText = "Общая сумма";
            this.общаяСуммаDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.общаяСуммаDataGridViewTextBoxColumn.Name = "общаяСуммаDataGridViewTextBoxColumn";
            this.общаяСуммаDataGridViewTextBoxColumn.Width = 150;
            // 
            // BusinessTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 623);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BusinessTrips";
            this.Text = "BusinessTrips";
            this.Load += new System.EventHandler(this.BusinessTrips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationDataSetTrips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.организацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.business_tripsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.командировкиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private EmployeesDataSet1 employeesDataSet1;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private EmployeesDataSet1TableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private OrganizationDataSetTrips organizationDataSetTrips;
        private System.Windows.Forms.BindingSource организацииBindingSource;
        private OrganizationDataSetTripsTableAdapters.ОрганизацииTableAdapter организацииTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Business_tripsDataSet business_tripsDataSet;
        private System.Windows.Forms.BindingSource командировкиBindingSource;
        private Business_tripsDataSetTableAdapters.КомандировкиTableAdapter командировкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОрганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДнейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суточныеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьБилетовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn общаяСуммаDataGridViewTextBoxColumn;
    }
}