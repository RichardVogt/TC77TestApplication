using TC77TestApplication.ViewModels;

namespace TC77TestApplication
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new PropsViewModel();
        }
    }
}