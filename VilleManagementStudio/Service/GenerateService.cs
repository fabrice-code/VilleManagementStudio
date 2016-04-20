using VilleManagementStudio.Models;

namespace VilleManagementStudio.Service
{
    static class GenerateService
    {
        public static ServiceBuildingModel GenerateTemplateService(string name, int price, int capacity)
        {
            return new ServiceBuildingModel
            {
                Name = name,
                Price = price,
                Capacity = capacity,
                Quantity = 0
            };
        }

        public static AttractivityBuildingModel GenerateTemplate(string name, int price, int attractivity)
        {
            return new AttractivityBuildingModel
            {
                Name = name,
                Price = price,
                Attractivity = attractivity,
                Quantity = 0
            };
        }
    }
}
