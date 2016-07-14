namespace UwpTemplate.ViewModels {

    public class WheelViewModel : NotificationBase {

        private TireViewModel _tireViewModel;
        private RimViewModel _rimViewModel;

        public double TireWidthInMillimeters {
            get {
                return _tireViewModel.WidthInMillimeter;
            }
            set {
                SetProperty(_tireViewModel.WidthInMillimeter, value, () => _tireViewModel.WidthInMillimeter = value);
            }
        }

        public double HeightToWidthRatio {
            get {
                return _tireViewModel.HeightToWidthRatio;
            }
            set {
                SetProperty(_tireViewModel.HeightToWidthRatio, value, () => _tireViewModel.HeightToWidthRatio = value);
            }
        }

        public double RimDiameterInInches {
            get {
                return _rimViewModel.DiameterInInches;
            }
            set {
                SetProperty(_rimViewModel.DiameterInInches, value, () => _rimViewModel.DiameterInInches = value);
            }
        }

        public double DisplayWheelHeight => _tireViewModel.SideWallHeight * 2 + _rimViewModel.DiameterInMillimeters;
        public double DisplayRimHeight => _rimViewModel.DiameterInMillimeters;

        public WheelViewModel() {
            _tireViewModel = new TireViewModel();
            _rimViewModel = new RimViewModel();
        }

    }

}