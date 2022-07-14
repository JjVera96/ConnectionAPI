using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionAPI.Models
{
    public class NBAPlayer
    {
        public NBAPlayer(string id, string firstName, string heightFeet, string heightInches, string lastName, string position, NBATeam team, string weight_Pounds)
        {
            Id = id;
            FirstName = firstName;
            HeightFeet = heightFeet;
            HeightInches = heightInches;
            LastName = lastName;
            Position = position;
            Team = team;
            Weight_Pounds = weight_Pounds;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("height_feet")]
        public string HeightFeet { get; set; }

        [JsonProperty("height_inches")]
        public string HeightInches { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("team")]
        public NBATeam Team { get; set; }

        [JsonProperty("weight_pounds")]
        public string Weight_Pounds { get; set; }

    }
}
