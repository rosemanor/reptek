using System;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Assimp.Sample
{
    public class Camara
    {     
        #region Private atributes

        static float eyex, eyey, eyez;
        static float forwardSpeed = 0.2f;
        static float angleY, angleX;
        static float rotationSpeed = 1/5f;
        int[] viewport = new int[4];
        double[] modelview = new double[16];
        double[] projection = new double[16];

        #endregion

        public void PlaceCamera(int width, int height)
        {
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            //Glu.gluPerspective(50, width/(float)height, 0.1f, 300);
            eyex = 3f;
            eyey = -4f;
            eyez = 3f;
        }

        
        public void Draw()
        {
			GL.PushMatrix();

            GL.Color3(0.0f, 1.0f, 0.0f);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Begin(BeginMode.Quads);
            GL.Vertex3(eyex, 2.0f, eyez);
            GL.Vertex3(eyex + 1.0f, 2.0f, eyez);
            GL.Vertex3(eyex + 1.0f, 2.0f, eyez + 1.0f);
            GL.Vertex3(eyex, 2.0f, eyez + 1.0f);

            GL.End();
            GL.PopMatrix();

        }
        
        
        
        
        public static void CenterMouse()
        {
            //MainForm.Instance.CenterMouse();   
        }
                	
        public void Update(int pressedButton)
        {
            #region calcular la variacion de pitch y yaw

            //Point position = MainForm.Instance.MousePos;
            //Point center = MainForm.Instance.ScreenCenter();

            //int difX = center.X - position.X;
            //int difY = center.Y - position.Y;


            //// 384 es la mitad de 768 y 512 la de 1024
            //// son los valores del tamaño del formulario
            //if (position.Y < 384)
            //{
            //    angleX -= rotationSpeed * difY;
            //}
            //else
            //    if (position.Y > 384)
            //    {
            //        angleX += rotationSpeed * -difY;
            //    }
            //if (position.X < 512)
            //{
            //    angleY += rotationSpeed * -difX;
            //}
            //else
            //    if (position.X > 512)
            //    {
            //        angleY -= rotationSpeed * difX;
            //    }

            #endregion

            //GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadIdentity();

            //GL.Rotate(angleX, 1, 0, 0);
            //GL.Rotate(angleY, 0, 1, 0);

            //GL.Translate(eyex, eyey, eyez);

            //CenterMouse();

            
            //if (pressedButton == 1) 
            //{
            //	eyex = eyex - forwardSpeed;
            //}
            
            //if (pressedButton == -1) 
            //{
            //	eyex = eyex + forwardSpeed;           	
            //}
            
            //if (pressedButton == 2) 
            //{
            //	eyey = eyey - forwardSpeed;
            //}

            //if (pressedButton == -2) 
            //{
            //	eyey = eyey + forwardSpeed;
            //}

            
            if (pressedButton == 4) 
            {
                //float dispX = -(float)Math.Sin(Helper.DegreeToRad((double)angleY)) * forwardSpeed;
                //float dispY =(float)Math.Cos(Helper.DegreeToRad((double)angleY)) * forwardSpeed;
                //if (dispX > 0)
                //{
                //    dispX = dispX + 0.1f;
                //}
                //else
                //    dispX = dispX - 0.1f;
                //if (dispY > 0)
                //{
                //    dispY = dispY + 0.1f;
                //}
                //else
                //    dispY = dispY - 0.1f;


                //float newEyeX = eyex + dispX;
                //float newEyeZ = eyez + dispY;

                //eyex = newEyeX;
                //eyez = newEyeZ;
                
                
//                if (!Collision.CheckCollision(new Point3D(-newEyeX, -newEyeZ, 0)))
//                {
//                    eyex = newEyeX;
//                    eyez = newEyeZ;
//                }
//                else
//                    if (!Collision.CheckCollision(new Point3D(-newEyeX, -eyez, 0)))
//                    {
//                        eyex = newEyeX; 
//                    }
//                    else
//                        if (!Collision.CheckCollision(new Point3D(-eyex, -newEyeZ, 0)))
//                        {
//                            eyez = newEyeZ;
//                        }

            }
        }
    }
}
