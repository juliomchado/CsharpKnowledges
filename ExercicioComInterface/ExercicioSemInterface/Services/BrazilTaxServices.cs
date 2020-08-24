﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioSemInterface.Services
{
    class BrazilTaxServices : ITaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
                return amount * 0.2;
            else
                return amount * 0.15;
        }
    }
}
