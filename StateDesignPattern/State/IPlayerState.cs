namespace StateDesignPattern.State;

public interface IPlayerState
{
    IPlayerState Play(MediaPlayer player);
    IPlayerState Pause(MediaPlayer player);
    IPlayerState Stop(MediaPlayer player);
}