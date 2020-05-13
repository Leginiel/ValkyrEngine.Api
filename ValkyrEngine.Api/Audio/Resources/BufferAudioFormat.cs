namespace ValkyrEngine.Audio.Resources
{
  /// <summary>
  /// Defines the supported audio formats. 
  /// </summary>
  public enum BufferAudioFormat
  {
    /// <summary>
    /// Uses the format, which is considered using a single channel and 8 bits. 
    /// </summary>
    Mono8,
    /// <summary>
    /// Uses the format, which is considered using a single channel and 16 bits.
    /// </summary>
    Mono16,
    /// <summary>
    /// Uses the format, which is considered using two channels and 8 bits.
    /// </summary>
    Stereo8,
    /// <summary>
    /// Uses the format, which is considered using two channels and 16 bits.
    /// </summary>
    Stereo16
  }
}