using System;

// README.md를 읽고 아래에 코드를 작성하세요.

BankAccount account = new BankAccount();
account.account=("123 - 456 - 789");
account.OwnerName = ("홍길동");
account.Showinfo();
account.Deposit(50000);
account.Deposit(30000);
account.Withdraw(20000);
account.Withdraw(100000);
account.Deposit(-1000);

account.Showinfo();


class BankAccount
{
   public string account;
   public string OwnerName;
   public int Balance;
 

    public void Deposit(int amount)
    {

        if (amount < 0)
        {
            Console.WriteLine("입금금액은 0보다 커야 합니다.");
        }
        else
        {
            Balance += amount;
            Console.WriteLine($"{amount}원 입금완료. 잔액: {Balance}원");
        }
    }
    public void Withdraw(int amount)
    {

        if (amount > Balance)
        {
            Console.WriteLine("잔액이 부족합니다");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"{amount}원 출금완료. 잔액: {Balance}원");
        }
    }

    public void Showinfo()
    {
        Console.WriteLine($"[계좌정보] {account} ({OwnerName}) - 잔액:" +
            $"{Balance}원");
    }
}



