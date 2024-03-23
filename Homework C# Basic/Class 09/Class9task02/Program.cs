using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var person = new Person
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Age = 30,
            FavoriteMusicType = Genre.Rock,
            FavoriteSongs = new List<Song>
            {
                new Song { Title = "Bohemian Rhapsody", Length = 355, Genre = Genre.Rock },
                new Song { Title = "Hotel California", Length = 391, Genre = Genre.Rock }
            }
        };

        person.GetFavSongs();
    }
}
