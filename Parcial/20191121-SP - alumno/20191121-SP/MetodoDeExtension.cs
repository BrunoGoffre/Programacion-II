﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20191121_SP
{
    public static class MetodoDeExtension
    {
        public static string EstadoSimulacion(this bool valor)
        {
            if (valor)
            {
                return "Orbitando";
            }
            else 
            {
                return "Detenido";
            }
        }

    }
}
