using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThue
{
    internal class KhachHang
    {
        private string _idkh;
        private string _namekh;
        private string _addresskh;
        private string _numberkh;
        public KhachHang(string idkh, string namekh, string addresskh, string numberkh)
        {
            _idkh = idkh;
            _namekh = namekh;
            _addresskh = addresskh;
            _numberkh = numberkh;
        }

        public string Idkh { get => _idkh; set => _idkh = value; }
        public string Namekh { get => _namekh; set => _namekh = value; }
        public string Addresskh { get => _addresskh; set => _addresskh = value; }
        public string Numberkh { get => _numberkh; set => _numberkh = value; }
    }
    
}
