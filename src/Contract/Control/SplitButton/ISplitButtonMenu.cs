using System;

namespace AddinX.Ribbon.Contract.Control.SplitButton
{
    public interface ISplitButtonMenu
    {
        ISplitButtonExtra AddMenu(string label, Action<Control.MenuUnsize.IMenuUnsizeId> menu);
    }
}
