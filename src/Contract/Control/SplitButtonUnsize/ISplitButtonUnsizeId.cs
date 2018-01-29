namespace AddinX.Ribbon.Contract.Control.SplitButtonUnsize
{
    public interface ISplitButtonUnsizeId
    {
        ISplitButtonUnsizeButton SetId(string name);

        ISplitButtonUnsizeButton SetIdMso(string name);

        ISplitButtonUnsizeButton SetIdQ(string ns, string name);
    }
}