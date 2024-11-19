using StateDesignPattern.State;

namespace StateDesignPattern;

public class MediaPlayer
{
    private IPlayerState _currentState;

    public MediaPlayer()
    {
        _currentState = new StoppedState();
    }

    public void SetState(IPlayerState state)
    {
        _currentState = state;
    }

    public void Play() => _currentState.Play(this);
    public void Pause() => _currentState.Pause(this);
    public void Stop() => _currentState.Stop(this);
}