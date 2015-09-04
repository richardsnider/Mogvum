namespace Assets.Scripts.Interfaces
{
    public interface IEffect
    {
        void Apply();
        void UnApply();
        string GetName();
        bool CanStack();
    }
}
