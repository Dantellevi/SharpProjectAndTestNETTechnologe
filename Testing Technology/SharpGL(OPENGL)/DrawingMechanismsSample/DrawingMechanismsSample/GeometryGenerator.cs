using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpGL.SceneGraph;


namespace DrawingMechanismsSample
{
    public static class GeometryGenerator
    {
        public static Vertex[] GenerateGeometry(uint numberOfVertices, float maxRadius)
        {
            //генератор случайных чисел
            var random = new Random();

            //создаем вертиксы
            var vertices = new Vertex[numberOfVertices];
            //задаем точки для постраения
            for (uint i = 0; i < numberOfVertices; i++)
            {
                vertices[i].X = (float)((random.NextDouble() - 0.5) * (maxRadius * 2));
                vertices[i].Y = (float)((random.NextDouble() - 0.5) * (maxRadius * 2));
                vertices[i].Z = (float)((random.NextDouble() - 0.5) * (maxRadius * 2));
            }
            return vertices;

        }

    }
}
