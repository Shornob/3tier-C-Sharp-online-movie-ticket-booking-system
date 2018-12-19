using Project.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.PLL
{
    interface IEmployee
    {
        employee Emp { get; set; }
        void Reload();
    }
}
