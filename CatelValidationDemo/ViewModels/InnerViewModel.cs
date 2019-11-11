using System;
using Catel.MVVM;
using CatelValidationDemo.Models;

namespace CatelValidationDemo.ViewModels
{
    public class InnerViewModel : ViewModelBase
    {
        [Model]
        public InnerModel Model { get; set; }

        [ViewModelToModel]
        public DateTime? Date { get; set; }

        public InnerViewModel(InnerModel model)
        {
            Model = model;
        }

    }
}
