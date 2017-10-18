using System;
using System.Collections.Generic;

public class ViewPoint
{
    private int _x;
    private int _y;
    private List<Flash> _flashes;
	private int _visits;

	public ViewPoint(int x, int y)
	{
        X = x;
        Y = y;
	}

    public int X
    {
		get { return _x; }
        set { _x = value; }
    }

    public int Y
    {
		get {return _y;}
        set { _y = value; }
    }

    public List<Flash> Flashes
    {
		get { return _flashes; }
        set { _flashes = value; }
    }

	public int Visits
	{
		get {return Flashes.Count;}
	}
}

