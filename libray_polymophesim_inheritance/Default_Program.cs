using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lpi.Classes;
using lpi.Contracts;


namespace libray_polymophesim_inheritance
{
    class Default_Program
    {
        static void Main(string[] args)
        {
            Customer c0 = new Customer();
            c0.CustomerId = 111;

            Supplier s0 = new Supplier();
            s0.SupplierId = 222;

            Console.WriteLine("22 -- CustomerID: {0} -- SupplierId: {1}.", c0.CustomerId, s0.SupplierId);

            ICalculate CalOpt0 = new AddCalculate();
            ICalculate CalOpt1 = new SubstractCalculate();
            ICalculate CalOpt2 = new MultiplyCalculate();
            ICalculate CalOpt3 = new DivideCalculate();

            int rz0 = CalOpt0.ProformanceCalculate(0, 10);
            int rz1 = CalOpt1.ProformanceCalculate(2, 3);
            int rz2 = CalOpt2.ProformanceCalculate(4, 5);
            int rz3 = CalOpt3.ProformanceCalculate(6, 2);

            Console.WriteLine("35 -- add: {0} -- subsctract: {1} -- multiply: {2} -- divide: {3}.", rz0, rz1, rz2, rz3);

            Console.ReadLine();

        }
    }
}
