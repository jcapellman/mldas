using System.Reflection;

using MLDAS.Lib.Platform.Abstractions.Base;
using MLDAS.Lib.Platform.Enums;
using MLDAS.Lib.Platform.Managers.Base;

namespace MLDAS.Lib.Platform.Managers
{
    public class ModuleManager : BaseManager
    {
        private readonly List<BaseModule> _availableModules = new List<BaseModule>();

        public ModuleManager()
        {
            LoadModules();
        }

        private void LoadModules()
        {
            var potentialModules = Directory.GetFiles(CurrentDirectory, "MLDAS.Lib.Category.*.dll");

            foreach (var potentialModulePath in potentialModules)
            {
                var assembly = Assembly.LoadFile(potentialModulePath);

                _availableModules.AddRange(assembly.GetTypes().Where(a => a.BaseType?.BaseType == typeof(BaseModule) && !a.IsAbstract).
                    Select(b => (BaseModule)Activator.CreateInstance(b)!).Where(c => c.DevelopedForAPI == Common.AppConstants.APIVersion));
            }
        }

        public IEnumerable<BaseModule> GetModulesByCategory(Categories category) => _availableModules.Where(a => a.Category == category);
    }
}