﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistema_megacenter
{
    class VerificarRut
    {
        public string digitoVerificador(int rut)
        {
            int Digito;
            int Contador;
            int Multiplo;
            int Acumulador;
            string RutDigito;

            Contador = 2;
            Acumulador = 0;

            while (rut != 0)
            {
                Multiplo = (rut % 10) * Contador;
                Acumulador = Acumulador + Multiplo;
                rut = rut / 10;
                Contador = Contador + 1;
                if (Contador == 8)
                {
                    Contador = 2;
                }

            }

            Digito = 11 - (Acumulador % 11);
            RutDigito = Digito.ToString().Trim();
            if (Digito == 10)
            {
                RutDigito = "k";
            }
            if (Digito == 11)
            {
                RutDigito = "0";
            }

            return (RutDigito);
        }
    }
}
