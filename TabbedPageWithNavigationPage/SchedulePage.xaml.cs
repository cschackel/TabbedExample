using System;
using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SchedulePage : ContentPage
	{
		public SchedulePage ()
		{
			InitializeComponent ();
		}

		async void OnUpcomingAppointmentsButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new UpcomingAppointmentsPage ());
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            int age = -1;
            if(int.TryParse(ageEntry.Text, out age))
            {
                if(age < 16)
                {
                    outputLabel.Text = "You cannot drive in Wisconsin";

                }
                else if (age >= 16)
                {
                    outputLabel.Text = "You have been able to drive in wisconsin for " + (age - 16) +" year(s)!";

                }
            }
            ageEntry.Text = "";
        }
    }
}

