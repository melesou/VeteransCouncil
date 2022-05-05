using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeteransCouncil
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void TablesButton_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
