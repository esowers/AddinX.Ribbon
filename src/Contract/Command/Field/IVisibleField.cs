using System;

namespace AddinX.Ribbon.Contract.Command.Field
{
    public interface IVisibleField
    {
        Func<bool> IsVisibleField { get; }
    }
}