public class DocumentContainerService : IDocumentContainerService
{
    private readonly IDocumentValidatorService _documentValidator;
    private List<IDocument> documents;
    public IContainerDisplay DisplayType { get; set; }
    public DocumentContainerService(IDocumentValidatorService documentValidator)
    {
        documents = new List<IDocument>();
        DisplayType = new ContainerDisplaySimple();
        _documentValidator = documentValidator;
    }

    public bool AddDocument(IDocument document)
    {
        if (document == null)
            throw new ArgumentNullException(nameof(document));

        if (documents.Any(d => d.Id == document.Id))
            throw new InvalidOperationException($"Entry already exists.");

        if (_documentValidator.IsExpired(document))
        {
            return false;
        }
        else
        {
            documents.Add(document);
            return true;
        }
    }

    public IDocument? FindDocumentById(int id)
    {
        if (id <= 0)
            throw new ArgumentOutOfRangeException(nameof(id));

        var document = documents.FirstOrDefault(d => d.Id == id);
        return document;
    }

    public bool RemoveDocument(IDocument document)
    {
        if (document == null)
            throw new ArgumentNullException(nameof(document));

        documents.Remove(document);
        return true;
    }

    public void ChangeDocumentOrder(int oldIndex, int newIndex)
    {
        if (oldIndex < 0 || oldIndex >= documents.Count || newIndex < 0 || newIndex >= documents.Count)
            throw new ArgumentOutOfRangeException("Invalid index.");

        var temp = documents[oldIndex];
        documents[oldIndex] = documents[newIndex];
        documents[newIndex] = temp;
    }

    public void ShowDocuments()
    {
        DisplayType.Display(documents);
    }
}
