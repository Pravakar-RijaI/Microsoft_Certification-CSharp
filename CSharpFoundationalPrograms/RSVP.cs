using System;

namespace CSharpFoundational
{
    internal class RSVP
    {
        static int noOfGuests = 0;
        static string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
        static string[] rsvp = new string[10];
        
        public static void Main()
        {
            Rsvp("Rebecca", 1, "none", true);
            Rsvp("Nadia", 2, "Nuts", true);
            Rsvp("Linh", 2, "none", false);
            Rsvp("Tony", 1, "Jackfruit", true);
            Rsvp("Noor", 4, "none", false);
            Rsvp("Jonte", 2, "Stone fruit", false);
            displayRsvp();
        }
        
        private static void Rsvp(string name, int partySize, string allergies, bool inviteOnly)
        {
            if(inviteOnly)
            {
                bool found = false;
                
                foreach(string guest in guestList)
                {
                    if(guest.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if(!found)
                {
                    Console.WriteLine($"Sorry, {name} was not found in the guest list.");
                    return;
                }
            }
            
            rsvp[noOfGuests] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            noOfGuests++;
        }
        
        public static void displayRsvp()
        {
            foreach(string guest in rsvp)
            {
                Console.WriteLine(guest);
            }
        }
    }
}