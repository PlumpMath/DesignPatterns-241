namespace DesignPatterns.AbstractFactory
{
    public abstract class MazeFactoryBase
    {
        public abstract DoorBase CreateDoor(RoomBase room1, RoomBase room2);

        public abstract MazeBase CreateMaze();

        public abstract RoomBase CreateRoom(int roomNumber);

        public abstract WallBase CreateWall();
    }
}