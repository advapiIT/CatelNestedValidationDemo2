using Catel.Data;
using CatelValidationDemo.Models;

namespace CatelValidationDemo.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;

    public class MainWindowViewModel : ViewModelBase
    {

        private readonly ISelectedModelService selectedModelService;
        [ViewModelToModel]
        public string TextMessage { get; set; }

        [ViewModelToModel]
        public  InnerModel Inner { get; set; }

        [Model]
        public MainModel Model { get; set; }

        public MainWindowViewModel(ISelectedModelService selectedModelService)
        {
            this.selectedModelService = selectedModelService;
            DeferValidationUntilFirstSaveCall = false;
            
         

            Model = new MainModel();

            selectedModelService.Model = Model;
        }

       
        public override string Title { get { return "Welcome to CatelValidationDemo"; } }

        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
