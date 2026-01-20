using System;

interface IChecker
{
    // generate Password
    string GeneratePassword();
    bool Cracker(Password password, string attempt, int idx);

}