﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Modelo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int IDMarca { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
