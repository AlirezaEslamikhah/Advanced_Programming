using System;
using System.Timers;

class Account
{
    public double Balance {get; private set;}
    IAccountState AccountState;
    public Account(Action onUnfreeze, int freezeAfter)
    {
        this.AccountState = new NotVerifiedState(onUnfreeze);

        Timer t = new Timer(freezeAfter);
        t.Elapsed += (a,s) => Freeze();
        t.Start();
    }

    // 5: isClosed=true, isVerified=*, Balance=10, Deposit=5, ==> Balance = 10
    // 6: isClosed=false, isVerified=*, Balance=10, Deposit=5, ==> Balance = 15
    // 7: isFrozen=true, OnUnfreeze() is called
    // 8: isFrozen=false, OnUnfreeze() is not called
    public void Deposit(double amount) =>
        this.AccountState = this.AccountState.Deposit( () => this.Balance += amount);

    // 1: Verified = false, isClosed=true, Balance=10 Withdraw=5 ==> Balance == 10
    // 2: Verified = false, isClosed=false, Balance=10 Withdraw=5 ==> Balance == 10
    // 3: Verified = true, isClosed=false, Balance=10 Withdraw=5 ==> Balance == 5
    // 4: Verified = true, isClosed=true, Balance=10 Withdraw=5 ==> Balance == 10
    // 9: isFrozen=true, OnUnfreeze() is called
    // 10: isFrozen=false, OnUnfreeze() is not called
    public void Withdraw(double amount) =>
        this.AccountState = this.AccountState.Withdraw(() => this.Balance -= amount);

    public void Close() => 
        this.AccountState = this.AccountState.Close();

    public void HolderVerified() =>
        this.AccountState = this.AccountState.HolderVerified();

    public void Freeze() =>
        this.AccountState = this.AccountState.Freeze();
}