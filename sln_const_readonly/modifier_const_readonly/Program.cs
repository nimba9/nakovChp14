using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifier_const_readonly
{
    public class  Modifiers
    {
        public const double interestRate = 5.25;
        public readonly int mortgageLength = 12;

        public Modifiers(int length)
        {
            this.mortgageLength = length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(interestRate);
            Console.WriteLine(Modifiers.interestRate);
            Modifiers instance = new Modifiers(23);
            Console.WriteLine(instance.mortgageLength);

            

            

        }
    }
}
