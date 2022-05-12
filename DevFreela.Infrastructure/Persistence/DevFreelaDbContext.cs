using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects= new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Descrição do projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Descrição do projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Descrição do projeto 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Jean Mendes", "jean@gmail.com", new DateTime(1996,11,12)),
                new User("Adriano Ferreira", "adriano@gmail.com", new DateTime(2000,01,28)),
                new User("Luis Felipe", "luis@gmail.com", new DateTime(1980,04,25)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET Core"),
                new Skill("C#"),
                new Skill("SQL")

            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
