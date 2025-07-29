namespace Overkill.Event;

public class NurseStation
{
    public bool NotificationReceived = false;
    
    public void OnRoomAvailable(object? sender, EventArgs e)
    {
        NotificationReceived = true;
        Console.WriteLine("Nurse Station: Room is available! Prepare to admit a patient.");
    }
}