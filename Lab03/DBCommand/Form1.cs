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

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            sqlCommand1.CommandType = CommandType.Text;
            using (sqlConnection1)
            {
                try
                {
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
                    MoreResults = reader.NextResult();
                    reader.Close();
                    sqlCommand1.Connection.Close();
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            sqlCommand2.CommandText = "Ten Most Expensive Products";
            using (sqlConnection1)
            {
                try
                {
                    sqlCommand2.Connection.Open();
                    SqlDataReader reader = sqlCommand2.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    reader.Close();
                    sqlCommand2.Connection.Close();
                    textBox1.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (sqlConnection1)
            {
                sqlCommand3.CommandType = CommandType.Text;
                sqlCommand3.CommandText =
                    "CREATE TABLE SalesPersons (" +
                    "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                    "[FirstName] [nvarchar](50) NULL, " +
                    "[LastName] [nvarchar](50) NULL)";
                try
                {
                    sqlConnection1.Open();
                    sqlCommand3.ExecuteNonQuery();
                    sqlConnection1.Close();
                    MessageBox.Show("Таблица SalesPersons создана");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            sqlCommand4.CommandType = CommandType.Text;
            try
            {
                sqlCommand4.Parameters["@City"].Value = CityTextBox.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand4.ExecuteReader();
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
                sqlCommand4.Connection.Close();
                ResultsTextBox.Text = results.ToString();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void button5_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder results = new System.Text.StringBuilder();
            try
            {
                sqlCommand5.Parameters["@CategoryName"].Value = CategoryNameTextBox.Text;
                sqlCommand5.Parameters["@OrdYear"].Value = OrdYearTextBox.Text;
                sqlConnection1.Open();
                SqlDataReader reader = sqlCommand5.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                reader.Close();
                sqlConnection1.Close();
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}




