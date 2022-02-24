﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeAula133.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2") 
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2")
                + ")";
        }
    }

}
