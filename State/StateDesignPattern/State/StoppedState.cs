namespace StateDesignPattern.State;

public class StoppedState : IPlayerState
{
    public IPlayerState Play(MediaPlayer player)
    {
        Console.WriteLine("Starting playback.");
        return new PlayingState();
    }
    public IPlayerState Pause(MediaPlayer player)
    {
        Console.WriteLine("Can't pause. Player is stopped.");
        return this;
    }
    public IPlayerState Stop(MediaPlayer player)
    {
        Console.WriteLine("Already stopped.");
        return this;
    }
}