namespace ValkyrEngine.MessageSystem
{
  public interface IActionMessage : IMessage
  {
    ActionTypes ActionType { get; }
  }
}
