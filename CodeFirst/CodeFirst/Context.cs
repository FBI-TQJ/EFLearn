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
        //在这里，DbContext是所有基于EF的上下文基类，通过它可以访问到数据库中的所有表。
        //上面的代码中调用了父类的构造函数，并且传入了一个键值对，键是name,值是FirstCodeFirstApp，
        //这个键值对是定义在应用程序的配置文件中的，取决于你的应用程序类型，可能是app.config或者web.config。
        //在我们的控制台应用程序中就是app.config。
        //在app.config文件的configuration的节点下（不要在第一个节点下，否则报错）添加：
        public Context()
            : base("name=FirstCodeFirstApp")
        {
        }

        //一张表中一般肯定不止一条数据行，所以我们必须定义一个集合属性，EF使用DbSet来实现这个目的。
        public DbSet<Donator> Donators { get; set; }
    }
}
