namespace DesignPatterns.AbstractFactory
{
    public class MazeGame
    {
        public MazeBase CreateMaze(MazeFactoryBase factory)
        {
            var maze = factory.CreateMaze();
            var room1 = factory.CreateRoom(1);
            var room2 = factory.CreateRoom(2);
            var door = factory.CreateDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, factory.CreateWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, factory.CreateWall());
            room1.SetSide(Direction.West, factory.CreateWall());

            room2.SetSide(Direction.North, factory.CreateWall());
            room2.SetSide(Direction.East, factory.CreateWall());
            room2.SetSide(Direction.South, factory.CreateWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}