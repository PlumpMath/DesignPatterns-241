namespace DesignPatterns.AbstractFactory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override Door CreateDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        public override Room CreateRoom(int roomNumber)
        {
            return new EnchantedRoom(roomNumber, CastSpell());
        }

        private Spell CastSpell()
        {
            return new Spell();
        }
    }
}