using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void SaveEditTest()
        {
            var news = new News
            {
                Id = 1,
                Name = "СтатическоеНазвание",
                Text = "Презентация программного обеспечения APPLE",
                DatePublish = DateTime.Parse("01.02.2020")
            };
            
            HomeController controller = new HomeController();
            controller.SaveEdit(1, "СтатическоеНазвание", "Презентация программного обеспечения APPLE", "01.02.2020");

            Assert.AreEqual(news.GetHashCode(), controller.GetNewsFromList(0).GetHashCode());
        }
    }
}