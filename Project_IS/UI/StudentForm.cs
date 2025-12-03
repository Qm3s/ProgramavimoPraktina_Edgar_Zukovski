using System;
using System.Windows.Forms;
using Project_IS.Models;
using Project_IS.Services;

namespace Project_IS.UI
{
    public partial class StudentForm : Form
    {
        private readonly Student _student = null!;
        private readonly StudentService _studentService = new StudentService();

        
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentName_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        public StudentForm(Student student) : this()
        {
            _student = student;

            
            StudentName.Text = $"{student.FirstName} {student.LastName}";

          
            LoadData();
        }

        
        private void LoadData()
        {
            var table = _studentService.GetGradesTable(_student.StudentId); 

            dataGridView.Rows.Clear();

            foreach (var row in table)
            {
                dataGridView.Rows.Add(row.SubjectName, row.GradesText);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e) // LOG OUT
        {
            var form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
