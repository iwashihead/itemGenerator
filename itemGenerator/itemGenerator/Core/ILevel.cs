namespace itemGenerator
{
    /// <summary>
    /// レベルインターフェース
    /// </summary>
    public interface ILevel
    {
        void LevelUp();
        void LevelDown();
        void AddExp(int addValue);

        int GetLevel();
        int GetExp();
    }
}