namespace DesignPatterns.AbstractFactory
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public EnchantedRoom(int roomNumber, Spell spell)
            : base(roomNumber)
        {
            _spell = spell;
        }
    }
}