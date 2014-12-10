/* UserInterface.cs
 * Author: Ritvik Mandala
 * Home Work Assignment 6
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ksu.Cis300.GraphDrawing;
using Ksu.Cis300.Graphs;
using System.IO;

namespace Ksu.Cis300.GraphDraw
{
    /// <summary>
    /// Class of the program that finds a minimum spanning tree.
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// Construct the GUI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Handles uxLoad event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLoad_Click(object sender, EventArgs e)
        {
          DirectedGraph<Point, double> graphs = new DirectedGraph<Point, double>();
          List<Point> _nodes = new List<Point>();
         if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                uxGraphDrawing.Clear();
                using (StreamReader sr = new StreamReader(uxOpenDialog.FileName))
                {
                    string[] graphSize = sr.ReadLine().Split(',');
                    Size size = new Size(Convert.ToInt32(graphSize[0]), Convert.ToInt32(graphSize[1]));
                    uxGraphDrawing.GraphSize = size;
                    while (!sr.EndOfStream)
                    {
                        string[] points = sr.ReadLine().Split(',');
                        int x = Convert.ToInt32(points[0]);
                        int y = Convert.ToInt32(points[1]);
                        Point point = new Point(x, y);
                        _nodes.Add(point);
                        graphs.AddNode(point);
                        uxGraphDrawing.DrawPoint(point);
                    }
                }
                foreach (Point a in _nodes)
                {
                    foreach (Point b in _nodes)
                    {
                        if (b != a)
                        {
                            graphs.AddEdge(a, b, EdgeCalc(a, b));
                        }
                    }
                }
            }
            try
            {
                Point start = _nodes[0];
                double totalCost = 0;
                Dictionary<Point, Tuple<Point, double>> dict = new Dictionary<Point, Tuple<Point, double>>();
                foreach (Tuple<Point, double> tup in graphs.OutgoingEdges(start))
                {
                    Tuple<Point, double> t = new Tuple<Point, double>(start, tup.Item2);
                    dict.Add(tup.Item1, t);
                }
                while (dict.Count > 0)
                {
                    double cost = Double.PositiveInfinity;
                    Point point = new Point(0, 0);
                    foreach (KeyValuePair<Point, Tuple<Point, double>> kvp in dict)
                    {
                        if (cost > kvp.Value.Item2)
                        {
                            cost = kvp.Value.Item2;
                            point = kvp.Key;
                            start = kvp.Value.Item1;
                        }
                    }
                    uxGraphDrawing.DrawLine(point, start);
                    totalCost += cost;
                    dict.Remove(point);
                    foreach (Tuple<Point, double> tup in graphs.OutgoingEdges(point))
                    {
                        if (dict.ContainsKey(tup.Item1))
                        {
                            if (tup.Item2 < dict[tup.Item1].Item2)
                            {
                                Tuple<Point, double> temp = new Tuple<Point, double>(point, tup.Item2);
                                dict[tup.Item1] = temp;
                            }
                        }
                    }
                }
                MessageBox.Show("The total cost is " + totalCost);
            }
            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Total cost: 0");
            }
        }
        private double EdgeCalc(Point x, Point y)
        {
            double xSum = y.X - x.X;
            xSum *= xSum;
            double ySum = y.Y- x.Y;
            ySum *= ySum;
            double edge = Math.Sqrt(xSum + ySum);
            return edge;

        }
    }
}
