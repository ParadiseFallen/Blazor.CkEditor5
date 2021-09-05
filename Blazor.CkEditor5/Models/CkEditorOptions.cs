using System.Collections.Generic;

namespace Blazor.CkEditor5.Models
{
    public class CkEditorOptions : Dictionary<string, object>
    {
        public static CkEditorOptions Default
        {
            get
            {
                var options = new CkEditorOptions();
                options["toolbar"] = new
                {
                    items = new[]
                    {
                        "heading",
                        "bold",
                        "italic",
                        "link",
                        "bulletedList",
                        "numberedList",
                        "outdent",
                        "indent",
                        "blockQuote",
                        "insertTable",
                        "mediaEmbed",
                        "undo",
                        "redo",
                        "alignment",
                        "code",
                        "fontBackgroundColor",
                        "fontFamily",
                        "codeBlock",
                        "findAndReplace",
                        "fontSize",
                        "fontColor",
                        "highlight",
                        "htmlEmbed",
                        "horizontalLine",
                        "removeFormat",
                        "sourceEditing",
                        "specialCharacters",
                        "restrictedEditingException",
                        "superscript",
                        "subscript",
                        "strikethrough",
                        "todoList",
                        "underline",
                        "imageInsert"
                    },
                    shouldNotGroupWhenFull = true
                };

                options["image"] = new
                {
                    toolbar = new[] {
                        "imageTextAlternative",
                        "imageStyle:inline",
                        "imageStyle:block",
                        "imageStyle:side",
                        "linkImage"
                    }
                };

                options["table"] = new
                {
                    contentToolbar = new[] {
                        "tableColumn",
                        "tableRow",
                        "mergeTableCells",
                        "tableCellProperties",
                        "tableProperties"
                    }
                };

                return options;
            }
        }
    }
}
