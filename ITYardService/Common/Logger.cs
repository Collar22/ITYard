using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ITYardService.Models
{
    public class Logger
    {
        private const string Info = "Info";
        private const string Error = "error";
        string path = @"logfile.txt";
        /// <summary>
        /// Print log info
        /// </summary>
        /// <param name="message"></param>
        public void LogInfo(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow} Type {Info}. Message: {message}");
            WriteLog($"{DateTime.UtcNow} Type {Info}. Message: {message}");
        }

        /// <summary>
        /// Print log error
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow} Type {Error}. Message: {message}");
            WriteLog($"{DateTime.UtcNow} Type {Error}. Message: {message}");
        }


        private void WriteLog(string message)
        {
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(message);
            }
        }










    }
}
