using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum VehicleStates
{
    DRIVING,
    STOPPED
}

public enum ErrorType
{
    NONE,
    ACCIDENT,
    OTHER
}

public class AgentMessage : MonoBehaviour
{
    public double x_location;
    public double z_location;
    public double y_rotation;
    public int vehicle_speed;
    public VehicleStates vehicle_state;
    public bool error_state;
    public ErrorType error_code;

    /*public AgentMessage (double x_location, double z_location, double y_rotation, double vehicle_speed, VehicleStates vehicle_state, bool error_state, ErrorType error_code)
    {
        this.x_location = x_location;
        this.z_location = z_location;
        this.y_rotation = y_rotation;
        this.vehicle_speed = vehicle_speed;
        this.vehicle_state = vehicle_state;
        this.error_state = error_state;
        this.error_code = error_code;
    }*/

    public override string ToString()
    {
        return JsonUtility.ToJson(this);
    }
}

