﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaUygulamasi.Concrets
{
    public class MusterilerListesi
    {
        static public List<Musteri> TumMusteriler { get; set; } = new();
        static public List<Musteri> VipMusteriler { get; set; } = new();
        public List<Musteri> GiseMusterileri { get; set; } = new();
        public List<Musteri> BireyselMusteriler { get; set; } = new();

    }
}

