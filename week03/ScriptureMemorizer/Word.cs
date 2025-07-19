using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _text = new string('_', _text.Length);
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        if (_text == new string('_', _text.Length))
        {
            return true;
        }

        return false;
    }

    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }

        return new string('_', _text.Length);
    }
}