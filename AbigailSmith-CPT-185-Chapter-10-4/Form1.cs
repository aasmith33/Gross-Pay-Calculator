// This program will calculate gross pay from hourly pay and display an employees summary info
// Abigail Smith 2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbigailSmith_CPT_185_Chapter_10_4
{
    public partial class Form1 : Form
    {
        string shift;
        public Form1()
        {
            InitializeComponent();
            txtEmployeeName.Focus();
        }
        private void GetEmployeeData (Employee employee)
        {
            decimal pay;
            employee.Name = txtEmployeeName.Text;
            employee.Number = int.Parse(txtEmployeeNumber.Text);
            if (decimal.TryParse(txtHourly.Text, out pay))
            {
                employee.Pay = pay * 40;
            }
            else
            {
                MessageBox.Show("Invalid hourly pay amount");
            }
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                GetEmployeeData(employee);
                txtSumName.Text = employee.Name;
                txtSumNum.Text = employee.Number.ToString();
                txtGrossPay.Text = employee.Pay.ToString("c");
                if (rbDay.Checked)
                {
                    shift = "1";
                }
                if (rbNight.Checked)
                {
                    shift = "2";
                }
                txtShift.Text = shift;
            }
            catch
            {
                MessageBox.Show("You must enter all data before pressing calculate. Only use numbers for Pay and Employee Number.");
                txtEmployeeName.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Clear();
            txtEmployeeNumber.Clear();
            txtGrossPay.Clear();
            txtShift.Clear();
            txtSumName.Clear();
            txtSumNum.Clear();
            txtHourly.Clear();
            rbDay.Checked = false;
            rbNight.Checked = false;
            txtEmployeeName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
