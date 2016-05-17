using System;

namespace itemGenerator
{
    public class Weapon : EquiItem, ILevel, IWeapon
    {
        private int attack;
        private int exp;
        private int hit;
        private bool isEquip;
        private int level;


        public Weapon()
        {
            level = 1;
            exp = 0;
        }

        public Weapon(Random rand)
        {
        }

        public override string ToString()
        {
            return
                string.Format(
                    "[Weapon] id:{0} name:{1} iconId:{2} price:{3} level:{4} exp:{5} isEquip:{6} attack:{7} hit:{8}",
                    GetId(), GetName(), GetIconId(), GetPrice(), GetLevel(), GetExp(), isEquip, GetAttack(), GetHit());
        }

        #region IEquippable

        public override void Equip()
        {
            isEquip = true;
            Console.WriteLine(GetName() + "を装備した。");
        }

        public override void UnEquip()
        {
            isEquip = false;
            Console.WriteLine(GetName() + "を装備から外した。");
        }

        #endregion

        #region ILevel

        public void LevelUp()
        {
            level++;
            if (level > 100) level = 100;
        }

        public void LevelDown()
        {
            level--;
            if (level <= 0) level = 1;
        }

        public void AddExp(int addValue)
        {
            exp += addValue;

            while (exp < 0)
            {
                exp += 100;
                LevelDown();
            }
            while (exp >= 100)
            {
                exp -= 100;
                LevelUp();
            }
        }

        public int GetLevel()
        {
            return level;
        }

        public int GetExp()
        {
            return exp;
        }

        #endregion

        #region IWeapon

        public int GetAttack()
        {
            return (int) (attack*(1 + GetLevel()*0.1f));
        }

        public int GetHit()
        {
            return hit + 3*GetLevel();
        }

        #endregion
    }
}