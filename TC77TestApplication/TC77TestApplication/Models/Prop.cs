using System;

namespace TC77TestApplication.Models
{
    public class Prop : BaseViewModel
    {
        private string _PropName, _PropValue;
        public string PropName
        {
            get => _PropName;
            set
            {
                if (string.Compare(_PropName, value, StringComparison.CurrentCultureIgnoreCase) == 0)
                    return;
                _PropName = value;
                OnPropertyChanged("PropName");
            }
        }
        public string PropValue
        {
            get => _PropValue;
            set
            {
                if (string.Compare(_PropValue, value, StringComparison.CurrentCultureIgnoreCase) == 0)
                    return;
                _PropValue = value;
                OnPropertyChanged("PropValue");
            }
        }
    }
}
