using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using MyMediaCollection.Enums;
using MyMediaCollection.Model;
using MyMediaCollection.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Popups;
using WinRT.Interop;


namespace MyMediaCollection
{
   
    public sealed partial class MainWindow : Window
    {
        private bool _isLoaded;
        public MainViewModel ViewModel => App.ViewModel;

        public MainWindow()
        {
            this.InitializeComponent();
            //this.Activated += MainWindow_Activated;
        }

        //private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
        //{
        //    ItemFilter.SelectionChanged += ItemFilter_SelectionChanged;
        //}

        //private void ItemFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var updatedItems = (from item in ViewModel.
        //                        where string.IsNullOrWhiteSpace(ItemFilter.SelectedValue.ToString())
        //                             || ItemFilter.SelectedValue.ToString() == "All"
        //                             || ItemFilter.SelectedValue.ToString() == item.MediaType.ToString()
        //                        select item).ToList();
        //    ItemList.ItemsSource = updatedItems;
        //}

        

       

        //private async void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    var dialog = new MessageDialog("Adding items to the collection is not yet available.",
        //        "My Media Collection");

        //    //Этот блок решает ошибку вызова диалогового окна
        //    var hwnd = WindowNative.GetWindowHandle(this);
        //    InitializeWithWindow.Initialize(dialog, hwnd);

        //    await dialog.ShowAsync();
        //}
    }
}
