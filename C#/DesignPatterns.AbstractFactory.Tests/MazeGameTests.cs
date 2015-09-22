using DesignPatterns.AbstractFactory.Factories;
using DesignPatterns.AbstractFactory.Products.Rooms;
using DesignPatterns.AbstractFactory.Products.Walls;
using FluentAssertions;

using NUnit.Framework;

namespace DesignPatterns.AbstractFactory.Tests
{
    [TestFixture]
    public class MazeGameTests
    {
        [Test]
        public void CanCreateBombedMaze()
        {
            // Arrange
            MazeFactory factory = new BombedMazeFactory();
            var game = new MazeGame(factory);

            // Act
            var maze = game.CreateMaze();
            var firstRoom = maze.GetRoom(1);
            var wall = firstRoom.GetSide(Direction.North);

            // Assert
            maze.Should().BeOfType<Maze>();
            firstRoom.Should().BeOfType<RoomWithABomb>();
            wall.Should().BeOfType<BombedWall>();
        }

        [Test]
        public void CanCreateEnchantedMaze()
        {
            // Arrange
            var factory = new EnchantedMazeFactory();
            var game = new MazeGame(factory);

            // Act
            var maze = game.CreateMaze();
            var firstRoom = maze.GetRoom(1);
            var door = firstRoom.GetSide(Direction.East);

            // Assert
            maze.Should().BeOfType<Maze>();
            firstRoom.Should().BeOfType<EnchantedRoom>();
            door.Should().BeOfType<DoorNeedingSpell>();
        }

        [Test]
        public void CanCreateMazes()
        {
            // Arrange
            var factory = new MazeFactory();
            var game = new MazeGame(factory);

            // Act
            var maze = game.CreateMaze();
            var firstRoom = maze.GetRoom(1);
            var door = firstRoom.GetSide(Direction.East);

            // Assert
            maze.Should().BeOfType<Maze>();
            firstRoom.Should().BeOfType<Room>();
            door.Should().BeOfType<Door>();
        }
    }
}
