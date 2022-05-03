namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.sBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new WindowsFormsApplication4.dbDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sTableAdapter = new WindowsFormsApplication4.dbDataSetTableAdapters.sTableAdapter();
            this.sBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new WindowsFormsApplication4.dbDataSet1();
            this.sBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sTableAdapter1 = new WindowsFormsApplication4.dbDataSet1TableAdapters.sTableAdapter();
            this.sBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet2 = new WindowsFormsApplication4.dbDataSet2();
            this.tb1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb1TableAdapter = new WindowsFormsApplication4.dbDataSet2TableAdapters.tb1TableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sBindingSource
            // 
            this.sBindingSource.DataMember = "s";
            this.sBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "آضافه کردن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "بروزرسانی";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "جستجو";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(503, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "حذف کردن";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(366, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "فامیلی استاد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "کد استاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "نام استاد";
            // 
            // sTableAdapter
            // 
            this.sTableAdapter.ClearBeforeFill = true;
            // 
            // sBindingSource1
            // 
            this.sBindingSource1.DataMember = "s";
            this.sBindingSource1.DataSource = this.dbDataSet;
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "dbDataSet1";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sBindingSource2
            // 
            this.sBindingSource2.DataMember = "s";
            this.sBindingSource2.DataSource = this.dbDataSet1;
            // 
            // sTableAdapter1
            // 
            this.sTableAdapter1.ClearBeforeFill = true;
            // 
            // sBindingSource3
            // 
            this.sBindingSource3.DataMember = "s";
            this.sBindingSource3.DataSource = this.dbDataSet;
            // 
            // sBindingSource4
            // 
            this.sBindingSource4.DataMember = "s";
            this.sBindingSource4.DataSource = this.dbDataSet1;
            // 
            // dbDataSet2
            // 
            this.dbDataSet2.DataSetName = "dbDataSet2";
            this.dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb1BindingSource
            // 
            this.tb1BindingSource.DataMember = "tb1";
            this.tb1BindingSource.DataSource = this.dbDataSet2;
            // 
            // tb1TableAdapter
            // 
            this.tb1TableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(341, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 54);
            this.button5.TabIndex = 18;
            this.button5.Text = "نمایش کاربران";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 215);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource sBindingSource;
        private dbDataSetTableAdapters.sTableAdapter sTableAdapter;
        private System.Windows.Forms.BindingSource sBindingSource1;
        private dbDataSet1 dbDataSet1;
        private System.Windows.Forms.BindingSource sBindingSource2;
        private dbDataSet1TableAdapters.sTableAdapter sTableAdapter1;
        private System.Windows.Forms.BindingSource sBindingSource4;
        private System.Windows.Forms.BindingSource sBindingSource3;
        private dbDataSet2 dbDataSet2;
        private System.Windows.Forms.BindingSource tb1BindingSource;
        private dbDataSet2TableAdapters.tb1TableAdapter tb1TableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

