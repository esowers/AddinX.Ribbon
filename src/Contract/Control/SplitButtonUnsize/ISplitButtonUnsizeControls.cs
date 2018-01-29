using AddinX.Ribbon.Contract.Control.ButtonUnsize;
using AddinX.Ribbon.Contract.Control.MenuUnsize;
using AddinX.Ribbon.Contract.Control.ToggleButtonUnsize;

namespace AddinX.Ribbon.Contract.Control.SplitButtonUnsize
{
    public interface ISplitButtonUnsizeControls
    {
        IButtonUnsize AddButton(string label);

        //ICheckboxId AddCheckbox(string label);

        IToggleButtonUnsize AddToggleButton(string label);

        //IGalleryUnsizeId AddGallery(string label);

        IMenuUnsize AddMenu(string label);

        //ISeparatorId
        //ISplitButtonUnsized

    }
}