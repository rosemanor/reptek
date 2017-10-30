using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using System.Windows.Forms;
using ShadowEngine;
using ShadowEngine.Sound;
using ShadowEngine.ContentLoading; 

namespace Plaza
{
	public class SpaceShip : Asteroid
    {
        int vidas = 3;
        //Position p = new Position(3, -4, 3);
        int count;
        int compare = 10;
        ModelContainer m;
        bool moviendo;

        public SpaceShip()
        {
            p = default(Position);
            //rot = r.Next(90);
        }
               

        public bool Moviendo
        {
            get { return moviendo; }
            set { moviendo = value; }
        }

        public int Vidas
        {
            get { return vidas; }
            set { vidas = value; }
        }

        public void Reiniciar()
        {
            vidas = 3;
            p = new Position(1, 1, 1);
        }

        public void Create()
        {
             m = ContentManager.GetModelByName("nave.3DS");
             m.CreateDisplayList(); 
        }

        public void Dibujar()
        {
            if (vidas > 0)
            {
                switch (MainForm.Moviendo)
                {
                    case 1:
                        {
                            //if (p.x < 3)
                            p.x += 0.08f;
                            break;
                        }
                    case -1:
                        {
                            //if (p.x > -3)
                            p.x -= 0.08f;
                            break;
                        }
                    case 2:
                        {
                            //if (p.y < 3)
                            p.y += 0.08f;
                            break;
                        }
                    case -2:
                        {
                            //if (p.y > -3)
                            p.y -= 0.08f;
                            break;
                        }
                    default:
                        break;
                }
            }

//                count++;
////                if (count == compare)
////                {
////                    if (compare == 25)
////                    {
////                        compare = 10;
////                    }
////                    Position wingLeft = new Position(this.p.x - 1f, this.p.y, this.p.z);
////                    Position wingRight = new Position(this.p.x + 1f, this.p.y, this.p.z);
////                    if (AsteroidGenerator.CheckCollision(this.p, 1.1f))
////                    {
////                        RestarVida(); 
////                    }
////                    else
////                        if (AsteroidGenerator.CheckCollision(wingRight, 1.1f))
////                        {
////                            RestarVida(); 
////                        }
////                        else
////                            if (AsteroidGenerator.CheckCollision(wingLeft, 1.1f))
////                            {
////                                RestarVida(); 
////                            }
////                    count = 0;
//                }
                //tmp
                Gl.glPushMatrix();
                Gl.glColor3f(0.0f, 1.0f, 0.0f);
                Gl.glEnable(Gl.GL_BLEND);
                Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

                
                //Gl.glTranslatef(p.x, p.y, p.z);            
                //
                Gl.glBegin(Gl.GL_QUADS);
			    Gl.glVertex3f(p.x, p.y, p.z);
			    Gl.glVertex3f(p.x + 1.0f, p.y, p.z);
			    Gl.glVertex3f(p.x + 1.0f, p.y, p.z + 1.0f);
			    Gl.glVertex3f(p.x, p.y, p.z + 1.0f);

                Gl.glEnd();
                Gl.glPopMatrix();
                
                //
                Gl.glColor3f(1.0f, 1.0f, 1.0f);
                                
                Gl.glPushMatrix();
                Gl.glTranslatef(p.x, p.y, p.z);
                Gl.glScalef(0.3f, 0.3f, 0.3f);
                m.DrawWithTextures();
                Gl.glPopMatrix();
                Gl.glDisable(Gl.GL_TEXTURE_2D);

            }

        public void Draw2()
        {
            p.z += this.asteroidSpeed * -1.0f;
            p.y += incY;
            p.x += incX;
            rot += 1f;

            Gl.glPushMatrix();
            Gl.glTranslatef(p.x, p.y, p.z);
            Gl.glScalef(0.3f, 0.3f, 0.3f);
            m.DrawWithTextures();
            Gl.glPopMatrix();
            Gl.glDisable(Gl.GL_TEXTURE_2D);

        }
        
        
        
        
        
           
        }
    
    
    
//        void RestarVida()
//        {
//            //AudioPlayback.PlayOne("choque.mp3");
//            compare = 25;
//            vidas--;
//            p = new Position(0, 0, 0);
//        }
//    }
}
