using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddTel_Click(object sender, EventArgs e)
        {
            ListaTel.Visible = true;
            DataGridViewRow row = (DataGridViewRow)ListaTel.Rows[0].Clone();

            row.Cells[0].Value= TxtNome.Text;
            row.Cells[1].Value = TxtTelefone.Text;
            ListaTel.Rows.Add(row);
            int tot = ListaTel.RowCount - 1;
            total.Text = ("Total: "+tot.ToString());
            Console.WriteLine(); 
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ListaTel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(ListaTel);

        }
    }
}
