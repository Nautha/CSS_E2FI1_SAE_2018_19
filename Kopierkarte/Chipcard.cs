using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopierkarte
{
    class Chipcard
    {
        private int pin;

        public Chipcard() : this(12345) { }

        public Chipcard(int pin) {
            this.Pin = pin;
        }

        public int Pin {
            get => pin;
            set {
                if (value >= 10000 && value <= 99999) {
                    pin = value;
                }
            }
        }

        public bool isPinValid(int pin) {
            return this.pin == pin;
        }
    }
}
