using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    static public class MyElements
    {
        static public bool Lock_log = false;
        static public bool trener = false;
        static public bool spotman = false;
        static public bool admin = false;
        static public string NameUser = null;
        static public string LogName = null;
        static public DataTable GroupTable = new DataTable();
        static public DataTable ZalsTablePON = new DataTable();
        static public DataTable ZalsTableVTOR = new DataTable();
        static public DataTable ZalsTableSREDA = new DataTable();
        static public DataTable ZalsTableCHETV = new DataTable();
        static public DataTable ZalsTablePYAT = new DataTable();
        static public DataTable ZalsTableSUBB = new DataTable();
        static public DataTable PonTable = new DataTable();
        static public DataTable VtorTable = new DataTable();
        static public DataTable SredTable = new DataTable();
        static public DataTable ChetTable = new DataTable();
        static public DataTable PyatTable = new DataTable();
        static public DataTable SubbTable = new DataTable();
    }
}
