using System;

namespace ValkyrEngine
{
  public interface ISystem<in Settings> : IDisposable
    where Settings : struct
  {
    void Setup(Settings settings);
  }
}
