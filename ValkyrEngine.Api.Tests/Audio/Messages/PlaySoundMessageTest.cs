using Moq;
using System.Numerics;
using ValkyrEngine.Assets.Audio;
using ValkyrEngine.Audio.Messages;
using ValkyrEngine.Audio.Resources;
using Xunit;

namespace ValkyrEngine.Api.Tests.Audio.Messages
{
  public class PlaySoundMessageTest
  {
    [Fact]
    [Trait("Category", "Unit")]
    public void TestConstructor_SingleAsset()
    {
      // Arrange
      Mock<IAudioAsset> audioAssetMock = new Mock<IAudioAsset>();
      PlaySoundMessage<IAudioAsset> message;

      // Act
      message = new PlaySoundMessage<IAudioAsset>(audioAssetMock.Object);

      // Assert
      Assert.Equal(audioAssetMock.Object, message.Asset);
      Assert.Equal(1f, message.Volume);
      Assert.Equal(1f, message.Pitch);
      Assert.Equal(Vector3.Zero, message.Position);
      Assert.Equal(AudioPositionKind.ListenerRelative, message.AudioPositionKind);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void TestConstructor_AssetVolumePitch()
    {
      // Arrange
      Mock<IAudioAsset> audioAssetMock = new Mock<IAudioAsset>();
      PlaySoundMessage<IAudioAsset> message;
      float expectedVolume = 2f;
      float expectedPitch = 2f;

      // Act
      message = new PlaySoundMessage<IAudioAsset>(audioAssetMock.Object, expectedVolume, expectedPitch);

      // Assert
      Assert.Equal(audioAssetMock.Object, message.Asset);
      Assert.Equal(expectedVolume, message.Volume);
      Assert.Equal(expectedPitch, message.Pitch);
      Assert.Equal(Vector3.Zero, message.Position);
      Assert.Equal(AudioPositionKind.ListenerRelative, message.AudioPositionKind);
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void TestConstructor_AssetVolumePitchPositionPositionKind()
    {
      // Arrange
      Mock<IAudioAsset> audioAssetMock = new Mock<IAudioAsset>();
      PlaySoundMessage<IAudioAsset> message;
      float expectedVolume = 2f;
      float expectedPitch = 2f;
      AudioPositionKind expectedPositionKind = AudioPositionKind.AbsoluteWorld;
      Vector3 expectedPosition = new Vector3(2, 2, 2);
      // Act
      message = new PlaySoundMessage<IAudioAsset>(audioAssetMock.Object, expectedVolume, expectedPitch, expectedPosition, expectedPositionKind);

      // Assert
      Assert.Equal(audioAssetMock.Object, message.Asset);
      Assert.Equal(expectedVolume, message.Volume);
      Assert.Equal(expectedPitch, message.Pitch);
      Assert.Equal(expectedPosition, message.Position);
      Assert.Equal(expectedPositionKind, message.AudioPositionKind);
    }
  }
}
