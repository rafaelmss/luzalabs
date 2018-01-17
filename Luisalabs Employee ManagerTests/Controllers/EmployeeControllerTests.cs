using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Http.Routing;

namespace Luisalabs_Employee_Manager.Controllers.Tests
{
    [TestClass()]
    public class EmployeeControllerTests
    {

        
        [TestMethod()]
        public void GetAllEmployeesTest()
        {
            EmployeeController controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/employee/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            var employee = new Models.Employee { Name = "Funcionario Teste", Email = "func@luizalabs.com", Department = "Commerce" };
            IHttpActionResult response = controller.PostEmployee(employee);

            Assert.AreNotSame(employee.Id, 0);

            response = controller.GetAllEmployees(1,1);

            Assert.IsNotNull(response);
        }
        

        [TestMethod()]
        public void PostEmployeeTest()
        {
            EmployeeController controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/employee/";
            
            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;
            
            var employee = new Models.Employee { Name = "Funcionario Teste", Email = "func@luizalabs.com", Department = "Commerce" };
            IHttpActionResult response = controller.PostEmployee(employee);
            
            Assert.AreNotSame(employee.Id, 0);
        }
        
        [TestMethod()]
        public void DeleteEmployeeTest()
        {
            EmployeeController controller = new EmployeeController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            string locationUrl = "http://localhost:8000/employee/";

            var mockUrlHelper = new Mock<UrlHelper>();
            mockUrlHelper.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns(locationUrl);
            controller.Url = mockUrlHelper.Object;

            var employee = new Models.Employee { Name = "Funcionario Teste", Email = "func@luizalabs.com", Department = "Commerce" };
            IHttpActionResult response = controller.PostEmployee(employee);

            Assert.AreNotSame(employee.Id, 0);
            
            response = controller.DeleteEmployee(Convert.ToInt32(employee.Id));

            Assert.IsNotNull(response);
        }
    }
}