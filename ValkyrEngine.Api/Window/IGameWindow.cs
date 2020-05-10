using System;
using Veldrid;

namespace ValkyrEngine.Window
{
  public interface IGameWindow
  {

    event EventHandler Resized;
    event EventHandler Closing;
    event EventHandler Closed;
    event EventHandler FocusLost;
    event EventHandler FocusGained;

    InputSnapshot GetInputSnapshot();
  }
}
