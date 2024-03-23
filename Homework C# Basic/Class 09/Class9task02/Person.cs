public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Genre FavoriteMusicType { get; set; }
    public List<Song> FavoriteSongs { get; set; }

    public void GetFavSongs()
    {
        if (FavoriteSongs == null || FavoriteSongs.Count == 0)
        {
            Console.WriteLine($"{FirstName} {LastName} hates music.");
        }
        else
        {
            Console.WriteLine($"{FirstName} {LastName}'s favorite songs:");
            foreach (var song in FavoriteSongs)
            {
                Console.WriteLine($"{song.Title} - {song.Genre}");
            }
        }
    }
}
