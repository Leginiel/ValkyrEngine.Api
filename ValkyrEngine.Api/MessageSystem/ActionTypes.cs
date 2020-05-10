namespace ValkyrEngine.MessageSystem
{
  /// <summary>
  /// Specifies all action types, that can be used in an <seealso cref="IActionMessage"/>.
  /// </summary>
  public enum ActionTypes
  {
    /// <summary>
    /// Registers some resources on the target system.
    /// </summary>
    Registration,
    /// <summary>
    /// Releases som registered resources from the target system.
    /// </summary>
    Deregistration
  }
}