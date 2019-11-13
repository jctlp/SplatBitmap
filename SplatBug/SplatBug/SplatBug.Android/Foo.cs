using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Splat;

namespace SplatBug.Droid
{
    public class Foo
    {
        public void Bar(IBitmap source, int radius)
        {
            Bitmap native = source.ToNative();
            IBitmap bitmap = native.FromNative();
        }
    }
}