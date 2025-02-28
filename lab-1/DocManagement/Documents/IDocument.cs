using Documents.Documents.Data;

public interface IDocument
{
    int Id { get; }
    string FullName { get; }
    string IssuedBy { get; }
    DateSpan Validity { get; }
    Photo Photo { get; }
    bool Hidden { get; set; }

    void ShowOverview();
    void Display();
    void GenerateQRCode();
    void DisplayFull();
    void DisplayHidden();
}
