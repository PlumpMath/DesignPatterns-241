using System;

namespace DesignPatterns.AbstractFactory
{
    public abstract class DoorBase : MapSite
    {
        private RoomBase _room1;
        private RoomBase _room2;

        protected DoorBase(RoomBase room1, RoomBase room2)
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