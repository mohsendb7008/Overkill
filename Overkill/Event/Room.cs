namespace Overkill.Event;

public class Room
{
    public event EventHandler? RoomAvailable;

    public void MarkRoomAvailable()
    {
        RoomAvailable?.Invoke(this, EventArgs.Empty);
    }
}