namespace shoes.Services
{
    internal class ValidationHelper
    {
        public static bool ValidationLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidationPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
