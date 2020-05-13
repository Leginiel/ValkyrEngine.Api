namespace ValkyrEngine.Audio.Resources
{
  /// <summary>
  /// Defines the position, where the sound is played.
  /// </summary>
  public enum AudioPositionKind
  {
    /// <summary>
    /// Uses a fixed world position to play the sounds. 
    /// </summary>
    AbsoluteWorld,
    /// <summary>
    /// Uses a position relative to the audio listener.
    /// </summary>
    ListenerRelative
  }
}