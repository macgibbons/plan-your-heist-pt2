using System;
using System.Collections.Generic;
using System.Linq;

namespace plan_your_heist_pt2
{
    class Program
    {
        static void Main (string[] args)
        {
            Random randy = new Random ();

            int AlarmScore = randy.Next (0, 101);
            int VaultScore = randy.Next (0, 101);
            int SecurityGuardScore = randy.Next (0, 101);
            int CashOnHand = randy.Next (500000, 1000000);

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
                            NewMember.Name = UserInputName;
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
                            NewMember.Name = UserInputName;
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
                            NewMember.Name = UserInputName;
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
            var ReconReport = new List<int> ();
            ReconReport.Add (VaultScore);
            ReconReport.Add (AlarmScore);
            ReconReport.Add (SecurityGuardScore);

            var HighestScore = ReconReport.Max (randy => randy);
            var LowestScore = ReconReport.Min (randy => randy);
            if (HighestScore == AlarmScore)
            {
                Console.WriteLine ("Highest: Alarm");
            }
            else if (HighestScore == VaultScore)
            {
                Console.WriteLine ("Highest: Vault");

            }
            else if (HighestScore == SecurityGuardScore)
            {
                Console.WriteLine ("Highest: Security");
            }
            if (LowestScore == AlarmScore)
            {
                Console.WriteLine ("Lowest: Alarm");
            }
            else if (LowestScore == VaultScore)
            {
                Console.WriteLine ("Lowest: Vault");

            }
            else if (LowestScore == SecurityGuardScore)
            {
                Console.WriteLine ("Lowest: Security");
            }
        }
    }
}