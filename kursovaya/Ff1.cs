using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FOODRols
{
    public partial class Ff1 : Form
    {
        public Ff1()
        {
            InitializeComponent();
        }

        private void FillData()
        {
            data.DataSource = Path.ReadTable();
        }

        private void dataGVBludCol()
        {
            data.DataSource = Path.ReadTable();
        }
        private void buttonSearchPath_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBPath.Text = openFileDialog1.FileName;
               Path.FilePath = openFileDialog1.FileName;
                dataGVBludCol();
                FillData();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            fr2 one = new fr2();
            one.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            data.DataSource = Path.ReadTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(data.CurrentRow.Cells[0].Value);
            Path.Delete(ID);
            FillData();
        }

        private void dataGVRollBlud_DoubleClick(object sender, EventArgs e)
        {
            fr2 first = new fr2(Convert.ToInt32(data.CurrentRow.Cells[0].Value));
            first.ShowDialog();
            FillData();
        }

        private void BludForm_Activated(object sender, EventArgs e)
        {
            if(textBPath.Text!= "Выберите путь")
            FillData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (data.DataSource as DataTable).DefaultView.RowFilter = String.Format("[Название] LIKE '%{0}%'", 
                textBFiltr.Text.Trim());
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
