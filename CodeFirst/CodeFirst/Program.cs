using CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.Database.CreateIfNotExists();//如果数据库不存在时则创建
                var donators = new List<Donator>
                {
                    new Donator
                    {
                      Name   = "陈志康",
                      Amount = 50,
                      DonateDate = new DateTime(2016, 4, 7)
                    },
                    new Donator
                    {
                        Name = "海风",
                        Amount = 5,
                        DonateDate = new DateTime(2016, 4, 8)
                    },
                    new Donator
                    {
                        Name = "醉千秋",
                        Amount = 18.8m,
                        DonateDate = new DateTime(2016, 4, 15)
                    }
                };

                context.Donators.AddRange(donators);
                context.SaveChanges();
            }
            // Console.Write("DB has Created!");//提示DB创建成功
            Console.Write("Creation Finished!");//提示创建完成
            Console.Read();
        }
    }
}
