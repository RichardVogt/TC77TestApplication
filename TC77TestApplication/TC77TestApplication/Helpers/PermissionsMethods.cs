using Plugin.Permissions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TC77TestApplication.Helpers
{
    public static class PermissionsMethods
    {
        public static async void CheckPermissions()
        {
            await GetPermissions(
                        new List<Plugin.Permissions.Abstractions.Permission>()
                        {
                            Plugin.Permissions.Abstractions.Permission.Camera,
                            Plugin.Permissions.Abstractions.Permission.Calendar,
                            Plugin.Permissions.Abstractions.Permission.LocationAlways,
                            Plugin.Permissions.Abstractions.Permission.LocationWhenInUse,
                            Plugin.Permissions.Abstractions.Permission.MediaLibrary,
                            Plugin.Permissions.Abstractions.Permission.Microphone,
                            Plugin.Permissions.Abstractions.Permission.Photos,
                            Plugin.Permissions.Abstractions.Permission.Reminders,
                            Plugin.Permissions.Abstractions.Permission.Sensors,
                            Plugin.Permissions.Abstractions.Permission.Sms,
                            Plugin.Permissions.Abstractions.Permission.Speech,                            
                            Plugin.Permissions.Abstractions.Permission.Contacts,
                            Plugin.Permissions.Abstractions.Permission.Location,
                            Plugin.Permissions.Abstractions.Permission.Phone,
                            Plugin.Permissions.Abstractions.Permission.Storage
                            //Others

                        });
        }

        public static async Task<bool> GetPermissions(List<Plugin.Permissions.Abstractions.Permission> permList)
        {
            bool permissionsGranted = true;

            var permissionsNeededList = new List<Plugin.Permissions.Abstractions.Permission>();

            try
            {
                foreach (var permission in permList)
                {
                    var status = await CrossPermissions.Current.CheckPermissionStatusAsync(permission);
                    if (status != Plugin.Permissions.Abstractions.PermissionStatus.Granted)
                    {
                        permissionsNeededList.Add(permission);
                    }
                }
            }
            catch (Exception)
            {
            }

            var results = await CrossPermissions.Current.RequestPermissionsAsync(permissionsNeededList.ToArray());

            try
            {
                foreach (var permission in permissionsNeededList)
                {
                    var status = Plugin.Permissions.Abstractions.PermissionStatus.Unknown;
                    //Best practice to always check that the key exists
                    if (results.ContainsKey(permission))
                        status = results[permission];
                    if (status == Plugin.Permissions.Abstractions.PermissionStatus.Granted || status == Plugin.Permissions.Abstractions.PermissionStatus.Unknown)
                    {
                        permissionsGranted = true;
                    }
                    else
                    {
                        permissionsGranted = false;
                        break;
                    }
                }
            }
            catch (Exception)
            {
            }
            return permissionsGranted;
        }
    }
}
