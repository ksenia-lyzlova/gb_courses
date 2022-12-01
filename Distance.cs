using System;
class Distance {
  static void Main() {
    int x0 = 3;
    int y0 = 6;
    int z0 = 8;
    int x1 = 2;
    int y1 = 1;
    int z1 = -7;
    float deltaX = x1 - x0;
    float deltaY = y1 - y0;
    float deltaZ = z1 - z0;
    float distance = (float) Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    Console.Write(distance);
  }
}