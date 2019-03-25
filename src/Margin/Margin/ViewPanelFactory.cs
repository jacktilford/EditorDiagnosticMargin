using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using System.ComponentModel.Composition;

namespace DiagnosticMargin
{
    [Export(typeof(IDiagnosticPanelFactory))]
    [Name("View")]
    [ContentType("Text")]
    [TextViewRole("Interactive")]
    internal sealed class ViewPanelFactory : IDiagnosticPanelFactory
    {
        public IDiagnosticPanel CreatePanel(IWpfTextViewHost textViewHost)
        {
            return new ViewPanel(textViewHost.TextView);
        }
    }

}
