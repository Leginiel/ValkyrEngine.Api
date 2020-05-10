using System.Diagnostics.CodeAnalysis;

namespace ValkyrEngine.Input
{
  /// <summary>
  /// Specifies the settings that are used to setup the input system.
  /// </summary>
  public struct InputSettings
  {
    /// <summary>
    /// Determines if the input system listenes to mouse input.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public bool UseMouseInput { get; }
    /// <summary>
    /// Determines if the input system listenes to keyboard input.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public bool UseKeyboardInput { get; }
  }
}