public class Song
{
    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        Song slowStep = this;
        Song fastStep = this;
        while (fastStep != null && fastStep.NextSong != null)
        {
            slowStep = slowStep.NextSong;
            fastStep = fastStep.NextSong.NextSong;

            if (slowStep == fastStep)
            {
                return true;
            }
        }
        return false;
    }

    //public static void Main(string[] args)
    //{
    //    Song first = new Song("Hello");
    //    Song second = new Song("Eye of the tiger");

    //    first.NextSong = second;
    //    second.NextSong = first;

    //    Console.WriteLine(first.IsRepeatingPlaylist());
    //}
}