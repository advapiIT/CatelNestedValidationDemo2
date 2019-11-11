using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace CatelValidationDemo
{
    public class SelectedModelService : ISelectedModelService
    {
        public IValidatableModel Model { get; set; }
    }

    public interface ISelectedModelService
    {
        IValidatableModel Model { get; set; }
    }
}
