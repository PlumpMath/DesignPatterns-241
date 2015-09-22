using System;

namespace DesignPatterns.AbstractFactory
{
    public abstract class RoomBase : MapSite
    {
        private MapSite _east;
        private MapSite _north;
        private MapSite _south;
        private MapSite _west;

        protected RoomBase(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }

        public MapSite GetSide(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return _north;
                case Direction.East:
                    return _east;
                case Direction.South:
                    return _south;
                case Direction.West:
                    return _west;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }

        public int RoomNumber { get; }

        public void SetSide(Direction direction, MapSite site)
        {
            switch (direction)
            {
                case Direction.North:
                    _north = site;
                    break;
                case Direction.East:
                    _east = site;
                    break;
                case Direction.South:
                    _south = site;
                    break;
                case Direction.West:
                    _west = site;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
    }
}