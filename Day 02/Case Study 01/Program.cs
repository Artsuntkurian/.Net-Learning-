/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

abstract class Account{
    
    public string AccountNumber{get;set;}
    public string CustomerName{get;set;}
    
    protected decimal Balance{get;set;}
    
    
    public Account(string accNo,string name,decimal initialbalance){
        AccountNumber=accNo;
        CustomerName=name;
        Balance=initialbalance;
        
    }
    
    public void Deposit(decimal amount){
        if(amount>0)
        {
            Balance+=amount;
        }
    }
    public virtual void Withdraw(decimal amount){
        if(amount>0 && amount<=Balance){
            Balance-=amount;
            Console.WriteLine($"{amount} Debited from your Account");
        }
        else{
            Console.WriteLine("Insufficient Balance");
        }
    }
    public decimal GetBalance()
    {
        return Balance;
    }
    public abstract void CalculateInterest();
    
    public void DisplayDetails(){
        Console.WriteLine($"Account : {AccountNumber}");
        Console.WriteLine($"Customer Name : {CustomerName}");
        Console.WriteLine($"Balance : {Balance}");
    }
}

class SavingsAccount:Account{
    private decimal InterestRate=5.0m;
    
    public SavingsAccount(string accNo,string name,decimal initialbalance):base(accNo,name,initialbalance){
        
    }
    
    public override void Withdraw(decimal amount){
        if(amount>0 && Balance-amount>=1000)
        {
            Balance-=amount;
            Console.WriteLine($"{amount} Debited from your Account");
        }
        else{
            Console.WriteLine("Minimum Balanc 1000 required in savings account");
            
        }
    }
    public override void CalculateInterest()
    {
        decimal interest=Balance*InterestRate/100;
        Balance+=interest;
        Console.WriteLine($"Interest Added : {interest}");
    }
}


class CurrentAccount:Account{
    
    public CurrentAccount(string accNo,string name,decimal initialbalance):base(accNo,name,initialbalance){
        
    }
    public override void Withdraw(decimal amount){
        if(amount>0 && Balance>amount)
        {
            Balance-=amount;
            Console.WriteLine($"{amount} Debited from your Account");
        }
        else{
            Console.WriteLine("Insufficient Balance in  account");
            
        }
    }
    public override void CalculateInterest()
    {
        
        Console.WriteLine("No interest for Current Account");
    }
}






class Program {
  static void Main(string[] args) {
      
      Account acc=new SavingsAccount("1001","Alfred",5000);
      
      acc.DisplayDetails();
      acc.CalculateInterest();
      
      
     
    Console.WriteLine($"Updated balance is {acc.GetBalance()}");
  }
}