using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon : IDescribable
    {
        public string ShowInformation()
        {
            return "This is a weapon";
        }

        public override string Attack()
        {
            int a = new Random().Next(0, 9);
            string b = " ";
            return b + a;
        } 
    }
}
