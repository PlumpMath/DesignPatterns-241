namespace DesignPatterns.AbstractFactory
{
    public class MazeFactory : MazeFactoryBase
    {
        public override MazeBase CreateMaze()
        {
            return new Maze();
        }

        public override RoomBase CreateRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }

        public override DoorBase CreateDoor(RoomBase room1, RoomBase room2)
        {
            return new Door(room1, room2);
        }

        public override WallBase CreateWall()
        {
            return new Wall();
        }
    }
}