# DOCFX example project
DLL file and documentation XML file are used to generate documentation in this project, and they are located in *root\\src* folder.
To check the generated pdf go to the *root\\\_site\_pdf* folder.

Also, you can put directly the whole Visual Studio C# project folder content inside the
*root\\src* folder but replace "\*\*.dll" with "\*\*.csproj" as value of the key "src" inside of "build"
dictionary in the *docfx.json* file.

Actually I'm interested to get documentation out of undocumented APIs, that's why I used a DLL for this example :) 
Source codes of the DLL and the XML are inside the *root\\\_site\_pdf* folder

A pdf default style has been used as template instead. While the web site has been built using *darkfx* 
template, inside *root\\templates* foder.

Refer to [this page](https://dotnet.github.io/docfx/templates-and-plugins/templates-dashboard.html) to download 
some of them, but mind they work only for webpages and they are not intended for PDFs

To get a web site that works on filesystem use "statictoc" style.

For more info about styles and PDF go to this [closed issue discussion](https://github.com/dotnet/docfx/issues/6110) 

*Mind* that DOCFX is meant to document APIs so this means that (at least today) only **public** methods, 
properties and classes get exposed in the docfx documentation 

# Tip: 
Drag and drop the pdf file into Microsoft Word application to read it as *editable* document. Too complex converted pdf documents 
into Word tend to be broken. After hand-made fixes save the document as DOCX file.

I Actually use docfx and Word like this also to get nice documentation out of my C# projects :) 

Refer to this [youtube tutorial](https://www.youtube.com/watch?v=oP393DSX9xs) and [this other youtube tutorial](https://www.youtube.com/watch?v=aThwPl-HdPo) to see how it works
