using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.functions;
using Project;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
             Users u1 = new Users();
            u1.userId = 2;
            u1.userName = "aaa";
            u1.emailAddress = "fdsfds@ss";
            //UsersManage.add(u1);

           foreach(var item in OrdersManage.getAll())
            {
                Console.WriteLine(item.orderId);
            }

        }
    }
}
