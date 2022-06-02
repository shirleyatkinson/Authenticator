using Microsoft.AspNetCore.Mvc;

namespace Authenticator.Models;

public class User
{
    //Note - we have put ? after string to indicate that it is ok 
    //for these values to potentially be null when the class is
    //instanstiated.  However, we do not want the email and password 
    //to be null at all ever - so we initiate these with an empty string
    public string? firstName { get; set;}
    public string? lastName { get; set;}
    public string Email { get; set;} = string.Empty;
    public string Password{ get; set;} = string.Empty;
}