using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TECi.Services.Courses;
using TECi.UI.Web.Models.Course;

namespace TECi.UI.Web.Controllers
{
    public class CourseController : Controller
    {
        #region Fields

        private ICourseService _courseService;
        //private readonly IPermissionService _permissionService;


        #endregion

        #region Constructors

        public CourseController(ICourseService courseService)
        {
            this._courseService = courseService;
        }
        public CourseController()
        {
        }
        #endregion
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
        public ActionResult Create()
        {

            var model = new CourseViewModel();
            return View(model);
        }
    }
}