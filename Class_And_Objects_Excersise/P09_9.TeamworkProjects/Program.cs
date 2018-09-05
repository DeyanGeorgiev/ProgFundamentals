using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace P09_9.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTeams = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            Team team = new Team();
            Dictionary<string, string> teamToDisband = new Dictionary<string, string>();
            List<string> notExistTeams= new List<string>();

            for (int i = 0; i < numTeams; i++)
            {
                string[] memberClub = Console.ReadLine()
                    .Split('-');

                string member = memberClub[0];
                string club = memberClub[1];


                if (dictionary.ContainsKey(club))
                {
                    Console.WriteLine($"Team {club} was already created!");
                    continue;
                }

                if (dictionary.ContainsKey(club) == false)
                {
                    dictionary.Add(club, new List<string>());
                    team.Club = club;
                }

                dictionary[club].Add(member);


                Console.WriteLine($"Team {club} has been created by {member}!");
            }


           

            while (true)
            {
                string secInput = Console.ReadLine();
                
                if (secInput.Equals("end of assignment"))
                {
                    break;
                }

                string[] secOperation = secInput.Split("->");

                string user = secOperation[0];
                string clubing = secOperation[1];
                
                
                if (dictionary.ContainsKey(clubing) == false)
                {
                    notExistTeams.Add(clubing);
                }
                if (dictionary.ContainsKey(clubing))
                {
                    if (dictionary[clubing].Contains(user) )
                    {
                        teamToDisband.Add(user, clubing);
                        dictionary.Remove(clubing);
                    }
                    else
                    {
                        dictionary[clubing].Add(user);
                    }
                    
                }

                

               
            }

            foreach (var item in notExistTeams)
            {
                Console.WriteLine($"Team {item} does not exist!");
            }
            
            foreach (var item in teamToDisband)
            {
                Console.WriteLine($"Member {item.Key} cannot join team {item.Value}!");
            }
            
            

            foreach (var item in dictionary.OrderBy(x=> x.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine("- {0}", item.Value[0]);
                for (int i = 1; i < item.Value.Count; i++)
                {
                    Console.WriteLine("-- {0}", item.Value[i]);
                    
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamToDisband)
            {
                Console.WriteLine("{0}", item.Value);
            }
            
            
        }
    }

    class Team
    {
        public List<string> Members { get; set; }
        public string Club { get; set; }

        public Team(List<string> members, string club)
        {
            Members = members;
            Club = club;
        }

        public Team()
        {
        }
    }
}