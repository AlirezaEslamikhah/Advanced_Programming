using System;

class FrozenState : IAccountState
{
    private Action OnUnFrozen;
    public FrozenState(Action onUnfrozen)
    {
        this.OnUnFrozen = onUnfrozen;
    }

    public IAccountState Close() => new ClosedState();

    public IAccountState Deposit(Action addToBalance)
    {
        addToBalance();
        this.OnUnFrozen();
        return new ActiveState(this.OnUnFrozen);
    }

    public IAccountState Freeze() => this;

    public IAccountState HolderVerified() => this;

    public IAccountState Withdraw(Action subFromBalance)
    {
        subFromBalance();
        this.OnUnFrozen();
        return new ActiveState(this.OnUnFrozen);    
    }
}