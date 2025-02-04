﻿using exercicio1;
using exercicio2;

namespace exercicio4

{
    internal class Poligono
    {
        private List<Vertice> array_vertices = new List<Vertice>();

        public List<Vertice> Array_vertices
        {
            get
            {
                return array_vertices;
            }
            set
            {
                if (array_vertices.Count - 1 < 3)
                {
                    throw new ImpossibleTriangleExeption("Este Triangulo e Impossivel");
                }
            }
        }

        public int NumeroVertices
        {
            get
            {
                return array_vertices.Count;
            }
            private set { }
        }


        public bool AddVertice(Vertice novo_vertice)
        {
            if (Array_vertices.Contains(novo_vertice))
            {
                return false;
            }
            else
            {
                Array_vertices.Add(novo_vertice);
                return true;
            }
        }

        public void RemovoeVertice(Vertice novo_vertice)
        {
            if (Array_vertices.Contains(novo_vertice))
            {
                Array_vertices.Remove(novo_vertice);
            }
        }

        public double Perimetro()
        {
            double soma = 0;
            for (int i = 0; i == Array_vertices.Count; i++)
            {
                soma = soma + Array_vertices[i].Distancia(Array_vertices[i + 1]);
            }
            return soma;

        }
    }
}