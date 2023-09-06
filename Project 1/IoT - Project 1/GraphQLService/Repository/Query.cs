using GraphQLService.Model;

namespace GraphQLService.Repository
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<AirPiValue> GetAirPiValues([Service] AirPiDbContext context) =>
            context.AirPiValues;
    }
}
