namespace DesignPatterns.AbstractFactory
{
    public class MazeGame
    {
        private readonly ICreateMazes _factory;

        public MazeGame(ICreateMazes factory)
        {
            _factory = factory;
        }

        public Maze CreateMaze()
        {
            var maze = _factory.CreateMaze();
            var room1 = _factory.CreateRoom(1);
            var room2 = _factory.CreateRoom(2);
            var door = _factory.CreateDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, _factory.CreateWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, _factory.CreateWall());
            room1.SetSide(Direction.West, _factory.CreateWall());

            room2.SetSide(Direction.North, _factory.CreateWall());
            room2.SetSide(Direction.East, _factory.CreateWall());
            room2.SetSide(Direction.South, _factory.CreateWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }
    }
}