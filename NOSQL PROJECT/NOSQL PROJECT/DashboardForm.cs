using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LOGIC;
using MODEL;

namespace NOSQL_PROJECT
{
    public partial class DashboardForm : Form
    {
        // Create connection to logic layer
        IncidentLogic incidentLogic;

        public DashboardForm()
        {
            InitializeComponent();
            incidentLogic = new IncidentLogic();
        }

        public void GenerateUnresolvedIncidentsChart()
        {
            var plt = new ScottPlot.Plot(350, 300);

            double[] values = { incidentLogic.GetIncidentsByStatus(TicketStatus.Open).Count, incidentLogic.GetIncidents().Count };
            string centerText = $"{values[0]}/{values[1]}";
            Color colorUnresolvedIncidents = Color.Orange;
            Color colorAllIncidents = Color.LightGray;

            var pie = plt.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = Color.Gray;
            pie.SliceFillColors = new Color[] { colorUnresolvedIncidents, colorAllIncidents };

            plt.SaveFig("unresolvedIncidentsChart.png");
            unresolvedIncidentsPictureBox.Load("unresolvedIncidentsChart.png");
        }

        public void GenerateIncidentsPastDeadlineChart()
        {
            var plt = new ScottPlot.Plot(350, 300);

            double[] values = { incidentLogic.GetIncidentsByStatus(TicketStatus.PastDeadline).Count, incidentLogic.GetIncidents().Count };
            string centerText = values[0].ToString();
            Color colorIncidentsPastDeadline = Color.Red;
            Color colorAllIncidents = Color.LightGray;

            var pie = plt.AddPie(values);
            pie.DonutSize = .6;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = Color.Gray;
            pie.SliceFillColors = new Color[] { colorIncidentsPastDeadline, colorAllIncidents };

            plt.SaveFig("incidentsPastDeadlineChart.png");
            incidentsPastDeadlinePictureBox.Load("incidentsPastDeadlineChart.png");
        }

        // Charts were generated with the help of this website https://scottplot.net/cookbook/4.1/category/plottable-pie/#donut-chart
    }
}
