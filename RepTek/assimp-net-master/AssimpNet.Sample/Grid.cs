using System;
using OpenTK.Graphics.OpenGL;



namespace Assimp.Sample
{
    class Grid : Asteroid
    {
        //int initList;
        int dlHexagon;
        int dlWorld;

        private float SQRT_3;
        private int zline;
        private int indent;
        private float sq3z;
        private float i6x;


        public void Create()
        {
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse); //GL_AMBIENT_AND_DIFFUSE);

            dlHexagon = GL.GenLists(1);
            GL.NewList(dlHexagon, ListMode.Compile);

            SQRT_3 = 1.7320F; // 508075688772935274463415059;

            //Gl.glDisable(Gl.GL_TEXTURE_2D);
            GL.Disable(EnableCap.Texture2D);
            //
            //Gl.glColor3f(1.0f, 1.0f, 0.0f);
            //Gl.glColor3f(0.0f, 1.0f, 0.0f);
            //
            //GL.Disable(EnableCap.Texture2D);
            //
            //GL.Color3(1.0f, 1.0f, 0.0f);
            GL.Begin(BeginMode.Quads);
            GL.Normal3(0.0f, 0.0f, 1.0f);
            GL.Vertex3(-1.0f, 0.0f, -SQRT_3);
            GL.Vertex3(1.0f, 0.0f, -SQRT_3);
            GL.Vertex3(1.0f, 1.0f, -SQRT_3);
            GL.Vertex3(-1.0f, 1.0f, -SQRT_3);
            GL.Normal3(0.0f, 0.0f, -1.0f);
            GL.Vertex3(-1.0f, 0.0f, SQRT_3);
            GL.Vertex3(1.0f, 0.0f, SQRT_3);
            GL.Vertex3(1.0f, 1.0f, SQRT_3);
            GL.Vertex3(-1.0f, 1.0f, SQRT_3);
            GL.Normal3(0.8660254f, 0.0f, 0.5f);
            GL.Vertex3(-1.0f, 0.0f, -SQRT_3);
            GL.Vertex3(-1.0f, 1.0f, -SQRT_3);
            GL.Vertex3(-2.0f, 1.0f, 0.0f);
            GL.Vertex3(-2.0f, 0.0f, 0.0f);
            GL.Normal3(-0.8660254f, 0.0f, 0.5f);
            GL.Vertex3(1.0f, 0.0f, -SQRT_3);
            GL.Vertex3(1.0f, 1.0f, -SQRT_3);
            GL.Vertex3(2.0f, 1.0f, 0.0f);
            GL.Vertex3(2.0f, 0.0f, 0.0f);
            GL.Normal3(0.8660254f, 0.0f, -0.5f);
            GL.Vertex3(-1.0f, 0.0f, SQRT_3);
            GL.Vertex3(-1.0f, 1.0f, SQRT_3);
            GL.Vertex3(-2.0f, 1.0f, 0.0f);
            GL.Vertex3(-2.0f, 0.0f, 0.0f);
            GL.Normal3(-0.8660254f, 0.0f, -0.5f);
            GL.Vertex3(1.0f, 0.0f, SQRT_3);
            GL.Vertex3(1.0f, 1.0f, SQRT_3);
            GL.Vertex3(2.0f, 1.0f, 0.0f);
            GL.Vertex3(2.0f, 0.0f, 0.0f);
            GL.End();
            GL.EndList();

            dlWorld = GL.GenLists(1);
            GL.NewList(dlWorld, ListMode.Compile);
            //maybe
            GL.Enable(EnableCap.ColorMaterial);
            GL.ColorMaterial(MaterialFace.Front, ColorMaterialParameter.AmbientAndDiffuse); //GL_AMBIENT_AND_DIFFUSE);
            //
            GL.Enable(EnableCap.Texture2D);
            GL.Color3(1.0f, 1.0f, 0.0f);
            zline = 0;
            for (int z = -58; z < 58; z++)
            {
                zline += 1;
                if ((zline % 2) > 0)
                    indent = 3; //3.0;
                else
                    indent = 0;
                GL.PushMatrix();
                //
                sq3z = (SQRT_3 + 0.01f) * z;//((SQRT_3 + 0.01) * z);
                GL.Translate(0.0f, 0.0f, sq3z);

                for (int x = -17; x < 17; x++)
                {
                    //float yy = z * 0.1f;
                    GL.PushMatrix();
                    i6x = 6 * x + indent;
                    GL.Translate(i6x, 0.0f, 0.0f); //0.0f, 0.0f);
                    GL.CallList(dlHexagon);
                    GL.PopMatrix();
                }
                GL.PopMatrix();

            }
            //
            //maybe
            //
            //GL.Begin(BeginMode.Quads);
            //GL.Normal3(0, 1, 0);
            //GL.Vertex3(0, 0, 0);
            //GL.Vertex3(0, 0, 100);
            //GL.Vertex3(100, 0, 100);
            //GL.Vertex3(100, 0, 0);
            //GL.End();

            GL.Color3(1.0f, 1.0f, 1.0f);
            GL.Enable(EnableCap.Texture2D);
            GL.EndList();
        }

        public void Draw2()
        {
            GL.PushMatrix();
            GL.Translate(p.x, p.y, p.z);
            GL.CallList(dlWorld);
            GL.PopMatrix();
		
        }
    }
}
