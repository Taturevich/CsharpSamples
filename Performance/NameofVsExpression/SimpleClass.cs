using Caliburn.Micro;

namespace NameofVsExpression
{
    public class SimpleClass : PropertyChangedBase
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }
    }
}
