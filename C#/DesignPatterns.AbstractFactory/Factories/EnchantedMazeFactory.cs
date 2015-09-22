namespace DesignPatterns.AbstractFactory
{
    public class EnchantedMazeFactory : MazeFactoryBase
    {
        public override DoorBase CreateDoor(RoomBase room1, RoomBase room2)
        {
            throw new System.NotImplementedException();
        }

        public override MazeBase CreateMaze()
        {
            throw new System.NotImplementedException();
        }

        public override RoomBase CreateRoom(int roomNumber)
        {
            return new EnchantedRoom(roomNumber, CastSpell());
        }

        private Spell CastSpell()
        {
            return new Spell();
        }

        public override WallBase CreateWall()
        {
            throw new System.NotImplementedException();
        }
    }
}