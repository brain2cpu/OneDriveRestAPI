using System;
using System.Collections.Generic;

namespace OneDriveRestAPI.Util
{
    public static class EnumExtensions
    {
        private static readonly Dictionary<string, string> enumValueMap = new Dictionary<string, string>
        {
            ["Basic"] = "wl.basic",
            ["OfflineAccess"] = "wl.offline_access",
            ["Signin"] = "wl.signin",
            ["Birthday"] = "wl.basic",
            ["Calendars"] = "wl.calendars",
            ["CalendarsUpdate"] = "wl.calendars_update",
            ["ContactsBirthday"] = "wl.contacts_birthday",
            ["ContactsCreate"] = "wl.contacts_create",
            ["ContactsCalendars"] = "wl.contacts_calendars",
            ["ContactsPhotos"] = "wl.contacts_photos",
            ["ContactsSkyDrive"] = "wl.contacts_skydrive",
            ["Emails"] = "wl.emails",
            ["EventsCreate"] = "wl.events_create",
            ["Messenger"] = "wl.messenger",
            ["PhoneNumbers"] = "wl.phone_numbers",
            ["Photos"] = "wl.photos",
            ["PostalAddress"] = "wl.postal_addresses",
            ["Share"] = "wl.share",
            ["SkyDrive"] = "wl.skydrive",
            ["SkyDriveUpdate"] = "wl.skydrive_update",
            ["WorkProfile"] = "wl.work_profile",
            ["Applications"] = "wl.applications",
            ["ApplicationsCreate"] = "wl.applications_create",

            ["ContactsEmails"] = "wl.contacts_emails",
            ["ContactsPhoneNumbers"] = "wl.contacts_phone_numbers",
            ["ContactsPostalAddresses"] = "wl.contacts_postal_addresses",


            ["DoNotOverwrite"] = "false",
            ["Overwrite"] = "true",
            ["Rename"] = "ChooseNewName",

            ["Small"] = "small",
            ["Medium"] = "medium",
            ["Large"] = "large"
        };

        public static string GetDescription(this Enum value)
        {
            //var fi = value.GetType().GetField(value.ToString());
            //var attributes = (DescriptionAttribute[]) fi.GetCustomAttributes(typeof (DescriptionAttribute),false);
            //return attributes.Length > 0 ? attributes[0].Description : value.ToString();

            return enumValueMap[value.ToString()];
        }
    }
}