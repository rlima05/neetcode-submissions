public class PrefixTree {

    TrieNode root;

    public PrefixTree() {
        root = new TrieNode();    
    }
    
    public void Insert(string word) {
        var curr = root;
        foreach(var c in word)
        {
            var i = c - 'a';
            if(curr.Children[i] == null)
                curr.Children[i] = new TrieNode();
            
            curr = curr.Children[i];
        } 

        curr.IsEndOfWord = true;
    }
    
    public bool Search(string word) {
        var curr = SearchInternal(word);

        return curr == null? false : curr.IsEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        var curr = SearchInternal(prefix);

        return curr != null;
    }

    private TrieNode SearchInternal(string word)
    {
        var curr = root;

        foreach(var c in word)
        {
            var i = c - 'a';
            if(curr.Children[i] != null)
                curr = curr.Children[i];
            else
                return null;
        }

        return curr;
    }
}

public class TrieNode
{
    public TrieNode[] Children = new TrieNode[26];
    public bool IsEndOfWord {get; set;}
}