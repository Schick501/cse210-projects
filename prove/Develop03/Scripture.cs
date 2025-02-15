using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; }
    private Random random = new Random();
    
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    
    public string GetDisplayText()
    {
        return $"{Reference}\n{string.Join(" ", Words)}";
    }
    
    public void HideRandomWords(int count)
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);
        
        for (int i = 0; i < wordsToHide; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }
    
    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
