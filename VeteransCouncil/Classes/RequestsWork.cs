using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorkWithRequest.Classes
{
    internal class RequestsWork
    {
        static private string CreateNamesForRequest(DataGridView dataGridView)
        {
            string names = "";
            string[] head = new string[dataGridView.ColumnCount];
            for (int i = 0; i < dataGridView.ColumnCount; i++) //Присвоение названия переменных
                head[i] = dataGridView.Columns[i].DataPropertyName;
            for (int i = 0; i < head.Length; i++) //Создание Названий переменных и названия значений
            {
                names += head[i].ToString();
                names += i + 1 == head.Length ? "" : ", ";
            }
            return names;//Пример: "Столбец1, Столбец2, Столбец3"
        }
        static private string CreateVariablesForRequest(DataGridView dataGridView)
        {
            string values = "";
            string[] head = new string[dataGridView.ColumnCount];
            for (int i = 0; i < dataGridView.ColumnCount; i++) //Присвоение названия переменных
                head[i] = dataGridView.Columns[i].DataPropertyName;
            for (int i = 0; i < head.Length; i++) //Создание Названий переменных и названия значений
            {
                values += "@v" + (i + 1).ToString();
                values += i + 1 == head.Length ? "" : ", ";
            }
            return values; //Пример: "v1, v2, v3, v4, v5, v6, v7"
        }
        static public void SendingAddRequest(DataGridView dataGridView, ComboBox comboBox, TextBox[] textBoxes, string settings)
        {
            string names = CreateNamesForRequest(dataGridView);
            string values = CreateVariablesForRequest(dataGridView);
            SqlConnection sqlConnection = new SqlConnection(settings);
            sqlConnection.Open();
            SqlCommand command = sqlConnection.CreateCommand();
            string sqlInsert = @"Insert into " + comboBox.Text + " (" + names + ") values (" + values + ")"; // SQL запрос
            command.CommandText = sqlInsert;
            for (int i = 0; i < dataGridView.ColumnCount; i++) // Присвоение значений переменным
                command.Parameters.AddWithValue("@v" + (i + 1).ToString(), textBoxes[i].Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        static private string CreateChangeRequest(DataGridView dataGridView, ComboBox comboBox)
        {
            string[] head = new string[dataGridView.ColumnCount]; 
            for (int i = 0; i < dataGridView.ColumnCount; i++) // Присвоение названия переменных
                head[i] = dataGridView.Columns[i].DataPropertyName;
            string sqlUpdate = @"update " + comboBox.Text + " set ";
            for (int i = 1; i < head.Length; i++)
            {
                sqlUpdate += "" + head[i] + " = @v" + (i + 1).ToString();
                sqlUpdate += i + 1 == head.Length ? " " : ", ";
            }
            sqlUpdate += "where " + head[0] + " = @v1";
            return sqlUpdate;
        }
        static public void SendingChangeRequest(DataGridView dataGridView, ComboBox comboBox, TextBox[] textBoxes, string settings)
        {
            SqlConnection sqlConnection = new SqlConnection(settings);
            sqlConnection.Open();
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = CreateChangeRequest(dataGridView, comboBox);//Пример: "update БЛЮДО set КОД_ПРОДУКТА = @v2, ОБЪЕМ_ПРОДУКТА = @v3 where КОД_БЛЮДА = @v1"
            for (int i = 0; i < dataGridView.ColumnCount; i++) // Присвоение значений переменным
                command.Parameters.AddWithValue("@v" + (i + 1).ToString(), textBoxes[i].Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        static public void SendingDeleteRequest(DataGridView dataGridView, ComboBox comboBox, TextBox[] textBoxes, string settings)
        {
            string sqlDelete = @"delete from [" + comboBox.Text + "] where " + dataGridView.Columns[0].DataPropertyName + " = @v1";
            SqlConnection conn = new SqlConnection(settings);
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@v1", textBoxes[0].Text);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
