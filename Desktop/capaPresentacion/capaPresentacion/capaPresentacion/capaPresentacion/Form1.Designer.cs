namespace capaPresentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(495, 334);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(339, 369);
            button2.Name = "button2";
            button2.Size = new Size(168, 74);
            button2.TabIndex = 13;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 369);
            button4.Name = "button4";
            button4.Size = new Size(172, 74);
            button4.TabIndex = 15;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(628, 378);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(628, 407);
            button3.Name = "button3";
            button3.Size = new Size(132, 23);
            button3.TabIndex = 14;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 128, 255);
            button5.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(847, 378);
            button5.Name = "button5";
            button5.Size = new Size(132, 23);
            button5.TabIndex = 16;
            button5.Text = "Agregar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(628, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(628, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(628, 214);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(132, 23);
            textBox4.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(847, 87);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(132, 23);
            textBox6.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(556, 137);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 25;
            label2.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(513, 176);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 26;
            label3.Text = "Metros cuadrados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(576, 217);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 27;
            label4.Text = "Precio:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(811, 90);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 29;
            label6.Text = "Iva:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "casa", "apartamento", "terreno" });
            comboBox1.Location = new Point(628, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(576, 90);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 31;
            label1.Text = "Tipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(628, 49);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 32;
            label5.Text = "Propiedades";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(875, 49);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 33;
            label7.Text = "Ventas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(993, 471);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button3;
        private Button button5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private Label label1;
        private Label label5;
        private Label label7;
    }
}