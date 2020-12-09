using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android;

namespace TC77TestApplication.Droid
{
    [Activity(Label = "TC77TestApplication", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {

        //Added for permissions
        //readonly string[] Permission = {
        //    Manifest.Permission.WriteExternalStorage,
        //    Manifest.Permission.ReadExternalStorage,
        //    Manifest.Permission.Camera,
        //    Manifest.Permission.ReadPhoneState,
        //    Manifest.Permission.AccessWifiState,
        //    Manifest.Permission.ChangeWifiState,
        //    Manifest.Permission.AccessNetworkState,
        //    Manifest.Permission.ChangeNetworkState,
        //    Manifest.Permission.BluetoothPrivileged,
        //    Manifest.Permission.CallPhone,
        //    Manifest.Permission.CallPrivileged,
        //    Manifest.Permission.Diagnostic,
        //    Manifest.Permission.ReadLogs,
        //    Manifest.Permission.WriteSms
        //};
        //readonly int RequestId = 0;
        //End permissions add

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            ////Added for permissions
            //RequestPermissions(Permission, RequestId);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}