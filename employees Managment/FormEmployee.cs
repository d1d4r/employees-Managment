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
    public partial class FormEmployee : Form
    {
        private readonly UC_Employee _parent;
        public string  id, name, rfid, salary;
       
        public FormEmployee(UserControl parent)
        {
            InitializeComponent();
            _parent = (UC_Employee)parent;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateInfo()
        {
            btnSave.Text = "Update";
            txtID.Text = id;
            txtName.Text = name;
            txtRFID.Text = rfid;
            txtSalary.Text = salary;
        }
        public void Clear()
        {
            txtID.Text = txtName.Text = txtRFID.Text = txtSalary.Text = String.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Employee ID is Empty");
                return;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Employee Name is Empty");
                return;
            }
            if (txtRFID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Employee RFID is Empty");
                return;
            }
            if (txtSalary.Text.Trim().Length == 0)
            {
                MessageBox.Show("Employee Salary is Empty");
                return;
            }
            if(btnSave.Text == "Save")
            {
             
                Employee emp = new Employee(txtID.Text.Trim(), txtName.Text.Trim(), txtRFID.Text.Trim(), txtSalary.Text.Trim());
                DbEmployee.AddEmploye(emp);
                Clear();
            
            }
            if (btnSave.Text == "Update")
            {
                
                Employee emp = new Employee(txtID.Text.Trim(), txtName.Text.Trim(), txtRFID.Text.Trim(), txtSalary.Text.Trim());
                DbEmployee.UpdateEmploye(emp, id);
                
              
            }
            
                

            _parent.Display();


        }
    }
}
