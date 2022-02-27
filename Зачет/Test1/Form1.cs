using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet11.Employees;
            dataGridView2.DataSource = dataSet21.Orders;

            dataGridView2.DataSource = dataSet21.Orders;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dataSet11.Employees);
            sqlDataAdapter2.Fill(dataSet21.Orders);
            BindingSource employeesBindingSource = new BindingSource(dataSet11, "Employees");
            dataGridView1.DataSource = employeesBindingSource;
            bindingNavigator1.BindingSource = employeesBindingSource;

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(dataSet11);
            sqlDataAdapter2.Update(dataSet21);

        }

        private void sqlDataAdapter1_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
            DataSet1.EmployeesRow EmplRow = (DataSet1.EmployeesRow)e.Row;
            DialogResult response = MessageBox.Show("Continue updating " + EmplRow.EmployeeID.ToString() + "?", "Continue Update?", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            DataSet1.EmployeesRow EmplRow = (DataSet1.EmployeesRow)e.Row;
            MessageBox.Show(EmplRow.EmployeeID.ToString() + " has been updated");
            dataSet11.Employees.Clear();
            sqlDataAdapter1.Fill(dataSet11.Employees);
        }

        private void sqlDataAdapter2_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
            DataSet2.OrdersRow OrdRow = (DataSet2.OrdersRow)e.Row;
            DialogResult response = MessageBox.Show("Continue updating " + OrdRow.OrderID.ToString() + "?", "Continue Update?", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        private void sqlDataAdapter2_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            DataSet2.OrdersRow OrdRow = (DataSet2.OrdersRow)e.Row;
            MessageBox.Show(OrdRow.OrderID.ToString() + " has been updated");
            dataSet21.Orders.Clear();
            sqlDataAdapter2.Fill(dataSet21.Orders);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StringBuilder results = new System.Text.StringBuilder();
                sqlCommand1.CommandType = CommandType.Text;
                sqlCommand1.Parameters["@ShipCountry"].Value = textBox1.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand1.ExecuteReader();
                bool MoreResults = false;
                do
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    MoreResults = reader.NextResult();
                } while (MoreResults);
                reader.Close();
                sqlCommand1.Connection.Close();
                textBox2.Text = results.ToString();

                
            
        }
    }
}

