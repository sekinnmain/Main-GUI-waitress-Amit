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

namespace WindowsFormsApp4
{
    public partial class EmployeeViewForm : Form
    {
        public int interval = 60000;
        DataSet dataSet = new DataSet();
        controller.ClientOs myClient = new controller.ClientOs();
        XDocument myDataFromServer;

        public EmployeeViewForm()
        {

            InitializeComponent();
            myClient.ConnectToServer();
            new System.Threading.Timer(ReadData, null, 0, interval);

        }

        public void ReadData(object o)
        {
           myDataFromServer = myClient.GetDataFromSrv();
        }

        public void BindDataToGrid()
        {
            foreach (XElement xe in (myDataFromServer.XPathSelectElements($"//User")))
            {
                dataSet.Tables[0].Rows;

            }

        }

    }
}
 