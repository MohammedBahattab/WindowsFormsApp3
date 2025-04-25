namespace WindowsFormsApp3
{
    partial class Car_Rental
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.car_renteDataSet = new WindowsFormsApp3.Car_renteDataSet();
            this.carrenteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_renteDataSet2 = new WindowsFormsApp3.Car_renteDataSet2();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new WindowsFormsApp3.Car_renteDataSet2TableAdapters.CarsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carCompnyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startRentedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endRentedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRentedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_renteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrenteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_renteDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Car Rental";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.carModelDataGridViewTextBoxColumn,
            this.carColorDataGridViewTextBoxColumn,
            this.carplateDataGridViewTextBoxColumn,
            this.carCompnyDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerAgeDataGridViewTextBoxColumn,
            this.startRentedDateDataGridViewTextBoxColumn,
            this.endRentedDateDataGridViewTextBoxColumn,
            this.isRentedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(606, 110);
            this.dataGridView1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(355, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(251, 119);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Car Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Custmer Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Card ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Start rental";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "End rental";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 194);
            this.panel1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(11, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 42);
            this.button3.TabIndex = 20;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(197, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(104, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Rental";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // car_renteDataSet
            // 
            this.car_renteDataSet.DataSetName = "Car_renteDataSet";
            this.car_renteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrenteDataSetBindingSource
            // 
            this.carrenteDataSetBindingSource.DataSource = this.car_renteDataSet;
            this.carrenteDataSetBindingSource.Position = 0;
            // 
            // car_renteDataSet2
            // 
            this.car_renteDataSet2.DataSetName = "Car_renteDataSet2";
            this.car_renteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.car_renteDataSet2;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "Car_Model";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "Car_Model";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            this.carModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carColorDataGridViewTextBoxColumn
            // 
            this.carColorDataGridViewTextBoxColumn.DataPropertyName = "Car_Color";
            this.carColorDataGridViewTextBoxColumn.HeaderText = "Car_Color";
            this.carColorDataGridViewTextBoxColumn.Name = "carColorDataGridViewTextBoxColumn";
            this.carColorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carplateDataGridViewTextBoxColumn
            // 
            this.carplateDataGridViewTextBoxColumn.DataPropertyName = "Car_plate";
            this.carplateDataGridViewTextBoxColumn.HeaderText = "Car_plate";
            this.carplateDataGridViewTextBoxColumn.Name = "carplateDataGridViewTextBoxColumn";
            this.carplateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carCompnyDataGridViewTextBoxColumn
            // 
            this.carCompnyDataGridViewTextBoxColumn.DataPropertyName = "Car_Compny";
            this.carCompnyDataGridViewTextBoxColumn.HeaderText = "Car_Compny";
            this.carCompnyDataGridViewTextBoxColumn.Name = "carCompnyDataGridViewTextBoxColumn";
            this.carCompnyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer_Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerAgeDataGridViewTextBoxColumn
            // 
            this.customerAgeDataGridViewTextBoxColumn.DataPropertyName = "Customer_Age";
            this.customerAgeDataGridViewTextBoxColumn.HeaderText = "Customer_Age";
            this.customerAgeDataGridViewTextBoxColumn.Name = "customerAgeDataGridViewTextBoxColumn";
            this.customerAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startRentedDateDataGridViewTextBoxColumn
            // 
            this.startRentedDateDataGridViewTextBoxColumn.DataPropertyName = "Start_Rented_Date";
            this.startRentedDateDataGridViewTextBoxColumn.HeaderText = "Start_Rented_Date";
            this.startRentedDateDataGridViewTextBoxColumn.Name = "startRentedDateDataGridViewTextBoxColumn";
            this.startRentedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endRentedDateDataGridViewTextBoxColumn
            // 
            this.endRentedDateDataGridViewTextBoxColumn.DataPropertyName = "End_Rented_Date";
            this.endRentedDateDataGridViewTextBoxColumn.HeaderText = "End_Rented_Date";
            this.endRentedDateDataGridViewTextBoxColumn.Name = "endRentedDateDataGridViewTextBoxColumn";
            this.endRentedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isRentedDataGridViewCheckBoxColumn
            // 
            this.isRentedDataGridViewCheckBoxColumn.DataPropertyName = "isRented";
            this.isRentedDataGridViewCheckBoxColumn.HeaderText = "isRented";
            this.isRentedDataGridViewCheckBoxColumn.Name = "isRentedDataGridViewCheckBoxColumn";
            this.isRentedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Car_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Car_Rental";
            this.Text = "Car_Rental";
            this.Load += new System.EventHandler(this.Car_Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car_renteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrenteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_renteDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource carrenteDataSetBindingSource;
        private Car_renteDataSet car_renteDataSet;
        private Car_renteDataSet2 car_renteDataSet2;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Car_renteDataSet2TableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carplateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carCompnyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startRentedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endRentedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRentedDataGridViewCheckBoxColumn;
    }
}