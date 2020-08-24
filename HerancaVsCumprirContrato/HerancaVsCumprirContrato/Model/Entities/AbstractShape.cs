﻿using System;
using System.Collections.Generic;
using System.Text;
using HerancaVsCumprirContrato.Model.Enums;

namespace HerancaVsCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
