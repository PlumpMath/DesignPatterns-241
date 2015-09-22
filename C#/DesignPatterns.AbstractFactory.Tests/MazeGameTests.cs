using FluentAssertions;

using NUnit.Framework;

namespace DesignPatterns.AbstractFactory.Tests
{
    [TestFixture]
    public class MazeGameTests
    {
        [Test]
        public void CanCreateMazes()
        {
            // Arrange
            var game = new MazeGame();
            var factory = new MazeFactory();

            // Act
            var result = game.CreateMaze(factory);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<Maze>();
        }
    }
}
