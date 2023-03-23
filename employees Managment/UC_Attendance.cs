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
    public partial class UC_Attendance : UserControl
    {
        public UC_Attendance()
        {
            InitializeComponent();
            Display();
        }
        public void Display()
        {
            DbEmployee.DisplayAndSearch("SELECT * FROM attendance", dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
