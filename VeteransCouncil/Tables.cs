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
//using Word = Microsoft.Office.Interop.Word;

namespace VeteransCouncil
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }
        string GetSettings()
        {
            return $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=sovet_veteranov;Integrated Security=True";
        }
        string[] tablesNames = { "FILIAL", "MEROPRIYATIE" , "SOTRUDNIK", "VETERAN" , "ZAYAVKA" };
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
            dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tablesComboBox.Text}]");
        }
        private void TableSearch(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
                if (searchTextBox.Text == dataGridView.Rows[i].Cells[dataGridView.CurrentCell.ColumnIndex].Value.ToString())
                {
                    dataGridView.CurrentCell = dataGridView.Rows[i].Cells[dataGridView.CurrentCell.ColumnIndex];
                    dataGridView.CurrentCell.Selected = true;
                    break;
                }
        }
        private void FilterUse(object sender, EventArgs e)
        {
            if (filterCheckBox.Checked)
                dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tablesComboBox.Text}] WHERE ({dataGridView.Columns[dataGridView.CurrentCell.ColumnIndex].DataPropertyName}) LIKE '{searchTextBox.Text}'");
            else
                dataGridView.DataSource = FillDataGridView($"SELECT * FROM [{tablesComboBox.Text}]");
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            //createDocument();   
        }
        //public void createDocument()
        //{
        //    Word.Application app = new Word.Application();
        //    Word.Document doc = app.Documents.Add();
        //    Word.Paragraph p = doc.Content.Paragraphs.Add();
        //    p.Range.Text = "Примечание";
        //    p.Range.Font.Bold = 1;
        //    p.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
        //    p.Format.SpaceAfter = 0;
        //    p.Range.InsertParagraphAfter();
        //    p.Range.Font.Bold = 0;
        //    p.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            
        //    p.Range.Text = "Примечание2";
        //    p.Range.Text += "Примечание3";
        //    p = doc.Content.Paragraphs.Add();
        //    //doc.Save();
        //    app.Visible = true;
        //}
    }
}
