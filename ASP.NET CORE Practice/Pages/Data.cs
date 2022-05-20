namespace ASP.NET_CORE_Practice.Pages
{
    public class Data
    {
        public static string Cat { get; set; }
        public static string Act { get; set; }
        public static string Dog { get; set; }
        public static string Noris { get; set; }
        public static string Guess { get; set; }
        public static string Number { get; set; }

        public static void UpdateData(string catfact, string activity, string dogimage, string noris, string guess, string num)
        {
            Cat = catfact;
            Act = activity;
            Dog = dogimage;
            Noris = noris;
            Guess = guess;
            Number = num;
        }
    }
}
