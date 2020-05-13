using System.Numerics;

namespace ValkyrEngine.Audio.Resources
{
  /// <summary>
  /// Provides a mechanism for handling audio data and managing audio related hardware.
  /// </summary>
  public interface IAudioEngine
  {
    /// <summary>
    /// Set the audio listener position.
    /// </summary>
    /// <param name="position">New position of the audio listener</param>
    void SetListenerPosition(Vector3 position);
    /// <summary>
    /// Set the audio listener orientation.
    /// </summary>
    /// <param name="forward">New forward orientation of the audio listener</param>
    /// <param name="up">New up orientation of the audio listener</param>
    void SetListenerOrientation(Vector3 forward, Vector3 up);
  }
}
