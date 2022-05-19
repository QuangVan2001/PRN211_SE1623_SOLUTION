public class Address
{
    public int No { get; set; }
    public string Street { get; set; }
    public string Ward { get; set; }
    public string District { get; set; }

    public Address(int no, string street, string ward, string district)
    {
        No = no;
        Street = street;
        Ward = ward;
        District = district;
    }

    public override string? ToString()
    {
        return $"No={No}, Street = {Street}, Ward = {Ward}, District={District}";
    }
}
