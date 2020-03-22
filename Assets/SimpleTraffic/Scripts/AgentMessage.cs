using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMessage : MonoBehaviour
{
    
    public double location_x { get; set; }
    public double location_y { get; set; }
    public AgentMessage (double x, double y) { location_x = x; location_y = y; }
}

