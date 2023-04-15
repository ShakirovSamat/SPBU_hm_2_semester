using ConsoleGame;

namespace ConsoleGameTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CharacterStartXPositionTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            Assert.AreEqual(1, character.XPosition);
        }

        [Test]
        public void CharacterStartYPositionTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            Assert.AreEqual(3, character.YPosition);
        }

        [Test]
        public void CharacterLeftStepTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            character.LeftStep();
            Assert.AreEqual(3, character.YPosition);
            Assert.AreEqual(0, character.XPosition);
        }
        [Test]
        public void CharacterRightStepTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            character.RightStep();
            Assert.AreEqual(3, character.YPosition);
            Assert.AreEqual(2, character.XPosition);
        }
        [Test]
        public void CharacterDownStepTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            character.DownStep();
            Assert.AreEqual(4, character.YPosition);
            Assert.AreEqual(1, character.XPosition);
        }

        [Test]
        public void CharacterUpStepTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            character.UpStep();
            Assert.AreEqual(2, character.YPosition);
            Assert.AreEqual(1, character.XPosition);
        }

        [Test]
        public void MapIsLeftEmptyTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            Map map = new Map("====\n" +
               "=  =\n" +
               "=  =\n" +
               "====\n");
            Assert.IsFalse(map.IsLeftEmpty(character));
        }

        [Test]
        public void MapIsRighttEmptyTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            Map map = new Map("====\n" +
               "=  =\n" +
               "=  =\n" +
               "====\n");
            Assert.IsTrue(map.IsRightEmpty(character));
        }

        [Test]
        public void MapIsDownEmptyTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            Map map = new Map("====\n" +
               "=  =\n" +
               "=  =\n" +
               "====\n");
            Assert.IsTrue(map.IsDownEmpty(character));
        }

        [Test]
        public void MapIsUpEmptyTest()
        {
            Character character = new Character("====\n" +
               "=@ =\n" +
               "=  =\n" +
               "====\n");
            Map map = new Map("====\n" +
               "=  =\n" +
               "=  =\n" +
               "====\n");
            Assert.IsFalse(map.IsUpEmpty(character));
        }

    }
}