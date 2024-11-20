using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class ИсторияПродаж
    {
        List<ОписаниеТоваров> Запись = new List<ОписаниеТоваров>();

        public void НоваяЗапись (ОписаниеТоваров x) 
        {
            Запись.Add(x);
        }
        public string ConvertString()
            
        {
            string res = " ";
            for (int i = 0; i < Запись.Count; i++) 
            {
                ЗаписьПродаж s = Запись[i];
                res += Convert.ToString(s.День);
                res += Convert.ToString(s.количество);
                res += s.ОписаниеТоваров. СкажиНазвание();


            }
            return res;
        }
        
    }
}
