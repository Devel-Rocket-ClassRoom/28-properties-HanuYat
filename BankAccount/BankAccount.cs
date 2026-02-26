using System;

class BankAccount
{
    private int _balance;

    public string AccountNumber { get; }
    public string OwnerName { get; set; }
    public int Balance
    {
        get => _balance;

        private set
        {
            if (_balance < 0)
            {
                _balance = 0;
            }

            else
            {
                _balance = value;
            }
        }
    }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
    }

    public void Deposit(int amount)
    {  
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void Withdraw(int amount)
    {
        bool IsWithdraw = amount < Balance;

        if (amount > Balance)
        {
            Console.WriteLine($"출금 성공: {IsWithdraw}");
        }

        else
        {
            Balance -= amount;
            Console.WriteLine($"출금 성공: {IsWithdraw}");
        }
    }
}