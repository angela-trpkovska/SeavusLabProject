﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Common
{
   public class CurrencyMismatchException:ApplicationException
    {
       public CurrencyMismatchException(string message)
           : base(message)
       { 
       }

    }
}
