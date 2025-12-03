using EdreesApp_2024.Model;

namespace EdreesApp_2024
{
    public partial class AddTaskPage : ContentPage
    {
        public AddTaskPage()
        {
            InitializeComponent();
        }

        private async void tamamClicked(object sender, EventArgs e)
        {
            string taskName = taskEntry.Text;
            string taskDetail = taskEditor.Text;

            DateTime taskDate = taskDatePicker.Date ?? DateTime.Today;
            TimeSpan taskTime = taskTimePicker.Time ?? TimeSpan.Zero;

            var newTask = new TaskItem
            {
                Name = taskName,
                Detail = taskDetail,
                Date = taskDate,
                Time = taskTime
            };

            
            EdreesApp_2024.Model.TaskRepository.Tasks.Add(newTask);

            await DisplayAlert("Tamam", "Görev başarıyla kaydedildi", "Tamam");
            await Navigation.PopAsync();
        }

        private async void iptalClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
