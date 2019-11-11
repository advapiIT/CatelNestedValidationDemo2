using System.Threading.Tasks;
using Catel.Data;
using Catel.MVVM;

namespace CatelValidationDemo.ViewModels
{
    public class FooterViewModel : ViewModelBase
    {
        private readonly ISelectedModelService selectedModelService;
        public Command ClickCommand { get; set; }

        public FooterViewModel(ISelectedModelService selectedModelService)
        {
            this.selectedModelService = selectedModelService;
            ClickCommand = new Command(OnClickCommandExecute, CanClickCommandExecute);
        }

        private bool CanClickCommandExecute()
        {
            var m = selectedModelService.Model.GetValidationContext();

            return !m.HasErrors;
        }

        private void OnClickCommandExecute()
        {


        }

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            selectedModelService.Model.Validated += Model_Validated;
        }

        private void Model_Validated(object sender, ValidationEventArgs e)
        {
            this.ClickCommand.RaiseCanExecuteChanged();
        }
    }
}
