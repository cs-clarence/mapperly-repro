using PrivatePackage;
using Riok.Mapperly.Abstractions;

public record UserUpdateDto(string EmailAddress);

[Mapper(IncludedMembers = MemberVisibility.All)]
public static partial class UserMapper 
{
	static partial void ApplyTo(this UserUpdateDto input, User user);
	
	public static void ApplyUpdates(this UserUpdateDto input, User user) 
	{
		input.ApplyTo(user);
	}
}
					
public class Program
{
	public static void Main()
	{
		var user = new User("user@gmail.com");
		var updates = new UserUpdateDto("new-user@gmail.com");
		
		updates.ApplyUpdates(user);
		
		Console.WriteLine(user.EmailAddress); // still shows user@gmail.com
	}
}