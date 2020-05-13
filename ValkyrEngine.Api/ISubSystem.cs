namespace ValkyrEngine
{
  /// <summary>
  /// Provides a mechanism for defininig basic engine subsystems.
  /// </summary>
  public interface ISubSystem
  {
    /// <summary>
    /// Name of the subsystem.
    /// </summary>
    string Name { get; }
  }
}
