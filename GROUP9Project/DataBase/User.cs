/*
 * By: Spencer P. Lowery
 *
 * A class used to store all the data specific to a single user.
 * 
 *  
 * Update History
 * 
 * March 8: Initial creation and construction.
 * March 9: Set access permissions for the fields and added the ability to edit the password and change the point values.
 */

using SQLite;
using System.Security.Cryptography;
using System.Text;

namespace GROUP9Project.DataBase;

//Enumeration used to private setup the different roles in the sytem.
public enum UserDesignation
{
    Customer,// Customer -> The basic user type can purchase tickets and cancel them. ALl others can act as a user.
    MarketingManager,// MarketingManager -> Can decide which planes to fly on a given route.
    LoadEngineer,//LoadEngineer -> Can decide which routes to offer.
    FlightManager,//FlightManager -> Can print out flight manifests.
    Accountant,//Accountant -> Can view and print financial info for the company as a whole.
    ADMIN//ADMIN -> Cabable of all actions specified above.
}

public class User
{
    //Defines the collums of the tables, all other needed info will be fetched form other tables.
    [PrimaryKey]
    public int UserId { get; private set; }//6 Digit number between 100000 and 999999
    public string FisrtName { get; private set; }//First name of the user
    public string LastName { get; private set; }//Last name of the user
    public SHA512 Password { get; private set; }//Password transfered into a SHA-512 hash from a given string, no plain text passwords :(
    public string Address { get; set; }//User's adress
    public uint Age { get; private set; }//User's Age
    public string PhoneNumber { get; set; }//User's phone number
    public string CreditCardNumber { get; set; }//User's Credit card number, plain text for this one hehehe
    public uint Points { get; private set; }//Contains the total number of points a user has
    public UserDesignation UserType { get; private set; }//Defines what this user can do


    //Default constructor used by the database this should never be called by the main program.
    public User()
    {
        UserId = 0;
        FisrtName = string.Empty;
        LastName = string.Empty;
        Password = SHA512.Create();
        Password.ComputeHash(Encoding.UTF8.GetBytes(""));
        Address = string.Empty;
        Age = 0;
        PhoneNumber = string.Empty;
        CreditCardNumber = string.Empty;
        Points = 0;
        UserType = UserDesignation.Customer;
    }
    //Full constructor used by the program.
    public User(int uId, string fName, string lName, string pWord, string ccn, UserDesignation type, string addr, uint ag, string pn)
    {
        UserId = uId;
        FisrtName = fName;
        LastName = lName;
        Password = SHA512.Create();
        Password.ComputeHash(Encoding.UTF8.GetBytes(pWord));
        Address = addr;
        Age = ag;
        PhoneNumber = pn;
        CreditCardNumber = ccn;
        Points = 0;
        UserType = type;
    }

   /*
    * By: Spencer P. Lowery
    *
    * Date: 3/09/23
    * 
    * In: 
    *      cPass: String containing the "current" password.
    *      nPass: String containing the new password.
    *      
    * Out:
    *      0: Returned on success.
    *      1: Returned on error.
    *      
    * Function will check the supplied current password to ensure it matches the actual current password. 
    * Then on success it will set the new password for the user.
    */
    public int ChangePassword(string cPass, string nPass) 
    {
        if (cPass.Equals(nPass)) { return 1; }//If the new password and the current password are the same the opperation fails.

        //Transferes the current password into its hash
        var cPassHash = SHA512.Create();
        cPassHash.ComputeHash(Encoding.UTF8.GetBytes(cPass));

        if (!cPassHash.Equals(Password)) { return 1; }//If the current password is incorect the opperation fails

        Password.ComputeHash(Encoding.UTF8.GetBytes(nPass));//Sets the user's password to the new password.

        return 0;

    }
   /*
    * By: Spencer P. Lowery
    *
    * Date: 3/09/23
    * 
    * In: 
    *      nPoints: The number of points to be added or removed from the account.
    *      
    * Out:
    *      The number of points the account has.
    *      
    * Functions will add or remove a given number of points from an account then return the new amount of points on the account.
    */
    public uint AddPoints(uint nPoints) { Points += nPoints; return Points; }
    public uint SubPoints(uint nPoints) { Points -= nPoints; return Points; }

    public int Login(string pWord)
    {
        var cPassHash = SHA512.Create();
        cPassHash.ComputeHash(Encoding.UTF8.GetBytes(pWord));

        if (cPassHash.Equals(Password)) { return 0; }//If the current password is incorect the opperation fails
        else return 1; //If the current password checks out then 1 is retunred.
    }

}
