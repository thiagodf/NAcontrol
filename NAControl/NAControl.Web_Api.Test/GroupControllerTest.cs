using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NAControl.Web_Api.Test
{
    [TestClass]
    public class GroupControllerTest
    {
        [TestMethod]
        public void GetAllGroups()
        {
            var controller = new GroupController(_repository);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            var result = controller.Get();

            IEnumerable<Car> cars;

            Assert.IsTrue(result.TryGetContentValue<IEnumerable<Car>>(out cars));
            Assert.IsNotNull(cars);
            Assert.AreEqual(3, cars.Count());
        }
    }
}
