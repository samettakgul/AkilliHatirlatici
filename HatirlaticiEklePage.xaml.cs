using System;
using Xamarin.Forms;
using AkilliHatirlatici.Models;
using AkilliHatirlatici.Services;


namespace AkilliHatirlatici
{
    public partial class HatirlaticiEklePage : ContentPage
    {
        public HatirlaticiEklePage()
        {
            InitializeComponent();
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            var reminder = new Reminder
            {
                Title = titleEntry.Text,
                Description = descEntry.Text,
                ReminderTime = datePicker.Date + timePicker.Time
            };

            await ReminderService.AddReminder(reminder);
            await Navigation.PopAsync();
        }
    }
}
