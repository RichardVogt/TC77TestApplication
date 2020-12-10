using Android;
using Android.Content;
using Android.Net.Wifi;
using Android.OS;
using Plugin.Permissions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using TC77TestApplication.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using static Android.Manifest;
using static Xamarin.Essentials.Permissions;
using Plugin.Permissions.Abstractions;

namespace TC77TestApplication.Helpers
{
    internal class PropMethods
    {


        //public void DoSomething()
        //{
        //    Android.Support.V4.App.ActivityCompat.CheckSelfPermission(this., "android.permission.READ_PRIVILEGED_PHONE_STATE")

        //}

        ////Don't Need Location 
        //internal Prop GetLocation()
        //{

        //    //Task<Location> bob = Task<Location>.Factory.StartNew(() =>
        //    //{
        //    //    var mary = GetLocationAsync();
        //    //    var joe = mary.Result;
        //    //    return joe;
        //    //});
        //    return new Prop { PropName = "Location", PropValue = $"{GetLocationAsync().Result}" };
        //}
        //        public async Task<Location> GetLocationAsync()
        //        {
        //            var status = await CheckAndRequestPermissionAsync(new Permissions.LocationWhenInUse());
        //            if (status != PermissionStatus.Granted)
        //            {
        //                // Notify user permission was denied
        //                return null;
        //            }
        //            return await Geolocation.GetLocationAsync();
        //        }


        //public async Task<PermissionStatus> CheckAndRequestPermissionAsync<T>(T permission)
        //            where T : BasePermission
        //{
        //    var status = await permission.CheckStatusAsync();
        //    if (status != PermissionStatus.Granted)
        //    {
        //        status = await permission.RequestAsync();
        //    }
        //    return status;
        //}

        internal Prop GetHostName()
        {
            return new Prop { PropName = "HostName", PropValue = $"{Dns.GetHostName()}" };
        }
        internal Prop GetModel()
        {
            return new Prop { PropName = "Model", PropValue = $"{DeviceInfo.Model}" };
        }
        internal Prop GetManufacturer()
        {
            return new Prop { PropName = "Manufacturer", PropValue = $"{DeviceInfo.Manufacturer}" };
        }
        internal Prop GetName()
        {
            return new Prop { PropName = "Name", PropValue = $"{DeviceInfo.Name}" };
        }
        internal Prop GetPlatform()
        {
            return new Prop { PropName = "Platform", PropValue = $"{DeviceInfo.Platform}" };
        }
        internal Prop GetIpAddress()
        {
            return new Prop { PropName = "IPAddress", PropValue = $"{Dns.GetHostAddresses(Dns.GetHostName())[0]}" };
        }
        internal Prop GetIdiom()
        {
            return new Prop { PropName = "Idiom", PropValue = $"{DeviceInfo.Idiom}" };
        }
        internal Prop GetDeviceType()
        {
            return new Prop { PropName = "DeviceType", PropValue = $"{DeviceInfo.DeviceType}" };
        }
        internal Prop GetVersion()
        {
            return new Prop { PropName = "Version", PropValue = $"{DeviceInfo.Version}" };
        }
        internal Prop GetBuildVersion()
        {
            return new Prop { PropName = "Android Build Version", PropValue = $"{(int)Build.VERSION.SdkInt}" };
        }
        internal Prop GetSerialNumber()
        {
            return new Prop { PropName = "GetSerialNumber()", PropValue = "Not Implemented" };
        }
    }
}
