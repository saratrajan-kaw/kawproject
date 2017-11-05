using System;

using Xamarin.Forms;

namespace KAWApp
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            const string EVENTS = "Events";
            const string OFFERS = "Offers";
            const string SPONSORS = "Sponsors";
            const string PICTURES = "Pictures";
            const string JOIN = "Join";

            Page eventsPage, offersPage, sponsorsPage, picturePage,  joinPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    eventsPage = new NavigationPage(new EventsPage())
                    {
                        Title = EVENTS
                    };

                    offersPage = new NavigationPage(new OffersPage())
                    {
                        Title = OFFERS
                    };
                    sponsorsPage = new NavigationPage(new SponsorsPage())
                    {
                        Title = SPONSORS
                    };
                    picturePage = new NavigationPage(new PicturesPage())
                    {
                        Title = PICTURES
                    };
                    joinPage = new NavigationPage(new AboutPage())
                    {
                        Title = JOIN
                    };
                    eventsPage.Icon = "tab_feed.png";
                    offersPage.Icon = "tab_about.png";
                    sponsorsPage.Icon = "tab_about.png";
                    picturePage.Icon = "tab_about.png";
                    joinPage.Icon = "tab_about.png";

                    break;
                default:
                    eventsPage = new EventsPage()
                    {
                        Title = EVENTS
                    };
                    offersPage = new AboutPage()
                    {
                        Title = OFFERS
                    };
                    sponsorsPage = new AboutPage()
                    {
                        Title =  SPONSORS
                    };
                    picturePage = new AboutPage()
                    {
                        Title =  PICTURES
                    };
                    joinPage = new AboutPage()
                    {
                        Title = JOIN
                    };
                    break;
            }

            Children.Add(eventsPage);
            Children.Add(offersPage);
            Children.Add(sponsorsPage);
            Children.Add(picturePage);
            Children.Add(joinPage);


            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
