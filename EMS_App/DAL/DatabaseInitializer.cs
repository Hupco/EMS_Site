using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace DataAccessLayer
{
    class DatabaseInitializer: DropCreateDatabaseIfModelChanges<DataContext>// Change inheritating to IfNotExists 
    {
        protected override void Seed(DataContext context)
        {
            context.Ranks.AddRange(new List<Rank>()
            {
                new Rank(){Id = 0, Name = "Chief of EMS"},
                new Rank(){Id = 1, Name = "Deputy chief of EMS"},
                new Rank(){Id = 2, Name = "Hospital Administrator"},
                new Rank(){Id = 3, Name = "Doctor"},
                new Rank(){Id = 4, Name = "Senor Paramedic II"},
                new Rank(){Id = 5, Name = "Senor Paramedic I"},
                new Rank(){Id = 6, Name = "Paramedic III"},
                new Rank(){Id = 7, Name = "Paramedic II"},
                new Rank(){Id = 8, Name = "Paramedic I"},
                new Rank(){Id = 9, Name = "EMT Advanced"},
                new Rank(){Id = 10, Name = "EMT Basic"},
                new Rank(){Id = 11, Name = "Adept"},
                new Rank(){Id = 12, Name = "Intern"}
            });

            context.Specializations.AddRange(new List<Specialization>()
            {
                new Specialization(){Id = 0, Name = "Psychologia"},
                new Specialization(){Id = 1, Name = "Patologia"},
                new Specialization(){Id = 2, Name = "Traumatologia"},
                new Specialization(){Id = 3, Name = "Weterynaria"},
                new Specialization(){Id = 4, Name = "Okulistyka"},
                new Specialization(){Id = 5, Name = "Ginekologia"},
                new Specialization(){Id = 6, Name = "Kardiochirurgia"},
                new Specialization(){Id = 7, Name = "Psychiatria"},
                new Specialization(){Id = 8, Name = "Otolaryngologia"},
                new Specialization(){Id = 9, Name = "Stomatologia"},
                new Specialization(){Id = 10, Name = "Chirurgia ogólna"},
                new Specialization(){Id = 11, Name = "Neurologia"},
                new Specialization(){Id = 12, Name = "Ortopedia"},
                new Specialization(){Id = 13, Name = "Torakochirurgia"},
                new Specialization(){Id = 14, Name = "Patomorfologia"},
            });

            context.Trainings.AddRange(new List<Training>()
            {
                new Training(){Id = 0, Name = "00"},
                new Training(){Id = 1, Name = "MRU"},
                new Training(){Id = 2, Name = "WRU"},
                new Training(){Id = 3, Name = "FRU"},
                new Training(){Id = 4, Name = "ASU"},
                new Training(){Id = 5, Name = "EOP"},
                new Training(){Id = 6, Name = "FTO"},
                new Training(){Id = 7, Name = "JFTO"},
            });

            base.Seed(context);
        }
    }
}
