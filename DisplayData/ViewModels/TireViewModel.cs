using UwpTemplate.Objects.Models;

namespace UwpTemplate.DisplayData.ViewModels {

    public class TireViewModel : NotificationBase<Tire> {
        
        public double WidthInMillimeter {
            get {
                return This.WidthInMillimeters;
            }
            set {
                SetProperty(This.WidthInMillimeters, value, () => This.WidthInMillimeters = value);
            }
        }

        public double HeightToWidthRatio {
            get {
                return This.HeightToWidthRatio;
            }
            set {
                SetProperty(This.HeightToWidthRatio, value, () => This.HeightToWidthRatio = value);
            }
        }


        public double SideWallHeight => This.SideWallHeight;

        public TireViewModel() {
            This = new Tire();
        }
    }

}