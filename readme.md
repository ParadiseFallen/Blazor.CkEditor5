# Blazor.CkEditor5
## How to use
### Activating functionality
Add your `ClassicEditor` [build](https://ckeditor.com/ckeditor-5/online-builder/) in `_Host` 
```html
<script type="module" src="/js/ckeditor.js"></script>
```
Add package modula mutator 
```html
<script type="module" src="/_content/Blazor.CkEditor5/js/module.js"></script>
```
Add using
```cs
@using Blazor.CkEditor5.Components
@using Blazor.CkEditor5.Models
```
Use component
```cs
<CkEditor @bind-Content="@Content" Options="@Options"/>
```
Options is `Dictionary<string,object>` and you can configure it with [documentation](https://ckeditor.com/docs/ckeditor5/latest/builds/guides/integration/configuration.html)

<!--- dotnet nuget push ./bin/release/Blazor.CkEditor5.x.x.x.nupkg --source "github" -->