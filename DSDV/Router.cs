
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DSDV
{
    public class Router
    {
        string _name;
        Dictionary<Router, int> _neighbors;
        RoutingTable _routingTable;


        public Router(string name)
        {
            _neighbors = new Dictionary<Router, int>();
            _name = name;
            _routingTable = new RoutingTable(this.Name);
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public Dictionary<Router, int> Neighbor
        {
            get
            {
                return _neighbors;
            }
            set
            {
                _neighbors = value;
            }
        }

        public RoutingTable RoutingTable
        {
            get
            {
                return _routingTable;
            }

            set
            {
                _routingTable = value;
            }
        }

        public Dictionary<Router, int> Neighbors
        {
            get
            {
                return _neighbors;
            }

            set
            {
                _neighbors = value;
            }
        }

        public void AddNeighbor(Router router, int weight)
        {
            if (!_neighbors.ContainsKey(router))
            { 
                _neighbors.Add(router, weight);
                router._neighbors.Add(this, weight);
            }
        }

        public void SendTable(Router receiver, int time, int updateSeconds)
        {
            receiver.ReceiveTable(this.RoutingTable, this, time, updateSeconds);
        }

        public void ReceiveTable(RoutingTable table, Router sender, int time, int updateSeconds)
        {
            RoutingTable.UpdateTable(table, _neighbors[sender], time, updateSeconds);
        }
    }
}
