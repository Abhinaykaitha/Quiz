using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
       [Fact]
        public void Test1()
        {
            var expected = 10;
            var a = 2;
            var b = 10; 
            var actual = biggestOfnum(a, b);
            Assert.Equal(expected,actual);
        }
        [Theory]
        [InlineData(10,3,10)]
        [InlineData(5,5,2)]
        [InlineData(9,9,1)]
        public void biggestOfnum_multipleInput(int expected, int n1,int n2){
            Assert.Equal(expected,biggestOfnum(n1,n2));
        }
       
         


        // for more see 

        int biggestOfnum(int x, int y)
        {
            return Math.Max(x,y);
        }


    }
}
