using CommunityToolkit.Mvvm.Input;
using EdreesApp_2024.Models;

namespace EdreesApp_2024.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}