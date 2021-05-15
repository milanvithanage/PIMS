namespace MSS
{
    class GlobalFun
    {
        // This class is used to store global functions and variables
        // Updated 17 Dec 2017
        // Version 01

        private static string currentUser = "";

        public static string CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }

        public static string CurrentUserWithGreeting()
        {
            int index = CurrentUser.IndexOf(" ");

            if (index > 0)
            {
                CurrentUser = CurrentUser.Trim();
                CurrentUser = CurrentUser.Substring(0, index);
            }

            CurrentUser = "Welcome,\n" + CurrentUser.ToUpper();
            return CurrentUser;
        }
    }
}
