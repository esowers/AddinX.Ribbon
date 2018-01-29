using System;

namespace AddinX.Ribbon.Contract.Command
{
    public interface ITabCommand : ICommand
    {
        void IsVisible(Func<bool> condition);
    }
}
