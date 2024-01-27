using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarduriMeniu.Models
{
    public class Product
    {

        private int _id;

        private string _type;

        private string _name;

        private string _imgPath;

        public Product(int id, string type, string name, string imgPath)
        {
            _id = id;
            _type = type;
            _name = name;
            _imgPath = imgPath;
        }

        public Product(string t)
        {

            string[] prop = t.Split(',');

            this._id = int.Parse(prop[0]);
            this._type = prop[1];
            this._name = prop[2];
            this._imgPath = prop[3];

        }

        public int Id { get => _id; set => _id = value; }
        public string Type { get => _type; set => _type = value; }
        public string Name { get => _name; set => _name = value; }
        public string ImgPath { get => _imgPath; set => _imgPath = value; }

    }
}
