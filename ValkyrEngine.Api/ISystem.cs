using System.Collections.Generic;

namespace ValkyrEngine
{
  /// <summary>
  /// Provides a mechanism for defininig basic engine systems.
  /// </summary>
  /// <typeparam name="Settings">Defines the <code>struct</code> that is used to describe the systems settings.</typeparam>
  public interface ISystem<in Settings> : ICleanable
    where Settings : struct
  {
    /// <summary>
    /// Returns all available sub systems. 
    /// </summary>
    IReadOnlyList<ISubSystem> SubSystems { get; }
    /// <summary>
    /// Returns the current active subsystem.
    /// </summary>
    ISubSystem ActiveSubSystem { get; }

    /// <summary>
    /// Initializes the systems and performs neccessary actions to ensure that the system can be used. 
    /// </summary>
    /// <param name="settings">Provides the settings, with whom the system should be configured.</param>
    void Setup(Settings settings);
    /// <summary>
    /// Activates the given subsystem.
    /// </summary>
    /// <param name="subsystem">Subsystem, that should be activated</param>
    void ActivateSubSystem(ISubSystem subsystem);
  }
}
