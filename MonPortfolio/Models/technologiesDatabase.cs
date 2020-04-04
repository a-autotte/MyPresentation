using System.Collections.Generic;
using System;

namespace MonPortfolio.Models
{
    public class technologiesDatabase
    {
        public List<technologyDetails> ObtainTechnologiesInformation()
        {
            var database = new List<technologyDetails>()
            {
                new technologyDetails() { FileName = "html", Description = "HTML is a structured langage used to build static web pages", CareerOportunity="Web Developper, Developper Full-stack", ProductionYear = DateTime.Now, UseFor="Building WebPage"},
                new technologyDetails() { FileName = "css", Description = "CSS is a style sheet language used to make page beautiful", CareerOportunity = "Web Designer", ProductionYear = DateTime.Now, UseFor = "Building WebPage"},
                new technologyDetails() { FileName = "javascript", Description = "Javascript is a dynamic langage used to build interactive web page and make them dynamic", CareerOportunity = "Game web developper", ProductionYear = DateTime.Now, UseFor = "Create game and animation on webpage"},
                new technologyDetails() { FileName = "sql", Description = "SQL is a query langage used to collect data on a web page", CareerOportunity = "Backend Developper", ProductionYear = DateTime.Now, UseFor = "Databases"}
            };

            return database;
        }
    }
}
