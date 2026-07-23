public class WordDictionary {

    TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
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
        return DFS(word, 0, root);
    }

    private bool DFS(string word, int index, TrieNode root)
    {
        var curr = root; 

        for(var i = index; i < word.Length; i++)
        {
            var c = word[i];
            if(c == '.')
            {
                foreach(var child in curr.Children)
                {
                    if(child != null && DFS(word, i+1, child))
                        return true;
                }
            return false;
            }
            else
            {
                if(curr.Children[c - 'a'] == null)
                    return false;
                
                curr = curr.Children[c-'a'];
            }            

        }

        return curr.IsEndOfWord;
    }
}

public class TrieNode
{
    public TrieNode[] Children = new TrieNode[26];
    public bool IsEndOfWord {get; set;}
}

