using System;

namespace ValkyrEngine
{
  public interface ISystem<Settings> : IDisposable
    where Settings : struct
  {
    void Setup(Settings settings);
  }
}
