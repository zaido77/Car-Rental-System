using CarRentalDataAccessLayer;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace CarRentalBusinessLayer
{
    public class clsUser
    {
        public enum enMode : byte { AddNew, Update }
        public enMode Mode { get; private set; } = enMode.AddNew;

        public int ID { get; private set; }
        public string Username { get; set; }
        public string Password { get; private set; }

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

        private static string _ComputeHash(string Value)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Value));
                return BitConverter.ToString(bytes).Replace("-", "");
            }
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

        public static clsUser Find(int UserID)
        {
            string Username = "";
            string Password = "";

            if (clsUserDataAccess.GetUserInfoByUserID(UserID, ref Username, ref Password))

                return new clsUser(UserID, Username, Password);

            else

                return null;
        }

        public static clsUser Find(string Username, string Password)
        {
            int UserID = -1;

            Password = _ComputeHash(Password);

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
                    this.Password = _ComputeHash(this.Password);

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

        public void ChangePassword(string NewPlainPassword)
        {
            this.Password = _ComputeHash(NewPlainPassword);
        }

        public bool IsEqualPassword(string PasswordToConfirm)
        {
            return Password == _ComputeHash(PasswordToConfirm);
        }

    }
}