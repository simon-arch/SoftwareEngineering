using Documents.Documents;
using Documents.Documents.Data;

public class MilitaryRecord : Document, ICopiable
{
    public string MilitaryCamp { get; set; }
    public string Rank { get; set; }

    public MilitaryRecord(int id,
                      string fullName,
                      DateSpan validity,
                      string issuingAuthority,
                      Photo photo,
                      string militaryCamp,
                      string rank,
                      bool hidden)
    {
        Id = id;
        FullName = fullName;
        Validity = validity;
        IssuedBy = issuingAuthority;
        Photo = photo;
        MilitaryCamp = militaryCamp;
        Rank = rank;
        Hidden = hidden;
    }

    public void CopyDocument()
    {
        Console.WriteLine($"Military Record ID: copied.");
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Military Record Info:\n" +
            $"ID: {Id}\n" +
            $"Full Name: {FullName}\n" +
            $"Military Camp: {MilitaryCamp}\n" +
            $"Rank: {Rank}\n" +
            $"Issued by: {IssuedBy}\n" +
            $"Date of Issue: {Validity.DateIssued.ToShortDateString()}\n" +
            $"Expiration Date: {Validity.DateExpire.ToShortDateString()}\n");
    }

    public override void DisplayHidden()
    {
        Console.WriteLine($"Military Record Info is hidden.\n");
    }
}
