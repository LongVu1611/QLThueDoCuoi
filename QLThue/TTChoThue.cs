using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThue
{
    internal class TTChoThue
    {
        private string _ctpt;
        private string _idphieu;
        private string _idsp;
        private string _soluong;
        private string _bill;

        public TTChoThue(string ctpt, string idphieu, string idsp, string soluong, string bill)
        {
            _ctpt = ctpt;
            _idphieu = idphieu;
            _idsp = idsp;
            _soluong = soluong;
            _bill = bill;
        }

        public string Ctpt { get => _ctpt; set => _ctpt = value; }
        public string Idphieu { get => _idphieu; set => _idphieu = value; }
        public string Idsp { get => _idsp; set => _idsp = value; }
        public string Soluong { get => _soluong; set => _soluong = value; }
        public string Bill { get => _bill; set => _bill = value; }
    }
}
