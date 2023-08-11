using Model;


namespace USSD_Code_Simulation.DataPlan
{
    public class DisplayPlans
    {
        List<DataPlanDTO> dataPlans = new List<DataPlanDTO>();
        public DisplayPlans()
        {
            dataPlans = new DataServices().GetDataPlans();
        }
        public void showPlans()
        {
            //foreach(var item in dataPlans.Select(x=>x.Plans).Distinct())
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine((int)Plans.Daily + "."+ Plans.Daily);
            Console.WriteLine((int)Plans.Weekly + "." + Plans.Weekly);
            Console.WriteLine((int)Plans.Monthly + "." + Plans.Monthly);
            //select a plan
            Console.WriteLine("select your plan");
            var selectedPlan = Console.ReadLine();
            var selectCategory = Validation(selectedPlan);
            if (selectCategory > 0)
            {
                Console.WriteLine(selectCategory);

                filterBySelectedPlan(selectCategory);
            }
            else
            {
                Console.WriteLine("Invalid input");
                showPlans();
            }
        }
        public void filterBySelectedPlan(int category)
        {
            var filtered = dataPlans.FindAll(x => (int)x.Plans == category);
            foreach(var item in filtered)
            {
                Console.WriteLine($"{item.PlanDescription} @ KES.{item.Price}");
            }
        }
        public int Validation(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                Console.WriteLine("Invalid Input");
                showPlans();
            }
            else
            {
               bool canConverted = int.TryParse(category, out int converted);
                if(canConverted && converted>0 && converted < 4)
                {
                    return converted;
                }
                return 0;
            }
            showPlans();
            return 0;
        }
    }
}
