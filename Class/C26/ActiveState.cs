using System;

class ActiveState : IAccountState
{
    private Action OnUnFrozen;
    public ActiveState(Action onUnfrozen)
    {
        this.OnUnFrozen = onUnfrozen;
    }

    public IAccountState Close() => new ClosedState();

    public IAccountState Deposit(Action addToBalance)
    {
        addToBalance();
        return this;
    }

    public IAccountState Freeze() => new FrozenState(this.OnUnFrozen);

    public IAccountState HolderVerified() => this;

    public IAccountState Withdraw(Action subFromBalance)
    {
        subFromBalance();
        return this;
    }
}