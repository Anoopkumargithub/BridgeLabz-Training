using NUnit.Framework;
using BankAccount;
namespace BankAccount.Tests;

public class Tests
{
    private BankAccount _account;

    [SetUp]
    public  void Setup()
    {
        _account = new BankAccount(1000);
    }

    [Test]
    public void Test_Deposit_ValidAmount()
    {
        _account.Deposit(100);
        Assert.That(_account.Balance, Is.EqualTo(1100));
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Assert.Throws<ArgumentException>(() => _account.Deposit(-50));
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        _account.Deposit(200);
        _account.Withdraw(50);
        Assert.That(_account.Balance, Is.EqualTo(1150));
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        _account.Deposit(100);
        Assert.Throws<InvalidOperationException>(() => _account.Withdraw(1250));
    }
}       