using ConsoleGame;

namespace ConsoleGameTests
{
    public class Tests
    {
        const string Map =
            """
            ====
            =@ = 
            =  =\n
            ====\n;
            """
               ;
        Character character;
        Map map;

        [SetUp]
        public void Setup()
        {
            character = new Character(Map);
            map = new Map(Map);
        }

        [Test]
        public void CharacterStartXPositionTest()
        {
            Assert.AreEqual(1, character.XPosition);
        }

        [Test]
        public void CharacterStartYPositionTest()
        {
            Assert.AreEqual(1, character.YPosition);
        }

        [Test]
        public void CharacterLeftStepTest()
        {
            character.LeftStep();
            Assert.AreEqual(1, character.YPosition);
            Assert.AreEqual(0, character.XPosition);
        }
        [Test]
        public void CharacterRightStepTest()
        {
            character.RightStep();
            Assert.AreEqual(1, character.YPosition);
            Assert.AreEqual(2, character.XPosition);
        }
        [Test]
        public void CharacterDownStepTest()
        {
            character.DownStep();
            Assert.AreEqual(2, character.YPosition);
            Assert.AreEqual(1, character.XPosition);
        }

        [Test]
        public void CharacterUpStepTest()
        {
            character.UpStep();
            Assert.AreEqual(0, character.YPosition);
            Assert.AreEqual(1, character.XPosition);
        }

        [Test]
        public void MapIsLeftEmptyTest()
        {
            Assert.IsFalse(map.IsLeftEmpty(character));
        }

        [Test]
        public void MapIsRighttEmptyTest()
        {
            Assert.IsTrue(map.IsRightEmpty(character));
        }

        [Test]
        public void MapIsDownEmptyTest()
        {
            Assert.IsTrue(map.IsDownEmpty(character));
        }

        [Test]
        public void MapIsUpEmptyTest()
        {
            Assert.IsFalse(map.IsUpEmpty(character));
        }

    }
}