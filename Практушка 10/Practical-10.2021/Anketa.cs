using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10._2021
{
    class ycheniki
    {
        public string FIO;
        public string group;
        public int ocenka;

        public override string ToString()
        {
            return " ФИО " + FIO + " Группа=" + group + " Оценка=" + ocenka;
        }
    }
}
