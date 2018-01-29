using System;
using AddinX.Ribbon.Contract.Command;
using AddinX.Ribbon.Contract.Command.Field;

namespace AddinX.Ribbon.Implementation.Command
{
    public class TabCommand : ITabCommand, IVisibleField
    {
        public Func<bool> IsVisibleField { get; private set; }

        public TabCommand()
        {
            IsVisibleField = () => true;
        }
        public void IsVisible(Func<bool> condition)
        {
            IsVisibleField = condition;
        }
    }
}