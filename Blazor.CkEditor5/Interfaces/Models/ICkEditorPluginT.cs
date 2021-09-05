namespace Blazor.CkEditor5.Interfaces.Models
{
    public interface ICkEditorPlugin<T>
    {
        public string Name { get; }
        public T Options { get; }
    }
}
