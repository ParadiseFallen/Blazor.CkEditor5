(() => {
    class BlazorEditor extends ClassicEditor {
        static async create(target, options, reference) {
            const editor = await super.create(target, options);
            editor.model.document.on('change:data', async () => {
                await reference.invokeMethodAsync('EditorContentChanged', editor.getData());
            });
            return editor;
        }
    }
    ClassicEditor = BlazorEditor;
})();

