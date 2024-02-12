﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Projectv2.Models;

namespace Projectv2.DAL
{
        public class PublishingInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PublishingContext>
        {
            protected override void Seed(PublishingContext context)
            {
                var books = new List<Book>
{
new Book{Title="To Kill a Mockingbird", Genre="Fiction(Literary)", OriginalLanguage="English", Writer="Harper Lee", PublishingDate= DateTime.Parse("1960-01-01")},
new Book{Title="One Hundred Years of Solitude", Genre="Magical Realism, Fiction", OriginalLanguage="Spanish", Writer="Gabriel García Márquez", PublishingDate= DateTime.Parse("1967-01-01")},
new Book{Title="1984", Genre="Dystopian Fiction", OriginalLanguage="English", Writer="George Orwell", PublishingDate= DateTime.Parse("1949-01-01")},
new Book{Title="Harry Potter and the Philosopher's Stone", Genre="Fantasy", OriginalLanguage="English", Writer="J.K. Rowling", PublishingDate= DateTime.Parse("1997-01-01")},
new Book{Title="Pride and Prejudice", Genre="Romance, Classic Fiction", OriginalLanguage="English", Writer="Jane Austen", PublishingDate= DateTime.Parse("1813-01-01")},
new Book{Title="The Catcher in the Rye", Genre="Fiction (Coming-of-Age)", OriginalLanguage="English", Writer="J.D. Salinger", PublishingDate= DateTime.Parse("1951-01-01")},
new Book{Title="The Alchemist", Genre="Fiction (Philosophical)", OriginalLanguage="Portuguese", Writer="Paulo Coelho", PublishingDate= DateTime.Parse("1988-01-01")},
new Book{Title="The Diary of a Young Girl", Genre="Autobiography", OriginalLanguage="Dutch", Writer="Anne Frank", PublishingDate= DateTime.Parse("1952-01-01")},
new Book{Title="Animal Farm", Genre="Political satire", OriginalLanguage="English", Writer="George Orwell", PublishingDate= DateTime.Parse("1945-01-01")}
};
                books.ForEach(s => context.Books.Add(s));
                context.SaveChanges();
                var authors = new List<Author>
{
new Author{AuthorID=10, AmountOfBooks=10, TotalReaders="Over 500 million", Grade=Grade.A},
new Author{AuthorID=12, AmountOfBooks=60, TotalReaders="Hundreds of millions", Grade=Grade.B },
new Author{AuthorID=14, AmountOfBooks=66, TotalReaders="Over 2 billion", Grade=Grade.B},
new Author{AuthorID=16, AmountOfBooks=14, TotalReaders="Hundreds of millions", Grade=Grade.A},
new Author{AuthorID=18, AmountOfBooks=6, TotalReaders="Millions", Grade=Grade.D },
new Author{AuthorID=20, AmountOfBooks=9, TotalReaders="Tens of millions", Grade=Grade.C },
new Author{AuthorID=22, AmountOfBooks=50, TotalReaders="Millions", Grade=Grade.D}
};
                authors.ForEach(s => context.Authors.Add(s));
                context.SaveChanges();
                var genres = new List<Genre>
{
new Genre{GenreID=1, Name="Fantasy",MostPopularBook="Harry Potter and the Philosopher's Stone",MonthReaders="High, with peaks during holiday seasons and release dates of highly anticipated titles."},
new Genre{GenreID=2, Name="Mystery",MostPopularBook="The Da Vinci Code",MonthReaders="Steady throughout the year, with increased interest during summer and winter breaks."},
new Genre{GenreID=3, Name="Science Fiction",MostPopularBook="Dune",MonthReaders="Fairly consistent throughout the year, with spikes around major sci-fi conventions and movie releases."},
new Genre{GenreID=4, Name="Romance",MostPopularBook="Pride and Prejudice",MonthReaders="Consistently high, with increased interest around Valentine's Day and summer holidays."},
new Genre{GenreID=5, Name="Thriller",MostPopularBook="Gone Girl",MonthReaders="Strong throughout the year, with peaks during vacation periods and long weekends."},
new Genre{GenreID=6, Name="Historical Fiction",MostPopularBook="The Book Thief",MonthReaders="Steady, with potential increases during historical anniversaries or events."},
new Genre{GenreID=7, Name="Horror",MostPopularBook="The Shining",MonthReaders="Generally consistent, with potential spikes around Halloween."},
new Genre{GenreID=8, Name="Young Adult",MostPopularBook="The Hunger Games",MonthReaders="Strong year-round, with potential increases during school breaks and summer vacation."},
new Genre{GenreID=9, Name="Non-fiction (Biography/Memoir)",MostPopularBook="The Diary of a Young Girl",MonthReaders="Steady, with potential increases during educational periods or related events."},
new Genre{GenreID=10, Name="Literary Fiction",MostPopularBook="To Kill a Mockingbird", MonthReaders="Steady, with potential peaks during literary award seasons and book club selections."},
new Genre{GenreID=11, Name="Self-Help",MostPopularBook="The Seven Habits of Highly Effective People",MonthReaders="Steady, with potential increases at the start of the year due to New Year's resolutions."},
new Genre{GenreID=12, Name="Cookbooks",MostPopularBook="The Joy of Cooking",MonthReaders="Variable, with potential spikes around holidays and seasonal cooking trends."},
};
                genres.ForEach(s => context.Genres.Add(s));
                context.SaveChanges();
            }
        }

}
