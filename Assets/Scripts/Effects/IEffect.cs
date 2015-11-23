namespace Assets.Scripts.Effects
{
    public interface IEffect
    {
        bool IsStackable { get; set; }
        string Name { get; set; }
        void Apply();
        void UnApply();
    }
}
