
namespace Military
{
    public static class OptimalVehicle
    {
        public static string OptimalVehicleCalculator(Tank checkTank, Warship checkWarship, Amfibia checkAmfibia)
        {
            if (checkTank.TotalFuelConsumption < checkWarship.TotalFuelConsumption &&
                checkTank.TotalFuelConsumption < checkAmfibia.TotalFuelConsumption)
            {
                return $"\n Tank is the most optimal vehicle with {checkTank.TotalFuelConsumption}L used";
            }
            if (checkWarship.TotalFuelConsumption < checkAmfibia.TotalFuelConsumption)
            {
                return $"\n Warship is the most optimal vehicle with {checkWarship.TotalFuelConsumption}L used";
            }
            return $"\n Amfibia is the most optimal vehicle with {checkAmfibia.TotalFuelConsumption}L used";
        }
    }
}
