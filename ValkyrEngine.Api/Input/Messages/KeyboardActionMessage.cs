using System;
using ValkyrEngine.MessageSystem;
using Veldrid;

namespace ValkyrEngine.Input.Messages
{
  public struct KeyboardActionMessage : IActionMessage
  {
    public KeyEvent KeyEvent { get; }
    public Action Callback { get; }
    public ActionTypes ActionType { get; }

    public KeyboardActionMessage(KeyEvent keyEvent, Action callback, ActionTypes actionType)
    {
      KeyEvent = keyEvent;
      Callback = callback;
      ActionType = actionType;
    }
  }
}
