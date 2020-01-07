using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class MockFeedbackRepository : IFeedbackRepository
    {
        private List<Feedback> _feedbacks;

        public MockFeedbackRepository()
        {
            if(_feedbacks == null)
            {
                InitializeFeedback();
            }
        }

        private void InitializeFeedback()
        {
            _feedbacks = new List<Feedback>
            {
                 new Feedback { Id = 1 , Name = "name1" , Email = "hell@123.com",CreateDateUTC=DateTime.Now,Message="hello"},
                new Feedback { Id = 1 , Name = "name1" , Email = "hell@123.com",CreateDateUTC=DateTime.Now,Message="hello"},
                new Feedback { Id = 1 , Name = "name1" , Email = "hell@123.com",CreateDateUTC=DateTime.Now,Message="hello"}
            };
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _feedbacks;
        }

        public void AddFeedback(Feedback feedback)
        {
            _feedbacks.Add(feedback);
        }
    }
}
