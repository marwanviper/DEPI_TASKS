namespace EFCORE_TASK
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
            Save = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            Edit = new Button();
            Delete = new Button();
            Show = new Button();
            button5 = new Button();
            textSalary = new TextBox();
            textJob = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Location = new Point(13, 318);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 0;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 271);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Name :";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 289);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 23);
            comboBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(672, 243);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(417, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 218);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 318);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Edit
            // 
            Edit.Location = new Point(94, 318);
            Edit.Name = "Edit";
            Edit.Size = new Size(75, 23);
            Edit.TabIndex = 6;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(175, 318);
            Delete.Name = "Delete";
            Delete.Size = new Size(75, 23);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Show
            // 
            Show.Location = new Point(609, 317);
            Show.Name = "Show";
            Show.Size = new Size(75, 23);
            Show.TabIndex = 8;
            Show.Text = "Show";
            Show.UseVisualStyleBackColor = true;
            Show.Click += Show_Click;
            // 
            // button5
            // 
            button5.Location = new Point(517, 236);
            button5.Name = "button5";
            button5.Size = new Size(53, 23);
            button5.TabIndex = 9;
            button5.Text = "...";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textSalary
            // 
            textSalary.Location = new Point(64, 157);
            textSalary.Name = "textSalary";
            textSalary.Size = new Size(321, 23);
            textSalary.TabIndex = 10;
            textSalary.TextChanged += textSalary_TextChanged;
            // 
            // textJob
            // 
            textJob.Location = new Point(64, 113);
            textJob.Name = "textJob";
            textJob.Size = new Size(321, 23);
            textJob.TabIndex = 11;
            textJob.TextChanged += textJob_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 23);
            txtName.TabIndex = 12;
            txtName.TextChanged += textBox4_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 165);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 13;
            label2.Text = "Salary :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 14;
            label3.Text = "Job :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 77);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 15;
            label4.Text = "Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 297);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 16;
            label5.Text = "Search";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 44);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 17;
            label6.Text = "Id :";
            label6.Click += label6_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(69, 36);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(47, 23);
            textBox5.TabIndex = 18;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 602);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(textJob);
            Controls.Add(textSalary);
            Controls.Add(button5);
            Controls.Add(Show);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(Save);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button Edit;
        private Button Delete;
        private Button Show;
        private Button button5;
        private TextBox textSalary;
        private TextBox textJob;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
    }
}
