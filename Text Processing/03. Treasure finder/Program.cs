public class Program
{
    static void Main()
    {
        int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string input = "";
        while ((input = Console.ReadLine()) != "find")
        {
            char[] decrypter = input.ToCharArray();
            for (int i = 0; i < decrypter.Length; i++)
            {
                decrypter[i] = (char)(decrypter[i] - key[i % key.Length]);
            }
            string decrypted = new string(decrypter);
            int start = decrypted.IndexOf('&');
            int end = decrypted.LastIndexOf('&');
            string treasure = decrypted.Substring(start + 1, end - start - 1);
            start = decrypted.IndexOf('<');
            end = decrypted.LastIndexOf('>');
            string coordinates = decrypted.Substring(start + 1, end - start - 1);
            Console.WriteLine($"Found {treasure} at {coordinates}");
        }
    }
}