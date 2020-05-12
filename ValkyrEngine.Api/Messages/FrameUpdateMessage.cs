using System.Diagnostics.CodeAnalysis;
using ValkyrEngine.MessageSystem;

namespace ValkyrEngine.Messages
{
  /// <summary>
  /// Represents an update message that contains frame information when this message wars sent. 
  /// </summary>
  [ExcludeFromCodeCoverage]
  public struct FrameUpdateMessage : IMessage
  {
    /// <summary>
    /// Returns the number of the frame when this message was raised. 
    /// </summary>
    public uint FrameNumber { get; set; }

    /// <summary>
    /// Creates a new instance of the <see cref="FrameUpdateMessage"/> with the given frame number.
    /// </summary>
    /// <param name="frameNumber">Sets the frame number of the current message.</param>
    public FrameUpdateMessage(uint frameNumber)
    {
      FrameNumber = frameNumber;
    }
  }
}
