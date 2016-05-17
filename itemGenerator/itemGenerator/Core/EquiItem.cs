namespace itemGenerator
{
    /// <summary>
    /// 装備アイテムクラス
    /// 仮想クラスなので実装は継承した
    /// 武器クラスや、防具クラス、アクセサリクラスなどで行う
    /// </summary>
    public abstract class EquiItem : Item, IEquippable
    {
        public abstract void Equip();
        public abstract void UnEquip();
    }
}