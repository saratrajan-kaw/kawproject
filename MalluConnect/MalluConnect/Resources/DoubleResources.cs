using System;
using Xamarin.Forms;
namespace MalluConnect.Resources
{
    public static class DoubleResources
    {
        public static readonly Thickness ButtonGroupPadding = new Thickness(0, Device.OnPlatform(25, 0, 0), 0, 0);
        public static readonly double ButtonHeight = Device.OnPlatform(40, 60, 80);
        public static readonly double FBButtonHeight = Device.OnPlatform(50, 50, 64);
    }
}
