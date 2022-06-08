// using System;
// class ActiveState : IFreezable
// {
//     private Action OnUnFreeze;    
//     public ActiveState(Action onUnfreeze)
//     {
//         this.OnUnFreeze = onUnfreeze;
//     }
//     public IFreezable Deposit() => this;

//     public IFreezable Freeze() => new FrozenState(this.OnUnFreeze);

//     public IFreezable Withdraw() => this;
// }