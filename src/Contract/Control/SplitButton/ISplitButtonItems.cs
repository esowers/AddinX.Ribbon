using System;

namespace AddinX.Ribbon.Contract.Control.SplitButton
{
    public interface ISplitButtonItems
    {
        ISplitButtonExtra AddItems(Action<ISplitButtonControls> items);
    }
}