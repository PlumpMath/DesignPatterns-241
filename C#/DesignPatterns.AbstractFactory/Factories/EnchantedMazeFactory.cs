namespace DesignPatterns.AbstractFactory
{
    public class EnchantedMazeFactory : AbstractMazeFactory
    {
        public override Door CreateDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        public override Maze CreateMaze()
        {
            return new Maze();
        }

        public override Room CreateRoom(int roomNumber)
        {
            return new EnchantedRoom(roomNumber, CastSpell());
        }

        public override Wall CreateWall()
        {
            return new Wall();
        }

        private Spell CastSpell()
        {
            return new Spell();
        }
    }
}