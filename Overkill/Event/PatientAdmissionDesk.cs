namespace Overkill.Event;

public class PatientAdmissionDesk
{
    public bool NotificationReceived = false;

    public void OnRoomAvailable(object? sender, EventArgs e)
    {
        NotificationReceived = true;
        Console.WriteLine("Patient Admission Desk: Room is available! Check the waiting list.");
    }
}