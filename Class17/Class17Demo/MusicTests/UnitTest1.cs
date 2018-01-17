using Class17Demo.Controllers;
using Class17Demo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using Xunit;

namespace MusicTests
{
    public class UnitTest1
    {
        [Fact]

        public void GetRetunsString()
        {
            var options = new DbContextOptionsBuilder<MusicDbContext>()
            .UseInMemoryDatabase(databaseName: "ReturnStringTest")
            .Options;

            //Arrange
            using (var context = new MusicDbContext(options))
            {
                var controller = new SongsController(context);

                //Act
                var result = controller.Get(5);

                //Assert
                Assert.IsType<string>(result);
            }



        }
    }
}
