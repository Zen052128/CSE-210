using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string phrase)
    {
        _reference = reference;
        string[] splitWords = phrase.Split(" ");
        _words = new List<Word>();

        foreach (string word in splitWords)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numbersToHide)
    {
        for (int i = 0; i < numbersToHide; i++)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string DisplayText()
    {
        string displayText = _reference.DisplayText() + ": ";
        foreach (Word i in _words)
        {
            displayText += i.DisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}