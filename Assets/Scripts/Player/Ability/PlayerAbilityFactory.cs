using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Player.Ability
{
    internal class PlayerAbilityFactory
    {
        public PlayerAbility GetAbility(string nameAbility)
        {
            switch (nameAbility)
            {
                case "SpeedUp":
                    return new SpeedUpAbility();
                case "HealSelf":
                    return new HealSelfAbility();
                case "AddBullet":
                    return new AddBulletAbility();
                case "Plane":
                    return new PlaneAbility();
                default:
                    throw new ArgumentException("Loại sản phẩm không hợp lệ");
            }
        }
    }
}
