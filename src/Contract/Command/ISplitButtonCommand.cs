using System;

namespace AddinX.Ribbon.Contract.Command
{
    public interface ISplitButtonCommand : ICommand
    {
        ISplitButtonCommand IsVisible(Func<bool> condition);

        ISplitButtonCommand IsEnabled(Func<bool> condition);
    }
}
