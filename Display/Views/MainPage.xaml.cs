using UwpTemplate.DisplayData.ViewModels;

namespace UwpTemplate.Display.Views {

    public sealed partial class MainPage : Display.Views.BasePage {
        
        public WheelViewModel WheelViewModel;

        public MainPage() {
            InitializeComponent();

            WheelViewModel = new WheelViewModel();
        }
    }
}
