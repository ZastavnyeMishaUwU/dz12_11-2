using System.Text;

namespace dz12_11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 12; // Вкажіть бажану довжину пароля
            string password = GeneratePassword(length);
            Console.WriteLine("Згенерований пароль: " + password);
        }

        static string GeneratePassword(int length)
        {
            const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercase = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*()-_=+[]{}|;:,.<>?/`~\"'\\";
            

            string allChars = uppercase + lowercase + digits + specialChars + ;
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(allChars.Length);
                password.Append(allChars[index]);
            }

            return password.ToString();
        }
    }
}
