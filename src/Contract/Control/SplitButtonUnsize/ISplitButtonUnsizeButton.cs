using System;

namespace AddinX.Ribbon.Contract.Control.SplitButtonUnsize
{
    public interface ISplitButtonUnsizeButton
    {
        ISplitButtonUnsizeMenu AddButton(string label, Action<Contract.Control.ButtonUnsize.IButtonUnsizeId> button);
        ISplitButtonUnsizeMenu AddToggleButton(string label, Action<Contract.Control.ToggleButtonUnsize.IToggleButtonUnsizeId> toggleButton);
    }
}
