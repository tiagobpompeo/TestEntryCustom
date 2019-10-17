using System;
using Android.Content;
using TestEntry;
using TestEntry.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryCustom), typeof(MultiLineBreakLabelRenderer))]
namespace TestEntry.Droid
{
    public class MultiLineBreakLabelRenderer : EntryRenderer
    {
        public MultiLineBreakLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Gray);

            }
        }
    }
}
