using System;

namespace Prestige.Common
{
    /// <summary>
    /// Notifies talent
    /// </summary>
    static public class NotificationService
    {
        static public string NotifyTalent(string talentName) {
            var message = "talent" + talentName;
            Console.WriteLine(message);
            return message;
            }
    }
}
    