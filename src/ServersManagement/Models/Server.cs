namespace ServersManagement.Models;

public class Server
{

    public Server()
    {
        Random random = new();
        IsOnline = random.Next(0, 2) == 1;
    }

    public int ServerId { get; set; }

    public bool IsOnline { get; set; }

    public string? Name { get; set; }

    public string? City { get; set; }
}
