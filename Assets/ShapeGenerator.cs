using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator 
{
    ShapeSettings settings;

    public ShapeGenerator(ShapeSettings settings)
    {
        this.settings = settings;
    }

    public Vector3 CalculatePointOnPlanet(Vector3 pointOnUnitSphere)
    {
        //Debug.Log("Calculate Point On Planet: ["+ pointOnUnitSphere * settings.planetRadius +"]");
        return pointOnUnitSphere * settings.planetRadius;
    }
}
