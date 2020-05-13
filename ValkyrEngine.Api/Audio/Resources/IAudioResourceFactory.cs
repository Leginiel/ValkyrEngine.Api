namespace ValkyrEngine.Audio.Resources
{
  /// <summary>
  /// 
  /// </summary>
  public interface IAudioResourceFactory
  {
    /// <summary>
    /// Creates a new audio source object.
    /// </summary> 
    /// <returns>Returns a new audio source.</returns>
    IAudioSource CreateAudioSource();
    /// <summary>
    /// Creates a new audio buffer.
    /// </summary>
    /// <returns>Returns the new created audio buffer.</returns>
    IAudioBuffer CreateAudioBuffer();
  }
}