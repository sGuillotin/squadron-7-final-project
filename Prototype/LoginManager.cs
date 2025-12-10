namespace MauiApp1;
using System.IO;
using System.Text.Json;

public class LoginManager
{
    // create a blueprint for our login managers
    public Dictionary<string, string> login;
    // if login needs to be read only uncomment below line
    // private readonly Dictionary<string, string> login;
    // we need write abilites though, rite?

    public LoginManager()
    {
        // file io stuff here
        // 1. load from file to directory

        //gets file JSON data, converts back to dictionary
        StreamReader userRead = new StreamReader("../../../../Resources/accounts_data.txt");
        string fileData = userRead.ReadToEnd();

        // deserialize from file to dictionary
        login = JsonSerializer.Deserialize<Dictionary<string, string>>(fileData);
        userRead.Close();
    }


    // 2. validate login
    // pwd matches stored?
    // return true or false accordingly
    public bool ValidateLogin(string username, string password)
    {
        // check if username exists in dictionary
        if (login.ContainsKey(username))
        {
            // check if password matches
            return login[username] == password;
        }
        return false;
    }

    // 3. register new user (write to file)
    // adds key, value to dictionary, parses into JSON, writes to file
    public static void RegisterNewUser(string username, string password, Dictionary<string, string> database)
    {
        if (database.ContainsKey(username))
        {
            // User already exists
            throw new InvalidOperationException("Username already taken.");
        }
        else
        {
            // add new key, value pair to dictionary
            database[username] = password;
            // Append, or read and re-write with new info, to text file
            string jsonData = JsonSerializer.Serialize(database);
            StreamWriter userWrite = new StreamWriter("Resources/accounts_data.txt", false);
            userWrite.Write(jsonData);
            // close stream
            userWrite.Close();
        }

        // Recap:
        // If user already exists return false
        // Append, or read and re-write with new info, to text file
        // format username : password (whatever dictionary needs to have key:value pairs)
    }
}