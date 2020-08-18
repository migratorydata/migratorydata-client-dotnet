using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using com.migratorydata.client;
using System;
using System.Threading;

namespace TestClientCSharp
{
    class Program
    {
        public static void Main()
        {
            MigratoryDataClient client = new MigratoryDataClient();

            client.SetLogListener(new LogList(), MigratoryDataLogLevel.DEBUG);
            client.SetListener(new Listener());

            client.SetEntitlementToken("some-token");
            client.SetServers(new string[] { "127.0.0.1:8800" });
            
            List<string> subjects = new List<string>();
            subjects.Add("/server/status");
            client.Subscribe(subjects);
            
            client.Connect();
            
            // publish a message every 3 seconds
            int count = 1;
            while (count < 1000000)
            {
            	client.Publish(new MigratoryDataMessage("/server/status", System.Text.Encoding.ASCII.GetBytes("data - " + count), "id" + count));
            	count++;
            	Thread.Sleep(3000);
            }            
        }
        class Listener : MigratoryDataListener
        {

            public void OnMessage(MigratoryDataMessage message)
            {
                System.Console.WriteLine(message.ToString());
            }

            public void OnStatus(string status, string info)
            {
	            System.Console.WriteLine(status + " " + info);
            }
        }

        class LogList : MigratoryDataLogListener
        {
            public void OnLog(string log, MigratoryDataLogLevel level)
            {
                string msg = string.Format("[{0:G}] [{1}] {2}\r\n", DateTime.Now, level, log);
                Console.Write(msg);
            }
        }
    }
}
