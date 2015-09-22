using System;

namespace DesignPatterns.AbstractFactory
{
    public class Door : MapSite
    {
        private Room _room1;
        private Room _room2;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }

        public bool IsOpen { get; set; }
    }
}