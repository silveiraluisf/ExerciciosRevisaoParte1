using Vertice;

namespace Poligono
{
    public class Polygon
    {
        private List<Vertex> _V;

        public List<Vertex> VertexList
        {
            get { return _V; }
            set { if (VertexList.Count < 3)
                    throw new Exception("O polígono deve possuir mais de 3 vértices!");
            else _V= value;
            }
        }

        public int QtdVertex
        {
            get { return _V.Count; } 
        } 

        public Polygon(List<Vertex> Vertices)
        {
            _V = Vertices;
        }

        public bool AddVertex(Vertex A)
        {
            foreach (Vertex vertex in _V) 
            { 
                if (Vertex.IsEqual(vertex, A)) 
                    return false; 
            }
            _V.Add(A);
            return true;
        }

        public bool RemoveVertex(Vertex R)
        {
            if (_V.Count <= 3) throw new Exception("O polígono não pode ter menos de 3 lados");
                for (int i = 0; i < _V.Count; i++)
                {
                    Vertex vertex = _V[i];
                    if (Vertex.IsEqual(vertex, R))
                        _V.Remove(vertex);          
                }

                return true;
        }

        public object CalculatePerimeter()
        {
            double Perimeter = 0;
            foreach (Vertex vertexA in _V)  foreach(Vertex vertexB in _V)
            {
                Perimeter = Vertex.Distance(vertexA, vertexB);
                    Perimeter++;
            }
                     
            return Perimeter;
        }
    }
}
