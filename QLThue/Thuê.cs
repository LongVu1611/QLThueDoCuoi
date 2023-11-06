using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThue
{
    internal class Thuê
    {
        private string _id;
        private string _idkh;
        private DateTime _datego;
        private DateTime _dateback;
        private string _bill;

        public Thuê(string id, string idkh, DateTime datego, DateTime dateback, string bill)
        {
            _id = id;
            _idkh = idkh;
            _datego = datego;
            _dateback = dateback;
            _bill = bill;
        }

        public string Id { get => _id; set => _id = value; }
        public string Idkh { get => _idkh; set => _idkh = value; }
        public DateTime Datego { get => _datego; set => _datego = value; }
        public DateTime Dateback { get => _dateback; set => _dateback = value; }
        public string Bill { get => _bill; set => _bill = value; }
    }
}
