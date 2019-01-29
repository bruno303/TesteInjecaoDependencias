using System;

namespace TesteInjecaoDependencias.DI.classes
{
    public class RenderScoped : IRenderScoped
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }
}