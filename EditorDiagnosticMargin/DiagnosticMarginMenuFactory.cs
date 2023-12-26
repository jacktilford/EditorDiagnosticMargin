using System.ComponentModel.Composition;
using EditorDiagnosticMargin;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

[Export(typeof(IWpfTextViewMarginProvider))]
[Name(DiagnosticMarginMenu.MarginName)]
[Order(Before = PredefinedMarginNames.HorizontalScrollBarContainer, After = "ZoomControlMarginProvider" /*PredefinedMarginNames.ZoomControl) FUCK */)]
[MarginContainer(PredefinedMarginNames.BottomControl)]
[ContentType("text")]
[TextViewRole(PredefinedTextViewRoles.Interactive)]

internal sealed class DiagnosticMarginMenuFactory : IWpfTextViewMarginProvider
{
    public IWpfTextViewMargin CreateMargin(IWpfTextViewHost textViewHost, IWpfTextViewMargin containerMargin)
    {
        return new DiagnosticMarginMenu();
    }
}
