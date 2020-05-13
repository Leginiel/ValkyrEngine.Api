using System;

namespace ValkyrEngine.Audio.Resources
{
  /// <summary>
  /// Provides a mechanism for buffering audio data. 
  /// </summary>
  public interface IAudioBuffer : IDisposable
  {
    /// <summary>
    /// Buffers the specified data with a special audio format.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data">Data, that should be buffered.</param>
    /// <param name="format">Specified audio format fot this data.</param>
    void BufferData<T>(T[] data, BufferAudioFormat format);
  }
}