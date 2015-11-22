using Assets.Scripts.Utilities;

namespace Assets.Scripts.Characters
{
    public class CarryWeight : BarValue
    {
        public CarryWeight()
        {
        }

        public CarryWeight(int value) : base(value)
        {
        }

        public CarryWeight(decimal percent, int max) : base(percent, max)
        {
        }

        public CarryWeight(int current, int max) : base(current, max)
        {
        }
    }
}
