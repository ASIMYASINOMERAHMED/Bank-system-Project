using Bank_System_Project.Properties;
using BankBusinessLayer;
using BankBussinessLayer;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_System_Project
{
    public partial class Transactions : Form
    {
        private const int Port = 8888;
        private const string ServerIP = "127.0.0.1";
        private TcpClient client;
        private ServerListener serverListener;

        private NetworkStream stream;
        public Transactions()
        {
            InitializeComponent();

            AddButtonColumn();
            serverListener = new ServerListener();
            serverListener.MessageReceived += ServerListener_MessageReceived;

            //serverListener.

     


        }
        private async void Transactions_Load(object sender, EventArgs e)
        {
            await AcceptserverAsync();

        }
        private async Task AcceptserverAsync()
        {
            try
            {
                do
                {
                    await serverListener.StartListeningAsync(ServerIP, Port);
                } while (serverListener.IsConnected == false);
                SendMessage(serverListener.networkStream, "start");
            }
            catch (Exception ex)
            {
                // Handle errors
            }
        }
        //private void ConnectToServer()
        //{
        //    try
        //    {
        //        // Create a TCP _client and connect to the server
        //        _client = new TcpClient();
        //        _client.Connect("127.0.0.1", 8888);

        //        // Get the network stream for sending and receiving data
        //        stream = _client.GetStream();

        //        // Start listening for messages from the server in a separate thread
        //        StartListening();
        //    }
        //    catch (SocketException ex)
        //    {
        //        MessageBox.Show("Socket Error: Authorize offline! " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}

        //private void StartListening()
        //{
        //    try
        //    {
        //        byte[] buffer = new byte[1024];
        //        int bytesRead;

        //        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
        //        {
        //            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
        //            // Process the received message
        //            if (message == "Refresh")
        //            {
        //                Invoke(new Action(() =>
        //                {
        //                    // Invoke a function in the Transaction form based on the received message
        //                    _RefreashDataGridView();
        //                }));
        //            }
        //            string[] Msg = message.Split('#');
        //            string response = Msg[0];
        //            string transactionId = Msg[1];
        //            if (response == "Authorize")
        //                Invoke(new Action(() =>
        //                {
        //                    // Invoke a function in the Transaction form based on the received message

        //                    PerformTransaction(response, Convert.ToInt32(transactionId));
        //                }));
        //            // Example: Display the received message in a MessageBox
        //            //MessageBox.Show("Received message: " + message);
        //        }
        //    }
        //    catch (SocketException ex)
        //    {
        //        MessageBox.Show("Socket Error: " + ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        stream?.Close();
        //        _client?.Close();
        //    }
        //}




        private async void ServerListener_AuthorizeOnLine(object sender, int state)
        {
            if (state == 1)
            {
                this?.Invoke((Action)(() =>
                {
                    SendMessage(serverListener.networkStream, "start");
                }));

            }
            else
            {
                MessageBox.Show(this, "Authorize offline!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                serverListener.StopListening();
                return;
            }
        }

        private void ServerListener_MessageReceived(object sender, string message)
        {
            // Call a function in the Transaction Form
            if (message != null)
            {
                this?.Invoke((Action)(() =>
                {
                    if (message == "Refresh")
                    {
                        Invoke(new Action(() =>
                        {
                            // Invoke a function in the Transaction form based on the received message
                            _RefreashDataGridView();
                        }));
                    }
                    else
                    {
                        string[] Msg = message.Split('#');
                        string response = Msg[0];
                        string transactionId = Msg[1];
                        if (response == "Authorize")
                        {
                            Invoke(new Action(() =>
                            {
                                // Invoke a function in the Transaction form based on the received message

                                PerformTransaction(response, Convert.ToInt32(transactionId));
                            }));
                        }
                        else if(response == "NotAuthorize")
                        {
                            Invoke(new Action(() =>
                            {
                                // Invoke a function in the Transaction form based on the received message
                                _RefreashDataGridView();
                            }));
                        }
                    }
                }));
            
            }
        }

        private clsBankClient Client = new clsBankClient();

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
         private string _File = @"F:\TransactionRegister.txt";
      
        private void _RefreashDataGridView()
        {

            // DGVTransactionsList.DataSource = _FillDataGridViewFromFile();

            DGVTransactionsList.DataSource = clsTransaction.GetTransactionList();
            DGVTransactionsList.ClearSelection();
            if (DGVTransactionsList.Rows.Count == 0)
            {
                DGVTransactionsList.Visible = false;
                lbNoTransactions.Visible = true;
            }
            else
            {
                DGVTransactionsList.Visible = true;
                lbNoTransactions.Visible = false;
            }
            DGVTransactionsList.ClearSelection();
          
        
        }
        private void AddButtonColumn()
        {
          
            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.HeaderText = "";
            ButtonColumn.Name = "PrintReceipt";
            ButtonColumn.UseColumnTextForButtonValue = true;
            ButtonColumn.Text = "Print Receipt";
           
            DGVTransactionsList.Columns.Add(ButtonColumn);
   
        }
        //private DataTable _FillDataGridViewFromFile()
        //{
        //    DataTable dt = new DataTable();
        //    string[] rows = System.IO.File.ReadAllLines(_File);
        //    string[] separator = new string[] { "#//#" };
        //    dt = new DataTable(_File);
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
  
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {

                _RefreashDataGridView();
                _ = serverListener.StartListeningAsync(ServerIP, Port);
                PerformTransaction();

            

            }
        }
        private void DGVTransactionsList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in DGVTransactionsList.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals("Accept"))
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                    else if (cell.Value != null && cell.Value.ToString().Equals("Reject"))
                    {

                        row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    }
                    else if(cell.Value != null && cell.Value.ToString().Equals("Pending"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    if (cell.Value != null && cell.Value.ToString().Equals("Completed"))
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                }
            }


        }
        // private Point messageBoxLocation;
        //private void CalculateMessageboxPosition(string Message)
        //{
        //    // Get the center position of the parent form
        //    Point parentCenter = new Point(Location.X + Width / 2, Location.Y + Height / 2);


        //    // Define the font for the message box
        //    Font font = SystemFonts.MessageBoxFont;

        //    // Calculate the size required to display the message
        //    Size messageSize = TextRenderer.MeasureText(Message, font);

        //    // Add padding to the calculated size
        //    int padding = 20; // Adjust as needed
        //    messageSize.Width += padding;
        //    messageSize.Height += padding;
        //    // Calculate the top-left position for the message box
        //    messageBoxLocation = new Point(
        //        parentCenter.X - messageSize.Width / 2,
        //        parentCenter.Y - messageSize.Height / 2
        //        );
        //}
        private string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
        //private  ConcurrentQueue<clsBankBusiness.clsBankClient.clsTransaction> transactionQueue;
        //private SemaphoreSlim semaphore;
        //public void TransactionProcessor()
        //{
        //    transactionQueue = new ConcurrentQueue<clsBankBusiness.clsBankClient.clsTransaction>();
        //    semaphore = new SemaphoreSlim(0); // Initialized with 0 permits
        //}

        //public void AddTransaction(clsBankBusiness.clsBankClient.clsTransaction transaction)
        //{
        //    transactionQueue.Enqueue(transaction);
        //    semaphore.Release(); // Increase the semaphore count to indicate a new transaction is available
        //}
        private void DGVTransactionsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow currentRow = DGVTransactionsList.CurrentRow;
            string cellValue = currentRow.Cells[2].Value?.ToString();
            string Status = currentRow.Cells[7].Value?.ToString();
            string Operation = currentRow.Cells[4].Value?.ToString();
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && currentRow != null)
            {
                if (DGVTransactionsList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex < DGVTransactionsList.Rows.Count)
                {
                    string buttonStatus = DGVTransactionsList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (buttonStatus == "Print Receipt")
                    {
                        if (Status == "Completed")
                        {
                            clsBankClient client = clsBankClient.FindByAccountNumber(cellValue);
                            frmTransactionReport receipt = new frmTransactionReport(client,Operation);
                            receipt.ShowDialog(this);
                            return;
                        }
                 
                    }
                }
            }
        }
        clsBankClient client1;
        string Oparetion = "";
  

        private async void ListenForMessages()
        {

            try
            {
                NetworkStream networkStream = null;
                client = new TcpClient(ServerIP, Port);
                networkStream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = 0;

                // Continuously listen for messages from the server
                while (client.Connected)
                {
                    // Read asynchronously from the network stream
                    bytesRead = await networkStream.ReadAsync(buffer, 0, buffer.Length);

                    if (bytesRead > 0)
                    {
                        // Process the received message
                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                        // Handle the received message
                        //  Response= message;
                        // PerformTransaction(Response);
                        //do
                        //{
                        //    await Task.Delay(1000);
                        //    Response = message;
                        //} while (Response == "");
                        //_RefreashDataGridView();
                        //PerformTransaction();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle read errors or server disconnection
                return;
            }
        }
        private void notifyIcon_Click(object sender, EventArgs e)
        {
            frmTransactionReport receipt = new frmTransactionReport(client1, Oparetion);
            receipt.ShowDialog(this);
        }
        private async void PerformTransaction(string Response, int TransactionID)
        {

            DGVTransactionsList.ClearSelection();
            foreach (DataGridViewRow row in DGVTransactionsList.Rows)
            {
                DGVTransactionsList.ClearSelection();
                string IDValue = row.Cells[1].Value?.ToString();
                string Amount = row.Cells[5].Value?.ToString();
                string AccountNumber = row.Cells[2].Value?.ToString();
                string TransactionType = row.Cells[4].Value?.ToString();
                string Status = row.Cells[7].Value?.ToString();
           

                if (IDValue == TransactionID.ToString())
                {
                    if (Response == "Authorize")
                    {
                        row.Cells["Status"].Value = "Accept";
                        await Task.Delay(3000);


                        row.Selected = true;
                        client1 = clsBankClient.FindByAccountNumber(AccountNumber);
                        if (TransactionType == "Deposit")
                        {
                            //if (response == "Authorize")
                            //{
                            client1.Deposit(Convert.ToDecimal(Amount));
                            SystemSounds.Asterisk.Play();
                            //     MessageBox.Show(this, $"Amount Deposited Successfully.\n new Balance is {_client._AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            clsTransaction.UpdateBalance(TransactionID, client1._AccountBalance);
                            clsTransaction.UpdateTransactionStatus(TransactionID, "Completed");
                            row.Cells["Status"].Value = "Completed";
                            // _RefreashDataGridView();
                            await Task.Delay(2000);


                            notifyIcon.Icon = SystemIcons.Information;
                            notifyIcon.BalloonTipTitle = "Success";
                            notifyIcon.BalloonTipText = $"{client1.FullName()} new Balance is {client1._AccountBalance}.\nClick here to Print Receipt";
                            notifyIcon.ShowBalloonTip(3000);


                            // }

                        }
                        else if (TransactionType == "WithDraw")
                        {
                            // if (Response == "Authorize")
                            //  {
                            client1.Withdraw(Convert.ToDecimal(Amount));
                            SystemSounds.Asterisk.Play();
                            //    MessageBox.Show($"Withdraw Done Successfully.\n new Balance is {_client._AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            clsTransaction.UpdateBalance(TransactionID, client1._AccountBalance);
                            clsTransaction.UpdateTransactionStatus(TransactionID, "Completed");
                            row.Cells["Status"].Value = "Completed";
                            // _RefreashDataGridView();
                            await Task.Delay(2000);

                            notifyIcon.Icon = SystemIcons.Information;
                            notifyIcon.BalloonTipTitle = "Success";
                            notifyIcon.BalloonTipText = $"{client1.FullName()} new Balance is {client1._AccountBalance}.";
                            notifyIcon.ShowBalloonTip(3000);
                            // }



                        }
                        Oparetion = TransactionType;

                        await Task.Delay(1000);
                        row.Selected = false;
                    }
                    else if(Response== "NotAuthorize")
                    {
                        row.Cells["Status"].Value = "Reject";
                        await Task.Delay(3000);
                        row.Selected = true;
                        SystemSounds.Exclamation.Play();
                        // MessageBox.Show(this, "Opration was Cancelled..\nAuthorization Failed.");
                        // _RefreashDataGridView();
                        await Task.Delay(1000);
                        row.Selected = false;
                    }

                }
                else if (IDValue != TransactionID.ToString())
                {
                    continue;
                }
                else
                {
                    return;
                }

            }
            DGVTransactionsList.ClearSelection();
        }
        private async void PerformTransaction()
        {

            DGVTransactionsList.ClearSelection();
            foreach (DataGridViewRow row in DGVTransactionsList.Rows)
            {
                DGVTransactionsList.ClearSelection();
                string IDValue = row.Cells[1].Value?.ToString();
                string Amount = row.Cells[5].Value?.ToString();
                string AccountNumber = row.Cells[2].Value?.ToString();
                string TransactionType = row.Cells[4].Value?.ToString();
                string Status = row.Cells[7].Value?.ToString();


                    if (Status == "Accept")
                    {

                        row.Selected = true;
                        client1 = clsBankClient.FindByAccountNumber(AccountNumber);
                        if (TransactionType == "Deposit")
                        {
                            //if (response == "Authorize")
                            //{
                            client1.Deposit(Convert.ToDecimal(Amount));
                            SystemSounds.Asterisk.Play();
                            //     MessageBox.Show(this, $"Amount Deposited Successfully.\n new Balance is {_client._AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            clsTransaction.UpdateBalance(Convert.ToInt32(IDValue), client1._AccountBalance);
                            clsTransaction.UpdateTransactionStatus(Convert.ToInt32(IDValue), "Completed");
                            row.Cells["Status"].Value = "Completed";
                            // _RefreashDataGridView();
                            await Task.Delay(2000);


                            notifyIcon.Icon = SystemIcons.Information;
                            notifyIcon.BalloonTipTitle = "Success";
                            notifyIcon.BalloonTipText = $"{client1.FullName()} new Balance is {client1._AccountBalance}.\nClick here to Print Receipt";
                            notifyIcon.ShowBalloonTip(3000);


                            // }

                        }
                        else if (TransactionType == "WithDraw")
                        {
                            // if (Response == "Authorize")
                            //  {
                            client1.Withdraw(Convert.ToDecimal(Amount));
                            SystemSounds.Asterisk.Play();
                            //    MessageBox.Show($"Withdraw Done Successfully.\n new Balance is {_client._AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                            clsTransaction.UpdateBalance(Convert.ToInt32(IDValue), client1._AccountBalance);
                            clsTransaction.UpdateTransactionStatus(Convert.ToInt32(IDValue), "Completed");
                            row.Cells["Status"].Value = "Completed";
                            // _RefreashDataGridView();
                            await Task.Delay(2000);

                            notifyIcon.Icon = SystemIcons.Information;
                            notifyIcon.BalloonTipTitle = "Success";
                            notifyIcon.BalloonTipText = $"{client1.FullName()} new Balance is {client1._AccountBalance}.";
                            notifyIcon.ShowBalloonTip(3000);
                            // }



                        }
                        Oparetion = TransactionType;

                        await Task.Delay(1000);
                        row.Selected = false;
                    }
                    else if (Status != "Accept")
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                

             

            }
            DGVTransactionsList.ClearSelection();
        }

        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            if (CTBDepositAmount.Texts == string.Empty||CTBDepositAmount.Texts == "0")
            {
                SystemSounds.Hand.Play();
                MessageBox.Show(this,"Can not Preform Transaction While Deposit Amount is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
             string Message = "Are You Sure You Want To Preform This Transaction ?";



            if (MessageBox.Show(this, Message, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                decimal Amount = Convert.ToDecimal(CTBDepositAmount.Texts);
                //  GlobalWaitForm.waitForm.StartPosition = FormStartPosition.CenterScreen;
                //  GlobalWaitForm.waitForm.Show();
                string UTI = generateID();
          

                if (Client.RegisterTransactionInDB(clsUser.CurrentUser._ID, UTI,Client._ID,Amount, "Deposit"))
                {
                    //Client.RegisterTransactionInFile(clsBankBusiness.clsUser.CurrentUser._UserName, Amount, "Deposit","Waiting..");



                    // Start listening for messages from the server


                    WaitForm waitForm = new WaitForm();
                    waitForm.StartPosition = FormStartPosition.CenterParent;
                    waitForm.Show(this.tabControl1);
                    await Task.Delay(1500);
                    waitForm.Close();
            
                    //tabControl1.SelectedIndex = 3;


                    //  bool depositAuthorized = false;
                    //  TcpClient _client = null;

                    //  networkStream = _client.GetStream();
                    short milesec = 1000;
                    do
                    {
                        _ = serverListener.StartListeningAsync(ServerIP, Port);
                        if (milesec>5000)
                        {
                            MessageBox.Show(this,"Authorize offline!","Exception",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            return;
                        }
                        await Task.Delay(milesec);
                        milesec += 1000;
                    } while (serverListener.IsConnected==false);
                    SendMessage(serverListener.networkStream, "Deposit");

                    //SendMessageToAuthorize("Deposit");
                    // ListenForMessages();
                    // PerformTransaction();
                    //authorizeEvent.WaitOne();
                    // string Msg = "";
                    //do
                    //{
                    //    await Task.Delay(1000);
                    //    Msg = ReceiveMessage(_client.GetStream());
                    //} while (Msg == "");
                 
                    //clsBankBusiness.clsBankClient.clsTransaction transaction = new clsBankBusiness.clsBankClient.clsTransaction(Client);
                    //transaction.TransactionID = Convert.ToInt32(transactionId);
                    //transaction.Status = response;
                    //transactionList.Add(transaction);

                    //if (response == "Authorize")
                    //{
                    //    depositAuthorized = true;
                    //}
                    //else
                    //{
                    //    depositAuthorized = false;
                    //}

                     //_client.Close();
             

                    //if (depositAuthorized)
                    //{
                    //   // GlobalWaitForm.waitForm.Close();
                    //    Client.Deposit(Amount);
                    //    SystemSounds.Asterisk.Play();
                    //    MessageBox.Show(this, $"Amount Deposited Successfully.\n new Balance is {Client._AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //    clsBankDataAccess.UpdateBalance(Convert.ToInt32(transactionId),Client._AccountBalance);
                    //    _RefreashDataGridView();
                    //    await Task.Delay(2000);

                    //   // clsBankBusiness.clsBankClient.clsTransaction transaction = new clsBankBusiness.clsBankClient.clsTransaction(Client);
                    //    // transactionQueue = new ConcurrentQueue<clsBankBusiness.clsBankClient.clsTransaction>();
                    //  //  TransactionProcessor();
                    // //   AddTransaction(transaction);
                    //    // frmTransactionReport Report = new frmTransactionReport(Client);
                    //   // Report.StartPosition = FormStartPosition.CenterParent;
                    //   // Report.ShowDialog(this);
                    //    ResetDepositScreen();
                    //    notifyIconDeposit.Icon = SystemIcons.Information;
                    //    notifyIconDeposit.BalloonTipTitle = "Success";
                    //    notifyIconDeposit.BalloonTipText = $"{Client.FullName()} new Balance is {Client._AccountBalance}.\nClick here to Print Receipt";
                    //    notifyIconDeposit.ShowBalloonTip(3000);
                    //    // SendMessage(_client.GetStream(), depositAuthorized.ToString());

                    //}
                    //else
                    //{
                    //   // GlobalWaitForm.waitForm.Close();
                    //    ResetDepositScreen();
                    //    SystemSounds.Exclamation.Play();
                    //    MessageBox.Show(this, "Opration was Cancelled..\nAuthorization Failed.");
                    //    _RefreashDataGridView();
                    //}

                }
                else
                {

                    SystemSounds.Exclamation.Play();
                    MessageBox.Show(this, "Opration was Cancelled.");
                    return;
                }
            }
            else
            {

                SystemSounds.Exclamation.Play();
                MessageBox.Show(this, "Opration was Cancelled.");
                return;
            }


        }
        private void ResetDepositScreen()
        {
            lbClientID.Text = "0";
            lbAddress.Text = "Empty";
            lbEmail.Text = "Empty";
            lbBalance.Text = "0";
            lbFirstName.Text = "Empty";
            lbLastName.Text = "Empty";
            lbPhone.Text = "Empty";
            tbDateOfBirth.Value = DateTime.Now;
            roundPic1.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
            CTBDepositAmount.Texts = "";
            CTBAccountNumber.Texts = "";
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Client = clsBankClient.Find(CTBAccountNumber.Texts);
            if (Client != null)
            {
                lbAddress.Text = Client._Address;
                lbClientID.Text = Client._ID.ToString();
                lbBalance.Text = Client._AccountBalance.ToString();
                lbEmail.Text = Client._Email;
                lbFirstName.Text = Client._FirstName;
                lbLastName.Text = Client._LastName;
                lbPhone.Text = Client._Phone;
                tbDateOfBirth.Value = Client._DateOfBirth;
                roundPic1.Load(Client._ImagePath);

                CTBDepositAmount.Enabled = true;
                btnDeposit.Enabled = true;
                bttonCancel.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                roundPic1.Image = Resources.PersonEmptyPhoto;
                lbNotFound.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbNotFound.Visible = false;
            }
            Cursor = Cursors.Default;
        }

        private void bttonCancel_Click(object sender, EventArgs e)
        {
            CTBDepositAmount.Texts = "";
        }

        private async void btnSearchWithdraw_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Client = clsBankClient.Find(CTBAccountNum.Texts);
            if (Client != null)
            {
                lbAddressWithdraw.Text = Client._Address;
                lbClientIDWithdraw.Text = Client._ID.ToString();
                lbBalanceWithdraw.Text = Client._AccountBalance.ToString();
                lbEmailWithdraw.Text = Client._Email;
                lbFirstNameWithdraw.Text = Client._FirstName;
                lbLastNameWithdraw.Text = Client._LastName;
                lbPhoneWithdraw.Text = Client._Phone;
                DTPDateOfBirth.Value = Client._DateOfBirth;
                roundPic2.Load(Client._ImagePath);

                CTBWithdrawAmount.Enabled = true;
                btnWithdraw.Enabled = true;
                btnCancel.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                roundPic2.Image = Resources.PersonEmptyPhoto;
                lbClientNotFound.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbClientNotFound.Visible = false;
            }
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CTBWithdrawAmount.Texts = "";
        }

        private async void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal Amount = 0;
            if (int.TryParse(CTBWithdrawAmount.Texts, out int amount)) 
            {
                Amount = Convert.ToDecimal(amount);
            }
            else
            {
                MessageBox.Show("Amount Should be A Number!");
                CTBWithdrawAmount.Focus();
            }
            if(CTBWithdrawAmount.Texts==string.Empty||CTBWithdrawAmount.Texts=="0")
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Can not Preform Transaction While Withdraw Amount is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Message = "Are You Sure You Want To Preform This Transaction ?";
            
            //= Convert.ToDecimal(CTBWithdrawAmount.Texts);
            if (MessageBox.Show(this,Message, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
               // Client.RegisterTransactionInFile(clsBankBusiness.clsUser.CurrentUser._UserName, Amount, "WithDraw","Waiting..");
                if (Amount > Client._AccountBalance) 
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show($"Insuffecient Balance!\n You Can WithDraw Up To {Client._AccountBalance}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CTBWithdrawAmount.Texts = "";
                    return;
                }
                string UTI = generateID();


                if (Client.RegisterTransactionInDB(clsGlobal.CurrentUser._ID, UTI, Client._ID, Amount, "WithDraw"))
                {
                    //Client.RegisterTransactionInFile(clsBankBusiness.clsUser.CurrentUser._UserName, Amount, "Deposit","Waiting..");
                    WaitForm waitForm = new WaitForm();
                    waitForm.StartPosition = FormStartPosition.CenterScreen;
                    waitForm.Show();
                    await Task.Delay(1500);
                    waitForm.Close();
                    //GlobalWaitForm.waitForm.StartPosition = FormStartPosition.CenterScreen;
                    //  GlobalWaitForm.waitForm.Show();

                    // GlobalWaitForm.waitForm.Close();
                    //  tabControl1.SelectedIndex = 3;
                    // bool WithDrawAuthorized = false;
                    //  TcpClient _client = null;
                    //try
                    //{


                    //    _client = new TcpClient(ServerIP, Port);


                    //    SendMessage(_client.GetStream(), "WithDraw");
                    short milesec = 1000;
                    do
                    {
                    
                        if (milesec > 5000)
                        {
                            MessageBox.Show(this, "Authorize offline!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        await Task.Delay(milesec);
                        milesec += 1000;
                    } while (serverListener.IsConnected == false);
                    SendMessage(serverListener.networkStream, "WithDraw");
                    //authorizeEvent.WaitOne();
                    //string Msg = "";
                    //do
                    //{
                    //    await Task.Delay(1000);
                    //    Msg = ReceiveMessage(_client.GetStream());
                    //} while (Msg == "");
                    //string[] ArrMsg = Msg.Split('#');
                    //string response = ArrMsg[0];
                    //transactionId = ArrMsg[1];

                    //clsBankBusiness.clsBankClient.clsTransaction transaction = new clsBankBusiness.clsBankClient.clsTransaction(Client);
                    //transaction.TransactionID = Convert.ToInt32(transactionId);
                    //transaction.Status = response;
                    //transactionList.Add(transaction);
                    //  if (response == "Authorize")
                    //  {
                    //      WithDrawAuthorized = true;
                    //}
                    //else
                    //{
                    //    WithDrawAuthorized = false;
                    //}

                    //    _client.Close();
                    //}
                    //catch (Exception ex)
                    //{
                    //    SystemSounds.Hand.Play();
                    //    MessageBox.Show(this, "Authorize does not Respond.");
                    //}

                    //if (WithDrawAuthorized)
                    //{
                    //    // GlobalWaitForm.waitForm.Close();
                    //    Client.Withdraw(Amount);
                    //    SystemSounds.Asterisk.Play();
                    //    MessageBox.Show($"Withdraw Done Successfully.\n new Balance is {Client._AccountBalance}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //    clsBankDataAccess.UpdateBalance(Convert.ToInt32(transactionId), Client._AccountBalance);
                    //    _RefreashDataGridView();
                    //    await Task.Delay(2000);

                    // clsBankBusiness.clsBankClient.clsTransaction transaction = new clsBankBusiness.clsBankClient.clsTransaction(Client);
                    // transactionQueue = new ConcurrentQueue<clsBankBusiness.clsBankClient.clsTransaction>();
                    //  TransactionProcessor();
                    //   AddTransaction(transaction);
                    // frmTransactionReport Report = new frmTransactionReport(Client);
                    // Report.StartPosition = FormStartPosition.CenterParent;
                    // Report.ShowDialog(this);
                    //ResetWithDrawScreen();
                    //notifyIconWithDraw.Icon = SystemIcons.Information;
                    //notifyIconWithDraw.BalloonTipTitle = "Success";
                    //notifyIconWithDraw.BalloonTipText = $"{Client.FullName()} new Balance is {Client._AccountBalance}.";
                    //notifyIconWithDraw.ShowBalloonTip(3000);
                    // SendMessage(_client.GetStream(), depositAuthorized.ToString());

                    //}
                    //else
                    //{
                    //    // GlobalWaitForm.waitForm.Close();
                    //    ResetWithDrawScreen();
                    //    SystemSounds.Exclamation.Play();
                    //    MessageBox.Show(this, "Opration was Cancelled..\nAuthorization Failed.");
                    //    _RefreashDataGridView();
                    //}

                }
                else
                {

                    SystemSounds.Exclamation.Play();
                    MessageBox.Show(this, "Opration was Cancelled.");
                    return;
                }
            
          
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Opration was Cancelled.");
                ResetWithDrawScreen();
                return;
            }

        }
        private void ResetWithDrawScreen()
        {
            lbClientIDWithdraw.Text = "0";
            lbBalanceWithdraw.Text = "0";
            lbAddressWithdraw.Text = "Empty";
            lbEmailWithdraw.Text = "Empty";
            lbFirstNameWithdraw.Text = "Empty";
            lbLastNameWithdraw.Text = "Empty";
            lbPhoneWithdraw.Text = "Empty";
            DTPDateOfBirth.Value = DateTime.Now;
            CTBWithdrawAmount.Texts = "";
            CTBAccountNum.Texts = "";
            roundPic2.Load(@"C:\Resources\PersonEmptyPhoto.jfif");
        }
        private bool IsFoundTransferFrom = false;
        clsBankClient SourceClient = new clsBankClient();
        private async void btnSearchTransferFrom_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if(CTBTransferFrom.Texts == "AccountNumber")
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Please Enter AccountNumber First","Erorr",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }
            SourceClient = clsBankClient.Find(CTBTransferFrom.Texts);
            if (SourceClient != null)
            {
                lbBalanceTransferFrom.Text = SourceClient._AccountBalance.ToString();
                lbFirstnameTransferFrom.Text = SourceClient._FirstName;
                lbLastNameTransferFrom.Text = SourceClient._LastName;
                lbClientIDTransferFrom.Text = SourceClient._ID.ToString();
                roundPicfrom.Load(SourceClient._ImagePath);

                roundPicfrom.Visible = true;
                labelIDTransferFrom.Visible = true;
                labelFirstNameTransferFrom.Visible = true;
                lbLastNameFrom.Visible = true;
                lbBalanceFrom.Visible = true;
                lbBalanceTransferFrom.Visible = true;
                lbFirstnameTransferFrom.Visible = true;
                lbLastNameTransferFrom.Visible = true;
                lbClientIDTransferFrom.Visible = true;

                 IsFoundTransferFrom = true;
                 CheckBothClientExists();
                 Cursor = Cursors.Default;
            }
            else
            {
                IsFoundTransferFrom=false;
                lbNotFoundTransferFrom.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbNotFoundTransferFrom.Visible = false;
            }
            Cursor = Cursors.Default;
        }


        private bool IsFoundTransferTo = false;
        clsBankClient DestinationClient = new clsBankClient();
        private async void btnTransferTo_Click(object sender, EventArgs e)
        {
            
            Cursor = Cursors.WaitCursor;
            if (CTBTransferTo.Texts == "AccountNumber")
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Please Enter AccountNumber First", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor = Cursors.Default;
                return;
            }
            DestinationClient = clsBankClient.Find(CTBTransferTo.Texts);
            if (DestinationClient != null)
            {
                lbBalanceTransferTo.Text = DestinationClient._AccountBalance.ToString();
                lbFirstNameTransferTo.Text = DestinationClient._FirstName;
                lbLastNameTransferTo.Text = DestinationClient._LastName;
                lbClientIDTarnsferTo.Text = DestinationClient._ID.ToString();
                roundPicTo.Load(DestinationClient._ImagePath);

                roundPicTo.Visible = true;
                lbIDTo.Visible = true;
                lbLastNameTo.Visible = true;
                lbBalanceTo.Visible = true;
                lbFirstNameTo.Visible = true;
                lbFirstNameTransferTo.Visible = true;
                lbLastNameTransferTo.Visible = true;    
                lbClientIDTarnsferTo.Visible = true;
                lbBalanceTransferTo.Visible = true;
                IsFoundTransferTo = true;
                CheckBothClientExists();

                Cursor = Cursors.Default;
            }
            else
            {
                IsFoundTransferTo= false;
                lbNotFoundTransferTo.Visible = true;
                SystemSounds.Hand.Play();
                await Task.Delay(1500);
                lbNotFoundTransferTo.Visible = false;
            }
            Cursor = Cursors.Default;
        }
        private void CheckBothClientExists()
        {
            if(IsFoundTransferFrom && IsFoundTransferTo)
            {
                CTBTransferAmount.Enabled = true;
                btnTransfer.Enabled = true;
                btnCancelTransfer.Enabled = true;
               
            }
            else 
            {
                return;
            }
         
        }

        private void CTBTransferFrom_Enter(object sender, EventArgs e)
        {
            if (CTBTransferFrom.Texts == "AccountNumber")
                CTBTransferFrom.Texts = "";
            CTBTransferFrom.ForeColor = Color.Black;
      
        }

        private void CTBTransferFrom_Leave(object sender, EventArgs e)
        {
            if (CTBTransferFrom.Texts == "")
                CTBTransferFrom.Texts = "AccountNumber";
            CTBTransferFrom.ForeColor = Color.DimGray;
        }

        private void CTBTransferTo_Enter(object sender, EventArgs e)
        {
            if (CTBTransferTo.Texts == "AccountNumber")
                CTBTransferTo.Texts = "";
            CTBTransferTo.ForeColor = Color.Black;
        }

        private void CTBTransferTo_Leave(object sender, EventArgs e)
        {
            if (CTBTransferTo.Texts == "")
                CTBTransferTo.Texts = "AccountNumber";
            CTBTransferTo.ForeColor = Color.DimGray;
        }

        private void btnCancelTransfer_Click(object sender, EventArgs e)
        {
            CTBTransferAmount.Texts = string.Empty;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(CTBTransferAmount.Texts == "")
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Can not Preform Transaction While Transfer Amount is Empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal Amount = Convert.ToDecimal(CTBTransferAmount.Texts);
            if (MessageBox.Show("Are You Sure You Want To Preform This Transaction ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if(Amount > SourceClient._AccountBalance)
                {
                     SystemSounds.Hand.Play();
                     MessageBox.Show($"Amount Exeeds The Balance, Enter Another Amount\n You Can Transfer Up To {SourceClient._AccountBalance}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     CTBTransferAmount.Texts = "";
                     return;
                }
                SourceClient.Transfer(Amount,ref DestinationClient,clsUser.CurrentUser._UserName);
                SystemSounds.Asterisk.Play();
                MessageBox.Show($"Transfer Done Successfully.\n {SourceClient.FullName()} new Balance is {SourceClient._AccountBalance}\n {DestinationClient.FullName()} new Balance is {DestinationClient._AccountBalance}","Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ResetTransfer();
            }
            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Opration was Cancelled.");
                ResetTransfer();
                return;
            }

        }

    

        private void ResetTransfer()
        {
            lbIDTo.Visible = false;
            lbLastNameTo.Visible = false;
            lbBalanceTo.Visible = false;
            lbFirstNameTo.Visible = false;
            lbFirstNameTransferTo.Visible = false;
            lbLastNameTransferTo.Visible = false;
            lbClientIDTarnsferTo.Visible = false;
            lbBalanceTransferTo.Visible = false;
            IsFoundTransferTo = false;
            roundPicTo.Visible = false;

            roundPicfrom.Visible = false;
            labelIDTransferFrom.Visible = false;
            labelFirstNameTransferFrom.Visible = false;
            lbLastNameFrom.Visible = false;
            lbBalanceFrom.Visible = false;
            lbBalanceTransferFrom.Visible = false;
            lbFirstnameTransferFrom.Visible = false;
            lbLastNameTransferFrom.Visible = false;
            lbClientIDTransferFrom.Visible = false;

            CTBTransferFrom.Texts = "";
            CTBTransferTo.Texts = "";
            CTBTransferAmount.Texts = "";
        }


    }
}
