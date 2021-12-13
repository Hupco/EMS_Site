﻿using LogicLayer.LogicServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserInterfaceLayer.Library.ModelsConverters;
using UserInterfaceLayer.Library.UserInfoProviders;
using UserInterfaceLayer.Models;

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
        public ActionResult EmployeeCard()
        {
            var employee = _logicService.GetEmployeeById(_userInfoProvider.GetUserId());

            EmployeeCardViewModel employeeCardViewModel = _modelsConverter.ToEmployeeCardViewModel(employee);

            return View();
        }
    }
}