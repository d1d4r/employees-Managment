using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employees_Managment
{
    public partial class FormEmployeeInfo : Form
    {
        FormEmployee form;
        public FormEmployeeInfo()
        {
            InitializeComponent();
            //form = new FormEmployee(this);
        }

        private void adduserControl(UserControl userControl)
        {
           
           userControl.Dock =DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            panelContainer.BringToFront();


        }

        private void FormEmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        public void Display()
        {
        //    DbEmployee.DisplayAndSearch("SELECT id,Name,RFIDData,Salary FROM employee", dataGridView);
        }

        private void New_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void FormEmployeeInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DbEmployee.DisplayAndSearch("SELECT id,Name,RFIDData,Salary FROM employee WHERE Name LIKE '%"+txtSearch.Text +"%'", dataGridView);


        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                form.Clear();
               // form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                //form.name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
               // form.rfid = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                //form.salary = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString()+"$";
                
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Are you want to delete emplyee record?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                   // DbEmployee.DeleteEmployee(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
               return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            UC_Employee uC_Employee = new UC_Employee();
            adduserControl(uC_Employee);
            this.Text = "Employee";


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            UC_Attendance uC_Attendance = new UC_Attendance();
            adduserControl(uC_Attendance);
            this.Text = "Attendance";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
