using Blazor.CkEditor5.Interfaces.Models;
using Blazor.CkEditor5.Models;

namespace Blazor.CkEditor5.Extensions
{
    public static class CkEditorOptionsExtension
    {
        public static CkEditorOptions AddPlugin<T, X>(this CkEditorOptions options, T plugin) where T : ICkEditorPlugin<X>
        {
            options[plugin.Name] = plugin.Options;
            return options;
        }
        public static CkEditorOptions RemovePlugin(this CkEditorOptions options, string pluginName)
        {
            options.Remove(pluginName);
            return options;
        }
    }
}
