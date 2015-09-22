namespace DesignPatterns.AbstractFactory
{
    public class Door : DoorBase
    {
        public Door(RoomBase room1, RoomBase room2)
            : base(room1, room2)
        {
        }
    }
}