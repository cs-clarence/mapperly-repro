namespace PrivatePackage;

public class User(string emailAddress)
{
    public string EmailAddress { get; private set; } = emailAddress;
}