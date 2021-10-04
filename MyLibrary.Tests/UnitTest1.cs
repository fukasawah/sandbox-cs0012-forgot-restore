using System;
using Xunit;

namespace MyLibrary.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var context = new MyDbContext();
            Assert.NotNull(context.Blogs);
        }
    }
}
