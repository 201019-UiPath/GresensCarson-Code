using System;
using Xunit;
using HerosLib;

namespace HerosTest
{
    public class HeroTest
    {

         Hero testhero = new Hero();

        [Fact]
        public void AddSuperPowerAddsPower()
        {

            //arrange (arranging artifacts that I might need in testing)
            string power = "perfect code";

            //act (do what needs to be tested)
            testhero.AddSuperPower(power);

            //assert 
            Assert.Equal(power, testhero.superPowers.Peek());

        }

        [Theory]
        [InlineData("perfect code")]
        [InlineData("Flying")]
        [InlineData("Strength")]
        public void AddPowerTestTheory(string power)
        {
            //act
            testhero.AddSuperPower(power);

           //assert 
            Assert.Equal(power, testhero.superPowers.Peek());
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddInvalidPower(string power)
        {
            
            Assert.Throws<ArgumentException>(
                () => testhero.AddSuperPower(power));

        }



    }
}
