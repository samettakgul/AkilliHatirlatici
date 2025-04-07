using System.Collections.Generic;
using System.Threading.Tasks;
using AkilliHatirlatici.Models;
using AkilliHatirlatici.Services;

namespace AkilliHatirlatici
{
    public static class ReminderService
    {
        public static async Task<List<Reminder>> GetAllReminders()
        {
            var response = await SupabaseService.GetClient()
                .From<Reminder>()
                .Get();

            return response.Models;
        }








        public static async Task AddReminder(Reminder reminder)
        {
            await SupabaseService.GetClient()
                .From<Reminder>()
                .Insert(reminder);
        }

        public static async Task DeleteReminder(int id)
        {
            await SupabaseService.GetClient()
                .From<Reminder>()
                .Where(r => r.Id == id)
                .Delete();
        }
    }
}
