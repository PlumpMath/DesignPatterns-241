using FluentAssertions;

using NUnit.Framework;

namespace DesignPatterns.AbstractFactory.Tests
{
    [TestFixture]
    public class MazeGameTests
    {
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
            maze.Should().NotBeNull();
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
            maze.Should().NotBeNull();
            firstRoom.Should().BeOfType<Room>();
            door.Should().BeOfType<Door>();
        }
    }
}
