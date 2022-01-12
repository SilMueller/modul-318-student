﻿using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        //Funktion um Vorschläge zu der eingegebenen Startstation zu bekommen
        private void combVon_DropDown(object sender, EventArgs e)
        {
            if (combVon.Text.Length >= 3)
            {
                combVon.Items.Clear();
                combVon.Items.Add(combVon.Text);
                SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Stations stations = new SwissTransport.Models.Stations();
                stations = transport.GetStations(combVon.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    combVon.Items.Add(stations.StationList[i].Name);
                }
            }
        }

        //Funktion um Vorschläge zu der eingegebenen Endstation zu bekommen
        private void combNach_DropDown(object sender, EventArgs e)
        {
            if (combNach.Text.Length >= 3)   
            {
                combNach.Items.Clear();
                combNach.Items.Add(combVon.Text);
                SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Stations stations = new SwissTransport.Models.Stations();
                stations = transport.GetStations(combNach.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    combNach.Items.Add(stations.StationList[i].Name);
                }
            }
        }
        
        //Funktion um mit einem Klick auf den "Verbindungen suchen" Button, die 4 nächsten Verbindungen angezeigt zu bekommen.
        private void btnSearchConnections_Click(object sender, EventArgs e)
        {
            if(combNach.Text != "")
            {
                dataGridConnections.Rows.Clear();
                SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
                SwissTransport.Models.Connections connections = new SwissTransport.Models.Connections();
                connections = transport.GetConnections(combVon.Text, combNach.Text);
                for (int i = 0; i < connections.ConnectionList.Count; i++)
                {
                    string[] text = new string[5];
                    text[0] = connections.ConnectionList[i].From.Platform;
                    text[1] = connections.ConnectionList[i].From.Departure.ToString();
                    text[2] = connections.ConnectionList[i].To.Arrival.ToString();
                    text[3] = Convert.ToString(connections.ConnectionList[i].To.Arrival - connections.ConnectionList[i].From.Departure);
                    text[4] = Convert.ToString(connections.ConnectionList[i].From.Delay + " Minuten");
                    if (Convert.ToString(connections.ConnectionList[i].From.Delay) == "")
                    {
                        text[4] = "Keine Verspätung";
                    }
                    dataGridConnections.Rows.Add(text);
                }
            }
            else
            {
                fillListboxConnections(combVon.Text);
            }
        }

        //Funktion um die Abfahrtstafel zu befüllen.
        public void fillListboxConnections(string fromName)
        {
            listBoxConnections.Items.Clear();
            SwissTransport.Core.ITransport transport = new SwissTransport.Core.Transport();
            SwissTransport.Models.Connections connections = new SwissTransport.Models.Connections();
            SwissTransport.Models.StationBoardRoot stationboardroot = new SwissTransport.Models.StationBoardRoot();
            
            stationboardroot = transport.GetStationBoard(combVon.Text, "0");
            for(int i = 0; i < stationboardroot.Entries.Count; i++)
            {
                string[] text = new string[2];
                text[0] = Convert.ToString(stationboardroot.Station.Name);
                text[1] = stationboardroot.Entries[i].To;
                listBoxConnections.Items.Add(text[1]);
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            tbxTime.Text = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute);
        }
    }
}