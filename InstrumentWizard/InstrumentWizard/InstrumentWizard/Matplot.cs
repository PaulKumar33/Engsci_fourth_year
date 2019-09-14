using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace InstrumentWizard
{
    class Matplot
    {
        DataTable mainTable;

        StreamReader dataStream;
        public Matplot(string dir)
        {
            if (dir == null)
            {
                throw new Exception("Data file passed in was null");
            }
            /*dir = System.IO(dir);
            //general mathplot class constructor
            dataStream = new StreamReader(@"{0}", dir);*/

            mainTable = new DataTable();
            mainTable.Columns.Add("X_Value", typeof(double));
            mainTable.Columns.Add("Y_Value", typeof(double));
        }
    }
}
