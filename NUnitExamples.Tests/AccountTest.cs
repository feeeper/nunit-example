using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Core;
using NUnit.Framework;

namespace NUnitExamples.Tests
{
  [TestFixture]
  public class AccountTest
  {
    Account _source;
    Account _destination;

    [SetUp] // метод, который будет выполняться перед каждым тестом.
    public void Init()
    {
      _source = new Account();
      _source.Deposit(200m);

      _destination = new Account();
      _destination.Deposit(150m);
    }

    [Test]
    public void TransferFunds()
    {
      _source.TransferFunds(_destination, 100m);

      Assert.AreEqual(250m, _destination.Balance);
      Assert.AreEqual(100m, _source.Balance);
    }

    [Test]
    [ExpectedException(typeof(InsufficientFundsException))] // тест должен сгенерировать исключение InsufficientFundsException
    public void TransferWithInsufficientFunds()
    {
      _source.TransferFunds(_destination, 300m);
    }

    [Test]
    [Ignore("Decide how to implement transaction management")] // пропустить тест
    public void TransferWithInsufficientFundsAtomicity()
    {
      try
      {
        _source.TransferFunds(_destination, 300m);
      }
      catch (InsufficientFundsException expected)
      {
      }

      Assert.AreEqual(200m, _source.Balance);
      NUnitFramework.Assert.AreEqual(150m, _destination.Balance);
    }
  }
}
