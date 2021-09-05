using Blazor.CkEditor5.Interfaces.Models;

namespace Blazor.CkEditor5.Models.Base
{
    public record DynamicCkEditorPlugin<T> : ICkEditorPlugin<T>
    {
        public string Name { get; init; }
        public T Options { get; init; }
    }
}
