namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractMazeFactory : ICreateMazes
    {
        public abstract Door CreateDoor(Room room1, Room room2);

        public abstract Maze CreateMaze();

        public abstract Room CreateRoom(int roomNumber);

        public abstract Wall CreateWall();
    }
}