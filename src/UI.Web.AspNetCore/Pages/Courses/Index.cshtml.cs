using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Entities;
using Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Web.AspNetCore.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ICourseService _courseService;
        public List<Course> Courses { get; set; }

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public void OnGet()
        {
            Courses = _courseService.GetAll();
        }
    }
}