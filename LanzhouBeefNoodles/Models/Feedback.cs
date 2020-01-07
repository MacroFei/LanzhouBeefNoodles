using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class Feedback
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage="请留下你的名字")]
        [StringLength(50,ErrorMessage="名字不能超过20个字")]
        public string Name { get; set; }
        [Required(ErrorMessage = "请留下你的Email")]
        [StringLength(50, ErrorMessage = "Email不能超过20个字")]
        [DataType(DataType.EmailAddress,ErrorMessage ="请填写正确的email格式")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage="请填写正确的email格式")]
        public string Email { get; set; }
        public DateTime CreateDateUTC { get; set; }
        [Required(ErrorMessage = "请留下你的反馈意见")]
        [StringLength(400,ErrorMessage = "反馈意见不能超过200个字")]
        public string Message { get; set; }

    }
}
