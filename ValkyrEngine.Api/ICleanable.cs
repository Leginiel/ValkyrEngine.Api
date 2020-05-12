namespace ValkyrEngine
{
  /// <summary>
  /// Provides a mechanism for releasing unneeded momory. 
  /// </summary>
  public interface ICleanable
  {
    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting internal memory.
    /// </summary>
    void CleanUp();
  }
}