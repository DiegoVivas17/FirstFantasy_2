using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Axe : Weapon
    {
        public string Showinformation()
        {
            return "algo";
        }

        public override int Attack()
        {
            int a = new Random().Next(1, 8);
            int b = 4;
            return b + a;
        }
    }
}
