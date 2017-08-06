using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace HeretPreWorkControl
{
    class Excel
    {
        /* 
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public Dictionary<int, string[]> ReadFrom (int nStartIndex, int nStartCol)
        {
            Dictionary<int, string[]> Dictionary = new Dictionary<int, string[]>();

            foreach (var item in ws.Rows)
            {
                if(nStartIndex <= 625)
                {
                    int nClientNo = int.Parse(ws.Cells[nStartIndex, nStartCol].Value.ToString());
                    string strName = ws.Cells[nStartIndex, nStartCol + 1].Value;
                    string strEnglishName = ws.Cells[nStartIndex, nStartCol + 2].Value;
                    string strStatus = ws.Cells[nStartIndex, nStartCol + 3].Value;
                    string strPerson = ws.Cells[nStartIndex, nStartCol + 5].Value;

                    string[] strData = { strName, strEnglishName, strStatus, strPerson };

                    Dictionary.Add(nClientNo, strData);
                }
                else
                {
                    return Dictionary;
                }

                nStartIndex++;
            }

            return Dictionary;
        } */
    }
}
