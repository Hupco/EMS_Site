using LogicLayer.LogicServices;
using System.Web.Mvc;
using LogicLayer.Models;
using UserInterfaceLayer.Library.ModelsConverters;
using UserInterfaceLayer.Library.UserInfoProviders;
using UserInterfaceLayer.Models.Employee;

namespace UserInterfaceLayer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogicService _logicService;
        private readonly IUserInfoProvider _userInfoProvider;
        private readonly IModelsConverter _modelsConverter;

        public EmployeeController(ILogicService logicService, IUserInfoProvider userInfoProvider, IModelsConverter modelsConverter)
        {
            _logicService = logicService;
            _userInfoProvider = userInfoProvider;
            _modelsConverter = modelsConverter;
        }

        // GET: EmployeeCardViewModel
        [HttpGet]
        public ActionResult EmployeeCard()
        {
            var employee = _logicService.GetEmployeeById(_userInfoProvider.GetUserId());

            var employeeCardViewModel = _modelsConverter.ToEmployeeCardViewModel(employee);

            return View();
        }

        [HttpGet]
        public ActionResult CreateNewEmployee()
        {
            var createEmployeeViewModel = new CreateEmployeeViewModel
            {
                Id = _userInfoProvider.GetUserId()
            };

            return View(createEmployeeViewModel);
        }

        [HttpPost]
        public ActionResult CreateNewEmployee(CreateEmployeeViewModel createEmployeeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Error");
            }

            var newEmployee = _modelsConverter.ToNewEmployee(createEmployeeViewModel);
            _logicService.AddNewEmployee(newEmployee);

            return RedirectToAction("Index","Home");
        }
    }
}
