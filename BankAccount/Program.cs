using System;

// README.md를 읽고 아래에 코드를 작성하세요.

BankAccount b1  = new BankAccount("123-456");
b1.OwnerName = "홍길동";

Console.WriteLine($"계좌번호: {b1.AccountNumber}");
Console.WriteLine($"예금주: {b1.OwnerName}");
Console.WriteLine($"잔액: {b1.Balance}원");

Console.WriteLine("--- 50000원 입금 ---");
b1.Deposit(50000);
Console.WriteLine($"잔액: {b1.Balance}원");
Console.WriteLine("--- 20000원 출금 ---");
b1.Withdraw(20000);
Console.WriteLine($"잔액: {b1.Balance}원");
Console.WriteLine("--- 100000원 출금 시도 ---");
b1.Withdraw(100000);
Console.WriteLine($"잔액: {b1.Balance}원");