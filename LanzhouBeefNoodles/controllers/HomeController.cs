using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using LanzhouBeefNoodles.ViewModels;
using System.Linq;

namespace LanzhouBeefNoodles.controllers
{
    //[Route("[controller]")]
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        /* public IActionResult Index()
         {
             return View();
         }*/


        /* [Route("[controller]/[action]")]
         public String Index()
         {
             return "Hello from Index";
         }

         public string about()
         {
             return "Hello from About";
         }
         //[Route("[action]")]
         public String Hello1()
         {
             return "Hello 1";
         }
 */
        private INoodleRepository _noodleRepository;
        //public HomeController(INoodleRepository noodleRepository)
        //{
        //    //noodleRepository来自于IOC容器
        //    _noodleRepository = noodleRepository;
        //}
        public IActionResult Index()
        {
            //var noodles = _noodleRepository.GetAllNoodles();
            //return View(noodles);
            var viewModel = new HomeViewModel()
            {
                Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList(),
                Noodles = _noodleRepository.GetAllNoodles().ToList()
            };
            return View(viewModel);
        }

        private IFeedbackRepository _feedbackRepository;

        public HomeController(INoodleRepository noodleRepository,IFeedbackRepository feedbackRepository)
        {
            _noodleRepository = noodleRepository;
            _feedbackRepository = feedbackRepository;
        }
        
    }
}