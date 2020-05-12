using System;
using Veldrid;

namespace ValkyrEngine.Window
{
  /// <summary>
  /// Defines all functionailty that is needed for a game window.
  /// </summary>
  public interface IGameWindow
  {
    /// <summary>
    /// Triggers, when the window get resized.
    /// </summary>
    event EventHandler Resized;
    /// <summary>
    /// Triggers, when the window is closing.
    /// </summary>
    event EventHandler Closing;
    /// <summary>
    /// Triggers, when the window is closed.
    /// </summary>
    event EventHandler Closed;
    /// <summary>
    /// Triggers, when the focus is lost.
    /// </summary>
    event EventHandler FocusLost;
    /// <summary>
    /// Triggers, when the window gains focus.
    /// </summary>
    event EventHandler FocusGained;

    /// <summary>
    /// Returns the current input snapshot of the window.
    /// </summary>
    /// <returns>Current input snapshot.</returns>
    InputSnapshot GetInputSnapshot();
  }
}
