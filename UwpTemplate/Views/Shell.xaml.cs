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

namespace UwpTemplate.Views {

    public sealed partial class Shell : BasePage {

        public event BackClickEventHandler BackButtonClicked;

        public bool IsMenuOpen {
            get {
                return MainSplitView.IsPaneOpen;
            }
            set {
                MainSplitView.IsPaneOpen = value;
            }
        }

        public Shell() {
            InitializeComponent();
        }

        private void BackRadioButtonClick(object sender, RoutedEventArgs e) {
            var args = new BackClickEventArgs();
            BackButtonClicked?.Invoke(sender, args);
        }

        private void HamburgerRadioButtonClick(object sender, RoutedEventArgs e) {
            IsMenuOpen = !IsMenuOpen;
        }

        private void HomeRadioButtonClick(object sender, RoutedEventArgs e) {
            NavigateTo(typeof(MainPage));
        }

        private void NavigateTo(Type page, bool navtigateIfAlreadyOpen = false) {
            var frame = DataContext as Frame;
            var currentPage = frame?.Content as Page;

            if (navtigateIfAlreadyOpen) {
                frame?.Navigate(page);
            } else if (currentPage?.GetType() != page) {
                frame?.Navigate(page);
            }

            if (MainSplitView.DisplayMode != SplitViewDisplayMode.Inline) {
                IsMenuOpen = false;
            }
        }
    }
}
