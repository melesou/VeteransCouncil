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
using WorkWithRequest.Classes;
using WorkWithForm.Classes;

namespace VeteransCouncil
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }
        string GetSettings()
        {
            return $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=sovet_veteranov;Integrated Security=True";
        }
        private TextBox[] GetTextBoxes()
        {
            TextBox[] textBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            return textBoxes;
        }
        private Label[] GetLabels()
        {
            Label[] labels = { label1, label2, label3, label4, label5 };
            return labels;
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(GetSettings());
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void TableChange(object sender, EventArgs e)
        {
            TextBox[] textBoxes = GetTextBoxes();
            foreach (TextBox textBox in textBoxes)
                textBox.Text = "";
            dataGridView.DataSource = "";
            dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tableComboBox.Text}]");
            TablesWork.CategoryFormation(dataGridView, searchComboBox);
            TablesWork.LabelsTextChange(GetLabels(), tableComboBox.SelectedIndex);
            TablesWork.LabelsVisibleChange(GetTextBoxes(), GetLabels(), tableComboBox.SelectedIndex);
        }
        private void SearchInCategory(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "")
            {
                string request = $"SELECT * FROM [{tableComboBox.Text}] where {searchComboBox.Text} = '{searchTextBox.Text}';";
                dataGridView.DataSource = FillDataGridView(request);
            }
            else
            {
                dataGridView.DataSource = "";
                dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tableComboBox.Text}]");
            }
        }

        private void InsertRequest(object sender, EventArgs e)
        {
            RequestsWork.SendingAddRequest(dataGridView, tableComboBox, GetTextBoxes(), GetSettings());
            dataGridView.DataSource = "";
            dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tableComboBox.Text}]");
        }

        private void UpdateRequest(object sender, EventArgs e)
        {
            RequestsWork.SendingChangeRequest(dataGridView, tableComboBox, GetTextBoxes(), GetSettings());
            dataGridView.DataSource = "";
            dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tableComboBox.Text}]");
        }

        private void DeleteRequest(object sender, EventArgs e)
        {
            RequestsWork.SendingDeleteRequest(dataGridView, tableComboBox, GetTextBoxes(), GetSettings());
            dataGridView.DataSource = "";
            dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tableComboBox.Text}]");
        }

        private void CurrentCell(object sender, DataGridViewCellEventArgs e)
        {
            TextBox[] textBoxes = GetTextBoxes();
            for (int i = 0; i < dataGridView.ColumnCount; i++) // Присвоение TextBox'ов
                textBoxes[i].Text = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[i].Value.ToString();
        }
    }
}
