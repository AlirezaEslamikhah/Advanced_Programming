using System;

class NotVerifiedState : IAccountState
{
    private Action OnUnFrozen;
    public NotVerifiedState(Action onUnfrozen)
    {
        this.OnUnFrozen = onUnfrozen;
    }

    public IAccountState Close() => new ClosedState();

    public IAccountState Deposit(Action addToBalance)
    {
        addToBalance();
        return this;
    }

    public IAccountState Freeze() => this;

    public IAccountState HolderVerified() => new ActiveState(this.OnUnFrozen);

    public IAccountState Withdraw(Action subFromBalance) => this;
}