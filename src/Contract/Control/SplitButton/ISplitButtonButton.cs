using System;

namespace AddinX.Ribbon.Contract.Control.SplitButton
{
    public interface ISplitButtonButton
    {
        ISplitButtonMenu AddButton(string label, Action<Contract.Control.ButtonUnsize.IButtonUnsizeId> button);
        ISplitButtonMenu AddToggleButton(string label, Action<Contract.Control.ToggleButtonUnsize.IToggleButtonUnsizeId> toggleButton);
    }
}
