using System;

using Windows.UI.Xaml.Input;

namespace UwpTemplate.Display.Controls {

    public sealed partial class HamburgerButton {

        private Modes _mode;

        public event TappedEventHandler HamburgerButtonClicked;

        public event TappedEventHandler BackButtonClicked;

        public Modes Mode {
            get {
                return _mode;
            }
            set {
                _mode = value;

                switch (_mode) {
                    case Modes.Hamburger:
                        //TODO: Show Hamburger-Button
                        break;
                    case Modes.Back:
                        //TODO: Show Back-Button
                        break;
                    case Modes.None:
                        //TODO: Show None
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public HamburgerButton() {
            InitializeComponent();
        }

        private void HamburgerRadioButtonTapped(object sender, TappedRoutedEventArgs e) {
            switch (_mode) {
                case Modes.Hamburger:
                    HamburgerButtonClicked?.Invoke(sender, e);
                    break;
                case Modes.Back:
                    BackButtonClicked?.Invoke(sender, e);
                    break;
                case Modes.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public enum Modes {
            Hamburger,
            Back,
            None
        }

    }

}
