using ValkyrEngine.Input.Messages;
using ValkyrEngine.MessageSystem;
using Veldrid;
using Xunit;


namespace ValkyrEngine.Api.Tests.Input.Messages
{
  public class KeyboardActionMessageTest
  {
    [Fact]
    [Trait("Category", "Unit")]
    public void TestConstructor()
    {
      // Arrange
      KeyEvent e = new KeyEvent(Key.A, true, ModifierKeys.None);
      ActionTypes type = ActionTypes.Registration;
      static void callback() { }

      // Act
      KeyboardActionMessage message = new KeyboardActionMessage(e, callback, type);

      // Assert
      Assert.Equal(e, message.KeyEvent);
      Assert.Equal(type, message.ActionType);
      Assert.Equal(callback, message.Callback);
    }
  }
}
