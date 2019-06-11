using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;


//public static void XmlParserOrder(OrderService myOrder)
//{
//    XDocument doc = XDocument.Load(xmlOrder);
//    XElement school = doc.Element("Orders");
//    school.Add(new XElement("Order",
//               new XElement("IdOrder", myOrder.IdOrder),
//               new XElement("user", myOrder.user),
//               new XElement("dishes", myOrder.dishNameFromOrder()),
//               new XElement("TimeOrder", DateTime.Now),
//               new XElement("SeatOrGo", myOrder.SeatOrGo),
//               new XElement("TableBnum", myOrder.TableBnum),
//               new XElement("ClinetRequest", myOrder.Nots),
//               new XElement("Price", myOrder.price)));


//    doc.Save(xmlOrder);
//}

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
        //controller.ClientOs myClient = new controller.ClientOs();



        public EmployeeViewForm()
        {

            InitializeComponent();
            timer1.Start();
            

        }

        public void ReadData()
        {
           
            controller.ClientOs.ConnectToServer();
            myDataFromServer = controller.ClientOs.GetDataFromSrv();
            BindDataToGrid();
        }

        public void BindDataToGrid()
        {
            

            foreach (XElement xe in (myDataFromServer.XPathSelectElements($"//Order")))
            {
                row = OrderServiceTable.NewRow();

                row["IdOrder"] = xe.Element("IdOrder").Value;
                row["user"] = xe.Element("user").Value;
                row["dishes"] = xe.Element("dishes").Value;
                row["TimeOrder"] = xe.Element("TimeOrder").Value;
                row["TableBnum"] = xe.Element("TableBnum").Value;
                row["ClinetRequest"] = xe.Element("ClinetRequest").Value;
                OrderServiceTable.Rows.Add(row);
            }
            dataGridView1OrderService2.DataSource = OrderServiceTable;

        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            OrderServiceTable.Columns.Add("IdOrder");
            OrderServiceTable.Columns.Add("user");
            OrderServiceTable.Columns.Add("dishes");
            OrderServiceTable.Columns.Add("TimeOrder");
            OrderServiceTable.Columns.Add("TableBnum");
            OrderServiceTable.Columns.Add("ClinetRequest");
            dataSet.Tables.Add(OrderServiceTable);


        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tickTack++;
            ReadData();
        }
    }
}
 