using System;

namespace PlayerLink.Services
{
    public class FilterService
    {
        public string DesiredTraits { get; set; }
        public string UndesiredTraits { get; set; }
        public string YourTraits { get; set; }

        public event Action OnChange;

        public void SetTraits(string desiredTraits, string undesiredTraits, string yourTraits)
        {
            DesiredTraits = desiredTraits;
            UndesiredTraits = undesiredTraits;
            YourTraits = yourTraits;

            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
