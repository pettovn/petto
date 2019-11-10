using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Management.Common
{
    public class DateTimeMgr
    {
        /// <summary>
        /// Get the current date and time in UTC (Coordinated Universal Time) from Windows Azure Cloud Service.
        /// </summary>
        public static DateTime DateTimeUtcNow
        {
            get
            {
                try
                {
                    DateTime utcNow = DateTime.UtcNow;
                    return utcNow;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// convert DateTimeUtc to Vietnam
        /// </summary>
        public static DateTime DateTimeJst
        {
            get
            {
                try
                {
                    DateTime time = DateTimeUtcNow.AddHours(7);
                    time = DateTime.SpecifyKind(time, DateTimeKind.Unspecified);

                    return time;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
