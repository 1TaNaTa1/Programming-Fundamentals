using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    public class Team
    {
        public Team(string name, string teamCreator)
        {
            this.Name = name;
            this.TeamCreator = teamCreator;

            Members = new List<string>();
        }

        public string Name { get; set; }

        public string TeamCreator { get; set; }

        public List<string> Members { get; set; }

        public string DoesContain(string candidate)
        {
            if (this.Members.Contains(candidate) || this.TeamCreator == candidate)
            {
                return candidate;
            }
            
            return null;
        }

        public override string ToString()
        {
            string members = string.Empty;

            foreach (string member in this.Members.OrderBy(x => x))
            {
                members += Environment.NewLine;
                members += $"-- {member}";
            }

            string result = $"{this.Name}{Environment.NewLine}"
                + $"- {this.TeamCreator}"
                + members;

            return result;
        }
    }
}
