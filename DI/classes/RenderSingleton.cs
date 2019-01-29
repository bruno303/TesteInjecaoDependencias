using System;

namespace TesteInjecaoDependencias.DI.classes
{
    public class RenderSingleton : IRenderSingleton
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }
}