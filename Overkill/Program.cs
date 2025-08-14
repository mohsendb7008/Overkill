using Overkill.Domains.Event;

var room = new Room();
var nurseStation = new NurseStation();
var patientAdmissionDesk = new PatientAdmissionDesk();

room.RoomAvailable += nurseStation.OnRoomAvailable;
room.RoomAvailable += patientAdmissionDesk.OnRoomAvailable;

room.MarkRoomAvailable();

room.RoomAvailable -= patientAdmissionDesk.OnRoomAvailable;
room.RoomAvailable -= nurseStation.OnRoomAvailable;