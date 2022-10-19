

//find out how to make a new tab, store common methods/operations in this tab. 
//What Variables do I need?
// 




using ABIE;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text.Json;


int Greeting()
{
    Console.WriteLine("Hello, Im AIBE. ");
    Console.WriteLine("I am an Artificial Intelligence Budget Executive");
    Console.WriteLine("My goal is to help you plan a budget.");
    Console.WriteLine("select from the following options, and confirm your selection by pressing enter.");
    Console.WriteLine("1 - New Client , 2 - Returning client , 3 -Exit program");
    int input = int.Parse(Console.ReadLine());
    return input; 
}
 
//load (decearlize) json (making a gloab list) 
var clients = new List<budgetnewclient>();
//while loop, until greeting = 3. 
switch (Greeting())
{
    case 1:
        Console.WriteLine("You've selected number 1.");
        //instanciate class
        var newclient = new budgetnewclient (); 
        //add to global list of clients.
        clients.Add (newclient);
        Console.WriteLine("Please enter your name:");
        newclient.Name = Console.ReadLine();
        //how to save ind user info for more than one client. 
    
        //save serialize json.
        break;
    case 2:
        Console.WriteLine("You've selected number 2.");// use indentifier to search gloabl list. 
        //ask for ID (name ) 
        //iterate over list or use linq (GLobal list) 
        //Print client out to screen (use auth) 
        break;
    case 3:
        Console.WriteLine("You've selected number 3.");
        break;

    /* you can have any number of case statements */
    default: /* Optional */
        Console.WriteLine("you must select from the above options");
        break;
}



//if else else or switch  (passing X to swicth statement (x is parameter)
// if input is = 1 new client (if
// x = 1 
//if input is = 2 returning clien
//t 
//if input is >3,or not an int,  error message




// new client 

int CheckPointOne()
{
    Console.WriteLine("Welcome to AIBE.");
    Console.WriteLine("I will be collecting various amounts of data from you");
    Console.WriteLine("about bills, debts, and your income. you'll need due dates and amounts for your");
    Console.WriteLine("bills and debts. if you have do not have this information and wish to revisit");
    Console.WriteLine("a later time, as a new client,  press 3. if you want to contiune, press 1.");
    int CheckPoint1 = int.Parse(Console.ReadLine());
    return CheckPoint1;
}

switch (CheckPointOne())
{
    case 1 :
        Console.WriteLine("Thank you");
        break;

    case 3 :
        Environment.Exit(0); //doesnt work (doesnt close app)
            break;
    default:
        Console.WriteLine("You must select one of the above options.");
        break;

} 



// Console.WriteLine(Lets start with some detials about you.")
// Console.WriteLine("What is your first name?")
// Last name. 
//(Lets make a 6 digit numeric pin to allow access to your client data.)
//(this pin needs to be somehting easy to remember, as you will need it for 
//authenication when you return.) 
//
//guid
//
//

// (How often do you get paid?
// How much do you typically bring home every payday?


// Thank you, Now lets move on to Bills.
// I define Bills as a constant, recurring debt, one which cannot be paid off,
// but rather billed to you on a schdueled basis. Bills are things such as utilities,
// subscriptions, phone bills, or auto insurance.

//For my planning to be as precise as possible, I will need to know some things about
//each bill you pay. I will need
// 1. A Name for the bill (make this something you will easily identify the bill with.)
// 2. The due date(s) (MM/DD/YY) (If you have a bill due bi weekly, or more than
// once a month, seperate the dates by pressing Enter)
// 3. The amount (If this bill chnages month by month, enetr an amount that reflects the
// average of this bill.)


//If you are ready to start this process, type "start"

// Console.WriteLine (Excellent, What is the name of the bill?) NameOf
// What is the due date(s) DueDate
// what is the amount?) Bal

//Perfect. Just to make sure I have all the correct information,
//you pay (nameof), 
//on the (DueDate), 
//an amount of (Bal)? 
// type yes to confirm, no to erase this data, and done to move on to debts. (this will
// start the debt class/ method.

// if yes      if else statment or switch? 
// (nameof) Confirmed. 
//Console.WriteLine confirmed.
//  else 
// (Start new bill)
//console.WriteLine OKay, Lets start over with that bill
// else 
// (error message) 
// Conosole.WriteLine (error message) 
// else 
// start debt class method. 

//Now that I have all the information about bills, next is Debts. 
// I define debts as a balance you can deflate to a zero dollar amount, 
//and either that account will be paid in full and/or no suplimentary payments would be needed. 
//Examples of such accounts are Auto loans, Mortguage loans, and revolving accounts like credit cards. 
// I will collect the same information about your Debts, as I did previously with your Bills. 

//If you are ready to start this process, type "start"

// Console.WriteLine (Excellent, What is the name of the debt?) NameOf
// What is the due date(s) DueDate
// what is the amount?) Bal
// What is the intrest rate, if any. if no intrest rate is present, type NO. (rate)

//Perfect. Just to make sure I have all the correct information.
//you pay (nameof), 
//on the (DueDate), 
//an amount of (Bal)
// with an intrest rate of (rate)


// type yes to confirm, no to erase this data, and done to move on to paycheck.. (this will
// start the paycheck class/ method.

// if yes      if else statment or switch? 
// (nameof) Confirmed. 
//Console.WriteLine confirmed.
//  else 
// (Start new debt)
//console.WriteLine OKay, Lets start over with that debt
// else 
// (error message) 
// Conosole.WriteLine (error message) 
// else 
// start paycheck class method. 



