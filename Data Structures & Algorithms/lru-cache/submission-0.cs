public class LRUCache {
    LinkedList<CacheItem> lru = new LinkedList<CacheItem>();
    Dictionary<int, LinkedListNode<CacheItem>> cache = 
        new Dictionary<int, LinkedListNode<CacheItem>>();
    int _capacity;

    public LRUCache(int capacity) {
        _capacity = capacity;    
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key))
            return -1;
        
        var node = cache[key];
        UpdateMostRecent(node);

        return node.Value.Value;
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key))
        {
            var node = cache[key];
            node.Value.Value = value;
            UpdateMostRecent(node);
            cache[key] = node;
            return;
        }

        var newNode = lru.AddLast(new CacheItem(key, value));

        cache[key] = newNode;

        if(lru.Count > _capacity)
        {  
            var first = lru.First;
            lru.RemoveFirst();
            cache.Remove(first.Value.Key);
        }
    }

    private void UpdateMostRecent(LinkedListNode<CacheItem> node)
    {
        lru.Remove(node);
        lru.AddLast(node);
    }
}

public class CacheItem
{
    public CacheItem(int key, int value)
    {
        Key = key;
        Value = value;
    }

    public int Key {get; set;}
    public int Value {get; set;}

}


/*
CacheItem {key, value}

Doubly LinkedList, this list will keep the record of the LRU
LRU.First -> LRU
LRU.Last -> MRU

Keep a Dictionary having the key as the key and pointing to the node in the value

GET
Go to dictionary, if it does not exists, return -1
otherwise
    Get the node from the map
    Move to MRU
    return item

PUT
    if exists
        Update Value (get from dictionary, update val)
    else
        add to map
        add to MRU
        if over capacity
            remove from map
            remove LRU

*/