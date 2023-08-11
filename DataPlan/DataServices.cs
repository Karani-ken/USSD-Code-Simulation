using Model;

namespace USSD_Code_Simulation.DataPlan
{
    public class DataServices
    {
        public List<DataPlanDTO> GetDataPlans()
        {
            List<DataPlanDTO> list = new List<DataPlanDTO>()
            {
                new DataPlanDTO() {Id=1, PlanDescription="20Mbs", Price=5, Plans=Plans.Daily},
                new DataPlanDTO() {Id=2, PlanDescription="50Mbs", Price=10, Plans=Plans.Daily},
                new DataPlanDTO() {Id=3, PlanDescription="100Mbs", Price=50, Plans=Plans.Daily},
                new DataPlanDTO() {Id=4, PlanDescription="200Mbs", Price=70, Plans=Plans.Weekly},
                new DataPlanDTO() {Id=5, PlanDescription="500Mbs", Price=100, Plans=Plans.Weekly},
                new DataPlanDTO() {Id=6, PlanDescription="1GB", Price=150, Plans=Plans.Weekly},
                new DataPlanDTO() {Id=7, PlanDescription="10GB", Price=500, Plans=Plans.Monthly},
                new DataPlanDTO() {Id=8, PlanDescription="20GB", Price=1000, Plans=Plans.Monthly},
                new DataPlanDTO() {Id=9, PlanDescription="50GB", Price=3000, Plans=Plans.Monthly}

            };
            return list;
        }
    }
}
