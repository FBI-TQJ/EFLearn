using CodeFirst.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Context : DbContext
    {
        public Context()
            : base("name=FirstCodeFirstApp")
        {
        }

        //一张表中一般肯定不止一条数据行，所以我们必须定义一个集合属性，EF使用DbSet来实现这个目的。
        public DbSet<Donator> Donators { get; set; }
    }
}
