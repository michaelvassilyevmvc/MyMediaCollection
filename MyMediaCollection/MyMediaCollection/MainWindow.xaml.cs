using Microsoft.UI.Xaml;
using MyMediaCollection.ViewModels;


namespace MyMediaCollection
{

    public sealed partial class MainWindow : Window
    {
        private bool _isLoaded;
        public MainViewModel ViewModel => App.ViewModel;

        public MainWindow()
        {
            this.InitializeComponent();
        }


    }
}
