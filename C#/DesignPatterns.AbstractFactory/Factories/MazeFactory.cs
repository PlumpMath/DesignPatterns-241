namespace DesignPatterns.AbstractFactory
{
    public class MazeFactory : AbstractMazeFactory
    {
        public override Maze CreateMaze()
        {
            return new Maze();
        }

        public override Room CreateRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }

        public override Wall CreateWall()
        {
            return new Wall();
        }
    }
}