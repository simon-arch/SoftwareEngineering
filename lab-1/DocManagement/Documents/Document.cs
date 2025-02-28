using Documents.Documents.Data;

public abstract class Document : IDocument
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string IssuedBy { get; set; }
    public DateSpan Validity { get; set; }
    public Photo Photo { get; set; }
    public bool Hidden { get; set; }

    public void ShowOverview()
    {
        Console.WriteLine($"Document Overview:\n" +
            $"\tID: {Id}\n" +
            $"\tFull Name: {FullName}\n" +
            $"\tHidden: {Hidden}");
    }

    public void Display()
    {
        if (Hidden) DisplayHidden();
        else DisplayFull();
    }

    public abstract void DisplayFull();
    public abstract void DisplayHidden();

    public void GenerateQRCode()
    {
        Console.WriteLine($"Document #{Id}: QR Code generated.");
    }
}
