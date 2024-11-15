using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using UpdatedPortfolio.Models; // calls the project class in the model folder

namespace UpdatedPortfolio.Pages
{
    public class IndexModel : PageModel
    {
        // properties
        public string Description1 { get; set; } = string.Empty; // string initialized empty to not be considered possibly null 
        public string Description2 { get; set; } = string.Empty; // string initialized empty to not be considered possibly null 
        public string PhoneNumber { get; set; } = string.Empty; // string initialized empty to not be considered possibly null 
        public string Email { get; set; } = string.Empty; // string initialized empty to not be considered possibly null 
        public List<Project> Projects { get; set; } = new List<Project>(); // list  of project objects 
        private readonly ILogger<IndexModel> _logger;

        // contructor
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // methods
        public void OnGet() // when GET requested, it will return these members back
        {
            // separating descriptions into short paragraphs to have better design
            this.Description1 = @"C:\Users\George> Hi, I'm George and welcome to my online portfolio. I'm a recent graduate of the 
                State University of New York at Albany. I have approximately 4 years of educational knowledge in Computer
                Science, and acquired my Bachelor of Science.";
            this.Description2 = @"Personally I enjoy working with C#, and ASP.NET 6 for web applications. 
                For front-end I feel comfortable working with HTML, CSS3, Bootstrap4. I do plan on learning either javascript
                or python for more frontend duties. As for backend I like using C#, ASP.NET, Entity Framework and the MS MYSQL sever.";
            this.Email = "tackie.george89@gmail.com";
            this.PhoneNumber = "1 (845) 270 - 5941";
            this.Projects = new List<Project>() // each arguement is details of my previous projects
            {
                new Project(
                "Skiasharp Drawing Application",
                "C#",
                "Visual App that can be used to create Flowchart Diagrams, Business diagrams, and UML diagrams",
                new DateTime(2021, 1, 10),
                new DateTime(2021, 5, 17)
                ),
                new Project(
                "Itiner-Buddy Bot",
                "Python",
                "Itiner-Buddy provides faster, more efficient and easier ways to schedule and manage meetings and record meeting results in Discord's channels",
                new DateTime(2021, 1, 10),
                new DateTime(2021, 5, 17)
                ),
                new Project(
                "Software Computer Hardware",
                "Java",
                "A software version of how hardware is implemented for the builds of computers, learning the use of Bits, ALU, Memory, Instruction Stack and Registers",
                new DateTime(2021, 9, 19),
                new DateTime(2021, 12, 17)
                ),
                new Project(
                "tic-tac-toe",
                "C++",
                "A simple implementation of the classic game of tic-tac-toe, using arrays and hashmaps",
                new DateTime(2022, 3, 24),
                new DateTime(2022, 3, 25)
               )
            };
        }
        // methods using linq to find each project 
        // using print method from project to convert each proejct to strings
        public string SDA() 
        {
            var sda = Projects.Find(x => x.Name == "Skiasharp Drawing Application");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return sda.print();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        public string IBB()
        {
            var ibb = Projects.Find(x => x.Name == "Itiner-Buddy Bot");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return ibb.print();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        public string SCHI()
        {
            var schi = Projects.Find(x => x.Name == "Software Computer Hardware");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return schi.print();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
        public string TTT()
        {
            var ttt = Projects.Find(x => x.Name == "tic-tac-toe");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            return ttt.print();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}