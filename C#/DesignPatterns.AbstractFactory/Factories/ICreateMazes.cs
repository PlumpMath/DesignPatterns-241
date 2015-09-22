namespace DesignPatterns.AbstractFactory
{
    public interface ICreateMazes
    {
        Door CreateDoor(Room room1, Room room2);

        Maze CreateMaze();

        Room CreateRoom(int roomNumber);

        Wall CreateWall();
    }
}