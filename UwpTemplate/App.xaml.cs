using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UwpTemplate {

    internal sealed partial class App : Application {

        public App() {
            InitializeComponent();
            Suspending += OnSuspending;
        }
        
        protected override void OnLaunched(LaunchActivatedEventArgs e) {

            var rootFrame = Window.Current.Content as Frame;
            
            if (rootFrame == null) {
                rootFrame = new Frame();
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false) {
                if (rootFrame.Content == null) {
                    rootFrame.Navigate(typeof(Views.MainPage), e.Arguments);
                }
                Window.Current.Activate();
            }
        }
        private void OnSuspending(object sender, SuspendingEventArgs e) {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
