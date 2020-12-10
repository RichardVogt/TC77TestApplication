using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TC77TestApplication.Droid
{

    [Activity(Label = "TC77TestApplication", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //string[] PermissionsNeeded = {
            //    Manifest.Permission.AccessCoarseLocation,
            //    Manifest.Permission.WriteExternalStorage,
            //    Manifest.Permission.Internet,
            //    Manifest.Permission.ReadPhoneState,
            //    Manifest.Permission.ReadContacts
            //};
            //CheckPermissions(PermissionsNeeded);
            
            //Dictionary<Permission, PermissionStatus> results = await CrossPermissions.Current.RequestPermissionAsync()(Manifest.Permission.AccessCoarseLocation,
            //    Manifest.Permission.WriteExternalStorage,
            //    Manifest.Permission.Internet,
            //    Manifest.Permission.ReadPhoneState,
            //    Manifest.Permission.ReadContacts);

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        //internal void CheckPermissions(string[] permissions)
        //{
        //    foreach (string permission in permissions)
        //    {
        //        if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
        //        {
        //            if (CheckSelfPermission(permission) != Permission.Granted)
        //            {
        //                RequestPermissions(new string[] { permission }, 50);
        //            };
        //        };
        //    }
        //}
    }
}