﻿using System;
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

//Branch edition by Activate Me/yishundaodi

namespace C:\WINDOWS\system32\cmd.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft Windows [Version 10.0.80081.35]");
            Console.WriteLine("(c) 2019 Microsoft Corporation. All Rights Reserved.");
            
            Start:
            Console.Write("C:\WINDOWS\bin:~#");

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
				 Console.WriteLine("     ccee88oo");
				 Console.WriteLine("  C8O8O8Q8PoOb o8oo");
				 Console.WriteLine(" dOB69QO8PdUOpugoO9bD");
				 Console.WriteLine("CgggbU8OU qOp qOdoUOdcb");
				 Console.WriteLine("    6OuU  /p u gcoUodpP");
				 Console.WriteLine("      \\\//  /douUP");
				 Console.WriteLine("        \\\////");
				 Console.WriteLine("         |||/.|");
				 Console.WriteLine("         |||\^/");
				 Console.WriteLine("         |||||");
				 Console.WriteLine("   .....//||||\....");
                 goto Start;

                case "help":
                 Console.WriteLine("Here's a list of valid commands, and their functions");
                 Console.WriteLine("Loading List...");
                 Thread.Sleep(2000);
                 Console.WriteLine("Stop scamming people");
                 Console.WriteLine("Return all the money you stole");
                 Console.WriteLine("Turn yourself into the police");
                 Console.WriteLine("Snitch on the rest of you scammers at your call centre");
                 Console.WriteLine("Tell your parents this is your job");
                 Console.WriteLine("Hand over your accounts");
                 Console.WriteLine("Tell your boss to get a real job");
                 Console.WriteLine("Get a real job yourself");
                 Console.WriteLine("Have Jim Browning come after you");
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

                case "systeminfo":
                 Console.WriteLine("Loading processor information on scammer.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Loading OS Build information on scammer.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Loading user information on scammer.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Loading boot information on scammer.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Loading BIOS information on scammer.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Loading information for reverse hacking.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Loading syskey lock.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Looks like your hardware is good to go!");
                 Thread.Sleep(2000);
                 Console.WriteLine("Oh no! The scammer's hardware is going to die in 4 days!");
                 goto Start;
            
                case "cd":
                 Console.WriteLine("Initializing.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Stopping programs using A:.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
				 Console.WriteLine("The CD/DVD has been ejected successfully! You may now take it out of the bay.");
                 Thread.Sleep(1000);
                 goto Start;
				 
                case "cd ":
                 Console.WriteLine("Initializing.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Stopping programs using A:.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
				 Console.WriteLine("The CD/DVD has been ejected successfully! You may now take it out of the bay.");
                 Thread.Sleep(1000);
                 goto Start;
				 
				case "cd. .":
                 Console.WriteLine("Initializing.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Stopping programs using A:.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
				 Console.WriteLine("The CD/DVD has been ejected successfully! You may now take it out of the bay.");
                 Thread.Sleep(1000);
                 goto Start;

                case "cd..":
                 Console.WriteLine("Initializing.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Stopping programs using A:.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
				 Console.WriteLine("The CD/DVD has been ejected successfully! You may now take it out of the bay.");
                 Thread.Sleep(1000);
                 goto Start;

				case "cd...":
                 Console.WriteLine("Initializing.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("Stopping programs using A:.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
				 Console.WriteLine("The CD/DVD has been ejected successfully! You may now take it out of the bay.");
                 Thread.Sleep(1000);
                 goto Start;
				 
                case "run":
                 Console.WriteLine("There is nowhere you can run");
                 Thread.Sleep(500);
                 Console.WriteLine("There is nowhere you can hide");
				 Thread.Sleep(500);
                 Console.Write("Reporting location to local police");
                 Thread.Sleep(500);
                 Console.Write("Expect the police to arrive in 5 minutes!");
                 Thread.Sleep(500);
                 Console.WriteLine("Scammer Location: INDIA");
                 Thread.Sleep(2000);
                 goto Start;

                case "hack":
                 Console.WriteLine("Exploiting MS17-010 EternalBlue CVE2017-0144.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
                 Console.WriteLine("The exploit was successful. Session established.");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(500);
                 Console.Write("..");
                 Thread.Sleep(1000);
				 Console.WriteLine("You may now connect to the scammer's PC.");
                 Thread.Sleep(1000);
                 goto Start;
				 
                case "manage-bde -status":
                 Console.WriteLine("BitLocker Drive Encryption: Configuration Tool version 10.0.80081.35");
				 Console.WriteLine("Copyright (C) 2019 Microsoft Corporation. All rights reserved.");
				 Thread.Sleep(6000);
				 Console.WriteLine(" ");
				 Console.WriteLine("Disk volumes that can be protected with");
				 Console.WriteLine("BitLocker Drive Encryption:");
				 Console.WriteLine("Volume C: []");
				 Console.WriteLine("[OS Volume]");
				 Console.WriteLine(" ");
				 Console.WriteLine("    Size:                 31.84 GB");
				 Console.WriteLine("    BitLocker Version:    2.0");
				 Console.WriteLine("    Conversion Status:    Fully Encrypted");
				 Console.WriteLine("    Percentage Encrypted: 100.0%");
				 Console.WriteLine("    Encryption Method:    XTS-AES 256");
				 Console.WriteLine("    Protection Status:    Protection On");
				 Console.WriteLine("    Lock Status:          Locked");
				 Console.WriteLine("    Identification Field: Local Computer");
				 Console.WriteLine("    Key Protectors:");
				 Console.WriteLine("        Numerical Password");
				 Console.WriteLine("        TPM");
				 Console.WriteLine("");
                 goto Start;
				 
			    default:
                 Console.WriteLine("I'm sorry, that's not a valid command");
                 Console.WriteLine("");
                 Console.WriteLine("For a list of commands please type 'help'");
                 goto Start;
			
            }
        }
    }
}
