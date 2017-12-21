using ICT13580005FinalA.Helpers;
using Xamarin.Forms;

namespace ICT13580005FinalA
{
    public partial class App : Application
    {
        public static DBHelper DbHelper { get; set; }

        public App()
        {
            InitializeComponent();
        }
        public App(string dbPath)
        {
            InitializeComponent();
            DbHelper = new DBHelper(dbPath);

            MainPage = new NavigationPage(new ICT13580005FinalAPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
