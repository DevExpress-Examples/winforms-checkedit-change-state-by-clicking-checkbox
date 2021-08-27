<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E315)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q181266/Form1.cs) (VB: [Form1.vb](./VB/Q181266/Form1.vb))
* [Program.cs](./CS/Q181266/Program.cs) (VB: [Program.vb](./VB/Q181266/Program.vb))
<!-- default file list end -->
# How to force the CheckEdit to change its state only when clicked in the glyph


<p>By default, the CheckEdit changes the check state when being clicked anywhere within its bounds. However, sometimes it is necessary that the CheckBox changes the check state only if a click was made exactly in the glyph area. To achieve this, you need to handle the MouseDown event. Within the MouseDown event handler, you can manually check whether a user clicks on a glyph rectangle and allow or suppress subsequent processing.</p>

<br/>


