using DesignPatterns.AbstractFactory.Products.Rooms;
using DesignPatterns.AbstractFactory.Products.Walls;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class BombedMazeFactory : MazeFactory
    {
        public override Room CreateRoom(int roomNumber)
        {
            return new RoomWithABomb(roomNumber);
        }

        public override Wall CreateWall()
        {
            return new BombedWall();
        }
    }
}