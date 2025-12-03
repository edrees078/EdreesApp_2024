using EdreesApp_2024.Models;
using EdreesApp_2024.PageModels;

namespace EdreesApp_2024.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}