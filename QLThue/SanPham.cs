using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThue
{
    internal class SanPham
    {
        private string _id;
        private string _name;
        private string _country;
        private string _info;
        private string _von;
        private string _giathue;

        public SanPham( string id, string name, string country, string info, string von, string giathue)
        {
            _id = id;
            _name = name;
            _country = country;
            _info = info;
            _von = von;
            _giathue = giathue;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Country { get => _country; set => _country = value; }
        public string Info { get => _info; set => _info = value; }
        public string Von { get => _von; set => _von = value; }
        public string Giathue { get => _giathue; set => _giathue = value; }
    }
}
