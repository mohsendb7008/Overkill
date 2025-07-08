namespace Overkill.Exception;

public class InvalidArgumentException(string reason) : System.Exception(reason);