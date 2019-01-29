using System;

namespace TesteInjecaoDependencias.DI.classes
{
    public class RenderTransient : IRenderTransient
    {
        public Guid GetGuidNow { get; private set; } = Guid.NewGuid();
    }
}