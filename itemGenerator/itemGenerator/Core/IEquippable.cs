namespace itemGenerator
{
    public interface IEquippable
    {
        /// <summary>
        ///     装備する
        /// </summary>
        void Equip();

        /// <summary>
        ///     装備を解除する
        /// </summary>
        void UnEquip();
    }
}