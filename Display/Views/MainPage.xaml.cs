using DisplayData.ViewModels;

namespace Display.Views {

    public sealed partial class MainPage {
        
        public WheelViewModel WheelViewModel;

        public MainPage() {
            InitializeComponent();

            WheelViewModel = new WheelViewModel();
        }
    }
}
