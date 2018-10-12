using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kopierkarte
{
    class Copycard : Chipcard
    {
        private int copies;
        private bool isValid;

        public Copycard() : this(500) { }

        public Copycard(int copies) : base() {
            this.copies = copies;
            this.isValid = true;
        }

        public Copycard(int copies, int pin) : base(pin) {
            this.copies = copies;
            this.isValid = true;
        }

        public bool copy(int copies) {
            if(this.isValid && this.copies >= copies) {
                this.copies -= copies;
                if(this.copies == 0) {
                    this.isValid = false;
                }
                return true;
            }
            return false;
        }
    }
}
