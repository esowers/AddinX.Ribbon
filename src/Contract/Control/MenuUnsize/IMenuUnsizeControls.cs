using AddinX.Ribbon.Contract.Control.ButtonUnsize;
using AddinX.Ribbon.Contract.Control.CheckBox;
using AddinX.Ribbon.Contract.Control.GalleryUnsize;
using AddinX.Ribbon.Contract.Control.MenuSeparator;
using AddinX.Ribbon.Contract.Control.SplitButtonUnsize;
using AddinX.Ribbon.Contract.Control.ToggleButtonUnsize;

namespace AddinX.Ribbon.Contract.Control.MenuUnsize
{
    public interface IMenuUnsizeControls
    {
        IButtonUnsizeId AddButton(string label);

        ICheckboxId AddCheckbox(string label);
        
        IToggleButtonUnsizeId AddToggleButton(string label);

        IGalleryUnsizeId AddGallery(string label);

        IMenuUnsizeId AddMenu(string label);

        IMenuSeparatorId AddSeparator(string title);

        ISplitButtonUnsizeId AddSplitButton(string label);
    }
}