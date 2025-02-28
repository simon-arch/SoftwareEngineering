using Documents.Documents.Data;

public class DriversLicense : Document
{
    public string LicenseNumber { get; set; }
    public string VehicleCategory { get; set; }

    public DriversLicense(int id,
                              string fullName,
                              DateSpan validity,
                              string issuedBy,
                              Photo photo,
                              string licenseNumber,
                              string vehicleCategory,
                              bool hidden)
    {
        Id = id;
        FullName = fullName;
        Validity = validity;
        IssuedBy = issuedBy;
        Photo = photo;
        LicenseNumber = licenseNumber;
        VehicleCategory = vehicleCategory;
        Hidden = hidden;
    }

    public void RegisterVehicle(string vehicleNumber)
    {
        Console.WriteLine($"Vehicle {vehicleNumber} has been registered:\n\tLicense: {LicenseNumber}.\n");
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Driver's License Info:\n" +
            $"ID: {Id}\n" +
            $"Full Name: {FullName}\n" +
            $"License Number: {LicenseNumber}\n" +
            $"Vehicle Category: {VehicleCategory}\n" +
            $"Issued by: {IssuedBy}\n" +
            $"Date of Issue: {Validity.DateIssued.ToShortDateString()}\n" +
            $"Expiration Date: {Validity.DateExpire.ToShortDateString()}\n");
    }

    public override void DisplayHidden()
    {
        Console.WriteLine($"Drivers License Info is hidden.\n");
    }
}
