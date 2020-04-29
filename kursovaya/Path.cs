                                                                                                                                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace FOODRols
{
    public static class Path
    {
        public static string FilePath;
        public static string PathPicture;

        public static List<string> ReadFile()
        {
                return File.ReadAllLines(FilePath).ToList();
        }
        public static DataTable ReadTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("iD");
            dt.Columns.Add("Название");
            dt.Columns.Add("Состав");
            dt.Columns.Add("Вес");
            List<string> roll = ReadFile();
            foreach (string str in roll)
            {
                if (str == "")
                    break;
                string[] s = str.Split(';');
                dt.Rows.Add(s[0], s[1], s[2], s[3]);
            }
            return dt;
        }
        public static void SaveFile(List<string> roll)
        {
            File.WriteAllLines(FilePath, roll.ToArray());
        }
        public static string ReadLine(int id)
        {
            List<string> roll = ReadFile();
            string str = "";
            foreach (string s in roll)
            {
                if (s.StartsWith(id.ToString() + ";"))
                {
                    str = s;
                    break;
                }
            }
            return str;
        }
        public static void AddUpdate(int id, string name, string sostav, int weight, string path_picture)
        {
            List<string> roll = ReadFile();

            if (id == 0)
            {
                foreach (string s in roll)
                {
                    string[] mas = s.Split(';');
                    if (Convert.ToInt32(mas[0]) > id)
                    {
                        id = Convert.ToInt32(mas[0]);
                    }
                }
                id++;

                string str = id.ToString() + ";"
                                    + name + ";"
                                    + sostav + ";"
                                    + weight.ToString() + ";"
                                    + path_picture;
                roll.Add(str);
            }
            else
            {
                for (int i = 0; i < roll.Count; i++)
                {
                    if (roll[i].StartsWith(id.ToString() + ";"))
                    {
                        roll[i] = id.ToString() + ";"
                                    + name + ";"
                                    + sostav + ";"
                                    + weight.ToString() + ";"
                                    + path_picture;
                        break;
                    }
                }
            }

            SaveFile(roll);
        }
        public static void Delete(int id)
        {
            List<string> roll = ReadFile();
            string str = ReadLine(id);
            roll.Remove(str);
            SaveFile(roll);
        }
    }
}
