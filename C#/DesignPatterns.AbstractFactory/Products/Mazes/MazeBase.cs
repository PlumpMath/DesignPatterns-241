using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.AbstractFactory
{
    public abstract class MazeBase
    {
        private readonly IList<RoomBase> _rooms;

        protected MazeBase()
        {
            _rooms = new List<RoomBase>();
        }

        public void AddRoom(RoomBase room)
        {
            _rooms.Add(room);
        }

        public RoomBase GetRoom(int roomNumber)
        {
            return _rooms.Single(room => room.RoomNumber == roomNumber);
        }
    }
}