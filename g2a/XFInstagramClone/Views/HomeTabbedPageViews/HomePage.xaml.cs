using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using g2a.Models;

namespace g2a.Views.HomeTabbedPageViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            FillInfo();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FillInfo();
            
        }

        public void FillInfo()
        {
            List<GamesModel> gamesModels = new List<GamesModel>();
            gamesModels.Add(new GamesModel
            {
                PostImage = "gta.jpg",
            });
            gamesModels.Add(new GamesModel
            {
          
                PostImage = "image0.jpg",
         
            });
            gamesModels.Add(new GamesModel
            {
            
                PostImage = "image1.jpg",
       
            });
            gamesModels.Add(new GamesModel
            {

                PostImage = "image2.jpg",
        
            });
            gamesModels.Add(new GamesModel
            {
   
                PostImage = "gta.jpg",
 
            });
            gamesModels.Add(new GamesModel
            {

                PostImage = "image0.jpg",

            });

            listPosts.BindingContext = gamesModels;
            
        }
        async public void OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiscoverPage());
        }
    }
}