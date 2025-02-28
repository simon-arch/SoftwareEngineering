using Documents.Documents.Data;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var passport = new Passport(id: 1, 
            fullName: "John Doe", 
            new DateSpan(
                dateIssued: new DateTime(2020, 5, 1),
                dateExpire: new DateTime(2030, 5, 1)
            ), 
            issuedBy: "Country Authority",
            new Photo("person_photo_A.jpg"), 
            passportNumber: "AA1111111", 
            nationality: "Ukrainian",
            hidden: false);

        var driversLicense = new DriversLicense(id: 2, 
            fullName: "John Doe", 
            new DateSpan(
                dateIssued: new DateTime(2021, 8, 10),
                dateExpire: new DateTime(2031, 8, 10)
            ),
            issuedBy: "Road Authority", 
            new Photo("person_photo_B.jpg"), 
            licenseNumber: "DD222222", 
            vehicleCategory: "B",
            hidden: false);

        var militaryID = new MilitaryRecord(id: 3, 
            fullName: "John Doe", 
            new DateSpan(
                dateIssued: new DateTime(2019, 3, 15),
                dateExpire: new DateTime(2029, 3, 15)
            ),
            issuingAuthority: "Military Authority", 
            new Photo("person_photo_C.jpg"), 
            militaryCamp: "#111", 
            rank: "Officer",
            hidden: true);

        IDocumentValidatorService validator = new DocumentValidatorService();
        IDocumentContainerService documentsContainer = new DocumentContainerService(validator);

        documentsContainer.AddDocument(passport);
        documentsContainer.AddDocument(driversLicense);
        documentsContainer.AddDocument(militaryID);

        Console.WriteLine("== Documents Overview ==");
        documentsContainer.ShowDocuments();

        Console.WriteLine("\n== Shared Document Actions ==");
        passport.GenerateQRCode();
        driversLicense.GenerateQRCode();
        militaryID.GenerateQRCode();

        Console.WriteLine("\n== Document-Specific Actions ==");
        militaryID.CopyDocument();
        passport.CopyDocument();
        passport.SendDocument();
        driversLicense.RegisterVehicle("AA0000BB");

        Console.WriteLine("== Document Reorder ==");
        Console.WriteLine("\n = Before Swap =");
        documentsContainer.ShowDocuments();
        documentsContainer.ChangeDocumentOrder(0, 2);
        documentsContainer.ChangeDocumentOrder(1, 2);

        Console.WriteLine("\n = After Swap =");
        documentsContainer.ShowDocuments();

        Console.WriteLine("\n== Document Removal ==");
        var document = documentsContainer.FindDocumentById(1)!;
        documentsContainer.RemoveDocument(document);
        documentsContainer.ShowDocuments();


        Console.WriteLine("\n== Extended Document View ==");
        documentsContainer.DisplayType = new ContainerDisplayDetailed();
        documentsContainer.ShowDocuments();

        Console.WriteLine("== Changed Document Visibility ==");
        document = documentsContainer.FindDocumentById(3)!;
        document.Hidden = false;
        document = documentsContainer.FindDocumentById(2)!;
        document.Hidden = true;

        documentsContainer.ShowDocuments();

        Console.WriteLine("== Handling Expired Documents ==");
        IDocument expired = new Passport(id: 4,
            fullName: "John Doe",
            new DateSpan(
                dateIssued: new DateTime(2000, 5, 1),
                dateExpire: new DateTime(2001, 5, 1)
            ),
            issuedBy: "Country Authority",
            new Photo("person_photo_C.jpg"),
            passportNumber: "AB1234567",
            nationality: "Ukrainian",
            hidden: false);

        expired.DisplayFull();
        bool success = documentsContainer.AddDocument(expired);
        if (!success) Console.WriteLine($"Document #{expired.Id} is expired!");
    }
}
