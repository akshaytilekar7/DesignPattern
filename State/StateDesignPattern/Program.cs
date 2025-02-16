namespace StateDesignPattern;

public class Program
{
    static void Main()
    {
        var mediaPlayer = new MediaPlayer();

        mediaPlayer.Play();   // Output: Starting playback.
        mediaPlayer.Pause();  // Output: Pausing playback.
        mediaPlayer.Play();   // Output: Resuming playback.
        mediaPlayer.Stop();   // Output: Stopping playback.
        mediaPlayer.Pause();  // Output: Can't pause. Player is stopped.
    }
}