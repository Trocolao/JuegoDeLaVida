﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaVida.LogicaDeNegocio
{
    public class Celula
    {
        public Celula(Boolean tieneVida)
        {
            TieneVida = tieneVida;
        }
        public Boolean TieneVida { get; set; }
    }
}