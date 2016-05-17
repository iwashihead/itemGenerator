using System;

namespace itemGenerator
{
    public class Item : Iitem
    {
        private readonly int iconId;
        private readonly int id;
        private readonly string name;
        private readonly int price;

        public Item()
        {
        }

        public Item(int id, string name, int iconId, int price)
        {
            this.id = id;
            this.name = name;
            this.iconId = iconId;
            this.price = price;
        }


        public override string ToString()
        {
            return string.Format("[Item] id:{0} name:{1} iconId:{2} price:{3}", GetId(), GetName(), GetIconId(),
                GetPrice());
        }

        #region static

        private static readonly string[] NameTable =
        {
            "普通なアイテム",
            "便利なアイテム",
            "恐ろしいアイテム",
            "安物のアイテム",
            "魔法のアイテム",
            "伝説のアイテム"
        };

        public static Iitem Create(int rarity, Random rand)
        {
            // TODO 本来はレアリティを見てランダムアイテムテーブルから抽選する
            var tempItem = new Item(
                rand.Next(0, 10),
                NameTable[rand.Next(0, NameTable.Length - 1)],
                rand.Next(0, 10),
                rand.Next(10, 100)*10
                );
            return tempItem;
        }

        #endregion

        #region Iitem

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetIconId()
        {
            return iconId;
        }

        public int GetPrice()
        {
            return price;
        }

        #endregion
    }
}