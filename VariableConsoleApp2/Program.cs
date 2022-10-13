using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Styurin Konstantin Nikolaevich";
            byte age = 27;
            var email = "Kostya.pure@yande.ru";
            double scoreInformatics = 74.936;
            double scoreMaths = 85.654;
            double scorePhysics = 90.123;

            double valueA = scoreInformatics;
            double valueB = scoreMaths;
            double valueC = scorePhysics;

            double valueD = valueA + valueB + valueC;
            double valueF = (valueA + valueB + valueC) / 3;

            string pattern = "Ф.И.О. - {0} \nВозраст - {1} \nПочта - {2} \nБаллы по информатике - {3} \nБаллы по математике - {4} \nБаллы по физике - {5} \nОбщее кол-во баллов - {6} \nСредний балл - {7}";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              scoreInformatics,
                              scoreMaths,
                              scorePhysics,
                              valueD,
                              valueF);

                       Console.ReadKey();

               
           
        }
    }
}
