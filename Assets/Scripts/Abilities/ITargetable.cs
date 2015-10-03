using Assets.Scripts.Effects;

namespace Assets.Scripts.Abilities
{
    public interface ITargetable
    {
        bool AddEffect(IEffect effect);
        bool RemoveEffect(IEffect effect);
    }
}
