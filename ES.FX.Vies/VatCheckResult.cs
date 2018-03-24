using System;

namespace ES.FX.Vies
{
    public class VatCheckResult
    {
        public bool Valid { get; set; }
        public string CountryCode { get; set; }
        public string VatNumber { get; set; }
        public DateTime RequestDate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{nameof(VatCheckResult)}[{CountryCode}-{VatNumber}]-{(Valid ? "Valid" : "Invalid")}";
        }
    }
}