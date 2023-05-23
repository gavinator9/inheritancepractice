using System.Runtime.CompilerServices;

// Gavin Elliott
// IT112
// NOTES: what's funny is the only screwup that ended up taking me time to figure out was something silly, I couldnt figure out how I messed up my
//for loop for like 15 minutes lol
// BEHAVIORS NOT IMPLIMENTED AND WHY: content complete as far as I can tell 

namespace Elliott_RoboDialer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phone[] directory = new phone[10];

            directory[0] = new homephone("(303) 985-5060", "CompuTest",1);
            directory[1] = new cellphone("(603) 532-4123", "Curtis Manufacturing",2);
            directory[2] = new homephone("(800) 876-2524", "Data Functions",1);
            directory[3] = new homephone("(708) 397-3330", "Donnay Repair",1);
            directory[4] = new homephone("(360) 434-3894", "ErgoNomic Inc", 1);
            directory[5] = new homephone("(800) 969-4374", "ErgoSource", 1);
            directory[6] = new cellphone("(800) 874-8527", "Fox Bay Industries",2);
            directory[7] = new cellphone("(800) 545-6254", "Glare-Guard",2);
            directory[8] = new cellphone("(407) 783-6641", "Hazard Comm Specialists",2);
            directory[9] = new cellphone("(714) 472-4409", "Komfort Support",2);


            for (int i=0; i < directory.Length;i++) 
            {
                Console.WriteLine(directory[i].dial());
            }
        }
    }
}