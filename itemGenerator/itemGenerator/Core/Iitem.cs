using System;

namespace itemGenerator
{
	/// <summary>
	/// アイテムのインターフェース
	/// </summary>
	public interface Iitem
	{
		int			GetId();
		string		GetName();
		int			GetIconId();
		int			GetPrice();
	}
}

