using MLDAS.Lib.Category.CyberSecurity.Modules.Base;

namespace MLDAS.Lib.Category.CyberSecurity.Modules
{
    public class FileClassificationModule : BaseCyberSecurityModule
    {
        public override string Name => "File Classification";

        public override string Description => "Classifies the PE32 file as malware or not";

        public override int Version => 1;

        public override void Run()
        {
            // TODO
        }
    }
}