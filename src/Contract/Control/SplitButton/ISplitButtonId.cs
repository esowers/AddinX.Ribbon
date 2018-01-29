namespace AddinX.Ribbon.Contract.Control.SplitButton
{
    public interface ISplitButtonId
    {
        ISplitButtonSize SetId(string name);

        ISplitButtonSize SetIdMso(string name);

        ISplitButtonSize SetIdQ(string ns, string name);
    }
}