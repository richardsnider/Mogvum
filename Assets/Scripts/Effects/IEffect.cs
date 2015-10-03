namespace Assets.Scripts.Effects
{
    public interface IEffect
    {
        void Apply();
        void UnApply();
        string GetName();
        bool CanStack();
    }
}
