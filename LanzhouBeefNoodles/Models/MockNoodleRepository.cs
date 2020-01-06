using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    /// <summary>
    /// 假数据仓库
    /// 实现相关接口
    /// </summary>
    public class MockNoodleRepository : INoodleRepository
    {
        private List<Noodle> _noodles;

        public MockNoodleRepository()
        {
            if(_noodles == null)
            {
                InitializeNoodle();
            }
        }

        private void InitializeNoodle() => _noodles = new List<Noodle>
        {
             new Noodle { Id = 1 , Name= "h1" , Price = 12,ShortDescription = "这是一段描述",ImageURL="www.baidu.com",LongDescription="asd"},
             new Noodle { Id = 2 , Name= "h1" , Price = 12,ShortDescription = "这是一段描述",ImageURL="www.baidu.com",LongDescription="asd"},
             new Noodle { Id = 3 , Name= "h1" , Price = 12,ShortDescription = "这是一段描述",ImageURL="www.baidu.com",LongDescription="asd"}

        };

        public IEnumerable<Noodle> GetAllNoodles()
        {
            return _noodles;
         }

        public Noodle GetNoodleById(int id)
        {
            //C#的linq语句进行处理 （其中为lambda表达式）
            //在noodle列表中寻找 与参数ID一致的元素
            //如果找不到则返回空
            //并将其注入到系统的依赖注入容器
            return _noodles.FirstOrDefault(n => n.Id == id);  
        }
    }
}
