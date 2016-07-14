using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UwpTemplate.Views {

    public partial class BasePage : Page {

        public readonly Shell Shell;

        public BasePage() {
            Shell = Window.Current.Content as Shell;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            base.OnNavigatedTo(e);

            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;

            if (Shell != null) {
                Shell.BackButtonClicked += OnBackRequested;
            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e) {
            base.OnNavigatedFrom(e);
            SystemNavigationManager.GetForCurrentView().BackRequested -= OnBackRequested;
            Shell.BackButtonClicked -= OnBackRequested;
        }

        protected virtual void GoBack() {
            if (!Frame.CanGoBack) {
                return;
            }

            Frame.GoBack();
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e) {
            e.Handled = true;
            GoBack();
        }

        private void OnBackRequested(object sender, BackClickEventArgs e) {
            e.Handled = true;
            GoBack();
        }
    }
}
