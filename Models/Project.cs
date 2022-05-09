using System;

namespace UpdatedPortfolio.Models
{
    public class Project
    {
        // properties
        public string Name { get; set; } 
        public string Description { get; set; } 
        public string Language { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedOn { get; set; }

        // constructor 
        public Project(string name, string language, string description, DateTime createdAt, DateTime completedOn) // takes each property as a parameter
        {
            // stores each value for projects
            this.Name = name;
            this.Description = description; 
            this.Language = language;   
            this.CreatedAt = createdAt;
            this.CompletedOn = completedOn;
            
        }
        // method
        public string print() // prints project as string and uses datetime tostring
        {
            return "Project Name: " + Name + ", " + "Language: " + Language + ", " + "Description: "+ Description + ", " + "Created: " + CreatedAt.ToString("d") + ", " + "Completed: " + CompletedOn.ToString("d");
        }

    }
}
