using Objects.Models;

namespace DisplayData.ViewModels {

    public class RimViewModel : NotificationBase<Rim> {

        public double DiameterInInches {
            get {
                return This.DiameterInInches;
            }
            set {
                SetProperty(This.DiameterInInches, value, () => This.DiameterInInches = value);
            }
        }

        public double DiameterInMillimeters => This.DiameterInMillimeters;

        public RimViewModel() {
            This = new Rim();
        }

    }

}