﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace wf_CanteenManagement
{
    public class Connection
    {
        private static volatile Connection instance;

        private Connection() { }

        public static Connection Instance
        {
            get
            {
                if (instance == null)
                    instance = new Connection();

                return instance;
            }
        }

        SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        string path_connect = @"Data Source=DESKTOP-RNV8JUS\SQLEXPRESS;Initial Catalog=Canteen;Integrated Security=True";
        DataSet ds = new DataSet();

        public DataSet getData(string sql)
        {
            try
            {
                conn = new SqlConnection(path_connect);
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                ds = new DataSet();
                adapter.Fill(ds, sql);
                conn.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public bool setData(string sql)
        {
            try
            {
                conn = new SqlConnection(path_connect);
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                /*if (ex.Errors.Count > 0) 
                {
                    switch (ex.Errors[0].Number)
                    {
                        case 547: // Code of foreign key violation
                            MessageBox.Show("Foreign key errors");
                            break;                          
                        case 2601: // Code of primary key violation
                            MessageBox.Show("Primary ky errors .");
                            break;                      
                    }
                }*/
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}