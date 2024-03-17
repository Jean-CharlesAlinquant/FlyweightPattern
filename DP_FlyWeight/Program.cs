using DesignPattern.Flyweight;

var sentence = new Sentence("This sentence is provided to illustrate the flyweight pattern");
sentence[1].Capitalize = true;
Console.WriteLine(sentence);
