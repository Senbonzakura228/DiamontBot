namespace CruelWorld.IronAgeRoad.Models.Place
{
    public class PlaceBuildingEntity
    {
        public string cityentity_id;
        public int connected = 1;
        public int id;
        public int level = 0;
        public int max_level = 0;
        public int player_id = 0;
        public ConstructionState state;
        public string type;
        public int x;
        public int y;
        public string __class__ = "CityMapEntity";

        public PlaceBuildingEntity(string entityID, ConstructionState state, int id, string type, int x, int y)
        {
            cityentity_id = entityID;
            this.state = state;
            this.id = id;
            this.type = type;
            this.x = x;
            this.y = y;
        }
        
    }
}