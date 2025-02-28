public interface IDocumentContainerService
{
    public IContainerDisplay DisplayType { get; set; }
    bool AddDocument(IDocument document);
    bool RemoveDocument(IDocument document);
    IDocument? FindDocumentById(int id);
    void ChangeDocumentOrder(int oldIndex, int newIndex);
    void ShowDocuments();
}
