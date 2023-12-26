using System;
using System.Windows;
using System.Windows.Controls;
using Microsoft.VisualStudio.Text.Editor;

namespace EditorDiagnosticMargin
{
    public partial class DiagnosticMarginMenu : UserControl, IWpfTextViewMargin
    {
        public const string MarginName = "DiagnosticMarginMenu";

        public DiagnosticMarginMenu()
        {
            InitializeComponent();
        }

        public FrameworkElement VisualElement => this;

        public ITextViewMargin GetTextViewMargin(string marginName)
        {
            return string.Compare(marginName, DiagnosticMarginMenu.MarginName, StringComparison.OrdinalIgnoreCase) == 0 ? this : (ITextViewMargin)null;
        }

        public double MarginSize => 100;

        public bool Enabled => true;

        public void Dispose()
        {
        }
    }
}
