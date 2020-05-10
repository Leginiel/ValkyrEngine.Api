using System;
using System.Collections.Generic;
using System.Text;

namespace ValkyrEngine.MessageSystem
{
  public interface IActionMessage : IMessage
  {
    ActionTypes ActionType { get; }
  }
}
