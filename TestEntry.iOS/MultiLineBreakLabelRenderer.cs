using System;
using TestEntry;
using TestEntry.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryCustom), typeof(MultiLineBreakLabelRenderer))]
namespace TestEntry.iOS
{
    public class MultiLineBreakLabelRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.Gray;
                //Control.BorderStyle = UITextBorderStyle.None;                
                //this.Control.AutocapitalizationType = UIKit.UITextAutocapitalizationType.None;
                //this.Control.AutocorrectionType = UIKit.UITextAutocorrectionType.No;

            }
        }
    }
}
