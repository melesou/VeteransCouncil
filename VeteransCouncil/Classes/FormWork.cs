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

namespace WorkWithForm.Classes
{
    internal class TablesWork
    {
        static string[] _filial = { "Номер филиала", "Адрес филиала", "Телефон филиала" };
        static string[] _meropriyatie = { "Номер мероприятия", "Название мероприятия", "Дата мероприятия", "Время мероприятия", "Номер филиала" };
        static string[] _sotrudnik = { "Номер сотрудника", "ФИО сотрудника", "Стаж сотрудника", "Должность сотрудника", "Номер филиала"};
        static string[] _veteran =   { "Номер ветерана", "ФИО ветерана", "День рождения", "Телефон ветерана", "Номер филиала" };
        static string[] _zayavka = { "Номер заявки", "Статус заявки", "Дата заявки", "Задача заявки", "Номер ветерана" };
        static List<string[]> _tables = new List<string[]> { _filial, _meropriyatie, _sotrudnik, _veteran, _zayavka };
        static public void CategoryFormation(DataGridView dataGridView, ComboBox comboBox)
        {
            string[] head = new string[dataGridView.ColumnCount];
            for (int i = 0; i < dataGridView.ColumnCount; i++)
                head[i] = dataGridView.Columns[i].DataPropertyName;
            comboBox.Items.Clear();
            comboBox.Items.AddRange(head);
        }
        static public void LabelsTextChange(Label[] labels, int tableId)
        {
            string[] tables = _tables[tableId];
            for (int i = 0; i < tables.Length; i++)
                labels[i].Text = tables[i];
        }
        static public void LabelsVisibleChange(TextBox[] textBoxes, Label[] labels, int tableId)
        {
            int tableSize = _tables[tableId].Length;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                labels[i].Visible = i < tableSize ? true : false;
                textBoxes[i].Visible = i < tableSize ? true : false;
            }
        }
    }
}
