namespace MauiApp1;
using System.IO;

public class LoginManager
{
    private Dictionary<string, string> login;
    public LoginManager()
    {
        // initialize dictionary and set it equal to loading from JSON file
        // write stuff from userRef here
        // end in this.login = playerData; (instead of "return")
    }

    // TODO code here

    // Dictionary<user,password> login(?)= new Dictionary<user,password>();
    //login(?).Add(param1, param2);


    // 1. load from file to directory

    // 2. validate login
    // pwd matches stored?
    // return true or false accordingly

    // 3. register new user (write to file)

    // If user already exists return false
    // If not append, or read and re-write with new info, to text file
    // format username : password (whatever dictionary needs to have key:value pairs)

    // TODO code here

}