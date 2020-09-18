﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Windows
{
    class DataAccess
    {
        private OracleConnection connection;

        public OracleConnection Connection
        {
            get { return this.connection; }
            set { this.connection = value; }
        }

        private OracleCommand command;

        public OracleCommand Command
        {
            get { return this.command; }
            set { this.command = value; }
        }

        private OracleDataAdapter adapter;

        public OracleDataAdapter Adapter
        {
            get { return this.adapter; }
            set { this.adapter = value; }
        }

        private void QueryText(string query)
        {
            this.command = new OracleCommand(query, this.connection);
        }

        public DataTable ExecuteQueryTable(string query)
        {
            this.QueryText(query);
            this.adapter = new OracleDataAdapter(this.command);
            DataTable table = new DataTable();
            this.adapter.Fill(table);
            return table;
        }
    }
}
