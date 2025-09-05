using EFCORE_TASK.Models;

using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
namespace EFCORE_TASK
{
    public partial class Form1 : Form
    {
        private string selectedPhotoPath;
        private void ClearForm()
        {
            if (textBox5.Text != null)
            {
                textBox5.Text = string.Empty;
            }
            txtName.Text = string.Empty;   // Name
            textJob.Text = string.Empty;     // Job
            textSalary.Text = string.Empty;  // Salary
            pictureBox1.Image = null;       // Clear photo
            selectedPhotoPath = null;
        }
        private void LoadComboBox()
        {
            using (var db = new EMPCONTEXT())
            {
                var employees = db.Employees.ToList();
                comboBox1.DataSource = employees;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }
        private void LoadGrid()
        {
            using (var db = new EMPCONTEXT())
            {
                string keyword = textBox1.Text.Trim();

                var result = db.Employees
                    .Where(x => x.Name.Contains(keyword))   // filter by name
                    .Select(x => new { x.Id, x.Name, x.Job, x.Salary, x.PhotoPath })
                    .ToList();

                dataGridView1.DataSource = result;
            }
        }

        public Form1()
        {
            InitializeComponent();
            LoadComboBox();
            LoadGrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedPhotoPath = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(selectedPhotoPath);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            using (EMPCONTEXT db = new EMPCONTEXT())
            {
                Employee emp = new Employee
                {
                    Name = txtName.Text,
                    Job = textJob.Text,
                    Salary = float.Parse(textSalary.Text),
                    PhotoPath = selectedPhotoPath
                };

                db.Employees.Add(emp);
                db.SaveChanges();
                ClearForm();
                LoadComboBox();
                LoadGrid();
                MessageBox.Show("Employee saved!");
            }
        }

        private void textSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textJob_TextChanged(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int empId)
            {
                using (var db = new EMPCONTEXT())
                {

                    var employee = db.Employees.FirstOrDefault(x => x.Id == empId);
                    if (employee != null)
                    {
                        textBox5.Text = employee.Id.ToString();
                        txtName.Text = employee.Name;
                        textJob.Text = employee.Job;
                        textSalary.Text = employee.Salary.ToString();

                        if (!string.IsNullOrEmpty(employee.PhotoPath) && File.Exists(employee.PhotoPath))
                        {
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Image = Image.FromFile(employee.PhotoPath);
                            selectedPhotoPath = employee.PhotoPath;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }

                        textBox5.Tag = employee.Id; // keep ID for update/delete
                    }
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            using (var db = new EMPCONTEXT())
            {
                int id = int.Parse(textBox5.Text);
                var emp = db.Employees.FirstOrDefault(x => x.Id == id);

                if (emp != null)
                {
                    emp.Name = txtName.Text;
                    emp.Job = textJob.Text;
                    emp.Salary = float.Parse(textSalary.Text);
                    if (pictureBox1.Image != null)
                        emp.PhotoPath = selectedPhotoPath;

                    db.SaveChanges();
                    ClearForm();
                    LoadComboBox();
                    LoadGrid();
                    MessageBox.Show("Employee updated!");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // ID
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (var db = new EMPCONTEXT())
            {
                int id = int.Parse(textBox5.Text);
                var emp = db.Employees.FirstOrDefault(x => x.Id == id);

                if (emp != null)
                {
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    ClearForm();
                    LoadComboBox();
                    LoadGrid();
                    MessageBox.Show("Employee deleted!");
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // ignore header row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Fill textboxes
                textBox5.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                textJob.Text = row.Cells["Job"].Value.ToString();
                textSalary.Text = row.Cells["Salary"].Value.ToString();

                // Load photo if exists
                if (row.Cells["PhotoPath"].Value != DBNull.Value && row.Cells["PhotoPath"].Value != null)
                {
                    string photoPath = row.Cells["PhotoPath"].Value.ToString();

                    if (File.Exists(photoPath))   // make sure the file still exists
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // fit nicely
                        pictureBox1.Image = Image.FromFile(photoPath);
                        selectedPhotoPath = photoPath;
                    }
                    else
                    {
                        pictureBox1.Image = null; // file missing
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }

                // Save Employee ID in Tag for edit/delete
                textBox5.Tag = row.Cells["Id"].Value;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
