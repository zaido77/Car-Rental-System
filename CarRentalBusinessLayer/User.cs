using CarRentalDataAccessLayer;
using System.Data;

namespace CarRentalBusinessLayer
{
    public class clsUser
    {
        public enum enMode : byte { AddNew, Update }
        public enMode Mode { get; private set; } = enMode.AddNew;

        public int ID { get; private set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public clsUser()
        {
            this.ID = -1;
            this.Username = "";
            this.Password = "";

            this.Mode = enMode.AddNew;
        }

        private clsUser(int ID, string Username, string Password)
        {
            this.ID = ID;
            this.Username = Username;
            this.Password = Password;

            this.Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.ID = clsUserDataAccess.AddNewUser(this.Username, this.Password);

            return this.ID != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.ID, this.Username, this.Password);
        }

        public static clsUser Find(string Username, string Password)
        {
            int UserID = -1;

            if (clsUserDataAccess.GetUserInfoByUsernameAndPassword(Username, Password, ref UserID))

                return new clsUser(UserID, Username, Password);

            else

                return null;
        }

        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        this.Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();

                default:
                    return false;
            }
        }
    }
}