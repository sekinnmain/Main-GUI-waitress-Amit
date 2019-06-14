using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using Main.ClientOs;


namespace ClientMain
/// <summary>
/// This class represent a form which is a client that connects to the server to port 9999 and get an update snapshot of the Orders.xml and Displays them in the DataGrid.
/// Developed by Amit Dahari and Yonatan Orozko
/// </summary>

{
    public partial class EmployeeViewForm : Form
    {
        public int interval = 60000;
        DataRow row;
        DataTable OrderServiceTable = new DataTable("Order Service");
        XDocument myDataFromServer;
        DataSet dataSet = new DataSet();
        int tickTack;

        public EmployeeViewForm() 
        {

            InitializeComponent();
            timer1.Start();


        }
        public void ReadData()//Open a socket in port 9999, gets data from server, clear previous data from the Data-grid and binds new data.
        {
            SynchronousSocketClient ssc = new SynchronousSocketClient();
            myDataFromServer = ssc.GetData();
            OrderServiceTable.Clear();
            BindDataToGrid();
        }
        public void BindDataToGrid()//Bind the data to the data-grid
        {


            foreach (XElement xe in (myDataFromServer.XPathSelectElements($"//Order")))
            {
                Double timeWaiting = (DateTime.Now - (DateTime.Parse(xe.Element("TimeOrder").Value))).TotalMinutes;

                row = OrderServiceTable.NewRow();

                row["Order number"] = xe.Element("idOrder").Value;
                row["Client name"] = xe.Element("user").Value;
                row["Dishes ordered"] = xe.Element("dishes").Value;
                row["Time since ordered"] = string.Format($"{timeWaiting.ToString("0.00")} minutes ago");
                row["Table number"] = xe.Element("tableBnum").Value;
                row["Client petition"] = xe.Element("ClinetRequest").Value;
                OrderServiceTable.Rows.Add(row);
            }
            dataGridView1OrderService2.DataSource = OrderServiceTable;

        }
        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            OrderServiceTable.Columns.Add("Order number");
            OrderServiceTable.Columns.Add("Client name");
            OrderServiceTable.Columns.Add("Dishes ordered");
            OrderServiceTable.Columns.Add("Time since ordered");
            OrderServiceTable.Columns.Add("Table number");
            OrderServiceTable.Columns.Add("Client petition");
            dataSet.Tables.Add(OrderServiceTable);


        }
        private void Timer1_Tick(object sender, EventArgs e)//Timer from the designer set to update the data each 5 seconds
        {
            tickTack++;
            ReadData();
        }
    }
}
