using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        // variables
        public string channelName, chatterURL, jsonString;
        int viewCount = 0;
        public dynamic jObj;
        public WebClient wClient = new WebClient();
        JArray modList, staffList, adminList, globalModList, viewerList;
        Properties.Settings settings = Properties.Settings.Default;


        public frmMain()
        {
            InitializeComponent();   
        }

        // on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // if channel is not set, prompt user for new channel
            if (settings.channelName == null)
            {
                changeChannel();
            }
            else
            {
                channelName = settings.channelName;
            }

            // put channel into api link
            chatterURL = "http://tmi.twitch.tv/group/user/" + channelName.ToLower() + "/chatters";

            // update label
            lblChannel.Text = ("Channel: " + channelName);
                        
            updateInfo();
        }

        // everytime timer ticks (15 sec default)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // call updateInfo()
            updateInfo();
        }

        // updates viewer count and user list
        public void updateInfo()
        {
            try
            {
                jsonString = wClient.DownloadString(chatterURL);
                jObj = JsonConvert.DeserializeObject(jsonString);

                viewCount = jObj["chatter_count"];

                modList = jObj["chatters"]["moderators"];
                staffList = jObj["chatters"]["staff"];
                adminList = jObj["chatters"]["admins"];
                globalModList = jObj["chatters"]["global_mods"];
                viewerList = jObj["chatters"]["viewers"];

                lstViewerList.Items.Clear();

                lblViewCount.Text = ("Viewers: " + viewCount.ToString());

                foreach (string m in modList)
                {
                    lstViewerList.Items.Add("@" + m);
                }

                foreach (string s in staffList)
                {
                    lstViewerList.Items.Add("S_" + s);
                }

                foreach (string a in adminList)
                {
                    lstViewerList.Items.Add("A_" + a);
                }

                foreach (string gm in globalModList)
                {
                    lstViewerList.Items.Add("GM_" + gm);
                }

                foreach (string v in viewerList)
                {
                    lstViewerList.Items.Add(v);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString() +
                    "\nStopping program. Use the menu strip on the main window to change channel name.");

                timer1.Enabled = false;
            }
        }

        private void changeChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeChannel();
        }

        private void changeChannel()
        {
            timer1.Enabled = false;

            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter new channel below:", "Enter new channel");

            if (input.Length > 0)
            {
                channelName = input;
                settings.channelName = channelName;
                settings.Save();

                chatterURL = "http://tmi.twitch.tv/group/user/" + channelName.ToLower() + "/chatters";

                lblChannel.Text = ("Channel: " + channelName);
            }
            else
            {
                // do nothing
            }

            timer1.Enabled = true;
            updateInfo();
        }
    }
}
