using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;




//FakeCMD by Lecter 
//BhenchodForums: https://bhenchod.org
//Users may modify this program to add additional functionality,
//but must not remove this header.

//Official Repository: https://github.com/Dr-lecter/

namespace FakeCmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft Windows [Version 10.0.18363.815]");
            Console.WriteLine("(c) 2019 Microsoft Corporation. All Rights Reserved");
            
            Start:
            Console.Write("C:\\");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "netstat":
                Console.WriteLine("Network Connected, Detecting Foreign IP's...");
                Thread.Sleep(2000);
                Console.WriteLine("Please Wait...");
                Thread.Sleep(1000);
                Console.WriteLine("Network Scan Complete");
                Console.WriteLine("Foreign Hackers Found: 0");             
                Console.WriteLine("Network Infections Found: 0");
                Console.WriteLine("Foreign IP's Found: 0");
                Console.WriteLine("Critical System Infrastructure Status: Good");
                Console.WriteLine("Indian Tech Support Scammers: 1");
                goto Start;
                    
                case "ipconfig":
                Console.WriteLine("Network Connected, Detecting Foreign IP's...");
                Thread.Sleep(2000);
                Console.WriteLine("Please Wait...");
                Thread.Sleep(1000);
                Console.WriteLine("Network Scan Complete");
                Console.WriteLine("Foreign Hackers Found: 0");             
                Console.WriteLine("Network Infections Found: 0");
                Console.WriteLine("Foreign IP's Found: 0");
                Console.WriteLine("Critical System Infrastructure Status: Good");
                Console.WriteLine("Indian Tech Support Scammers: 1");
                goto Start;

                case "dir /s":
                Console.Write("Scanning Directories for Viruses..");
                Thread.Sleep(500);
                Console.Write("..");
                Thread.Sleep(500);
                Console.Write("..");
                Thread.Sleep(500);
                Console.Write("..");
                Thread.Sleep(500);
                Console.WriteLine("..");
                Thread.Sleep(500);
                Console.WriteLine("All Windows directories have been successfully scanned. Please wait while we compile a list of results.");
                Thread.Sleep(500);
                Console.WriteLine("Compiling...");
                Thread.Sleep(5000);
                Console.WriteLine("All Systems Operational");
                Console.WriteLine("Security Service Status: OK");
                Console.WriteLine("Network Security: OK");
                Console.WriteLine("Microsoft Secure Server: Connected");
                Console.WriteLine("Foreign Connections: 0");
                Console.WriteLine("No Issues Found!");
                goto Start;
                
                case "tree":
                Console.Write("Scanning");
                Thread.Sleep(1000);
                Console.Write("..");
                Thread.Sleep(1000);
                Console.Write("..");
                Thread.Sleep(1000);
                Console.WriteLine("..");
                Thread.Sleep(1000);
                Console.WriteLine("We're having some trouble reaching the Secure Serwer right now. Please try again later");
                Thread.Sleep(500);
                Console.WriteLine("No Viruses, Foreign Hackers, or Malicious Software Found!!!");
                goto Start;

                case "help":
                Console.WriteLine("Here's a list of valid commands, and their functions");
                Console.WriteLine("Loading List...");
                Thread.Sleep(2000);
                Console.WriteLine("Actually, there's no list. I'm a lazy fuck, maybe it'll be on the next update, maybe it wont.");
                Console.WriteLine("Also, Fuck you. Scamming piece of shit.");
                goto Start;

                case "about":
                 Console.WriteLine("FakeCMD V1.0 by Lecter");
                 Console.WriteLine("Bhenchod Forums: https://bhenchod.org");
                 Console.WriteLine("Lecter's Personal: https://lecter.co");
                 Console.WriteLine("This project is mostly for my own pleasure, I might update it occasionally. If you've got suggestions for a new feature, or if you've found a bug let me know in the Suggestions section of BhenchodForums.");
                 goto Start;
              
                case "scammer":
                 Console.Write("Detecting Tech Support Scammers. Please Standby.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.WriteLine("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("WARNING!!! SCAMMER DETECTED");
                 Console.WriteLine("Scammer Location: INDIA");
                 Thread.Sleep(2000);
                 Console.WriteLine("Scammers IP, Connection Status, and Personal Information have been detected and forwarded to the Indian Cybercrime Police");
                 goto Start;

                default:
                 Console.WriteLine("I'm Sorry, that's not a valid command");
                 Console.WriteLine("");
                 Console.WriteLine("For a list of commands please type 'help'");
                 goto Start;
            
            }
        }
    }
}
