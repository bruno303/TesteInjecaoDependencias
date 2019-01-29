using System;

namespace TesteInjecaoDependencias.DI
{
    public interface IRender
    {
        Guid GetGuidNow { get; }
    }
}