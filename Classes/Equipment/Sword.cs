using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Sword : Weapon
    {
        public string Showinformation()
        {
            return "algo";
        }

        public override int Attack()
        {
            int a = new Random().Next(1, 9);
            int b = 5;
            return b + a;
        }
    }
}
