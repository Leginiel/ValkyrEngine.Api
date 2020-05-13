using System;

namespace ValkyrEngine
{
  /// <summary>
  /// Specifies a new exception, that is thrown if a subsystem can not be activated.
  /// </summary>
  [Serializable]
  public class SubSystemActivationException : Exception
  {
    /// <summary>
    /// Returns the subsystem, that raised the exception. 
    /// </summary>
    public ISubSystem SubSystem { get; }
    /// <summary>
    /// Creates a new instance of <see cref="SubSystemActivationException"/>.
    /// </summary>
    /// <param name="message">Additional message, that should be shown.</param>
    /// <param name="subsystem">Subsystem, that caused the exception.</param>
    public SubSystemActivationException(ISubSystem subsystem, string message = "")
      : base("Subsystem could not activated: " + message)
    {
      SubSystem = subsystem;
    }
  }
}
