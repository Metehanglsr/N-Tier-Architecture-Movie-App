namespace movieapp.webui.HelperMethods
{
    public static class HelperMethods
    {
        public static string Random()
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            return randomNumber.ToString();
        }
        public static string NotFound(string message)
        {
            message += " not found!";
            return message;
        }
    }
}
