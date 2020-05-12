namespace ValkyrEngine.MessageSystem
{
  /// <summary>
  /// Specifies an message, that executes a specific action on the receiving system.
  /// </summary>
  public interface IActionMessage : IMessage
  {
    /// <summary>
    /// Type of the action, that should be performed.
    /// </summary>
    ActionTypes ActionType { get; }
  }
}
