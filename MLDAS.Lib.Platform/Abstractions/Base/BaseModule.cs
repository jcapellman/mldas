using MLDAS.Lib.Platform.Enums;

namespace MLDAS.Lib.Platform.Abstractions.Base
{
    public abstract class BaseModule
    {
        public abstract Categories Category { get; }

        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract void Run();
    }
}