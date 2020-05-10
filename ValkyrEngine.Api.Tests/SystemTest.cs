using Moq;
using Moq.Protected;
using ValkyrEngine.MessageSystem;
using Xunit;

namespace ValkyrEngine.Api.Test
{
  public class SystemTest
  {
    [Fact]
    [Trait("Category", "Unit")]
    public void TestSetup_ValidSettings_SuccessfulSetup()
    {
      // Arrange
      Mock<IMessageSystem> messageSystemMock = new Mock<IMessageSystem>();
      Mock<System<TestSettings>> systemMock = new Mock<System<TestSettings>>(new object[] { messageSystemMock.Object }) { CallBase = true };
      TestSettings settings = new TestSettings();

      systemMock.Protected()
                .Setup("Setup")
                .Verifiable();
      systemMock.Protected()
                .Setup("SetupMessageHandler")
                .Verifiable();

      // Act

      systemMock.Object.Setup(settings);

      // Assert

      systemMock.VerifyAll();
    }
    [Fact]
    [Trait("Category", "Unit")]
    public void TestSetup_NoInput_SuccessfulCleanUp()
    {
      // Arrange
      Mock<IMessageSystem> messageSystemMock = new Mock<IMessageSystem>();
      Mock<System<TestSettings>> systemMock = new Mock<System<TestSettings>>(new object[] { messageSystemMock.Object }) { CallBase = true };

      systemMock.Protected()
                .Setup("CleanUpMessageHandler")
                .Verifiable();

      // Act

      systemMock.Object.CleanUp();

      // Assert

      systemMock.VerifyAll();
    }
  }
}
