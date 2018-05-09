using System;

public class Song
{
    public Song(string artistName, string songName, int mm,int ss)
    {
        ArtistName = artistName;
        SongName = songName;
        SongLenghtMinutes = mm;
        SongLenghtSeconds = ss;
    }

    private string artistName;

    public string ArtistName
    {
        get { return artistName; }
        set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }
    }

    private string songName;

    public string SongName
    {
        get { return songName; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            songName = value;
        }
    }

    private int songLenghtMinutes;

    public int SongLenghtMinutes
    {
        get { return songLenghtMinutes; }
        set
        {
            if (value < 0 || value > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            songLenghtMinutes = value;
        }
    }

    private int songLenghtSeconds;

    public int SongLenghtSeconds
    {
        get { return songLenghtSeconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            songLenghtSeconds = value;
        }
    }
}
