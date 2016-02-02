using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Life.Models;
using Life.Factory;
using NSubstitute;
using Life.Test.Models;
using System.Threading;

namespace Life.Test.Models
{
    public class PlanetTest
    {
        [Fact]
        public void CreatePlanetFactory()
        {
            var planet = PlanetFactory.Create();

            Assert.NotNull(planet);

            Assert.InRange(planet.Location.X, 0, 100000);
            Assert.InRange(planet.Location.Y, 0, 100000);
            Assert.InRange(planet.Location.Z, 0, 100000);
        }

        [Fact]
        public void AddUser()
        {
            var planet = PlanetFactory.Create();

            var user = Substitute.For<User>();

            planet.User = user;

            Assert.NotNull(planet.User);
                
        }

        [Fact]
        public void AddBuildingToPlanetSuccess()
        {
            var planet = PlanetFactory.Create();

            var building = new BuildingsTest().CreateMetalMine();

            // Adds first level
            Assert.True(planet.AddBuilding(building.BuildingLevels.ElementAt(0)));

            Assert.Equal(planet.BuiltBuildings.Count, 1);

            // Adds second level
            Assert.True(planet.AddBuilding(building.BuildingLevels.ElementAt(1)));

            Assert.Equal(planet.BuiltBuildings.Count, 2);
        }

        [Fact]
        public void AddBuildingToPlanetFalse()
        {
            var planet = PlanetFactory.Create();

            var building = new BuildingsTest().CreateMetalMine();

            // Adds second level
            Assert.False(planet.AddBuilding(building.BuildingLevels.ElementAt(1)));

            Assert.Equal(planet.BuiltBuildings.Count, 0);
        }

        [Fact]
        public void CheckStartBuildingSuccess()
        {
            var planet = PlanetFactory.Create();

            var building = new BuildingsTest().CreateMetalMine();

            // Start building lvl 1 metal mine
            Assert.True(planet.StartBuildingBuilding(building.BuildingLevels.ElementAt(0)));
            Assert.NotNull(planet.CurrentlyBuilding);

            // Wait for building to be built
            Thread.Sleep(1001);

            // Refreshes old build and starts building lvl 2 metal mine
            Assert.True(planet.StartBuildingBuilding(building.BuildingLevels.ElementAt(1)));
            Assert.NotNull(planet.CurrentlyBuilding);
            Assert.Equal(planet.BuiltBuildings.Count, 1);
        }

        [Fact]
        public void CheckStartBuildingWhenAlreadyBuilding()
        {
            var planet = PlanetFactory.Create();

            var building = new BuildingsTest().CreateMetalMine();

            // Start building lvl 1 metal mine
            Assert.True(planet.StartBuildingBuilding(building.BuildingLevels.ElementAt(0)));
            Assert.NotNull(planet.CurrentlyBuilding);

            // Wait to short for building to be built
            Thread.Sleep(200);

            // Refreshes old build, detects that it has not 
            // finish building and does not start building lvl 2 metal mine
            Assert.False(planet.StartBuildingBuilding(building.BuildingLevels.ElementAt(1)));
            Assert.NotNull(planet.CurrentlyBuilding);
            Assert.Equal(planet.BuiltBuildings.Count, 0);
        }

        [Fact]
        public void CheckStartBuildingWhenLowerLvlNotBuilt()
        {
            var planet = PlanetFactory.Create();

            var building = new BuildingsTest().CreateMetalMine();

            // Tires to build lvl 2 metal mine but lvl 1 not built
            Assert.False(planet.StartBuildingBuilding(building.BuildingLevels.ElementAt(1)));
            Assert.Null(planet.CurrentlyBuilding);
            Assert.Equal(planet.BuiltBuildings.Count, 0);
        }


        [Fact]
        public void StopBuilding()
        {
            var planet = PlanetFactory.Create();

            var building = new BuildingsTest().CreateMetalMine();

            // Start building lvl 1 metal mine
            Assert.True(planet.StartBuildingBuilding(building.BuildingLevels.ElementAt(0)));
            Assert.NotNull(planet.CurrentlyBuilding);

            // Stops build
            Assert.True(planet.StopBuilding());
        }

        [Fact]
        public void StopBuildingAfterComplete()
        {
            var planet = PlanetFactory.Create();

            var building = new BuildingsTest().CreateMetalMine();

            // Start building lvl 1 metal mine
            Assert.True(planet.StartBuildingBuilding(building.BuildingLevels.ElementAt(0)));
            Assert.NotNull(planet.CurrentlyBuilding);

            Thread.Sleep(1001);

            // Stops build after building complete
            Assert.False(planet.StopBuilding());
        }
    }
}
