using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "araba eklendi";
        public static string CarInvalidAdded = "araba eklenmedi";
        public static string CarUpdated = "araba güncellendi";
        public static string CarInvalidUpdated = "araba güncellenmedi";
        public static string CarDeleted = "araba silindi";
        public static string CarInvalidDeleted = "araba silinmedi";
        public static string MaintenanceTime = "sistem bakımda";
        public static string CarsListed = "arabalar listelendi";
        internal static CarImage CreatedFileMessages;
    }
}
