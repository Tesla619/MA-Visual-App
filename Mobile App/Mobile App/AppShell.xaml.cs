using Mobile_App.Views;
using Xamarin.Forms;

namespace Mobile_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddReportPage), typeof(AddReportPage));
            Routing.RegisterRoute(nameof(AddEntryPage), typeof(AddEntryPage));
        }
    }
}