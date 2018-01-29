namespace AddinX.Ribbon.Contract.Control.SplitButton
{
    public interface ISplitButtonExtra
    {
        ISplitButtonExtra Description(string description);

        ISplitButtonExtra Supertip(string supertip);

        ISplitButtonExtra Keytip(string keytip);

        ISplitButtonExtra Screentip(string screentip);
    }
}