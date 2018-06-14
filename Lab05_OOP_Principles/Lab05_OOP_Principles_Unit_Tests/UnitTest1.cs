using System;
using Xunit;
using Lab05_OOP_Principles.Classes;

namespace Lab05_OOP_Principles_Unit_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void JaguarsCanClimbTest()
        {
            // Arrange
            Jaguar jaguar = new Jaguar();

            // Act
            bool climb = jaguar.CanClimb;

            // Assert
            Assert.True(climb);
        }

        [Fact]
        public void HouseCatsFoodAcquisitionIsHumansTest()
        {
            // Arrange
            HouseCat houseCat = new HouseCat();

            // Act
            string food = houseCat.FoodAquisition();

            // Assert
            Assert.Equal("Humans", food);
        }

        [Fact]
        public void TundraWolvesHuntInPacksTest()
        {
            // Arrange
            TundraWolf tundraWolf = new TundraWolf();

            // Act
            string hunt = tundraWolf.FoodAquisition();

            // Assert
            Assert.Equal("Hunts for prey in a pack", hunt);
        }

        [Fact]
        public void DholeHaveLiveBirthTest()
        {
            // Arrange
            Dhole dhole = new Dhole();

            // Act
            string birth = dhole.Birth();

            // Assert
            Assert.Equal("live", birth);
        }

        [Fact]
        public void AnacondasGiveBirthToEggsTest()
        {
            // Arrange
            Anaconda anaconda = new Anaconda();

            // Act
            string birth = anaconda.Birth();

            // Assert
            Assert.Equal("eggs", birth);
        }

        [Fact]
        public void GyrfalconsAreAnimalsTest()
        {
            // Arrange and Act
            Gyrfalcon gyrfalcon = new Gyrfalcon();

            // Assert
            Assert.True(gyrfalcon is Animal);
        }

        [Fact]
        public void IFlyTestDragon()
        {
            // Arrange and Act
            Dragon dragon = new Dragon();

            //Assert
            Assert.True(dragon.BarrelRoll());
        }

        [Fact]
        public void IFlyTestDuck()
        {
            // Arrange and Act
            Mallard mallard = new Mallard();
            MandarinDuck mandarinDuck = new MandarinDuck();

            //Assert
            Assert.False(mallard.BarrelRoll() && mandarinDuck.BarrelRoll());
        }

        [Fact]
        public void ISwimTestDuck()
        {
            // Arrange and Act
            Mallard mallard = new Mallard();
            MandarinDuck mandarinDuck = new MandarinDuck();


            //Assert
            Assert.Equal("quack-quack-quack", mallard.Sing());
            Assert.Equal("quack-quack-quack", mandarinDuck.Sing());
        }

        [Fact]
        public void IFlyTestFalcon()
        {
            // Arrange and Act
            PrairieFalcon prairieFalcon = new PrairieFalcon();
            Gyrfalcon gyrfalcon = new Gyrfalcon();

            // Assert
            Assert.True(prairieFalcon.BarrelRoll() && gyrfalcon.BarrelRoll());
        }

        [Fact]
        public void ISwimTestPenguin()
        {
            // Arrange
            EmperorPenguin emperorPenguin = new EmperorPenguin();
            GalapagosPenguin galapagosPenguin = new GalapagosPenguin();

            // Act
            string empSing = emperorPenguin.Sing();
            string galSing = galapagosPenguin.Sing();

            // Assert
            Assert.Equal("under the SEA, under the sea", empSing);
            Assert.Equal("under the SEA, under the sea", galSing);
        }

        [Fact]
        public void ISwimTestShark()
        {
            // Arrange
            TigerShark tigerShark = new TigerShark();
            GreatWhiteShark greatWhiteShark = new GreatWhiteShark();

            // Act
            string tigSing = tigerShark.Sing();
            string greatWSSing = greatWhiteShark.Sing();

            // Assert
            Assert.Equal("Under the sea, under the sea", tigSing);
            Assert.Equal("Under the sea, under the sea", greatWSSing);
        }

        [Fact]
        public void ISwimTestCatfish()
        {
            // Arrange
            ChannelCatfish channelCatfish = new ChannelCatfish();
            FlatheadCatfish flatheadCatfish = new FlatheadCatfish();

            // Act
            string cCatSing = channelCatfish.Sing();
            string fCatSing = flatheadCatfish.Sing();

            // Assert
            Assert.Equal("down here all the fish are happy", cCatSing);
            Assert.Equal("down here all the fish are happy", fCatSing);
        }

        [Fact]
        public void ISwimTestAnaconda()
        {
            // Arrange
            Anaconda anaconda = new Anaconda();

            // Act
            string anaSing = anaconda.Sing();

            // Assert
            Assert.Equal("I see a sna-... I mean friend", anaSing);
        }

        [Fact]
        public void ISwimTestKomodoDragon()
        {
            // Arrange
            KomodoDragon komodoDragon = new KomodoDragon();

            // Act
            string komoSing = komodoDragon.Sing();

            // Assert 
            Assert.Equal("A whole new island", komoSing);
        }
    }
}
