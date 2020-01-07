using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Noodles.Any())
            {
                return;
            }

            context.AddRange(
                new Noodle { Name ="name1",Price = 12,ShortDescription="asmiaoshu",LongDescription="lomiaoshu",ImageURL="123.com"},
                new Noodle { Name = "name2", Price = 13, ShortDescription = "asmiaoshu", LongDescription = "lomiaoshu", ImageURL = "www.baidu.com" },
                new Noodle { Name = "name3", Price = 14, ShortDescription = "asmiaoshu", LongDescription = "lomiaoshu", ImageURL = "www.baidu.com" },
                new Noodle { Name = "name4", Price = 15, ShortDescription = "asmiaoshu", LongDescription = "lomiaoshu", ImageURL = "www.baidu.com" },
                new Noodle { Name = "name5", Price = 16, ShortDescription = "asmiaoshu", LongDescription = "lomiaoshu", ImageURL = "www.baidu.com" },
                new Noodle { Name = "name6", Price = 18, ShortDescription = "asmiaoshu", LongDescription = "lomiaoshu", ImageURL = "www.baidu.com" }

                );
            context.SaveChanges();
        }

    }
}
