using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    interface IEmployee
    {
         int hours { get; set; }
         int Money(int hours);
    }
}
