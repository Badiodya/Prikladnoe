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
    public partial class fr2 : Form
    {
        private int id;
        public fr2()
        {
            InitializeComponent();
            var s = Directory.GetFiles("Картинки");
            Array.Sort(s);
            comboBox1.Items.AddRange(s);
        }

        public fr2(int ID)
        {
            InitializeComponent();
            var s = Directory.GetFiles("Картинки");
            Array.Sort(s);
            comboBox1.Items.AddRange(s);
            id = ID;
            Bludo first = new Bludo(id);
            textBoxName.Text = first.name;
            textSostav.Text = first.sostav;
            textweight.Text = Convert.ToString(first.weight);
            picture.ImageLocation = comboBox1.Text = first.path_picture;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Path.AddUpdate(id, textBoxName.Text, textSostav.Text, Convert.ToInt32(textweight.Text), 
                picture.ImageLocation);
            Close();
        }

        private void pictureBBlud_Paint(object sender, PaintEventArgs e)
        { 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            picture.ImageLocation = comboBox1.SelectedItem.ToString();
            picture.Update();
        }
    }
}
