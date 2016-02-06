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
using Life.Repositories;
using Life.ViewModels;
using Life.Controllers;

namespace Life
{
    public partial class MainScreen : Form
    {
        private User user;

        private Timer timer;

        List<BuildingLevel> buildings = new List<BuildingLevel>();

        BuildingLevel currentlyBuilding;
        double buildingTimeLeft;
        int currentRow;
        EventHandler buildingEventHandler;

        public MainScreen(User user)
        {
            this.user = user;

            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            user.UpdateResources();

            metal.Text = user.UserResources.Where(b => b.Resource.Name == "Metal")
                .First().Amount.ToString();
            carbon.Text = user.UserResources.Where(b => b.Resource.Name == "Carbon")
                .First().Amount.ToString();
            fule.Text = user.UserResources.Where(b => b.Resource.Name == "Fule")
                .First().Amount.ToString();

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerHandler);

            timer.Start();

            PresentBuildings();
            AddPlanets();

            buildingEventHandler = new EventHandler(UpdateBuildingState);
        }

        private void TimerHandler(Object myObject, EventArgs myEventArgs)
        {
            user.UpdateResources();

            metal.Text = user.UserResources.Where(b => b.Resource.Name == "Metal")
                .First().Amount.ToString();
            carbon.Text = user.UserResources.Where(b => b.Resource.Name == "Carbon")
                .First().Amount.ToString();
            fule.Text = user.UserResources.Where(b => b.Resource.Name == "Fule")
                .First().Amount.ToString();
        }

        private void PresentBuildings()
        {
            buildings = new List<BuildingLevel>();

            var buildingRepo = new Repository<Building>();

            var list = new ListViewItem[buildingRepo.Get().Count];

            var displayBuildings = new List<BuildingLevelViewModel>();

            foreach (Building building in buildingRepo.Get())
            {
                var userBuilding = user.Planets.First()
                    .BuiltBuildings.Where(b => b.BuildingLevel.Building.Id == building.Id);

                if (userBuilding.Count() == 0)
                {
                    var buildingLevel = building.BuildingLevels.Where(b => b.Level == 1).First();

                    var metal = buildingLevel.BuildingCosts.Where(b => b.Resource.Name == "Metal").FirstOrDefault();
                    var carbon = buildingLevel.BuildingCosts.Where(b => b.Resource.Name == "Carbon").FirstOrDefault();
                    var fule = buildingLevel.BuildingCosts.Where(b => b.Resource.Name == "Fule").FirstOrDefault();

                    displayBuildings.Add(
                        new BuildingLevelViewModel()
                        {
                            Name = buildingLevel.Building.Name,
                            Level = buildingLevel.Level,
                            Duration = buildingLevel.BuildDuration,
                            MetalCost = metal != null ? metal.Value : 0,
                            CarbonCost = carbon != null ? carbon.Value : 0,
                            FuleCost = fule != null ? fule.Value : 0
                        }
                    );

                    buildings.Add(buildingLevel);
                }
                else
                {
                    var maxLevel = userBuilding.First().BuildingLevel.Level;

                    foreach (BuiltBuilding level in userBuilding)
                    {
                        if (maxLevel < level.BuildingLevel.Level)
                        {
                            maxLevel = level.BuildingLevel.Level;
                        }
                    }

                    var buildingLevel = building.BuildingLevels.Where(b => b.Level == maxLevel + 1).First();

                    var metal = buildingLevel.BuildingCosts.Where(b => b.Resource.Name == "Metal").FirstOrDefault();
                    var carbon = buildingLevel.BuildingCosts.Where(b => b.Resource.Name == "Carbon").FirstOrDefault();
                    var fule = buildingLevel.BuildingCosts.Where(b => b.Resource.Name == "Fule").FirstOrDefault();

                    displayBuildings.Add(
                        new BuildingLevelViewModel()
                        {
                            Name = buildingLevel.Building.Name,
                            Level = buildingLevel.Level,
                            Duration = buildingLevel.BuildDuration,
                            MetalCost = metal != null ? metal.Value : 0,
                            CarbonCost = carbon != null ? carbon.Value : 0,
                            FuleCost = fule != null ? fule.Value : 0
                        }
                    );

                    buildings.Add(buildingLevel);

                }

                var binding = new BindingSource();
                binding.DataSource = displayBuildings;

                dataGridView3.DataSource = binding;
            }

        }

        private void AddPlanets()
        {
            var repo = new Repository<Planet>();

            var planets = new List<PlanetViewModel>();

            foreach (Planet planet in repo.Get())
            {
                planets.Add(
                    new PlanetViewModel()
                    {
                        X = planet.Location.X,
                        Y = planet.Location.Y,
                        Z = planet.Location.Z,
                        Temperature = planet.Temperature,
                        Size = planet.Size,
                        Distance = Math.Sqrt(Math.Pow(planet.Location.X, 2) + Math.Pow(planet.Location.Y, 2) + Math.Pow(planet.Location.Z, 2))
                    }
                    );
            }

            var binding = new BindingSource();
            binding.DataSource = planets;
            dataGridView2.DataSource = binding;

        }

        private void startBuilding(int row)
        {
            if (currentlyBuilding != null)
            {
                MessageBox.Show("Building already being built. Wait for it to finish");
            }
            else
            {
                currentlyBuilding = buildings.ElementAt(row);

                if (!user.UserHasReseourceForBuild(currentlyBuilding))
                {
                    MessageBox.Show("You do not have enaugh resource for the build");
                    currentlyBuilding = null;
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Do you want to build " + currentlyBuilding.Building.Name + ", level " + currentlyBuilding.Level, "Yes", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        user.Planets.First().StartBuildingBuilding(currentlyBuilding);
                        user.RemoveResourceForBuild(currentlyBuilding);

                        currentRow = row;
                        buildingTimeLeft = currentlyBuilding.BuildDuration;

                        dataGridView3.Columns[8].Visible = true;
                        dataGridView3.Columns[9].Visible = true;
                        dataGridView3.Rows[row].Cells[8].Value = buildingTimeLeft.ToString();

                        timer.Tick += buildingEventHandler;
                    }
                    else
                    {
                        currentlyBuilding = null;
                    }
                }
            }
            
        }

        private void cancleBuild()
        {

            user.Planets.First().StopBuilding();
            user.AddResourceForBuild(currentlyBuilding);

            currentlyBuilding = null;

            dataGridView3.Columns[8].Visible = false;
            dataGridView3.Columns[9].Visible = false;
            timer.Tick -= buildingEventHandler;
            dataGridView3.Rows[currentRow].Cells[8].Value = "";

            PresentBuildings();
        }

        private void UpdateBuildingState(Object myObject, EventArgs myEventArgs)
        {
            buildingTimeLeft -= 1;

            if (buildingTimeLeft <= 0)
            {
                dataGridView3.Columns[8].Visible = false;
                dataGridView3.Columns[9].Visible = false;
                timer.Tick -= buildingEventHandler;
                dataGridView3.Rows[currentRow].Cells[8].Value = "";

                user.Planets.First().RefreshBuildingBuildState();

                var repo = new Repository<Planet>();
                repo.Update(user.Planets.First());

                currentlyBuilding = null;

                PresentBuildings();
            }
            else
            {
                dataGridView3.Rows[currentRow].Cells[8].Value = buildingTimeLeft.ToString();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var controller = new BuildingDetailController();
                var form = new BuildingDetails(buildings.ElementAt(e.RowIndex), controller);

                form.Show();
            }
            else if (e.ColumnIndex == 6)
            {
                startBuilding(e.RowIndex);
            }
            else if (e.ColumnIndex == 9)
            {
                if (e.RowIndex == currentRow)
                {

                    DialogResult dialog = MessageBox.Show("Do you want to cancle build", "Yes", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        cancleBuild();
                    }
                }
                else
                {
                    MessageBox.Show("Selected building not being built. To cancle select correct row");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();

            Program.form.Show();
        }

    }
}
