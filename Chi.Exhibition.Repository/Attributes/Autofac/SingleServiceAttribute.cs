using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chi.Exhibition.Repository.Attributes.Autofac
{
    /// <summary>
    /// Autofac生命週期(單一程序)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class SingleServiceAttribute : Attribute
    {
    }
}
