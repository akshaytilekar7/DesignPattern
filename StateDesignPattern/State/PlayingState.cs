namespace StateDesignPattern.State;

public class PlayingState : IPlayerState
{
    public IPlayerState Play(MediaPlayer player)
    {
        Console.WriteLine("Already playing.");
        return this;
    }

    public IPlayerState Pause(MediaPlayer player)
    {
        Console.WriteLine("Pausing playback.");
        return new PausedState();
    }
    public IPlayerState Stop(MediaPlayer player)
    {
        Console.WriteLine("Stopping playback.");
        return new StoppedState();
    }
}