using System;

namespace itemGenerator
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            // 通常のアイテムクラス
            for (var i = 0; i < 10; ++i)
            {
                var item = Item.Create(0, AppRandom.Instance.Random);
                Console.WriteLine(item.ToString());
            }

            // 一歩踏み込んで武器クラス
            var weapon = new Weapon();
            Console.WriteLine(weapon.ToString());

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}