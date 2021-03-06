﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using ManualMapInjection.Injection;
using MySql.Data.MySqlClient;

namespace DLLLoader
{
    public partial class Form2 : Form
    {
        /* Injection Variables */
        public string ProcessName;
        public string DLLPath;
        public string HWID;

        /* Database Variables */
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string ConnectionString;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeDatabase();
            InternetStatus();

            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            txtSystemHWID.Text = HWID;
            txtSystemHWID.ReadOnly = true;

            lblInjectInfo.Text = "";
        }

        public void GetDataFromForm(string Process, string DLLFilePath)
        {
            ProcessName = Process;
            DLLPath = DLLFilePath;

            lblCheck.Text = "Injecting into process: " + Process + ".";
        }

        private void InitializeDatabase()
        {
            try
            {
                server = "sql7.freemysqlhosting.net";
                database = "sql7243537";
                uid = "sql7243537";
                password = "2iFY7y7Xm2";

                ConnectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SslMode=None";
                connection = new MySqlConnection(ConnectionString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MySql Connection Failed");
            }
        }

        private void InternetStatus()
        {
            try
            {
                using (var WebC = new WebClient())
                {
                    using (WebC.OpenRead("https://google.com/"))
                    {
                        lblStatus.ForeColor = Color.Green;
                        lblStatus.Text = "Online";
                    }
                }
            }
            catch
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Offline";
            }
        }

        private bool ConnectionOpen()
        {
            if(connection.State.ToString() == "Open")
            {
                return true;
            }
            return false;
        }

        private void InjectAllowed()
        {
            try
            {
                if(this.ConnectionOpen() == true)
                {
                    string query = "SELECT * FROM loader WHERE HWID='" + HWID + "'";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    var Reader = cmd.ExecuteReader();
                    
                    while(Reader.Read())
                    {
                        var idDB = Reader["id"];
                        var nameDB = Reader["name"];
                        var active_subscriptionDB = Reader["active_subscription"];
                        string active_sub = active_subscriptionDB.ToString();

                        if(active_sub == "TRUE")
                        {
                            InjectDLL("Allowed");
                        } else
                        {
                            InjectDLL("Not Allowed");
                        }
                    }
                    connection.Close();
                } else
                {
                    connection.Open();
                    InjectAllowed();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed");
            }
        }

        private void InjectDLL(string allowed)
        {
            if(allowed == "Allowed")
            {
                // DLLPath
                // ProcessName
                var ProcessTarget = Process.GetProcessesByName(ProcessName).FirstOrDefault();
                var TargetFile = File.ReadAllBytes(DLLPath);

                if(!File.Exists(DLLPath))
                {
                    MessageBox.Show("DLL not found", "File Error");
                    return;
                }

                var injector = new ManualMapInjector(ProcessTarget) { AsyncInjection = true };
                lblInjectInfo.Text = $"hmodule = 0x{injector.Inject(TargetFile).ToInt64():x8}";

                btnInject.Text = "Injected";
                btnInject.Enabled = false;

                if(File.Exists(DLLPath))
                {
                    File.Delete(DLLPath);
                }
            } else
            {
                MessageBox.Show("Your HWID has not been whitelisted.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HWID);
            btnCopyHWID.Text = "Copied";
            btnCopyHWID.Enabled = false;
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            InjectAllowed();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(this.ConnectionOpen() == true)
            {
                connection.Close();
            }
            Application.Exit();
        }
    }
}
