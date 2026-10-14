namespace doxa.Shared.Models;

public class ChatMessage{
  public Guid Id {get; set;} = Guid.NewGuid();
  public string User {get; set;} = string.Empty;
  public string Content {get; set;} = string.Empty;
  public DateTime Timestamp {get; set;} = DateTime.UtcNow;

  public Guid ChannelId {get; set;}
}
