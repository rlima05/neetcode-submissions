public class TimeMap {
    Dictionary<string, Dictionary<int, string>> Map = new Dictionary<string, Dictionary<int, string>>();
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!Map.ContainsKey(key))
            Map[key] = new Dictionary<int, string>();
        
        Map[key].Add(timestamp, value);
    }
    
    public string Get(string key, int timestamp) {
        if(!Map.ContainsKey(key)) return "";

        var mapped = Map[key];

        while(!mapped.ContainsKey(timestamp) && timestamp >= 0)
            timestamp--;
        
        return timestamp >= 0? mapped[timestamp] : "";
    }
}
