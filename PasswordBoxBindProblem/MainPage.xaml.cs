using ReactiveUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, IViewFor<MainPageVM>
    {
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = value as MainPageVM; }
        }

        public MainPageVM ViewModel
        {
            get { return GetValue(ViewModelProperty) as MainPageVM; }

            set { SetValue(ViewModelProperty, value); }
        }

        public static readonly DependencyProperty ViewModelProperty =
    DependencyProperty.Register("ViewModel", typeof(MainPageVM), typeof(MainPage), new PropertyMetadata(null));

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MainPageVM();
            this.WhenActivated(d =>
            {
                d(this.Bind(ViewModel, vm => vm.Password, v => v.password.Password));
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Windows.UI.Popups.MessageDialog($"ViewModel Password: {this.ViewModel.Password}{Environment.NewLine}View Password:{this.password.Password}").ShowAsync();
        }
    }
}