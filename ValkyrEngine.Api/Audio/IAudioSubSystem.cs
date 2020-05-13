using ValkyrEngine.Audio.Resources;

namespace ValkyrEngine.Audio
{
  /// <summary>
  /// Specifies an subsystem for the auio module.
  /// </summary>
  public interface IAudioSubSystem : ISubSystem
  {
    /// <summary>
    /// Returns the neccessary resource factory for this subsystem.
    /// </summary>
    IAudioResourceFactory ResourceFactory { get; }
  }
}
