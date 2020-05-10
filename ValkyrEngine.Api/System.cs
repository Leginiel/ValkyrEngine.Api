using ValkyrEngine.MessageSystem;

namespace ValkyrEngine
{
  public abstract class System<Settings> : ISystem<Settings>
    where Settings : struct
  {
    protected Settings SystemSettings { get; private set; }
    protected IMessageSystem MessageSystem { get; }

    protected System(IMessageSystem messageSystem)
    {
      MessageSystem = messageSystem;
    }

    public virtual void Setup(Settings settings)
    {
      SystemSettings = settings;
      Setup();
      SetupMessageHandler();
    }
    public void Dispose()
    {
      CleanUpMessageHandler();
      CleanUp();
    }

    protected abstract void Setup();
    protected abstract void SetupMessageHandler();
    protected abstract void CleanUp();
    protected abstract void CleanUpMessageHandler();
  }
}
