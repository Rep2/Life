using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Life.Models;
using Life.Factory;

namespace Life.Test.Models
{
    public class ResearchTest
    {

        [Fact]
        public void ResearchCreation()
        {

            var research = CreateMockResearch();

            Assert.Equal(research.ResearchLevels.Count, 2);
            Assert.Equal(research.ResearchLevels.ElementAt(1).Duration, 800);

            foreach (ResearchLevel researchLevel in research.ResearchLevels)
            {
                Assert.Equal(researchLevel.Research, research);
            }
        }

        [Fact]
        public void ResearchLevelCosts()
        {
            var research = CreateMockResearch();

            research.ResearchLevels.ElementAt(0).AddResearchLevelsCosts(
                new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = new Resource(){
                            Name = "metal",
                            Description = "sdas"
                        },
                        Value = 100
                    },
                    new ResearchCost(){
                        Resource = new Resource(){
                            Name = "carbon",
                            Description = "sdas"
                        },
                        Value = 300
                    }
                }
            );

            Assert.Equal(research
                .ResearchLevels.ElementAt(0).ResearchCosts.Count, 2);
            
            foreach(ResearchCost cost in research
                .ResearchLevels.ElementAt(0).ResearchCosts)
            {
                Assert.Equal(cost.ResearchLevel, research
                .ResearchLevels.ElementAt(0));
            }

        }

        private Research CreateMockResearch()
        {
            var research = new Research()
            {
                Name = "Energy research",
                Description = "sadas"
            };

            Assert.Equal(research.Name, "Energy research");

            research.AddResearchLevels(
                   new List<ResearchLevel>()
                   {
                       new ResearchLevel(){
                           Level = 1,
                           Duration = 200
                        },
                        new ResearchLevel(){
                           Level = 2,
                           Duration = 800
                        }
                   }
                );

            return research;
        }

    }
}
