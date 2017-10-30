using System;
using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using Tao.OpenGl;

 
namespace Plaza
{
    public class MainClass
    { 
        Camara camara = new Camara();
        Plaza plaza = new Plaza();
        SkyBox cielo = new SkyBox();
        Flag flag;
        Road road;
        
        Star star = new Star();
        SpaceShip spaceShip = new SpaceShip();
        
		//tmp
		int counter = 0;//-1000;		
        

        public void CrearObjetos()
        {
            flag = new Flag(new Vector3(-4, 10, -4), "OGL.jpg");
            flag.Create();  
            plaza.Create();
            plaza.CrearColisiones();  
            Sprite.Create();
            //Collision.GhostMode = true;  
            road = new Road();
            road.Create();
            //
            star.CreateStars(450);
            spaceShip.Create();  
            Asteroid.Crear();  
            //
            AsteroidGenerator.GenerateAsteroid(35, true);
            SpcShipGenerator.Generate(9, true);
        }

        public Camara Camara
        {
            get { return camara; }
        }

        public void DibujarEscena()
        {
        	
        	counter++;
        	if (counter >= 0)
        	{
            //plaza.Dibujar();            
            //cielo.Dibujar();
            //flag.Draw();
            
            DebugMode.WriteCamaraPos(200, 200);
            //Collision.DrawColissions();
            road.Draw2();
            //
            star.Draw();
            AsteroidGenerator.DrawAsteroids();
            SpcShipGenerator.Draw();
            spaceShip.Dibujar(); 
            camara.Draw();
            
        	}

            //            
            Sprite.Begin();

            Sprite.DrawText(20, 20, "Press mouse left button to move forward", Glut.GLUT_BITMAP_HELVETICA_18);

            Sprite.DrawText(20, 50, "Press escape to exit", Glut.GLUT_BITMAP_HELVETICA_18); 

            Sprite.End();  
        }
    }
}
