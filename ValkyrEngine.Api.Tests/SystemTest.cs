using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using ValkyrEngine.MessageSystem;
using Xunit;

namespace ValkyrEngine.Api.Test
{
  [System.Runtime.InteropServices.Guid("1519F371-496F-4373-9000-1DD8795E6D85")]
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
                .Setup("SetupSubSystems")
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

    [Fact]
    [Trait("Category", "Unit")]
    public void TestActivateSubSystem_ValidSubSystem_ActivationSuccessful()
    {
      // Arrange
      Mock<IMessageSystem> messageSystemMock = new Mock<IMessageSystem>();
      Mock<System<TestSettings>> systemMock = new Mock<System<TestSettings>>(new object[] { messageSystemMock.Object }) { CallBase = true };
      Mock<ISubSystem> subsystemMock = new Mock<ISubSystem>();

      systemMock.Object.SubSystems = new List<ISubSystem> { subsystemMock.Object };

      systemMock.Protected()
                .Setup("SubSystemChanged")
                .Verifiable();

      // Act
      systemMock.Object.ActivateSubSystem(subsystemMock.Object);

      // Assert
      Assert.Equal(subsystemMock.Object, systemMock.Object.ActiveSubSystem);
      systemMock.Protected()
                .Verify("SubSystemChanged", Times.Once(), new object[] { });
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void TestActivateSubSystem_ValidSubSystem_ActivationNotNeeeded()
    {
      // Arrange
      Mock<IMessageSystem> messageSystemMock = new Mock<IMessageSystem>();
      Mock<System<TestSettings>> systemMock = new Mock<System<TestSettings>>(new object[] { messageSystemMock.Object }) { CallBase = true };
      Mock<ISubSystem> subsystemMock = new Mock<ISubSystem>();

      systemMock.Object.SubSystems = new List<ISubSystem> { subsystemMock.Object };
      systemMock.Object.ActiveSubSystem = subsystemMock.Object;

      systemMock.Protected()
                .Setup("SubSystemChanged")
                .Verifiable();

      // Act
      systemMock.Object.ActivateSubSystem(subsystemMock.Object);

      // Assert
      Assert.Equal(subsystemMock.Object, systemMock.Object.ActiveSubSystem);
      systemMock.Protected()
                .Verify("SubSystemChanged", Times.Never(), new object[] { });
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void TestActivateSubSystem_Null_ArgumentNullException()
    {
      // Arrange
      Mock<IMessageSystem> messageSystemMock = new Mock<IMessageSystem>();
      Mock<System<TestSettings>> systemMock = new Mock<System<TestSettings>>(new object[] { messageSystemMock.Object }) { CallBase = true };
      Mock<ISubSystem> subsystemMock = new Mock<ISubSystem>();

      systemMock.Object.SubSystems = new List<ISubSystem> { subsystemMock.Object };

      // Act / Assert
      Assert.Throws<ArgumentNullException>(() => systemMock.Object.ActivateSubSystem(null));

      systemMock.Protected()
          .Verify("SubSystemChanged", Times.Never(), new object[] { });
    }

    [Fact]
    [Trait("Category", "Unit")]
    public void TestActivateSubSystem_NotRegisteredSubSystem_SubSystemActivationException()
    {
      // Arrange
      Mock<IMessageSystem> messageSystemMock = new Mock<IMessageSystem>();
      Mock<System<TestSettings>> systemMock = new Mock<System<TestSettings>>(new object[] { messageSystemMock.Object }) { CallBase = true };
      Mock<ISubSystem> subsystemMock = new Mock<ISubSystem>();

      // Act / Assert
      Assert.Throws<SubSystemActivationException>(() => systemMock.Object.ActivateSubSystem(subsystemMock.Object));

      systemMock.Protected()
                .Verify("SubSystemChanged", Times.Never(), new object[] { });
    }
  }
}
