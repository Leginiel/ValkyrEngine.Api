using System;
using ValkyrEngine.MessageSystem;
using Veldrid;

namespace ValkyrEngine.Input.Messages
{
  /// <summary>
  /// Provides an message, that registeres specific keyboard actions in the <see cref="IInputSystem"/>.
  /// </summary>
  public struct KeyboardActionMessage : IActionMessage
  {
    /// <summary>
    /// Keyboard event, that should be listened on.
    /// </summary>
    public KeyEvent KeyEvent { get; }
    /// <summary>
    /// Callback that should be executed, when the mouse event occurs.
    /// </summary>
    public Action Callback { get; }
    /// <summary>
    /// Action type, that should be executed in the <see cref="IInputSystem"/>.
    /// </summary>
    public ActionTypes ActionType { get; }

    /// <summary>
    /// Creates a new instance of <see cref="KeyboardActionMessage"/>.
    /// </summary>
    /// <param name="keyEvent">key event, that should be listened on.</param>
    /// <param name="callback">Callback that should be executed, when the key event occurs.</param>
    /// <param name="actionType">Action type, that should be executed in the <see cref="IInputSystem"/>.</param>

    public KeyboardActionMessage(KeyEvent keyEvent, Action callback, ActionTypes actionType)
    {
      KeyEvent = keyEvent;
      Callback = callback;
      ActionType = actionType;
    }
  }
}
