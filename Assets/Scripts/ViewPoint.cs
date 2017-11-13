using System;
using System.Collections.Generic;

public class ViewPoint
{
    private float _x;
    private float _y;
    private List<Flash> _flashes;
	private int _visits;

	public ViewPoint(float x, float y)
	{
        X = x;
        Y = y;
        Flashes = new List<Flash>();
	}

    public float X
    {
		get { return _x; }
        set { _x = value; }
    }

    public float Y
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

    public override string ToString()
    {
        return "x: " + X + " y: " + Y;
    }
}

