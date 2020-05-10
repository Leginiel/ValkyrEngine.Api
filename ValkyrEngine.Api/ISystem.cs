using System;

namespace ValkyrEngine
{
  public interface ISystem<in Settings> : ICleanable
    where Settings : struct
  {
    void Setup(Settings settings);
  }
}
