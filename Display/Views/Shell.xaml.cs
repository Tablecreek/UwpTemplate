using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UwpTemplate.Display.Views {

    public sealed partial class Shell : Display.Views.BasePage {

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
            NavigateTo(typeof(Display.Views.MainPage));
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