using Academy.Data;
using Academy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Transactions;


class MyApp
{
    static void Main()
    {

        var participant1 = new Individual
        {
            Id = 1,
            Name = "Ahmad Ali",
            University = "JUST",
            YearOfGraduation = 2024,
            IsIntern = false
        };

        var participant2 = new Coprate
        {
            Id = 2,
            Name = "Ahmad Ali",
            Company = "Microsoft",
            JobTitle = "Developer"
        };

        using (var context = new AppDbContext())
        {
            context.Participants.Add(participant1);
            context.Participants.Add(participant2);
            context.SaveChanges();
        }



        Console.ReadKey();
    }
}

