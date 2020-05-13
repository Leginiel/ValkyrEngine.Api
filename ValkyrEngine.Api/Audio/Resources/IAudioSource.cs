using System;
using System.Numerics;

namespace ValkyrEngine.Audio.Resources
{
  /// <summary>
  /// Provides additional information about the audio source.
  /// </summary>
  public interface IAudioSource : IDisposable
  {
    /// <summary>
    /// Defines if the audio source should automatically restart at the end. 
    /// </summary>
    bool IsLooping { get; set; }
    /// <summary>
    /// Defines if the audio source is currently playing.
    /// </summary>
    bool IsPlaying { get; }
    /// <summary>
    /// Returns the current position in the audio source. 
    /// </summary>
    float PlaybackPosition { get; }
    /// <summary>
    /// Defines the current position of the audio source.
    /// </summary>
    Vector3 Position { get; set; }
    /// <summary>
    /// Defines the direction of the audio source.
    /// </summary>
    Vector3 Direction { get; set; }
    /// <summary>
    /// Specifies additional properties of the audio source position.
    /// </summary>
    AudioPositionKind PositionKind { get; set; }
    float Gain { get; set; }
    float Pitch { get; set; }

    /// <summary>
    /// Stops the audio source playback.
    /// </summary>
    void Stop();
    void Play(IAudioBuffer buffer);
  }
}