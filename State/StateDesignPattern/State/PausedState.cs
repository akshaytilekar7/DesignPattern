namespace StateDesignPattern.State;

public class PausedState : IPlayerState
{
    public IPlayerState Play(MediaPlayer player)
    {
        Console.WriteLine("Resuming playback.");
        return new PlayingState();
    }
    public IPlayerState Pause(MediaPlayer player)
    {
        Console.WriteLine("Already paused.");
        return this;
    }

    public IPlayerState Stop(MediaPlayer player)
    {
        Console.WriteLine("Stopping playback.");
        return new StoppedState();
    }
}