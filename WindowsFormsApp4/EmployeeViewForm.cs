using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;
using Main.ClientOs;


namespace WindowsFormsApp4


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

        public void ReadData()
        {
            SynchronousSocketClient ssc = new SynchronousSocketClient();
            myDataFromServer = ssc.GetData();
            OrderServiceTable.Clear();
            BindDataToGrid();
        }

        public void BindDataToGrid()
        {
            

            foreach (XElement xe in (myDataFromServer.XPathSelectElements($"//Order")))
            {
                Double timeWaiting = (DateTime.Now - (DateTime.Parse(xe.Element("TimeOrder").Value))).TotalMinutes;

                row = OrderServiceTable.NewRow();

                row["Order number"] = xe.Element("IdOrder").Value;
                row["Client name"] = xe.Element("user").Value;
                row["Dishes ordered"] = xe.Element("dishes").Value;
                row["Time since ordered"] = string.Format($"{timeWaiting.ToString("0.00")} minutes ago");
                row["Table number"] = xe.Element("TableBnum").Value;
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tickTack++;
            ReadData();
        }
    }
}
 