using System;

public class UserAccount
{
    private string username;
    private string password;

    // Constructor to initialize the user account
    public UserAccount(string initialUsername, string initialPassword)
    {
        username = initialUsername;
        password = initialPassword;
        // The confirmation message has been removed to improve security.
    }

    // Public method to attempt a login
    public bool Login(string inputPassword)
    {
        // This method now only returns true or false.
        // All user-facing messages are handled by the main program.
        return password == inputPassword;
    }

    // Public method to change the password
    public void ChangePassword(string oldPass, string newPass)
    {
        if (password == oldPass)
        {
            password = newPass;
            Console.WriteLine("Password changed successfully.");
        }
        else
        {
            Console.WriteLine("Password change failed: Incorrect old password.");
        }
    }
}