namespace C_Sharp_Practice.Services
{
     class UserService
    {
        public bool CheckPassword(string password)
        {
            bool upperStatus = false;
            bool lowerStatus = false;
            bool digitStatus = false;
            if(!string.IsNullOrWhiteSpace(password) && password.Length >= 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    //Pas123sword
                    if (char.IsUpper(password[i]))
                        upperStatus = true;
                    else if(char.IsLower(password[i]))
                        lowerStatus = true;
                    else if (char.IsDigit(password[i]))
                        digitStatus = true;

                    if (upperStatus && lowerStatus && digitStatus)
                        return true;
                }
            }

            return false;
        }
    }
}
