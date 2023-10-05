﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ClientChat.ServiceChat;
using System.Runtime.Remoting.Messaging;

namespace ClientChat
{
    public partial class Form1 : Form , IWCFserviceCallback
    {
        bool isConnected = false;
        WCFserviceClient client;
        int ID;
        string IDpassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void Connected()
        {
            if (!isConnected)
            {
                client = new WCFserviceClient(new System.ServiceModel.InstanceContext(this));
                string clientID = tbPassword.Text;
                ID = client.Connect(tbUsername.Text);
                bConnect.Enabled = false;
                bConnect.Text = "Disconnected";
                isConnected = true;

            }
        }
        void Disconnected()
        {
            if(isConnected)
            {
                client.Disconnect(ID);
                bConnect.Text = "Connected";
                isConnected = false;
                bConnect.Enabled = true;
            }
            
        }
        private void bConnect_Click(object sender, EventArgs e)
        {
            if(isConnected)
            {
                Disconnected();
            }
            else
            {
                Connected();
            }
        }

        public void MessageCallback(string msg)
        {
            lbCallBack.Items.Add(msg);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnected();
        }

        private void tbInsert_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (client != null)
                {
                    client.SendMessage(tbInsert.Text, ID);
                    tbInsert.Text = string.Empty;
                }
            }
        }
    }
}
