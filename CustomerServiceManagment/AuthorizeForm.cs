using BankBusinessLayer;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_Project
{
    public partial class AuthorizeForm : Form
    {
        private const int Port = 8888;
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1"); // Replace with your server IP address
        TcpListener server = null;
        private TcpListener tcpListener = null;
        private bool isRunning;
    


        public AuthorizeForm()
        {
            InitializeComponent();


            _RefreshDataGridView();
             StartListening(Port);
            // DGVTransactions.CellContentClick += DGVTransactions_CellContentClick;
            //  server = new TcpListener(ipAddress,Port);
            //AcceptClientConnections();
            // authorizeEvent = new ManualResetEvent(false);


        }


        private async void StartListening(int port)
        {
            try
            {
       

                tcpListener = new TcpListener(ipAddress, port);
                tcpListener.Start();
                isRunning = true;
       
                // Start accepting _client connections in a separate task
                _ = Task.Run(AcceptClientsAsync);
            }
            catch (Exception ex)
            {
                // Handle errors
            }
        }

        private async Task AcceptClientsAsync()
        {
            try
            {
                while (isRunning)
                {
                  
                        client = await tcpListener.AcceptTcpClientAsync();
                        _ = Task.Run(() => HandleClientAsync(client));
                
                }
            }
            catch (Exception ex)
            {
                // Handle errors
            }
        }
       private TcpClient client;
       private NetworkStream NetworkStream = null;
        private async Task HandleClientAsync(TcpClient client)
        {
            AuthorizeClick = false;
           
            try
            {

               NetworkStream networkStream = client.GetStream();
                this.NetworkStream = networkStream;
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = await networkStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                
                    if (message != null && message == "start")
                    {
                        message = "";
                    }
                    else
                    {
                        this?.Invoke((Action)(() =>
                        {
                            MessageBox.Show(this, "Authorization Request for " + message + " Operation");

                            _RefreshDataGridView();


                        }));
                    }
                    message = "";
            



                }

                client.Close();
            }
            catch (Exception ex)
            {
                // Handle errors
            }
 
        }
   
    private void _RefreshDataGridView()
        {
            DGVTransactions.DataSource = clsTransaction.GetAllTransactions();
         
            DGVTransactions.ClearSelection();
            if (DGVTransactions.Rows.Count ==0 )
            {
                DGVTransactions.Visible = false;
                DGVTransactions.Columns[0].Visible = false;
                lbNoTransactions.Visible = true;
            }
            else
            {
                DGVTransactions.ClearSelection();
                DGVTransactions.Visible = true;
                DGVTransactions.Columns[0].Visible = true;
                lbNoTransactions.Visible = false;
                DGVTransactions.Rows[0].Selected = false;
            }
          
            DGVTransactions.ClearSelection();
        }
    
    private static void SendMessage(NetworkStream stream, string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

        private static string ReceiveMessage(NetworkStream stream)
        {
            byte[] data = new byte[256];
            int bytesRead = stream.Read(data, 0, data.Length);
            return Encoding.ASCII.GetString(data, 0, bytesRead);
        }
        string authorizationResponse = "";
      //  bool Authorized = false;
       // string request = "";
        bool AuthorizeClick = false;
        //  string UTI="";
        string Msg = "";
       // private TaskCompletionSource<bool> authorizeTask;
        private async void HandleClient(object clientObj)
        {

            TcpClient client = (TcpClient)clientObj;
        

            try
            {
                NetworkStream stream = client.GetStream();

                // Receive the authorization request from the _client
              
                Msg = ReceiveMessage(stream);
             //  string[] ArrRequest = Msg.Split('#');
             //   request = ArrRequest[0];
                //UTI = ArrRequest[1];
                MessageBox.Show(this,"Authorization request for: " + Msg+" Operation");
                // Thread newthread = new Thread(() =>
                //  {
                // this.BeginInvoke((Action)delegate ()
                // {
                _RefreshDataGridView();
                AuthorizeClick = false;
                authorizationResponse = "";
                do
                {
                    await Task.Delay(1000);
                    //SendMessage(stream, "");
                } while (AuthorizeClick == false);
               // await AuthorizeTask();
                // authorizeEvent.WaitOne();
                // while (AuthorizeClick)
                //  {
                // Send the authorization response to the _client
                if(authorizationResponse!="")
                    SendMessage(stream, authorizationResponse);
                else
                    SendMessage(stream, "Refresh");


                // Receive the boolean value from the _client
                //  string AuthorizedStr = ReceiveMessage(stream);
                //  Authorized = Convert.ToBoolean(AuthorizedStr);
                //  Console.WriteLine("Deposit authorized: " + Authorized);

                // Handle the deposit authorization accordingly
                // Replace with your actual logic
                //  }
                // });
                //   });

                //  newthread.Start();


                // Simulating the authorization process
                //authorizationResponse = "Authorize"; // Replace with your actual authorization logic
                stream.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                client.Close();
        
                //authorizeEvent.Reset();
                //  Console.WriteLine("Client disconnected.");
            }

        }

        private string _File = @"F:\TransactionRegister.txt";
        private DataTable dt = new DataTable();
        //private DataTable _RefreashDataGridView()
        //{
        //    string[] rows = System.IO.File.ReadAllLines(_File);
        //    string[] separator = new string[] { "#//#" };
        //     dt = new DataTable(_File);
        //    if (rows.Length != 0)
        //    {
        //        foreach (string headerCol in rows[0].Split(separator, StringSplitOptions.None))
        //        {
        //            dt.Columns.Add(new DataColumn(headerCol));
        //        }
        //        if (rows.Length > 1)
        //        {
        //            for (int i = 1; i < rows.Length; i++)
        //            {
        //                var newRow = dt.NewRow();
        //                var cols = rows[i].Split(separator, StringSplitOptions.None);
        //                for (int j = 0; j < cols.Length; j++)
        //                {
        //                    newRow[j] = cols[j];
        //                }
        //                dt.Rows.Add(newRow);
        //            }
        //        }

        //    }
      
        //    return dt;
        //}
 
    
        private async void AcceptClientConnections()
        {
            try
            {

                server.Start();
                // Console.WriteLine("Server started. Waiting for connections...");

                while (true)
                {
                    TcpClient client = await server.AcceptTcpClientAsync();

                    //Handle the _client connection in a separate task
                   // Task.Run(() => HandleClient(_client));
                   HandleClient(client); 
                    // Console.WriteLine("Client connected.");

                    //Thread clientThread = new Thread(HandleClient);
                    //clientThread.Start(_client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                server.Stop();
            }
        }

       private void SendMessage(string Message)
        {
            try
            {
                client = new TcpClient("127.0.0.1", Port);
                SendMessage(client.GetStream(), Message);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }
        }
        private void DGVTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = DGVTransactions.CurrentRow;
            string cellValue = currentRow.Cells[3].Value?.ToString();
            string Status = currentRow.Cells[8].Value?.ToString();
            int TransactionID = Convert.ToInt32(currentRow.Cells[1].Value?.ToString());
            string AccountNumber = currentRow.Cells[4].Value?.ToString();
            string Operation = currentRow.Cells[5].Value?.ToString();
            if (Status == "Pending")
            {
                clsBankClient client = clsBankClient.Find(AccountNumber);
                DataGridViewRow row = DGVTransactions.Rows[e.RowIndex];

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && currentRow != null)
                {
                    if (DGVTransactions.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < DGVTransactions.Rows.Count)
                    {
                        string buttonStatus = DGVTransactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        DialogResult dialogResult;
                        if (buttonStatus == "Authorize")
                        {
                            if (Operation == "Deposit")
                                dialogResult = MessageBox.Show("Authorize Cash in Operation ? ", "Authorization", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            else
                                dialogResult = MessageBox.Show("Authorize Cash out Operation ? ", "Authorization", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (dialogResult == DialogResult.Yes)
                            {
                                int transactionId = (int)row.Cells["TransactionID"].Value;
                                authorizationResponse = "Authorize#" + transactionId;
                                //dt.Rows[e.RowIndex]["Status"] = "Accept";
                                row.Cells["Status"].Value = "Accept";

                                clsTransaction.UpdateTransactionStatus(transactionId, "Accept");
                                DGVTransactions.CurrentRow.DefaultCellStyle.BackColor = Color.LightGreen;
                                DGVTransactions.CurrentRow.ReadOnly = true;
                                //SendMessageToTransactionForm(authorizationResponse);
                                // rowColors[transactionId] = Color.Green;
                           
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                int transactionId = (int)row.Cells["TransactionID"].Value;
                                authorizationResponse = "NotAuthorize#" + transactionId;
                                //  dt.Rows[e.RowIndex]["Status"] = "Reject";
                                row.Cells["Status"].Value = "Reject";

                                clsTransaction.UpdateTransactionStatus(transactionId, "Reject");
                                DGVTransactions.CurrentRow.DefaultCellStyle.BackColor = Color.OrangeRed;
                                DGVTransactions.CurrentRow.ReadOnly = true;
                                // SendMessageToTransactionForm(authorizationResponse);
                                // rowColors[transactionId] = Color.Red;
                            
                            }
                            AuthorizeClick = true;
                            
                        }
                        //SendMessage(networkStream, authorizationResponse);
                     
                    }
                }
            }
            else if(Status == "Reject")
            {
                if(MessageBox.Show(this,"Transaction Already Rejected\nDo you Want to delete it ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if(clsTransaction.DeleteTransaction(TransactionID))
                    {
                        _RefreshDataGridView();
                        AuthorizeClick = true;
                      
                        //SendMessageToTransactionForm("Refresh");
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete this transaction");
                    }
                }
           
            }
            else { return; }

            if (NetworkStream != null)
            {
                if (authorizationResponse != "")
                    SendMessage(NetworkStream, authorizationResponse);
                else
                    SendMessage(NetworkStream, "Refresh");
            }
            else
                MessageBox.Show("Can Not Send Message, Connection Error!");
            // SendMessage(networkStream, authorizationResponse);
            //AuthorizeTask();

        } 

        private void DGVTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in DGVTransactions.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals("Accept"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (cell.Value != null && cell.Value.ToString().Equals("Reject"))
                    {

                        row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                    else if (cell.Value != null && cell.Value.ToString().Equals("Pending"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }


                }
            }

        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            //StartListening(Port);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StartListening(Port);
        }



        
    }
   
}
    


