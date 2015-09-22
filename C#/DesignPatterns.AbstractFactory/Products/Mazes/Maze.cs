using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.AbstractFactory
{
    public class Maze
    {
        private readonly IList<Room> _rooms;

        public Maze()
        {
            _rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room GetRoom(int roomNumber)
        {
            return _rooms.Single(room => room.RoomNumber == roomNumber);
        }
    }
}