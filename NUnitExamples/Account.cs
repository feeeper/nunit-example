using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitExamples
{
  public class Account
  {
    private decimal _balance;

    private decimal _minimumBalance = 10m;

    public decimal MinimumBalance
    {
      get { return _minimumBalance; }
    }
    public void Deposit(decimal amount)
    {
      _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
      _balance -= amount;
    }

    public void TransferFunds(Account destination, decimal amount)
    {
      destination.Deposit(amount);

      if (_balance - amount < MinimumBalance)
        throw new InsufficientFundsException();

      Withdraw(amount);
    }

    public decimal Balance
    {
      get { return _balance; }
    }
  }
}
