namespace WithoutStateDesignPattern;
public class MediaPlayer
{
    private MediaPlayerState _state; // Holds the current state as a string

    public MediaPlayer()
    {
        _state = MediaPlayerState.Stopped; // Initial state
    }

    public void Play()
    {
        if (_state == MediaPlayerState.Playing)
        {
            Console.WriteLine("Already playing.");
        }
        else if (_state == MediaPlayerState.Paused)
        {
            Console.WriteLine("Resuming playback.");
            _state = MediaPlayerState.Playing;
        }
        else if (_state == MediaPlayerState.Stopped)
        {
            Console.WriteLine("Starting playback.");
            _state = MediaPlayerState.Playing;
        }
    }

    public void Pause()
    {
        if (_state == MediaPlayerState.Playing)
        {
            Console.WriteLine("Pausing playback.");
            _state = MediaPlayerState.Paused;
        }
        else if (_state == MediaPlayerState.Paused)
            Console.WriteLine("Already paused.");
        else if (_state == MediaPlayerState.Stopped)
            Console.WriteLine("Can't pause. Player is stopped.");
    }

    public void Stop()
    {
        if (_state == MediaPlayerState.Playing || _state == MediaPlayerState.Stopped)
        {
            Console.WriteLine("Stopping playback.");
            _state =MediaPlayerState.Stopped;
        }
        else if (_state == MediaPlayerState.Stopped)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
