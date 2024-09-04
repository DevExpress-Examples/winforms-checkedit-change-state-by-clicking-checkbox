<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620920/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E315)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms CheckEdit - Change the state by clicking exactly on the checkbox (glyph)

The WinForms CheckEdit changes the check state when a user clicks a checkbox or text. This example handles the `MouseDown` event to prevent the state from changing when the user clicks anywhere other than the checkbox:

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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-checkedit-change-state-by-clicking-checkbox&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-checkedit-change-state-by-clicking-checkbox&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
