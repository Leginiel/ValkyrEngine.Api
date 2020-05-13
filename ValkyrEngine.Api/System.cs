using System;
using System.Collections.Generic;
using System.Linq;
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
    private List<ISubSystem> subsystems;
    /// <summary>
    /// Settings, that are used to configure the system.
    /// </summary>
    protected Settings SystemSettings { get; private set; }
    /// <summary>
    /// The underlying message system, to allow communication to other systems.
    /// </summary>
    protected IMessageSystem MessageSystem { get; }
    /// <inheritdoc/>
    public IReadOnlyList<ISubSystem> SubSystems
    {
      get => subsystems;
      internal set => subsystems = value.ToList();
    }
    /// <inheritdoc/>
    public ISubSystem ActiveSubSystem { get; internal set; }

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
      subsystems = SetupSubSystems().ToList();
      SetupMessageHandler();
    }
    /// <inheritdoc/>
    public virtual void CleanUp()
    {
      CleanUpMessageHandler();
    }

    /// <inheritdoc/>
    public void ActivateSubSystem(ISubSystem subsystem)
    {
      if (subsystem == null)
        throw new ArgumentNullException(nameof(subsystem));

      if (!subsystems.Contains(subsystem))
        throw new SubSystemActivationException(subsystem, "System is not registered");
      if (ActiveSubSystem != subsystem)
      {
        ActiveSubSystem = subsystem;
        SubSystemChanged();
      }
    }
    /// <summary>
    /// Performs additional setup routines.
    /// </summary>
    protected abstract void Setup();
    /// <summary>
    /// Initializes all avaialble Subsystems..
    /// </summary>
    protected abstract IEnumerable<ISubSystem> SetupSubSystems();
    /// <summary>
    /// Initializes all used message handler in the message system.
    /// </summary>
    protected abstract void SetupMessageHandler();
    /// <summary>
    /// Releases all used message handler in the message system.
    /// </summary>
    protected abstract void CleanUpMessageHandler();
    /// <summary>
    /// Performs all actions, that are neccessary when an subsystem changes.
    /// </summary>
    protected abstract void SubSystemChanged();
  }
}
