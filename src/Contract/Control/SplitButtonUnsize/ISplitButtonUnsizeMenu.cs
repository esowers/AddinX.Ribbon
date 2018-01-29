using System;

namespace AddinX.Ribbon.Contract.Control.SplitButtonUnsize
{
    public interface ISplitButtonUnsizeMenu
    {
        ISplitButtonUnsizeExtra AddMenu(string label, Action<Control.MenuUnsize.IMenuUnsizeId> menu);
    }
}
