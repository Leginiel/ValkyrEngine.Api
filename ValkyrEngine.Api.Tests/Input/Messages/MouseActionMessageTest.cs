using System.Numerics;
using ValkyrEngine.Input.Messages;
using ValkyrEngine.MessageSystem;
using Veldrid;
using Xunit;

namespace ValkyrEngine.Api.Tests.Input.Messages
{
  public class MouseActionMessageTest
  {
    [Fact]
    [Trait("Category", "Unit")]
    public void TestConstructor()
    {
      // Arrange
      MouseEvent e = new MouseEvent(MouseButton.Left, true);
      ActionTypes type = ActionTypes.Registration;
      static void callback(Vector2 position) { }

      // Act
      MouseActionMessage message = new MouseActionMessage(e, callback, type);

      // Assert
      Assert.Equal(e, message.MouseEvent);
      Assert.Equal(type, message.ActionType);
      Assert.Equal(callback, message.Callback);
    }
  }
}
