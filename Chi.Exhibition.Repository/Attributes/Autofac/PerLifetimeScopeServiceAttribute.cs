using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chi.Exhibition.Repository.Attributes.Autofac
{
    /// <summary>
    /// Autofac生命週期(每次Request)
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class PerLifetimeScopeServiceAttribute : Attribute
    {
    }
}
