using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    /// <summary>
    /// 仓库接口
    /// public 方便外部引用
    ///专门处理数据库数据列表的数据结构
    /// </summary>
   public  interface INoodleRepository
    {
        IEnumerable<Noodle> GetAllNoodles();

        Noodle GetNoodleById(int id);
    }
}
