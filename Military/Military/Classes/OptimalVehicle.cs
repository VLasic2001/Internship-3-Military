
namespace Military.Classes
{
    public static class OptimalVehicle
    {
        public static string OptimalVehicleCalculator(Tank checkTank, Warship checkWarship, Amfibia checkAmfibia)
        {
            if (checkTank.TotalFuelConsumption < checkWarship.TotalFuelConsumption &&
                checkTank.TotalFuelConsumption < checkAmfibia.TotalFuelConsumption)
            {
                return $"\nTank is the optimal vehicle with {checkTank.TotalFuelConsumption}L used";
            }
            if (checkWarship.TotalFuelConsumption < checkAmfibia.TotalFuelConsumption)
            {
                return $"\nWarship is the optimal vehicle with {checkWarship.TotalFuelConsumption}L used";
            }
            return $"\nAmfibia is the optimal vehicle with {checkAmfibia.TotalFuelConsumption}L used";
        }
    }
}
