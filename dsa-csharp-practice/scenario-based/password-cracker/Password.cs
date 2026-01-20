using System;

internal class Password
{
    private string password;

    public Password(string pwd)
    {
        password = pwd;
    }

    public string GetPassword()
    {
        return password;
    }


}