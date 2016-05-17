namespace itemGenerator
{
    /// <summary>
    /// ボーナスオプション
    /// ディアブロやサマナーズウォー等のアイテムモデル.
    /// </summary>
    public interface IbonusOption
    {
        string GetName();

        int GetOptionType();
        int GetValue();
    }
}