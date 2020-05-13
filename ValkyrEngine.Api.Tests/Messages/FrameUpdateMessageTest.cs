using ValkyrEngine.Messages;
using Xunit;

namespace ValkyrEngine.Api.Tests.Messages
{
  public class FrameUpdateMessageTest
  {
    [Fact]
    [Trait("Category", "Unit")]
    public void TestConstructor()
    {
      // Arrange
      uint frameNumber = 10;
      // Act
      FrameUpdateMessage message = new FrameUpdateMessage(frameNumber);

      // Assert
      Assert.Equal(frameNumber, message.FrameNumber);
    }
  }
}
