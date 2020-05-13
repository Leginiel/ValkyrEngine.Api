using ValkyrEngine.Audio.Resources;

namespace ValkyrEngine.Audio
{
  /// <summary>
  /// Specifies the settings that are used to setup the audio system.
  /// </summary>
  public struct AudioSettings
  {
    /// <summary>
    /// Specifies the initial created amount of audio sources.
    /// </summary>
    public int InitialAudioSourcesCount { get; }
    /// <summary>
    /// Specifies the maximal amount of audio sources.
    /// </summary>
    public int MaximumAudioSourcesCount { get; }
    /// <summary>
    /// Specifies the audio source provider.
    /// </summary>
    public string AudioSourceProvider { get; }
    public BufferAudioFormat AudioFormat { get; set; }
  }
}