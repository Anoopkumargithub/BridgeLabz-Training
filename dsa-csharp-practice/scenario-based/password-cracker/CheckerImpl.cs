using System;

internal class CheckerImpl : IChecker
{
    Random random = new Random();

// generate Password
    public string GeneratePassword()
    {
        // Implementation for generating a random password
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] passwordChars = new char[4];
        for (int i = 0; i < passwordChars.Length; i++)
        {
            passwordChars[i] = chars[random.Next(chars.Length)];
        }
        return new string(passwordChars);
    }

    public bool Cracker(Password password, string attempt, int idx)
    {
        // Base case: if the attempt length matches the password length
        if (attempt.Length == password.GetPassword().Length)
        {
            if (attempt == password.GetPassword())
            {
                Console.WriteLine("----------Password cracked: " + attempt + " ----------");
                return true;
            }
            return false;
        }

        // Recursive case: try all possible characters for the current index
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        foreach (char c in chars)
        {
            string newAttempt = attempt + c;
            if (Cracker(password, newAttempt, idx + 1))
            {
                return true;
            }
        }
        return false;
    }
}