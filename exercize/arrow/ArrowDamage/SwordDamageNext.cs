using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowDamage
{
    internal class SwordDamageNext : WeaponDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;        

        protected override void CalculateDamage()
        {
            decimal MagicMultiplier = 1M;
            if (Magic) MagicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE;

            if (Flaming) Damage += FLAME_DAMAGE;
        }
        
        public SwordDamageNext(int startingRoll) : base(startingRoll) { }           
    }
}
