namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string phoneNumber)
        {
            return $"Calling... {phoneNumber}";
        }

        public string Browse(string url)
        {
            if (url.Any(char.IsDigit))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}!";
        }
    }
}
