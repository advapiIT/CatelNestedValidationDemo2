using System;
using Catel.Data;
using FluentValidation;

namespace CatelValidationDemo.Models
{
    public class MainModel : ValidatableModelBase
    {
        public string TextMessage { get; set; }
        public InnerModel Inner { get; set; }

        public MainModel()
        {
            Inner = new InnerModel();
        }
    }

    public class InnerModel:ValidatableModelBase
    {
        public  DateTime? Date { get; set; }
    }

    public class MainModelValidator : AbstractValidator<MainModel>
    {
        public MainModelValidator()
        {
            RuleFor(x => x.TextMessage).NotEmpty().WithMessage("Campo richiesto");
            RuleFor(x => x.Inner).SetValidator(new InnerValidator());
        }
    }

    public class InnerValidator : AbstractValidator<InnerModel>
    {
        public InnerValidator()
        {
            RuleFor(x => x.Date).NotEmpty().WithMessage("Campo 'date' richiesto");
        }
    }
}
