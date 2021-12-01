// See https://aka.ms/new-console-template for more information

class contact
{
    private string firstName;
    private string lastName;
    private string organization;
    private int phoneNumber;
    private string address;

    public contact(string organization, string lastName, string firstName, int phoneNumber, string address)
    {
        this.organization = organization;
        this.lastName = lastName;
        this.firstName = firstName;
        this.phoneNumber = phoneNumber;
        this.address = address;
    }
}