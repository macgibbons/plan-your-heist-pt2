using System;
using System.Collections.Generic;

namespace plan_your_heist_pt2
{
    class Program
    {
        static void Main (string[] args)
        {
            // In the Main method, create a List<IRobber> and store it in a variable named rolodex. 
            // This list will contain all possible operatives that we could employ for future heists. 
            // We want to give the user the opportunity to add new operatives to this list, but for now let's 
            // pre-populate the list with 5 or 6 robbers (give it a mix of Hackers, Lock Specialists, and Muscle).

            var rolodex = new List<IRobber> ();
            var garrett = new Muscle ()
            {
                Name = "Mr. Stale",
                SkillLevel = 52,
                PercentageCut = 10

            };
            var willy = new Hacker ()
            {
                Name = "Mr. Bass",
                SkillLevel = 70,
                PercentageCut = 20

            };
            var kevin = new LockPick ()
            {
                Name = "Mr. Kith",
                SkillLevel = 30,
                PercentageCut = 5

            };
            var jansen = new LockPick ()
            {
                Name = "Mr. Brazil",
                SkillLevel = 48,
                PercentageCut = 15

            };
            var steve = new Hacker ()
            {
                Name = "Mr. chortolhort",
                SkillLevel = 80,
                PercentageCut = 30

            };
            var holden = new Muscle ()
            {
                Name = "Mr. Cloud",
                SkillLevel = 30,
                PercentageCut = 5

            };

            rolodex.Add (garrett);
            rolodex.Add (steve);
            rolodex.Add (willy);
            rolodex.Add (kevin);
            rolodex.Add (holden);
            rolodex.Add (jansen);
            while (true)
            {
                Console.WriteLine ($"You currently have {rolodex.Count} crew members in your rolodex");
                Console.WriteLine ($"please add a new crew member:");
                var UserInputName = Console.ReadLine ();
                Console.Clear ();
                if (UserInputName == "")
                {
                    break;
                }
                else
                {
                    while (true)
                    {

                        Console.WriteLine ($"Please Choose a sepcialty for {UserInputName}");
                        Console.WriteLine ("----------");
                        Console.WriteLine ("Hacker (Disables alarms)");
                        Console.WriteLine ("Muscle (Disarms guards)");
                        Console.WriteLine ("Lock Specialist (cracks vault)");
                        var UserInputSpecialty = Console.ReadLine ();
                        var UserInputSkillLevl = "";
                        var UserInputPercentage = "";

                        if (UserInputSpecialty.ToLower () == "muscle")
                        {
                            Muscle NewMember = new Muscle ();
                            Console.Clear ();
                            while (true)
                            {
                                Console.WriteLine ($"Please Choose a skill level for {UserInputName} (0 - 100)");
                                UserInputSkillLevl = Console.ReadLine ();
                                try
                                {
                                    if (int.Parse (UserInputSkillLevl) <= 100)
                                    {
                                        NewMember.SkillLevel = int.Parse (UserInputSkillLevl);
                                        break;

                                    }
                                    else
                                    {
                                        Console.Clear ();
                                        Console.WriteLine ("Please keep the number under 100.");
                                        Console.WriteLine ("---------------------------------");
                                    }

                                }
                                catch (System.FormatException)
                                {
                                    Console.Clear ();
                                    Console.WriteLine ("Please enter a valid  number.");
                                    Console.WriteLine ("---------------------------------");
                                }

                            }

                            while (true)
                            {
                                Console.WriteLine ($"Please define a percentage cut for {UserInputName} (0 - 100)");
                                UserInputPercentage = Console.ReadLine ();
                                try
                                {
                                    if (int.Parse (UserInputPercentage) <= 100)
                                    {
                                        NewMember.PercentageCut = int.Parse (UserInputPercentage);
                                        break;

                                    }
                                    else
                                    {
                                        Console.Clear ();
                                        Console.WriteLine ("Please keep the number under 100.");
                                        Console.WriteLine ("---------------------------------");
                                    }

                                }
                                catch (System.FormatException)
                                {
                                    Console.Clear ();
                                    Console.WriteLine ("Please enter a valid  number.");
                                    Console.WriteLine ("---------------------------------");
                                }

                            }
                            rolodex.Add (NewMember);
                            break;
                        }
                        else if (UserInputSpecialty.ToLower () == "hacker")
                        {
                            Hacker NewMember = new Hacker ();
                            while (true)
                            {
                                Console.WriteLine ($"Please Choose a skill level for {UserInputName} (0 - 100)");
                                UserInputSkillLevl = Console.ReadLine ();
                                try
                                {
                                    if (int.Parse (UserInputSkillLevl) <= 100)
                                    {
                                        NewMember.SkillLevel = int.Parse (UserInputSkillLevl);
                                        break;

                                    }
                                    else
                                    {
                                        Console.Clear ();
                                        Console.WriteLine ("Please keep the number under 100.");
                                        Console.WriteLine ("---------------------------------");
                                    }

                                }
                                catch (System.FormatException)
                                {
                                    Console.Clear ();
                                    Console.WriteLine ("Please enter a valid  number.");
                                    Console.WriteLine ("---------------------------------");
                                }

                            }

                            while (true)
                            {
                                Console.WriteLine ($"Please define a percentage cut for {UserInputName} (0 - 100)");
                                UserInputPercentage = Console.ReadLine ();
                                try
                                {
                                    if (int.Parse (UserInputPercentage) <= 100)
                                    {
                                        NewMember.PercentageCut = int.Parse (UserInputPercentage);
                                        break;

                                    }
                                    else
                                    {
                                        Console.Clear ();
                                        Console.WriteLine ("Please keep the number under 100.");
                                        Console.WriteLine ("---------------------------------");
                                    }

                                }
                                catch (System.FormatException)
                                {
                                    Console.Clear ();
                                    Console.WriteLine ("Please enter a valid  number.");
                                    Console.WriteLine ("---------------------------------");
                                }

                            }

                            rolodex.Add (NewMember);
                            break;
                        }
                        else if (UserInputSpecialty.ToLower () == "lock specialist")
                        {
                            LockPick NewMember = new LockPick ();
                            while (true)
                            {
                                Console.WriteLine ($"Please Choose a skill level for {UserInputName} (0 - 100)");
                                UserInputSkillLevl = Console.ReadLine ();
                                try
                                {
                                    if (int.Parse (UserInputSkillLevl) <= 100)
                                    {
                                        NewMember.SkillLevel = int.Parse (UserInputSkillLevl);
                                        break;

                                    }
                                    else
                                    {
                                        Console.Clear ();
                                        Console.WriteLine ("Please keep the number under 100.");
                                        Console.WriteLine ("---------------------------------");
                                    }

                                }
                                catch (System.FormatException)
                                {
                                    Console.Clear ();
                                    Console.WriteLine ("Please enter a valid  number.");
                                    Console.WriteLine ("---------------------------------");
                                }

                            }

                            while (true)
                            {
                                Console.WriteLine ($"Please define a percentage cut for {UserInputName} (0 - 100)");
                                UserInputPercentage = Console.ReadLine ();
                                try
                                {
                                    if (int.Parse (UserInputPercentage) <= 100)
                                    {
                                        NewMember.PercentageCut = int.Parse (UserInputPercentage);
                                        break;

                                    }
                                    else
                                    {
                                        Console.Clear ();
                                        Console.WriteLine ("Please keep the number under 100.");
                                        Console.WriteLine ("---------------------------------");
                                    }

                                }
                                catch (System.FormatException)
                                {
                                    Console.Clear ();
                                    Console.WriteLine ("Please enter a valid  number.");
                                    Console.WriteLine ("---------------------------------");
                                }

                            }
                            rolodex.Add (NewMember);
                            break;
                        }
                        else
                        {
                            Console.Clear ();
                            Console.WriteLine ("**** Please enter a valid specialty ****");
                        }

                    }
                }

            }

        }
    }
}