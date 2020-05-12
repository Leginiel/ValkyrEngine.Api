using System.Diagnostics.CodeAnalysis;
using ValkyrEngine.MessageSystem;

namespace ValkyrEngine
{
  /// <summary>
  /// Provides a base class for implementing engine systems.
  /// </summary>
  /// <typeparam name="Settings">Defines the <code>struct</code> that is used to describe the systems settings.</typeparam>
  public abstract class System<Settings> : ISystem<Settings>
    where Settings : struct
  {
    /// <summary>
    /// Settings, that are used to configure the system.
    /// </summary>
    [ExcludeFromCodeCoverage]
    protected Settings SystemSettings { get; private set; }
    /// <summary>
    /// The underlying message system, to allow communication to other systems.
    /// </summary>
    [ExcludeFromCodeCoverage]
    protected IMessageSystem MessageSystem { get; }

    /// <summary>
    /// Creates a new instance of the <see cref="System"/>-object.
    /// </summary>
    /// <param name="messageSystem">Underlying message system, which should be used to communicate.</param>
    protected System(IMessageSystem messageSystem)
    {
      MessageSystem = messageSystem;
    }
    /// <inheritdoc/>
    public virtual void Setup(Settings settings)
    {
      SystemSettings = settings;
      Setup();
      SetupMessageHandler();
    }
    /// <inheritdoc/>
    public virtual void CleanUp()
    {
      CleanUpMessageHandler();
    }
    /// <summary>
    /// Performs additional setup routines.
    /// </summary>
    protected abstract void Setup();
    /// <summary>
    /// Initializes all used message handler in the message system.
    /// </summary>
    protected abstract void SetupMessageHandler();
    /// <summary>
    /// Releases all used message handler in the message system.
    /// </summary>
    protected abstract void CleanUpMessageHandler();
  }
}
