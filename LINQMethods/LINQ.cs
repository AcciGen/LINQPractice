using LINQPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice.LINQMethods
{
    internal class LINQ
    {
        public static void LINQHomework()
        {
            var programmingLanguages = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage(){ Id = 1, Name = "C#" },
                new ProgrammingLanguage(){ Id = 2, Name = "C++" },
                new ProgrammingLanguage(){ Id = 3, Name = "C" },
                new ProgrammingLanguage(){ Id = 4, Name = "Python" },
                new ProgrammingLanguage(){ Id = 5, Name = "Rust" },
            };

            var accountants = new List<Accountant>()
            {
                new Accountant(){ Id = 1, AName = "Den", ProgrammingLanguageId = 1 },
                new Accountant(){ Id = 2, AName = "John" },
                new Accountant(){ Id = 3, AName = "Marlow", ProgrammingLanguageId = 2 },
                new Accountant(){ Id = 4, AName = "Tom" },
                new Accountant(){ Id = 5, AName = "Johan", ProgrammingLanguageId = 5 },
                new Accountant(){ Id = 6, AName = "IbrohimTeamLead", ProgrammingLanguageId = 3 },
                new Accountant(){ Id = 7, AName = "AcciGen", ProgrammingLanguageId = 4 }
            };

            // Who Knows Programming Languages
            //var result = accountants.Join(programmingLanguages, ac => ac.ProgrammingLanguageId, pl => pl.Id, (Accountant ac, ProgrammingLanguage pl) => new { AId = ac.Id, Name = ac.AName, APL = pl.Name });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.AId + " " + item.Name + " " + item.APL);
            //}

            //
        }
    }
}
