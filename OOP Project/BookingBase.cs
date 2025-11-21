using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public abstract class BookingBase
    {
        // Common validation message method (polymorphic — can be overridden)
        public virtual void ShowValidationMessage(string message)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Common medication-state handler (polymorphic)
        public virtual string GetMedicationStatus(RadioButton yes, RadioButton no)
        {
            if (yes.Checked) return "Yes";
            if (no.Checked) return "No";
            return string.Empty;
        }
    }
}
