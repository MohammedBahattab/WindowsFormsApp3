namespace WindowsFormsApp3
{
    partial class Delete_Form
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
            this.car_renteDataSet = new WindowsFormsApp3.Car_renteDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new WindowsFormsApp3.Car_renteDataSetTableAdapters.CarsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chIs = new System.Windows.Forms.CheckBox();
            this.txtcusN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtplaet = new System.Windows.Forms.TextBox();
            this.txtcompny = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_renteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(597, 191);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // car_renteDataSet
            // 
            this.car_renteDataSet.DataSetName = "Car_renteDataSet";
            this.car_renteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.car_renteDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delete Car";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chIs);
            this.panel1.Controls.Add(this.txtcusN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtplaet);
            this.panel1.Controls.Add(this.txtcompny);
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(15, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 150);
            this.panel1.TabIndex = 13;
            // 
            // chIs
            // 
            this.chIs.AutoSize = true;
            this.chIs.Location = new System.Drawing.Point(368, 111);
            this.chIs.Name = "chIs";
            this.chIs.Size = new System.Drawing.Size(72, 17);
            this.chIs.TabIndex = 11;
            this.chIs.Text = "Is Rented";
            this.chIs.UseVisualStyleBackColor = true;
            // 
            // txtcusN
            // 
            this.txtcusN.Location = new System.Drawing.Point(96, 112);
            this.txtcusN.Name = "txtcusN";
            this.txtcusN.Size = new System.Drawing.Size(180, 20);
            this.txtcusN.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer_Name";
            // 
            // txtplaet
            // 
            this.txtplaet.Location = new System.Drawing.Point(368, 64);
            this.txtplaet.Name = "txtplaet";
            this.txtplaet.Size = new System.Drawing.Size(180, 20);
            this.txtplaet.TabIndex = 8;
            // 
            // txtcompny
            // 
            this.txtcompny.Location = new System.Drawing.Point(368, 17);
            this.txtcompny.Name = "txtcompny";
            this.txtcompny.Size = new System.Drawing.Size(180, 20);
            this.txtcompny.TabIndex = 7;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(96, 64);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(180, 20);
            this.txtcolor.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Car compny";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Car Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Car Model";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(108, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(15, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Delete_Form";
            this.Text = "Delete_Form";
            this.Load += new System.EventHandler(this.Delete_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_renteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Car_renteDataSet car_renteDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private Car_renteDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtplaet;
        private System.Windows.Forms.TextBox txtcompny;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chIs;
        private System.Windows.Forms.TextBox txtcusN;
        private System.Windows.Forms.Label label6;
    }
}