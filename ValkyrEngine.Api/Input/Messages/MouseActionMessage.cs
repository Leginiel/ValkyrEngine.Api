using System;
using System.Numerics;
using ValkyrEngine.MessageSystem;
using Veldrid;

namespace ValkyrEngine.Input.Messages
{
  public struct MouseActionMessage : IActionMessage
  {
    public MouseEvent MouseEvent { get; }
    public Action<Vector2> Callback { get; }
    public ActionTypes ActionType { get; }

    public MouseActionMessage(MouseEvent mouseEvent, Action<Vector2> callback, ActionTypes actionType)
    {
      MouseEvent = mouseEvent;
      Callback = callback;
      ActionType = actionType;
    }
  }
}
