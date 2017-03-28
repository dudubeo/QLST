using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLST.DT0
{
    class PhieuNhap
    {
        private string mapn;
        private string mathukho;
        private string makho;
        private DateTime ngaylap;
        private float dongia;
        private float vat;
        private float tongtien;

        public string Mapn
        {
            get
            {
                return mapn;
            }

            set
            {
                mapn = value;
            }
        }

        public string Mathukho
        {
            get
            {
                return mathukho;
            }

            set
            {
                mathukho = value;
            }
        }

        public string Makho
        {
            get
            {
                return makho;
            }

            set
            {
                makho = value;
            }
        }

        public DateTime Ngaylap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

        public float Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public float Vat
        {
            get
            {
                return vat;
            }

            set
            {
                vat = value;
            }
        }

        public float Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }
    }
}
