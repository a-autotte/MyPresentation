using System.Collections.Generic;
using System;

namespace MonPortfolio.Models
{
    public class Database
    {
        public List<CapabilityModel> ListCapabilities { get; set; }

        public Database()
        {
            ListCapabilities = new List<CapabilityModel>();

            ListCapabilities.Add(new CapabilityModel() { TechnologyName = "CSharp", UrlImageSource = "/images/csharp.png", SkillId = 1, TechnologyDescription = "CSharp est un langage orienté objet"});
            ListCapabilities.Add(new CapabilityModel() { TechnologyName = "ASP", UrlImageSource = "/images/aspnet.png", SkillId = 2, TechnologyDescription = "ASP est un framework utilisé avec des pages Razor pour éviter la répétition du HTML dans les pages Web"});
            ListCapabilities.Add(new CapabilityModel() { TechnologyName = "Git", UrlImageSource = "/images/git.png", SkillId = 3, TechnologyDescription = "Git est un service où tu peux mettre des projets sur un serveur nommée Github le monde peuvent modifier le code source, voir et ainsi de suite." });
        }
    }
}
