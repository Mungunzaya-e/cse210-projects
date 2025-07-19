using System;
using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ").Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        int verseLength = _words.Count();
        int count = 0;
        Random rnd = new Random();

        while (count < numberToHide)
        {
            int index = rnd.Next(verseLength);
            Word randomWord = _words[index];

            if (!randomWord.IsHidden())
            {
                randomWord.Hide();
                count++;
            }

            randomWord.GetDisplayText();

        }

    }

    public string GetDisplayText()
    {
        string combinedVerse = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {combinedVerse}";
    }
}