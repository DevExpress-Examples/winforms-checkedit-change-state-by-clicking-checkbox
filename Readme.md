<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620920/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E315)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms CheckEdit - Change the state by clicking exactly on the checkbox (glyph)

The WinForms CheckEdit changes the check state when the user clicks a checkbox or text. This example handles the `MouseDown` event to prevent the state from changing when clicked anywhere other than the checkbox:

```csharp
private void checkEdit1_MouseDown(object sender, MouseEventArgs e) {
    CheckEdit cEdit = (CheckEdit)sender;
    CheckEditViewInfo cInfo = (CheckEditViewInfo)cEdit.GetViewInfo();
    Rectangle r = cInfo.CheckInfo.GlyphRect;
    Rectangle editorRect = new Rectangle(new Point(0, 0), cEdit.Size);
    if (!r.Contains(e.Location) && editorRect.Contains(e.Location))
        ((DXMouseEventArgs)e).Handled = true;
}
```


## Files to Review

* [Form1.cs](./CS/Q181266/Form1.cs) (VB: [Form1.vb](./VB/Q181266/Form1.vb))
