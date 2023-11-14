namespace CruelWorld.IronAgeRoad.Models
{
    public class BuildingPosition
    {
        public int x;
        public int y;
        public string __class__ = "Position";

        public BuildingPosition()
        {
            
        }

        public BuildingPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}