namespace DesignPattern.Flyweight;

public class Sentence
{
    private string[] _words;
    private Dictionary<int, WordToken> _cache = new Dictionary<int, WordToken>();

    public Sentence(string plainText)
    {
        _words = plainText.Split(" ");
    }

    public WordToken this[int index]
    {
        get
        {
            _cache.Add(index, new WordToken());
            return _cache[index];
        }
    }

    public override string ToString()
    {
        var sentence = new List<string>();
        for (int i = 0; i < _words.Length; i++)
        {

            sentence.Add(_cache.ContainsKey(i) && _cache[i].Capitalize ?
                _words[i].ToUpper() :
                _words[i]);
        }
        return string.Join(" ", sentence);
    }

    public class WordToken
    {
        public bool Capitalize;
    }
}