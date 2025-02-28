public class DocumentValidatorService : IDocumentValidatorService
{
    public bool IsExpired(IDocument document)
    {
        return document.Validity.IsExpired();
    }
}
