using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class ОписаниеТоваров
    {
        private string Название;
        private double Цена;
        public ОписаниеТоваров(string Название_, double Цена_) 
        {
            Название = Название_;
            Цена = Цена_;
        }
        public string СкажиНазвание() 
        {
            return Название;
            
        }
         
        
         

        
     
        
        
        
        


    }
}
