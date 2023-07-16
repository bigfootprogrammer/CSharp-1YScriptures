// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DailyScriptures
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now; // Get the current date and time
            int dayNumber = now.DayOfYear; // Get the day of the year

            // Create a dictionary of scriptures.
            Dictionary<int, string[]> scriptures = new Dictionary<int, string[]>();
            scriptures.Add(150, new string[] { "2 Samuel 15:23-16:23", "John 18:25-19:22", "Psalm 119:113-128", "Proverbs 16:10-11" });
            scriptures.Add(151, new string[] { "2 Samuel 17:1-29", "John 19:23-42", "Psalm 119:129-152", "Proverbs 16:12-13" });
            scriptures.Add(152, new string[] { "2 Samuel 18:1-19:10", "John 20:1-31", "Psalm 119:153-176", "Proverbs 16:14-15" });
            scriptures.Add(153, new string[] { "2 Samuel 19:11-20:13", "John 21:1-25", "Psalm 120:1-7", "Proverbs 16:16-17" });
            scriptures.Add(154, new string[] { "2 Samuel 20:14-21:22", "Acts 1:1-26", "Psalm 121:1-8", "Proverbs 16:18" });
            scriptures.Add(155, new string[] { "2 Samuel 22:1-23:23", "Acts 2:1-47", "Psalm 122:1-9", "Proverbs 16:19-20" });
            scriptures.Add(156, new string[] { "2 Samuel 23:24-24:25", "Acts 3:1-26", "Psalm 123:1-4", "Proverbs 16:21-23" });
            scriptures.Add(157, new string[] { "1 Kings 1:1-53", "Acts 4:1-37", "Psalm 124:1-8", "Proverbs 16:24" });
            scriptures.Add(158, new string[] { "1 Kings 2:1-3:2", "Acts 5:1-42", "Psalm 125:1-5", "Proverbs 16:25" });
            scriptures.Add(159, new string[] { "1 Kings 3:3-4:34", "Acts 6:1-15", "Psalm 126:1-6", "Proverbs 16:26 -27" });
            scriptures.Add(160, new string[] { "1 Kings 5:1-6:38", "Acts 7:1-29", "Psalm 127:1-5", "Proverbs 16:28-30" });
            scriptures.Add(161, new string[] { "1 Kings 7:1-51", "Acts 7:30-50", "Psalm 128:1-6", "Proverbs 16:31-33" });
            scriptures.Add(162, new string[] { "1 Kings 8:1-66", "Acts 7:51-8:13", "Psalm 129:1-8", "Proverbs 17:1" });
            scriptures.Add(163, new string[] { "1 Kings 9:1-10:29", "Acts 8:14-40", "Psalm 130:1-8", "Proverbs 17:2-3" });
            scriptures.Add(164, new string[] { "1 Kings 11:1-12:19", "Acts 9:1-25", "Psalm 131:1-3", "Proverbs 17:4-5" });
            scriptures.Add(165, new string[] { "1 Kings 12:20-13:34", "Acts 9:26-43", "Psalm 132:1-18", "Proverbs 17:6" });
            scriptures.Add(166, new string[] { "1 Kings 14:1-15:24", "Acts 10:1-23", "Psalm 133:1-3", "Proverbs 17:7-8" });
            scriptures.Add(167, new string[] { "1 Kings 15:25-17:24", "Acts 10:24-48", "Psalm 134:1-3", "Proverbs 17:9-11" });
            scriptures.Add(168, new string[] { "1 Kings 18:1-46", "Acts 11:1-30", "Psalm 135:1-21", "Proverbs 17:12-13" });
            scriptures.Add(169, new string[] { "1 Kings 19:1-21", "Acts 12:1-23", "Psalm 136:1-26", "Proverbs 17:14-15" });
            scriptures.Add(170, new string[] { "1 Kings 20:1-21:29", "Acts 12:24-13:15", "Psalm 137:1-9", "Proverbs 17:16" });
            scriptures.Add(171, new string[] { "1 Kings 22:1-53", "Acts 13:16-41", "Psalm 138:1-8", "Proverbs 17:17-18" });
            scriptures.Add(172, new string[] { "2 Kings 1:1-2:25", "Acts 13:42-14:7", "Psalm 139:1-24", "Proverbs 17:19-21" });
            scriptures.Add(173, new string[] { "2 Kings 3:1-4:17", "Acts 14:8-28", "Psalm 140:1-13", "Proverbs 17:22" });
            scriptures.Add(174, new string[] { "2 Kings 4:18-5:27", "Acts 15:1-35", "Psalm 141:1-10", "Proverbs 17:23" });
            scriptures.Add(175, new string[] { "2 Kings 6:1-7:20", "Acts 15:36-16:15", "Psalm 142:1-7", "Proverbs 17:24-25" });
            scriptures.Add(176, new string[] { "2 Kings 8:1-9:13", "Acts 16:16-40", "Psalm 143:1-12", "Proverbs 17:26" });
            scriptures.Add(177, new string[] { "2 Kings 9:14-10:31", "Acts 17:1-34", "Psalm 144:1-15", "Proverbs 17:27-28" });
            scriptures.Add(178, new string[] { "2 Kings 10:32-12:21", "Acts 18:1-22", "Psalm 145:1-21", "Proverbs 18:1" });
            scriptures.Add(179, new string[] { "2 Kings 13:1-14:29", "Acts 18:23-19:12", "Psalm 146:1-10", "Proverbs 18:2-3" });
            scriptures.Add(180, new string[] { "2 Kings 15:1-16:20", "Acts 19:13-41", "Psalm 147:1-20", "Proverbs 18:4-5" });
            scriptures.Add(181, new string[] { "2 Kings 17:1-18:12", "Acts 20:1-38", "Psalm 148:1-14", "Proverbs 18:6-7" });
            scriptures.Add(182, new string[] { "2 Kings 20:1-22:2", "Acts 21:18-36", "Psalm 150:1-6", "Proverbs 18:9-10" });
            scriptures.Add(183, new string[] { "2 Kings 22:3-23:30", "Acts 21:37-22:16", "Psalm 1:1-6", "Proverbs 18:11-12" });
            scriptures.Add(184, new string[] { "2 Kings 23:31-25:30", "Acts 22:17-23:10", "Psalm 2:1-12", "Proverbs 18:13" });
            scriptures.Add(185, new string[] { "1 Chronicles 1:1-2:17", "Acts 23:11-35", "Psalm 3:1-8", "Proverbs 18:14-15" });
            scriptures.Add(186, new string[] { "1 Chronicles 2:18-4:4", "Acts 24:1-27", "Psalm 4:1-8", "Proverbs 18:16-18" });
            scriptures.Add(187, new string[] { "1 Chronicles 4:5-5:17", "Acts 25:1-27", "Psalm 5:1-12", "Proverbs 18:19" });
            scriptures.Add(188, new string[] { "1 Chronicles 5:18-6:81", "Acts 26:1-32", "Psalm 6:1-10", "Proverbs 18:20-21" });
            scriptures.Add(189, new string[] { "1 Chronicles 7:1-8:40", "Acts 27:1-20", "Psalm 7:1-17", "Proverbs 18:22" });
            scriptures.Add(190, new string[] { "1 Chronicles 9:1-10:14", "Acts 27:21-44", "Psalm 8:1-9", "Proverbs 18:23-24" });
            scriptures.Add(191, new string[] { "1 Chronicles 11:1-12:18", "Acts 28:1-31", "Psalm 9:1-12", "Proverbs 19:1-3" });
            scriptures.Add(192, new string[] { "1 Chronicles 12:19-14:17", "Romans 1:1-17", "Psalm 9:13-20", "Proverbs 19:4-5" });
            scriptures.Add(193, new string[] { "1 Chronicles 15:1-16:36", "Romans 1:18-32", "Psalm 10:1-15", "Proverbs 19:6-7" });
            scriptures.Add(194, new string[] { "1 Chronicles 16:37-18:17", "Romans 2:1-24", "Psalm 10:16-18", "Proverbs 19:8-9" });
            scriptures.Add(195, new string[] { "1 Chronicles 19:1-21:30", "Romans 2:25-3:8", "Psalm 11:1-7", "Proverbs 19:10-12" });
            scriptures.Add(196, new string[] { "1 Chronicles 22:1-23:32", "Romans 3:9-31", "Psalm 12:1-8", "Proverbs 19:13-14" });
            scriptures.Add(197, new string[] { "1 Chronicles 24:1-26:11", "Romans 4:1-12", "Psalm 13:1-6", "Proverbs 19:15-16" });
            scriptures.Add(198, new string[] { "1 Chronicles 26:12-27:34", "Romans 4:13-5:5", "Psalm 14:1-7", "Proverbs 19:17" });
            scriptures.Add(199, new string[] { "1 Chronicles 28:1-29:30", "Romans 5:6-21", "Psalm 15:1-5", "Proverbs 19:18-19" });
            scriptures.Add(200, new string[] { "2 Chronicles 1:1-3:17", "Romans 6:1-23", "Psalm 16:1-11", "Proverbs 19:20-21" });
            scriptures.Add(201, new string[] { "2 Chronicles 4:1-6:11", "Romans 7:1-13", "Psalm 17:1-15", "Proverbs 19:22-23" });
            scriptures.Add(202, new string[] { "2 Chronicles 6:12-8:10", "Romans 7:14-8:8", "Psalm 18:1-15", "Proverbs 19:24-25" });
            scriptures.Add(203, new string[] { "2 Chronicles 8:11-10:19", "Romans 8:9-25", "Psalm 18:16-36", "Proverbs 19:26" });
            scriptures.Add(204, new string[] { "2 Chronicles 11:1-13:22", "Romans 8:26-39", "Psalm 18:37-50", "Proverbs 19:27-29" });
            scriptures.Add(205, new string[] { "2 Chronicles 14:1-16:14", "Romans 9:1-24", "Psalm 19:1-14", "Proverbs 20:1" });
            scriptures.Add(206, new string[] { "2 Chronicles 17:1-18:34", "Romans 9:25-10:13", "Psalm 20:1-9", "Proverbs 20:2-3" });
            scriptures.Add(207, new string[] { "2 Chronicles 19:1-20:37", "Romans 10:14-11:12", "Psalm 21:1-13", "Proverbs 20:4-6" });
            scriptures.Add(208, new string[] { "2 Chronicles 21:1-23:21", "Romans 11:13-36", "Psalm 22:1-18", "Proverbs 20:7" });
            scriptures.Add(209, new string[] { "2 Chronicles 24:1-25:28", "Romans 12:1-21", "Psalm 22:19-31", "Proverbs 20:8-10" });
            scriptures.Add(210, new string[] { "2 Chronicles 26:1-28:27", "Romans 13:1-14", "Psalm 23:1-6", "Proverbs 20:11" });
            scriptures.Add(211, new string[] { "2 Chronicles 29:1-36", "Romans 14:1-23", "Psalm 24:1-10", "Proverbs 20:12" });


            // Get the scripture for the current day.
            string[] scripture = scriptures[dayNumber];

            // Encode the scripture for the URL.
            for (int i = 0; i < scripture.Length; i++)
            {
                scripture[i] = scripture[i].Replace(" ", "%20");
            }

            // Open the Bible Gateway website in the web browser.
            string url = "https://www.biblegateway.com/passage/?search=" + string.Join(",", scripture) + "&interface=print";
            var psi = new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            System.Diagnostics.Process.Start(psi);


            // Add a log entry for the current day.
            readingLog();
        }

        private static void readingLog()
        {
            // Create a new DateTime object for the current date.
            DateTime now = DateTime.Now;

            // Create a new CSV file object.
            StreamWriter sw = new StreamWriter("DailyScripturesReadingLog.csv", true);

            // Write the current date to the CSV file.
            sw.WriteLine(now.ToString("yyyy-MM-dd"));

            // Close the CSV file object.
            sw.Close();
        }
    }
}