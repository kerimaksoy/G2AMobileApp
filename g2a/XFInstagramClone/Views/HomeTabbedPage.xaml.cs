using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using g2a.Views.HomeTabbedPageViews;

namespace g2a.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();

            Children.Add(new HomePage());
            Children.Add(new DiscoverPage());
            Children.Add(new Cart());
            Children.Add(new ProfilePage());
        }
        
    }
}