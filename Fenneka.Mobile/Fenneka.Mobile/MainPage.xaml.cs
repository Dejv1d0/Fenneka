using Fenneka.Mobile.Models;

namespace Fenneka.Mobile
{
    public partial class MainPage : ContentPage
    {
        public double ScreenWidth { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ScreenWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density * 0.8;

            BindingContext = this;
        }

        public List<Course> Courses { get; set; } = new()
        {
            new Course
            {
                id = 1,
                image = "uk.png",
                name = "J. Angielski",
                date = "Wtorek, 22.09.2026",
                hour = "18:30 - 19:30",
                localization = "Sala B1 - Wojnicz Rynek 1",
                teacher = "mgr Wojciech Mirek"
            },
            new Course
            {
                id = 2,
                image = "de.png",
                name = "J. Niemiecki",
                date = "Piątek, 25.09.2026",
                hour = "19:30 - 20:30",
                localization = "Sala 1 - Wojnicz Rynek 2",
                teacher = "mgr Beata Sikora"
            },
            new Course
            {
                id = 3,
                image = "pl.png",
                name = "J. Polski",
                date = "Sobota, 26.09.2026",
                hour = "12:30 - 14:30",
                localization = "Sala 2 - Wojnicz Rynek 2",
                teacher = "mgr Anna Piekarczyk"
            },
        };

        private void GoToCalendar(object sender, TappedEventArgs e)
        {

        }

        private void LessonInfo(object sender, EventArgs e)
        {

        }
    }
}
