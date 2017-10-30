using System;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;



namespace Assimp.Sample
{
    class SkyBox
    {
        private int myLeft;
        private int myRight;
        private int myTop;
        private int myBottom;
        private int myFront;
        private int myBack;

        public SkyBox()
        {
            String fileName = "GRASS2.JPG";
            myBottom = LoadTexture(fileName);

            fileName = "top.BMP";
            myTop = LoadTexture(fileName);

            fileName = "left.BMP";
            myLeft = LoadTexture(fileName);

            fileName = "right.BMP";
            myRight = LoadTexture(fileName);

            fileName = "front.BMP";
            myFront = LoadTexture(fileName);

            fileName = "back.BMP";
            myBack = LoadTexture(fileName);


        }


        public void Dibujar()
        {
            GL.PushMatrix();

            GL.Rotate(90, 0, 1, 0);
          
            int width = 240;
            int height = 200;
            int length = 240;

           
            int x = 10;
            int y = -3;
            int z = 7;

      
            x = x - width / 2;
            y = y - height / 2;
            z = z - length / 2;

            GL.Enable(EnableCap.Texture2D);
            GL.BindTexture(TextureTarget.Texture2D, myBottom);
            //GL.Disable(EnableCap.Texture2D);
            //
            //            Gl.glBegin(Gl.GL_QUADS);
            //            Gl.glNormal3d(-1, 1, 1);
            //            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x + width, y, z);
            //            Gl.glNormal3d(-1, -1, 1);
            //            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x + width, y + height, z);
            //            Gl.glNormal3d(1, -1, 1);
            //            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x, y + height, z);
            //            Gl.glNormal3d(1, 1, 1);
            //            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x, y, z);
            //            Gl.glEnd();
            //
            //            //Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("front.bmp"));
            //            Gl.glBegin(Gl.GL_QUADS);
            //            Gl.glNormal3d(1, 1, -1);
            //            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x, y, z + length);
            //            Gl.glNormal3d(1, -1, -1);
            //            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x, y + height, z + length);
            //            Gl.glNormal3d(-1, -1, -1);
            //            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x + width, y + height, z + length);
            //            Gl.glNormal3d(-1, 1, -1);
            //            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x + width, y, z + length);
            //            Gl.glEnd();
            //
            //            //Gl.glBindTexture(Gl.GL_TEXTURE_2D, ContentManager.GetTextureByName("top.bmp"));
            //            Gl.glBegin(Gl.GL_QUADS);
            //            Gl.glNormal3d(-1, -1, 1);
            //            Gl.glTexCoord2f(0.0f, 1.0f); Gl.glVertex3d(x + width, y + height, z);
            //            Gl.glNormal3d(-1, -1, -1);
            //            Gl.glTexCoord2f(0.0f, 0.0f); Gl.glVertex3d(x + width, y + height, z + length);
            //            Gl.glNormal3d(1, -1, -1);
            //            Gl.glTexCoord2f(1.0f, 0.0f); Gl.glVertex3d(x, y + height, z + length);
            //            Gl.glNormal3d(1, -1, 1);
            //            Gl.glTexCoord2f(1.0f, 1.0f); Gl.glVertex3d(x, y + height, z);
            //            Gl.glEnd();
            //
            GL.BindTexture(TextureTarget.Texture2D, myLeft);
            GL.Begin(BeginMode.Quads);
            GL.Normal3(1, -1, 1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x, y + height, z);
            GL.Normal3(1, -1, -1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x, y + height, z + length);
            GL.Normal3(1, 1, -1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x, y, z + length);
            GL.Normal3(1, 1, 1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x, y, z);
            GL.End();
            //
            GL.BindTexture(TextureTarget.Texture2D, myRight);
            GL.Begin(BeginMode.Quads);
            GL.Normal3(-1, 1, 1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x + width, y, z);
            GL.Normal3(-1, 1, -1);
            GL.TexCoord2(1.0f, 0.0f); GL.Vertex3(x + width, y, z + length);
            GL.Normal3(-1, -1, -1);
            GL.TexCoord2(1.0f, 1.0f); GL.Vertex3(x + width, y + height, z + length);
            GL.Normal3(-1, -1, 1);
            GL.TexCoord2(0.0f, 1.0f); GL.Vertex3(x + width, y + height, z);
            GL.End();

            GL.BindTexture(TextureTarget.Texture2D, myBottom);
            //
            GL.Begin(BeginMode.Quads);
            GL.Normal3(1, 1, 1);
            GL.TexCoord2(8.0f, 0.0f); GL.Vertex3(x, -1, z);
            GL.Normal3(1, 1, -1);
            GL.TexCoord2(8.0f, 8.0f); GL.Vertex3(x, -1, z + length);
            GL.Normal3(-1, 1, -1);
            GL.TexCoord2(0.0f, 8.0f); GL.Vertex3(x + width, -1, z + length);
            GL.Normal3(-1, 1, 1);
            GL.TexCoord2(0.0f, 0.0f); GL.Vertex3(x + width, -1, z);
            GL.End();

            GL.Color3(1.0f, 1.0f, 1.0f);
            GL.PopMatrix(); 
        }

 
        public int LoadTexture(String fileName)
        {
            fileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);

            Bitmap textureBitmap = new Bitmap(fileName);
            int texID = GL.GenTexture();

            GL.BindTexture(TextureTarget.Texture2D, texID);
            BitmapData data = textureBitmap.LockBits(new System.Drawing.Rectangle(0, 0, textureBitmap.Width, textureBitmap.Height),
                ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

            textureBitmap.UnlockBits(data);

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);

            return texID;
        }
    }
}
