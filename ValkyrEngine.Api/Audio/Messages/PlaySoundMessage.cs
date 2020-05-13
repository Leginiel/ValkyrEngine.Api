using System.Numerics;
using ValkyrEngine.Assets.Audio;
using ValkyrEngine.Audio.Resources;
using ValkyrEngine.MessageSystem;

namespace ValkyrEngine.Audio.Messages
{
  public struct PlaySoundMessage : IMessage
  {
    public IAudioAsset Asset { get; }
    public float Volume { get; }
    public float Pitch { get; }
    public Vector3 Position { get; }
    public AudioPositionKind AudioPositionKind { get; }


    public PlaySoundMessage(IAudioAsset asset)
      : this(asset, 1f) { }

    public PlaySoundMessage(IAudioAsset asset, float volume, float pitch = 1f)
      : this(asset, volume, pitch, Vector3.Zero, AudioPositionKind.ListenerRelative) { }
    public PlaySoundMessage(IAudioAsset asset, float volume, float pitch, Vector3 position, AudioPositionKind audioPositionKind)
    {
      Asset = asset;
      Volume = volume;
      Pitch = pitch;
      Position = position;
      AudioPositionKind = audioPositionKind;
    }
  }
}
