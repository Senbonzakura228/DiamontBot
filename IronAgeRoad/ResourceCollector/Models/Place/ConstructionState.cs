namespace CruelWorld.IronAgeRoad.Models.Place
{
    public class ConstructionState
    {
        public int collections = 0;
        public int constructionFinishedAt = 0;
        public int forge_points_for_level_up = 0;
        public int invested_forge_points = 0;
        public long next_state_transition_at = 0;
        public int next_state_transition_in = 0;
        public int pausedAt = 0;
        public int socialInteractionStartedAt = 0;
        public int timeReductionsUsed = 0;
        public string __class__ = "ConstructionState";

        public ConstructionState(long transition_at)
        {
            next_state_transition_at = transition_at;
        }
        
    }
    
}