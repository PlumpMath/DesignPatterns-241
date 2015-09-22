namespace DesignPatterns.AbstractFactory
{
    public class EnchantedRoom : RoomBase
    {
        private Spell _spell;

        public EnchantedRoom(int roomNumber, Spell spell)
            : base(roomNumber)
        {
            _spell = spell;
        }
    }
}