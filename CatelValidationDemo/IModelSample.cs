using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace CatelValidationDemo
{
    public interface IModelSample
    {
        IValidatableModel Model { get; set; }
    }
}
