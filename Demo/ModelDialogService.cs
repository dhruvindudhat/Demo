using Blazored.Modal;
using Blazored.Modal.Services;

namespace Demo
{
	public class ModelDialogService
	{
        private readonly IModalService _modelService;

        public ModelDialogService(IModalService modelService)
        {
            _modelService = modelService;
        }

        public IModalReference ShowLoader(string message)
        {
            ModalOptions options = new ModalOptions() { UseCustomLayout = true };
            ModalParameters parameters = new ModalParameters();
            parameters.Add(nameof(Spinner.Message), message);
            return _modelService.Show<Spinner>(string.Empty, parameters, options);
        }
    }
}

