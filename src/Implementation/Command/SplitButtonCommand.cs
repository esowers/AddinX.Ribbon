using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Command.Field;
using System;

namespace AddinX.Ribbon.Implementation.Command
{
    public class SplitButtonCommand : ISplitButtonCommand, IVisibleField, IEnabledField
    {
        public Func<bool> IsVisibleField { get; private set; }
        public Func<bool> IsEnabledField { get; private set; }

        public SplitButtonCommand()
        {
            IsVisibleField = () => true;
            IsEnabledField = () => true;
        }

        public ISplitButtonCommand IsVisible(Func<bool> condition)
        {
            IsVisibleField = condition;
            return this;
        }

        public ISplitButtonCommand IsEnabled(Func<bool> condition)
        {
            IsEnabledField = condition;
            return this;
        }
    }
}
