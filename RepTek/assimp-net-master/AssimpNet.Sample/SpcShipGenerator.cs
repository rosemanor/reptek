using System;
using System.Collections.Generic;
using System.Text;

namespace Plaza
{
    static class SpcShipGenerator
    {
        static Random r = new Random();
        static List<SpaceShip> listAsteroid = new List<SpaceShip>();   

        public static void Generate(int cantidad, bool borrar)
        {
            if (borrar == true)
                listAsteroid.Clear();
            for (int i = 0; i < cantidad; i++)
            {
            	SpaceShip s = new SpaceShip();
            	s.Create();
            	s.Reset();
            	listAsteroid.Add(s);
            }
           
        }

        public static bool CheckCollision(Position pNave, float radio)
        {
//            foreach (var item in listAsteroid)
//            {
//                Position pAsteroide = item.Position;
//                if (Math.Pow(Math.Pow(pAsteroide.x - pNave.x, 2) + Math.Pow(pAsteroide.y - pNave.y, 2) + Math.Pow(pAsteroide.z - pNave.z, 2), 1 / 3f) < radio)
//                {
//                    if (item.Crashed == false)
//                    {
//                        item.Crashed = true;
//                        return true; 
//                    }
//                }
//            }
            return false;
        }

        public static void Draw()
        {
            foreach (var item in listAsteroid)
            {
                item.Draw2();  
            }
        }
    }
}
