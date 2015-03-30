using System;

namespace Finan.Domain.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLogOn { get; set; }
        public bool IsActive { get; set; }

        // EntityFramework needs
        public User() { }

        // Create User
        public User(string email)
        {
            Email = email;
            CreateDate = DateTime.Now;
            LastLogOn = DateTime.Now;
            IsActive = true;
        }

        // Get User
        public User(int userId, string email, string password, 
            DateTime createDate, DateTime lastLogOn, bool isActive)
        {
            UserId = userId;
            Email = email;
            Password = password;
            CreateDate = createDate;
            LastLogOn = lastLogOn;
            IsActive = isActive;
        }

        public void SetPassword(string password, string confirmPassword)
        {
            if (password.Equals(confirmPassword))
            {
                Password = password;
            } else  throw new Exception();
            IsValid();
        }

        public void UpdateLogOn(DateTime lastDate)
        {
            LastLogOn = lastDate;
            IsValid();
        }

        public void ChangeStatus(bool status)
        {
            IsActive = status;
            IsValid();
        }

        public void ResetPassword(string oldPassword, string newPassword, string confirmPassword)
        {
            if (oldPassword.Equals(Password) && newPassword.Equals(confirmPassword))
            {
                Password = newPassword;
            }
            IsValid();
        }

        public void IsValid()
        {
            
        }
    }
}