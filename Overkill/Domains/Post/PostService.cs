namespace Overkill.Domains.Post;

public class PostService
{
    private readonly Dictionary<string, Person> _personDict;
    private readonly Dictionary<string, Home> _homeDict;
    private readonly Dictionary<string, Letter> _letterDict;
    private readonly Queue<ParcelPost> _parcelQueue;

    public PostService()
    {
        _personDict = new Dictionary<string, Person>();
        _homeDict = new Dictionary<string, Home>();
        _letterDict = new Dictionary<string, Letter>();
        _parcelQueue = new Queue<ParcelPost>();
    }

    public PostService(string dataFolderPath)
    {
        var peopleFilePath = Path.Combine(dataFolderPath, "People.json");
        var homesFilePath = Path.Combine(dataFolderPath, "Houses.json");
        var lettersFilePath = Path.Combine(dataFolderPath, "Letters.json");
        _personDict = Person.LoadFromFile(peopleFilePath);
        _homeDict = Home.LoadFromFile(homesFilePath);
        _letterDict = Letter.LoadFromFile(lettersFilePath);
        _parcelQueue = new Queue<ParcelPost>();
    }

    public void ProcessLetters()
    {
        foreach (var parcelPost in _letterDict.Values.Select(CreateParcelPost))
        {
            _parcelQueue.Enqueue(parcelPost);
        }
    }

    public void SaveState(string filePath)
    {
        ParcelPost.SaveToFile(_parcelQueue, filePath);
    }

    public bool AddPerson(Person person)
    {
        if (person == null || !person.Validate())
            return false;
        return _personDict.TryAdd(person.NationalCode, person);
    }

    public bool AddHome(Home home)
    {
        return home != null && _homeDict.TryAdd(home.PostalCode, home);
    }

    public bool AddLetter(Letter letter)
    {
        if (letter == null || string.IsNullOrWhiteSpace(letter.LetterId))
            return false;
        return _letterDict.TryAdd(letter.LetterId, letter);
    }

    public Queue<ParcelPost> GetParcels()
    {
        return new Queue<ParcelPost>(_parcelQueue);
    }

    private ParcelPost CreateParcelPost(Letter letter)
    {
        var sender = FindPersonByName(letter.SenderFullName);
        var receiver = FindPersonByName(letter.ReceiverFullName);

        string senderPostalCode = null;
        string receiverPostalCode = null;
        string receiverAddress = null;
        var isReturned = false;

        if (sender != null)
        {
            var senderHome = FindHomeByOwnerNationalCode(sender.NationalCode);
            if (senderHome != null)
            {
                senderPostalCode = senderHome.PostalCode;
            }
        }

        if (receiver != null)
        {
            var receiverHome = FindHomeByOwnerNationalCode(receiver.NationalCode);
            if (receiverHome != null)
            {
                receiverPostalCode = receiverHome.PostalCode;
                receiverAddress = receiverHome.Address;
            }
            else
            {
                isReturned = true;
            }
        }
        else
        {
            isReturned = true;
        }

        var name = receiver != null ? $"{receiver.FirstName} {receiver.LastName}" : null;

        var parcelPost = new ParcelPost
        {
            Letter = letter,
            Name = name,
            Address = receiverAddress,
            ReceiverPostalCode = receiverPostalCode,
            SenderPostalCode = senderPostalCode,
            IsReturned = isReturned
        };

        return parcelPost;
    }

    private Person FindPersonByName(string fullName)
    {
        return _personDict.Values.FirstOrDefault(person => $"{person.FirstName} {person.LastName}".Equals(fullName, StringComparison.OrdinalIgnoreCase));
    }

    private Home FindHomeByOwnerNationalCode(string nationalCode)
    {
        return _homeDict.Values.FirstOrDefault(home => home.OwnerNationalCode == nationalCode);
    }
}