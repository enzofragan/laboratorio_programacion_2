﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano
    {
        private int _dni;

        public int Dni {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }

        public override string ToString()
        {
            return this._dni.ToString();
        }
    }
}
