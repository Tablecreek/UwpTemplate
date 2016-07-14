namespace UwpTemplate.Objects.Models {

    public class Rim {

        private const double DefaultDiameterInInches = 15;

        public double DiameterInInches { get; set; } = DefaultDiameterInInches;

        public double DiameterInMillimeters => DiameterInInches * 2.54 * 10;

    }

}