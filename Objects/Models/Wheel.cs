using UwpTemplate.Objects.Models;

namespace UwpTemplate.BusinessLayer.Models {

    public class Wheel {

        public Rim Rim;
        public Tire Tire;

        public double HeightInMillimeters => Tire.SideWallHeight * 2 + Rim.DiameterInMillimeters;

        public Wheel() {
            Rim = new Rim();
            Tire = new Tire();
        }

    }
}