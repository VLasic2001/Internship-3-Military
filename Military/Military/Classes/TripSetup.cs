
namespace Military.Classes
{
    public static class TripSetup
    {
        public static void SetupTank(ref Tank setupTank, int soldierAmount, int tankDistance)
        {
            var totalDistance = 0.0;
            for (var i = 0; i < setupTank.AmountOfTrips(soldierAmount); i++)
            {
                totalDistance += setupTank.Move(tankDistance);
            }

            setupTank.TotalFuelConsumption = totalDistance * setupTank.FuelConsumption / 100;
        }
        public static void SetupWarship(ref Warship setupWarship, int soldierAmount, int warshipDistance)
        {
            var totalDistance = 0.0;
            for (var i = 0; i < setupWarship.AmountOfTrips(soldierAmount); i++)
            {
                totalDistance += setupWarship.Swim(warshipDistance);
            }

            setupWarship.TotalFuelConsumption = totalDistance * setupWarship.FuelConsumption / 100;
        }
        public static void SetupAmfibia(ref Amfibia setupAmfibia, int soldierAmount, int amfibiaLandDistance, int amfibiaWaterDistance)
        {
            var totalWaterDistance = 0.0;
            for (var i = 0; i < setupAmfibia.AmountOfTrips(soldierAmount); i++)
            {
                totalWaterDistance += setupAmfibia.Swim(amfibiaWaterDistance);
            }

            var totalLandDistance = 0.0;
            for (var i = 0; i < setupAmfibia.AmountOfTrips(soldierAmount); i++)
            {
                totalLandDistance += setupAmfibia.Move(amfibiaLandDistance);
            }

            setupAmfibia.TotalFuelConsumption = (totalLandDistance + totalWaterDistance) * setupAmfibia.FuelConsumption / 100;
        }
    }
}
