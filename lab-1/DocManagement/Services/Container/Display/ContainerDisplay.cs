public class ContainerDisplayDetailed : IContainerDisplay
{
    public void Display(IEnumerable<IDocument> documents)
    {
        foreach (var document in documents)
        {
            document.Display();
        }
    }
}

public class ContainerDisplaySimple : IContainerDisplay
{
    public void Display(IEnumerable<IDocument> documents)
    {
        foreach (var document in documents)
        {
            document.ShowOverview();
        }
    }
}