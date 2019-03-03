using Prism.Mvvm;
using System;

namespace WPFValidationDisplayErrors
{
    public class MainViewModel : BindableBase
    {
        private string _default;
        private string _toolTip;
        private string _background;
        private string _customError;

        public string Default
        {
            get => _default;
            set
            {
                ValidateInputData(value);
                _default = value;              
                RaisePropertyChanged();                
            }
        }              

        public string ToolTip
        {
            get => _toolTip;
            set
            {
                ValidateInputData(value);
                _toolTip = value;
                RaisePropertyChanged();
            }
        }              

        public string Background
        {
            get => _background;
            set
            {
                ValidateInputData(value);
                _background = value;
                RaisePropertyChanged();
            }
        }

        public string CustomError
        {
            get => _customError;
            set
            {
                ValidateInputData(value);
                _customError = value;
                RaisePropertyChanged();
            }
        }

        private void ValidateInputData(string value)
        {
            if (string.Equals(value, "test", StringComparison.OrdinalIgnoreCase))
                throw new Exception("Test is not valid.");
        }
    }
}
