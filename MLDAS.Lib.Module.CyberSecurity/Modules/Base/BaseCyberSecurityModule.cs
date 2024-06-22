using MLDAS.Lib.Platform.Abstractions.Base;
using MLDAS.Lib.Platform.Enums;

namespace MLDAS.Lib.Category.CyberSecurity.Modules.Base
{
    public abstract class BaseCyberSecurityModule : BaseModule
    {
        public override Categories Category => Categories.CyberSecurity;
    }
}