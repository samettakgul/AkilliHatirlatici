using Xamarin.Forms;
using AkilliHatirlatici.Models;
using AkilliHatirlatici.Services;
using System.Collections.ObjectModel;
using System;
using static Xamarin.Essentials.Permissions;

namespace AkilliHatirlatici.Views
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Reminder> reminders;

        public MainPage()
        {
            InitializeComponent();
            SupabaseService.Initialize().Wait();
            LoadReminders();
        }

        private async void LoadReminders()
        {
            var client = SupabaseService.GetClient();
            var result = await client.From<Reminder>().Get();
            reminders = new ObservableCollection<Reminder>(result.Models);
            reminderList.ItemsSource = reminders;
        }

        private async void OnAddReminderClicked(object sender, EventArgs e)
        {
            var reminder = new Reminder
            {
                Title = titleEntry.Text,
                Description = descriptionEditor.Text,
                ReminderTime = datePicker.Date + timePicker.Time
            };

            await SupabaseService.GetClient().From<Reminder>().Insert(reminder);
            reminders.Add(reminder);

            titleEntry.Text = string.Empty;
            descriptionEditor.Text = string.Empty;
        }

        private async void OnReminderSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Reminder selectedReminder)
            {
                bool confirm = await DisplayAlert("Sil", $"{selectedReminder.Title} silinsin mi?", "Evet", "Hayır");
                if (confirm)
                {
                    await SupabaseService.GetClient().From<Reminder>().Delete(selectedReminder);
                    reminders.Remove(selectedReminder);
                }
                reminderList.SelectedItem = null;
            }
        }
    }
}