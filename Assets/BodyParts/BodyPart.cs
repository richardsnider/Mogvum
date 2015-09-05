using Assets.Scripts.Interfaces;

namespace Assets.BodyParts
{
    class BodyPart : IBodyPart
    {
        Item EquipedItem;
        //There needs to be some kind of grappable/wieldable interface to distinguish between things that can hold weapons vs limbs that can't (you cant wield a sword with a leg)
        public int Life, MaxLife, LifeRegen;
        public int Energy, MaxEnergy, EnergyRegen;
        public int Soul, MaxSoul, SoulRegen; //Because what is you have an arm made of fire or something crazy like that. Or what if you have a bionic arm?


        public void EquipItem(Item item)
        {
            EquipedItem = item;
        }
    }
}
