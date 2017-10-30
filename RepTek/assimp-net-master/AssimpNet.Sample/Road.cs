/*
 * This projects belongs to Vasily Tserekh, if you find it useful 
 * Stop by for my blog and make a comment, I'll really apreciate some 
 * feedback
 *http://vasilydev.blogspot.com/
 */


using System.Collections.Generic;
using System.Text;
using ShadowEngine;
using Tao.OpenGl;


namespace Plaza
{
	class Road : Asteroid
    {
        //int initList;
        int dlHexagon;
        int dlWorld;

        private float SQRT_3;
        private int zline;
        private int indent;
        private float sq3z;
        private float i6x;
        //
        

        public void Create()
        {

            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glColorMaterial(Gl.GL_FRONT, Gl.GL_AMBIENT_AND_DIFFUSE);

            dlHexagon = Gl.glGenLists(1);
            Gl.glNewList(dlHexagon, Gl.GL_COMPILE);

            SQRT_3 = 1.7320F; // 508075688772935274463415059;

            Gl.glDisable(Gl.GL_TEXTURE_2D);
            //Gl.glColor3f(1.0f, 1.0f, 0.0f);
            //Gl.glColor3f(0.0f, 1.0f, 0.0f);            
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glNormal3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(-1.0f, 0.0f, -SQRT_3);
            Gl.glVertex3f(1.0f, 0.0f, -SQRT_3);
            Gl.glVertex3f(1.0f, 1.0f, -SQRT_3);
            Gl.glVertex3f(-1.0f, 1.0f, -SQRT_3);
            Gl.glNormal3f(0.0f, 0.0f, -1.0f);
            Gl.glVertex3f(-1.0f, 0.0f, SQRT_3);
            Gl.glVertex3f(1.0f, 0.0f, SQRT_3);
            Gl.glVertex3f(1.0f, 1.0f, SQRT_3);
            Gl.glVertex3f(-1.0f, 1.0f, SQRT_3);
            Gl.glNormal3f(0.8660254f, 0.0f, 0.5f);
            Gl.glVertex3f(-1.0f, 0.0f, -SQRT_3);
            Gl.glVertex3f(-1.0f, 1.0f, -SQRT_3);
            Gl.glVertex3f(-2.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-2.0f, 0.0f, 0.0f);
            Gl.glNormal3f(-0.8660254f, 0.0f, 0.5f);
            Gl.glVertex3f(1.0f, 0.0f, -SQRT_3);
            Gl.glVertex3f(1.0f, 1.0f, -SQRT_3);
            Gl.glVertex3f(2.0f, 1.0f, 0.0f);
            Gl.glVertex3f(2.0f, 0.0f, 0.0f);
            Gl.glNormal3f(0.8660254f, 0.0f, -0.5f);
            Gl.glVertex3f(-1.0f, 0.0f, SQRT_3);
            Gl.glVertex3f(-1.0f, 1.0f, SQRT_3);
            Gl.glVertex3f(-2.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-2.0f, 0.0f, 0.0f);
            Gl.glNormal3f(-0.8660254f, 0.0f, -0.5f);
            Gl.glVertex3f(1.0f, 0.0f, SQRT_3);
            Gl.glVertex3f(1.0f, 1.0f, SQRT_3);
            Gl.glVertex3f(2.0f, 1.0f, 0.0f);
            Gl.glVertex3f(2.0f, 0.0f, 0.0f);
            Gl.glEnd();
            Gl.glEndList();


            dlWorld = Gl.glGenLists(1);
            Gl.glNewList(dlWorld, Gl.GL_COMPILE);
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            zline = 0;

            for (int z = 0; z < 58; z++)
            {
                zline += 1;
                if ((zline % 2) > 0)
                    indent = 3; //3.0;
                else 
                    indent = 0;
                Gl.glPushMatrix();
                //
                sq3z = (SQRT_3 + 0.01f) * z;//((SQRT_3 + 0.01) * z);
                Gl.glTranslatef(0.0f, 0.0f, sq3z);

            for (int x = 1; x < 17; x++)
                {
            		//float yy = z * 0.1f;
                    Gl.glPushMatrix();
                    i6x = 6 * x + indent;
                    Gl.glTranslatef(i6x, 0.0f, 0.0f); //0.0f, 0.0f);
                    Gl.glCallList(dlHexagon);
                    Gl.glPopMatrix();
                }
                Gl.glPopMatrix();

            }



            //Gl.glBegin(Gl.GL_QUADS);
            //Gl.glNormal3f(0, 1, 0);
            //Gl.glVertex3i(0, 0, 0);
            //Gl.glVertex3i(0, 0, 100);
            //Gl.glVertex3i(100, 0, 100);
            //Gl.glVertex3i(100, 0, 0);
            //Gl.glEnd();
            Gl.glBegin(Gl.GL_LINES);
			Gl.glColor3f(1.0f,1.0f,1.0f); // White (RGB)
			for( float x = 0; x < 108.0f; x += 1.0f )
			{
			    Gl.glVertex3f(x, 0.0f, 0.0f);
			    Gl.glVertex3f(x, 0.0f, (98.0f));
			}
			for( float z = 0; z < 98; z += 1.0f )
			{
			    Gl.glVertex3f(0.0f, 0.0f, z);
			    Gl.glVertex3f((108.0f), 0.0f, z);
			}
			Gl.glEnd();
            
            
            Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glEndList();

 
            //int texturaDelimitador = ContentManager.GetTextureByName("delimitador.jpg");

                ////start line
                //Gl.glEnable(Gl.GL_TEXTURE_2D);
                //Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaDelimitador);
                //Gl.glPushMatrix();
                //Gl.glTranslatef(0, 0, 8);
                //Gl.glBegin(Gl.GL_QUADS);
                //Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.5f, 0.1f, 0);
                //Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.5f, 0.1f, 1);
                //Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(4f, 0.1f, 1);
                //Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(4f, 0.1f, 0);
                //Gl.glEnd();
                //Gl.glPopMatrix();

                ////end line
                //Gl.glPushMatrix();
                //Gl.glTranslatef(0, 0, -50);
                //Gl.glBegin(Gl.GL_QUADS);
                //Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.5f, 0.05f, 0);
                //Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.5f, 0.05f, 1);
                //Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.5f, 0.05f, 1);
                //Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.5f, 0.05f, 0);
                //Gl.glEnd();
                //Gl.glPopMatrix();


                //int texturaAsfalto = ContentManager.GetTextureByName("asfalto.jpg");
                //Gl.glEnable(Gl.GL_TEXTURE_2D);
                //Gl.glBindTexture(Gl.GL_TEXTURE_2D, texturaAsfalto);
                //Gl.glPushMatrix();
                //Gl.glTranslatef(0, 0, -100);

                //int count = 0;
                //for (int y = 0; y < 40; y++)// this for loop draws the road
                //{
                //    Gl.glBegin(Gl.GL_QUADS);
                //    Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3f(-0.8f, 0, count);
                //    Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3f(-0.8f, 0, count + 10);
                //    Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3f(3.8f, 0, count + 10);
                //    Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3f(3.8f, 0, count);
                //    Gl.glEnd();
                //    count += 10; 
                //}

                //Gl.glPopMatrix();

                //Gl.glEndList(); 
        }
//
//        public void Draw()
//        {
//            Gl.glCallList(dlWorld);  
//        }
        
        public void Draw2()
        {
//p.z += this.asteroidSpeed * 0.01f * 1.0f;
//            p.y += incY;
//            p.x += incX;
//            rot += 1f;

            Gl.glPushMatrix();
            Gl.glTranslatef(p.x, p.y, p.z);
            Gl.glCallList(dlWorld);  
            Gl.glPopMatrix();
			//
            if (p.z > 4)
            {
                Reset();  
            }			

        }
    }
}
