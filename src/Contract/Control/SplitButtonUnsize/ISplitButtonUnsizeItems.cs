using System;

namespace AddinX.Ribbon.Contract.Control.SplitButtonUnsize
{
    public interface ISplitButtonUnsizeItems
    {
        ISplitButtonUnsizeExtra AddItems(Action<ISplitButtonUnsizeControls> items);
    }
}