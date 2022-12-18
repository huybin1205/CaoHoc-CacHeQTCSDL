using MDTasks.Models;
using MDTasks.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MDTasks.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _ds;

        public EmployeeController(EmployeeService ds)
        {
            _ds = ds;
        }

        public IActionResult Index()
        {
            return View(_ds.Get());
        }

        public IActionResult Create()
        {
            return View(new Employee
            {
                FullName = "",
                Birthday= DateTime.Now.Date,
                Department="",
                Phone="",
                Position=""
            }
            );
        }

        public IActionResult CreateSave(Employee model)
        {
            List<EmployeeTask> listTasks = new List<EmployeeTask>();
            model.Tasks = listTasks;
            _ds.Create(model);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = _ds.Get(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        public IActionResult EditSave(Employee model)
        {
            if (ModelState.IsValid)
            {
                _ds.Update(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(string id)
        {
            try
            {
                var model = _ds.Get(id);

                if (model == null)
                {
                    return NotFound();
                }
                _ds.Remove(model.Id);
                return View(model);
            }
            catch
            {
                return View();
            }
            
        }

        public IActionResult DeleteConfirm(string id)
        {
            _ds.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var model = _ds.Get(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        //-------------------------------------
        //EMPLOYEE TASKS
        public IActionResult CreateTask(string id)
        {
            ViewBag.Id = id;
            return View(new EmployeeTask
            {
                TaskId = Guid.NewGuid().ToString(),
                TaskName = "",
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.Date,
                Description = "",
                Completed=false
            });
            
        }
        
        public IActionResult CreateTaskSave(string id, EmployeeTask employeeTask)
        {          
            _ds.CreateTask(id, employeeTask);
            return RedirectToAction("Detail", new { id = id });
        }
        public IActionResult EditTask(string id, string taskid)
        {
            var employee = _ds.Get(id);
            var task = employee.Tasks.Where(x => x.TaskId == taskid).FirstOrDefault();
            ViewBag.Id = id;
            return View(task);
        }
        public IActionResult EditTaskSave(string id, EmployeeTask employeeTask)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _ds.UpdateTask(id, employeeTask);
            }
            return RedirectToAction("Detail", new { id = id });
        }
        public IActionResult DeleteTask(string id, string taskid)
        {
            if (id == null || taskid == null)
            {
                return NotFound();
            }
            _ds.DeleteTask(id, taskid);
            return RedirectToAction("Detail", new { id = id });
        }

        public IActionResult Report()
        {
            SearchingEmployee searchingEmployee = new SearchingEmployee();
            return View(searchingEmployee);
        }
        public IActionResult SearchTask()
        {
            SearchingTask searchingTask = new SearchingTask();
            return View(searchingTask);
        }
        [HttpPost]
        public IActionResult SearchingTask(SearchingTask searchingTask)
        {
            //List<ResultEmployeeTask> _Tasks = new List<ResultEmployeeTask>();
            //var results = _ds.SearchByTask(searchingTask.TaskName, searchingTask.Completed).Result;

            //foreach (var p1 in results)
            //{
            //    foreach (var item in p1.Tasks)
            //    {
            //        _Tasks.Add(new ResultEmployeeTask
            //        {
            //            FullName = p1.FullName,
            //            Department = p1.Department,
            //            TaskName = item.TaskName,
            //            StartDate = item.StartDate,
            //            EndDate = item.EndDate,
            //            Completed = item.Completed,
            //            Description = item.Description
            //        });
            //    }
            //}
            //var data = from c in _Tasks
            //           where c.TaskName.Contains(searchingTask.TaskName) || c.Completed == searchingTask.Completed
            //           select c;

            return View(_ds.SearchByTask(searchingTask.TaskName, searchingTask.Completed));
        }

        //-------------------------------------
        //SEARCH
        [HttpPost]
        public IActionResult SearchRPEmployee(SearchingEmployee searchingEmployee)
        {
            string empName = "";
            string depName = "";
            if (!string.IsNullOrEmpty(searchingEmployee.EmployeeName))
            {
                empName = searchingEmployee.EmployeeName;
            }
            if (!string.IsNullOrEmpty(searchingEmployee.DepartmentName))
            {
                depName = searchingEmployee.DepartmentName;
            }
            var results =  _ds.SearchByEmpDepart(empName, depName);
            return View(results);
        }

        //public async Task<IActionResult> SearchRPEmployee(SearchingEmployee searchingEmployee)
        //{
        //    string empName = "";
        //    string depName = "";
        //    if (!string.IsNullOrEmpty(searchingEmployee.EmployeeName))
        //    {
        //        empName = searchingEmployee.EmployeeName;
        //    }
        //    if (!string.IsNullOrEmpty(searchingEmployee.DepartmentName))
        //    {
        //        depName = searchingEmployee.DepartmentName;
        //    }
        //    var results = await _ds.SearchByEmpDepart(empName, depName);
        //    return View(results);
        //}
    }
}
