using Documents.Documents;
using Documents.Documents.Data;

public class Passport : Document, ISendable, ICopiable
{
    public string PassportNumber { get; set; }
    public string Nationality { get; set; }

    public Passport(int id,
                        string fullName,
                        DateSpan validity,
                        string issuedBy,
                        Photo photo,
                        string passportNumber,
                        string nationality,
                        bool hidden)
    {
        Id = id;
        FullName = fullName;
        Validity = validity;
        IssuedBy = issuedBy;
        Photo = photo;
        PassportNumber = passportNumber;
        Nationality = nationality;
        Hidden = hidden;
    }

    public void SendDocument()
    {
        Console.WriteLine($"Passport ID Number: sent.");
    }

    public void CopyDocument()
    {
        Console.WriteLine($"Passport ID Number: copied.");
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Passport Info:\n" +
            $"ID: {Id}\n" +
            $"Full Name: {FullName}\n" +
            $"Passport Number: {PassportNumber}\n" +
            $"Nationality: {Nationality}\n" +
            $"Issued by: {IssuedBy}\n" +
            $"Date of Issue: {Validity.DateIssued.ToShortDateString()}\n" +
            $"Expiration Date: {Validity.DateExpire.ToShortDateString()}\n");
    }

    public override void DisplayHidden()
    {
        Console.WriteLine($"Passport Info is hidden.\n");
    }
}
