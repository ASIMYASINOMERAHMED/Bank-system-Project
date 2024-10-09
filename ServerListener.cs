using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System_Project
{
    using System;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public class ServerListener
    {
        public TcpClient client=null;
        public NetworkStream networkStream =null;
        private CancellationTokenSource cancellationTokenSource;
        public bool IsConnected=false;

        public event EventHandler<string> MessageReceived;
        public event EventHandler AuthorizeAvailable;

        private static void SendMessage(NetworkStream stream, string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        public async Task StartListeningAsync(string serverIpAddress, int serverPort)
        {
            try
            {
                client = new TcpClient();
                await client.ConnectAsync(serverIpAddress, serverPort);

                networkStream = client.GetStream();

                cancellationTokenSource = new CancellationTokenSource();
                IsConnected = true;
    
                // Start listening for messages in a separate task
                _ = Task.Run(ListenForMessagesAsync);

            }
            catch (Exception ex)
            {
                IsConnected = false;
     
                // Handle connection errors
            }
        }
        private async Task CheckAuthorizeAvailability()
        {
            while (true)
            {
                if (AuthorizeAvailable != null)
                {
          

                    if (IsConnected)
                    {
                        // Raise the event to notify that the Authorize form is available
                        AuthorizeAvailable.Invoke(this, EventArgs.Empty);
                    }
                }

                // Wait for a certain interval before checking again
                await Task.Delay(5000); // Adjust the interval as needed
            }
        }
        private async Task ListenForMessagesAsync()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                // Continuously listen for messages until cancellation is requested
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    bytesRead = await networkStream.ReadAsync(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        // Raise the MessageReceived event with the received message
                        MessageReceived?.Invoke(this, message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle read errors or server disconnection
            }
        }

        public void StopListening()
        {
            cancellationTokenSource?.Cancel();
            networkStream?.Close();
            client?.Close();
        }
    }
}
