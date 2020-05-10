using System;
using System.Numerics;
using ValkyrEngine.MessageSystem;
using Veldrid;

namespace ValkyrEngine.Input.Messages
{
  /// <summary>
  /// Provides an message, that registeres specific mouse actions in the <see cref="IInputSystem"/>.
  /// </summary>
  public struct MouseActionMessage : IActionMessage
  {
    /// <summary>
    /// Mouse event, that should be listened on.
    /// </summary>
    public MouseEvent MouseEvent { get; }
    /// <summary>
    /// Callback that should be executed, when the mouse event occurs.
    /// </summary>
    public Action<Vector2> Callback { get; }
    /// <summary>
    /// Action type, that should be executed in the <see cref="IInputSystem"/>.
    /// </summary>
    public ActionTypes ActionType { get; }

    /// <summary>
    /// Creates a new instance of <see cref="MouseActionMessage"/>.
    /// </summary>
    /// <param name="mouseEvent">Mouse event, that should be listened on.</param>
    /// <param name="callback">Callback that should be executed, when the mouse event occurs.</param>
    /// <param name="actionType">Action type, that should be executed in the <see cref="IInputSystem"/>.</param>
    public MouseActionMessage(MouseEvent mouseEvent, Action<Vector2> callback, ActionTypes actionType)
    {
      MouseEvent = mouseEvent;
      Callback = callback;
      ActionType = actionType;
    }
  }
}
