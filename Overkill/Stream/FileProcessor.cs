namespace Overkill.Stream;

public static class FileProcessor
{
    public static void ProcessFile(string inputFile, string outputFile)
    {
        var inputStream = new FileStream(inputFile, FileMode.Open);
        var outputStream = new FileStream(outputFile, FileMode.Create);
        ProcessStreams(inputStream, outputStream);
        inputStream.Close();
        outputStream.Close();
    }

    private static void ProcessStreams(System.IO.Stream inputStream, System.IO.Stream outputStream)
    {
        var buffer = new byte[1024];
        while (true)
        {
            var bytesRead = inputStream.Read(buffer, 0, buffer.Length);
            if (bytesRead == 0)
                break;
            var text = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
            var processedText = ProcessText(text);
            System.Text.Encoding.UTF8.GetBytes(processedText, 0, processedText.Length, buffer, 0);
            outputStream.Write(buffer, 0, bytesRead);
        }
    } 

    private static string ProcessText(string input)
    {
        return input.ToUpper();
    }
}
