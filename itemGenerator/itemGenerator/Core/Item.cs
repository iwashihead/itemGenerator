using System;

namespace itemGenerator
{
	public class Item : Iitem
	{
		private int id;
		private string name;
		private int iconId;
		private int price;

		#region static
		private static readonly string[] NameTable = new string[]
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
			Item tempItem = new Item(
				rand.Next(0,10),
				NameTable[ rand.Next(0,NameTable.Length-1) ],
				rand.Next(0,10),
				rand.Next(10,100) * 10
			);
			return tempItem;
		}
		#endregion

		public Item ()
		{
		}

		public Item (int id, string name, int iconId, int price)
		{
			this.id = id;
			this.name = name;
			this.iconId = iconId;
			this.price = price;
		}

		#region Iitem
		public int			GetId(){ return id; }
		public string		GetName(){ return name; }
		public int			GetIconId(){ return iconId; }
		public int			GetPrice(){ return price; }
		#endregion


		public override string ToString ()
		{
			return string.Format (string.Format("[Item] id:{0} name:{1} iconId:{2} price:{3}",
				GetId(),
				GetName(),
				GetIconId(),
				GetPrice())
			);
		}
	}
}

