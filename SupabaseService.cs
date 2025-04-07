using System.Threading.Tasks;
using Supabase;

namespace AkilliHatirlatici.Services
{
    public static class SupabaseService
    {
        private static Supabase.Client client;

        public static Supabase.Client GetClient()
        {
            if (client == null)
            {
                client = new Supabase.Client(
                    "https://dvrmquvlklcifypsvoqr.supabase.co",
                    "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImR2cm1xdXZsa2xjaWZ5cHN2b3FyIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NDM3ODk0MzksImV4cCI6MjA1OTM2NTQzOX0._ZunGYDtrsBu8ztPdmGUG3evInQUhV4NI_lsO7dNi-c",
                    new Supabase.SupabaseOptions { AutoConnectRealtime = true });
            }
            return client;
        }

        public static async Task Initialize()
        {
            await GetClient().InitializeAsync();
        }
    }
}
