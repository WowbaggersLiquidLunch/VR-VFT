using System;

public class Flash
{
    private int _size;
    private bool _seen;
    public Flash()
	{
	}

    public Flash(int size, bool seen)
    {
        Size = size;
		Seen = seen;
    }

    public Flash(int size)
    {
        Size = size;
        Seen = false;
    }

    public int Size
    {
		get { return _size; }
        set { _size = value; }
    }

    public bool Seen
    {
		get { return _seen; }
        set { _seen = value; }
    }
}
