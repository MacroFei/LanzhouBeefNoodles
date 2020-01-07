using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.controllers
{
    public class FeedbackController : Controller
    {

        private IFeedbackRepository _feedbackRepository;
        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            //Tag Helper    
            //启动模型验证功能
           if(ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);
                return RedirectToAction("FeebackComplete");

            }
            else
            {
                return View();
            }
         

        }
        public IActionResult feebackComplete()
        {
            return View();
        }

    }
}