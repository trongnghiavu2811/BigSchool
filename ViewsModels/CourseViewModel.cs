using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewsModels
{
    public class CourseViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ thông tin")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ thông tin")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ thông tin")]
        public string Time { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập đầy đủ thông tin")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}