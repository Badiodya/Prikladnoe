using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FOODRols
{
    public class Bludo
    {
        public int id;
        public string name;
        public string sostav;
        public int weight;
        public Image Image;
        public string path_picture;

        public Bludo()
        {
            id = 0;
            name = "";
            sostav = "";
            weight = 0;
            path_picture = "картинки\\1.jpg";
        }
        public Bludo(int _id)
        {
            string str = Path.ReadLine(_id);
            string[] mas = str.Split(';');

            id = Convert.ToInt32(mas[0]);
            name = Convert.ToString(mas[1]);
            sostav= Convert.ToString(mas[2]);
            weight = Convert.ToInt32(mas[3]);
            path_picture = Convert.ToString(mas[4]);
        }

        public void SaveBludo()
        {
            Path.AddUpdate(id, name, sostav, weight, path_picture);
        }
    }
}
