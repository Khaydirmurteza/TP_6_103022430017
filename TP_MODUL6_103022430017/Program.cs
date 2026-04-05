using System;

class SayaMusicTrack
{
    public int id;
    public string playcount;
    public string title;

    public SayaMusicTrack(string title)
    {
        this.title = title;

        Random rand = new Random();
        id = rand.Next(10000, 100000);
        playcount = "0";
    }

    public void IncreasePlayCount(int count)
    {
        int currentCount = int.Parse(playcount);
        currentCount = count;
        playcount = currentCount.ToString();
    }

    public void PrintTrackDetail()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Id Track: " + id);
        Console.WriteLine("Play Count: " + playcount);
    }

    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Masukkan nama lagu: ");
            string title = Console.ReadLine();

            SayaMusicTrack track = new SayaMusicTrack(title);

            Console.Write("Barapa banyak diputar: ");
            int count = int.Parse(Console.ReadLine());

            track.IncreasePlayCount(count);
            track.PrintTrackDetail();
        }
    }
}
