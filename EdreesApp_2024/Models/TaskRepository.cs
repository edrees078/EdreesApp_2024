using System.Collections.ObjectModel;

namespace EdreesApp_2024.Model
{
    public static class TaskRepository
    {
        
        public static ObservableCollection<TaskItem> Tasks { get; } = new();
    }
}
