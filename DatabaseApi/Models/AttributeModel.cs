// System
using System.ComponentModel;
using System.Collections.Generic;


namespace DatabaseApi.Models
{
    public class AttributeModel : INotifyPropertyChanged
    {
        private string _id;
        private string _name;
        private AttributeValueModel _selectedValue;
        private List<AttributeValueModel> _attributeValues;

        public string Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public AttributeValueModel SelectedValue
        {
            get => _selectedValue;
            set
            {
                if (_selectedValue != value)
                {
                    _selectedValue = value;
                    OnPropertyChanged(nameof(SelectedValue));
                }
            }
        }

        public List<AttributeValueModel> AttributeValues
        {
            get => _attributeValues;
            set
            {
                if (_attributeValues != value)
                {
                    _attributeValues = value;
                    OnPropertyChanged(nameof(AttributeValues));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
