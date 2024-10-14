Using System;

class Octopus
{
  public readonly int SizeInFeet = 12;
  public readonly string Name;
  public readonly int Legs = 8;
  
  public Octopus (string name)
  {
    Name = name;
  }
}

public class GiantOctopus : Octopus 
{
  public readonly int SizeInFeet = 24;
}



class startsHere
{
  public static void Main()
  {
    var Octavius = new Octopus("Octavius");
    Console.WriteLine("The size of " + Octavius.Name + " the octopus is " + " Octavius.Size");
    var OctaviusTheFourth = new GiantOctopus("OctaviusTheFourth");
    Console.WriteLine("The size of " + OctaviusTheFourth.Name + " the octopus is " + " OctaviusTheFourth.Size");
  }
}
