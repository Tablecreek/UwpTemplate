namespace UwpTemplate.Objects.Models {

    public class Tire {

        private const double DefaultWidthInMillimeter = 225;
        private const double DefaultHeightToWidthRatio = 50;


        public double SideWallHeight => WidthInMillimeters * HeightToWidthRatio / 100;
        public double WidthInMillimeters { get; set; } = DefaultWidthInMillimeter;
        public double HeightToWidthRatio { get; set; } = DefaultHeightToWidthRatio;

    }

}