//Capture the info about each guest
//first name, last name, message to the host
//once done, loop through each guest and print their info 
using GuestBookLibrary.Models;

List<GuestModel> guests = new List<GuestModel>();
string moreGuestsComing = "";

do
{
    GuestModel guest = new GuestModel();
    Console.Write("What is your first name: ");
    guest.FirstName = Console.ReadLine();

    Console.Write("What is your last name: ");
    guest.LastName = Console.ReadLine();

    Console.Write("What message would you like to tell your host: ");
    guest.MessageToHost = Console.ReadLine();

    Console.Write("Are more guests coming (yes/no): ");
    moreGuestsComing = Console.ReadLine();

    guests.Add(guest);

    Console.Clear();

} while (moreGuestsComing.ToLower() != "no");

foreach (GuestModel guest in guests)
{
    Console.WriteLine(guest.GuestInfo);
}

Console.ReadLine();