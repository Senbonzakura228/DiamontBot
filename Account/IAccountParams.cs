namespace CruelWorld.Account
{
    public interface IAccountParams
    {
        public string UserKey { get; set; }
        public string Domain { get; set; }
        public string region { get; set; }
        public string origin { get; set; }
        public string sid { get; set; }
        public int currentResearchIndex { get; set; }
        public bool tutorialHasComplete { get; set; }
        public bool startBuildingHasPlaced { get; set; }
    }
}
