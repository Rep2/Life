using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Life.Models;
using Life.ViewModels;
using Life.Controllers;

namespace Life
{
    public partial class BuildingDetails : Form
    {
        BuildingLevel buildingLevel;
        BuildingDetailController controller;

        public BuildingDetails(BuildingLevel buildingLevel, BuildingDetailController controller)
        {
            this.buildingLevel = buildingLevel;
            this.controller = controller;

            controller.view = this;

            InitializeComponent();
        }

        private void BuildingDetails_Load(object sender, EventArgs e)
        {
            label2.Text = buildingLevel.Building.Name + ", level " + buildingLevel.Level.ToString();
            label4.Text = "Build duration: " + buildingLevel.BuildDuration.ToString();
            label6.Text = buildingLevel.Building.Description;

            controller.ViewDidLoad(buildingLevel);
        }

        public void SetData(BindingSource binding1, BindingSource binding2)
        {
            dataGridView1.DataSource = binding1;

            dataGridView2.DataSource = binding2;
        }




   
    }
}
