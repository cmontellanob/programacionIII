using System;
using System.Collections.Generic;
using System.Text;

namespace ArbolBinarioOrdenado
{
    class Nodo
    {
        public int info;
        public Nodo izq, der;
    }
    class Arbol
    {
            
            public Nodo raiz;
            public Arbol()
            {
                raiz = null;
            }

            public void Insertar(int info)
            {
                    Nodo nuevo;
                    nuevo = new Nodo();
                    nuevo.info = info;
                    nuevo.izq = null;
                    nuevo.der = null;
                    if (raiz == null)
                        raiz = nuevo;
                    else
                    {
                        Nodo anterior = null, reco;
                        reco = raiz;
                        while (reco != null)
                        {
                            anterior = reco;
                            if (info < reco.info)
                                reco = reco.izq;
                            else
                                reco = reco.der;
                        }
                        if (info < anterior.info)
                            anterior.izq = nuevo;
                        else
                            anterior.der = nuevo;
                    }
            }

        public void PreOrden(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                PreOrden(reco.izq);
                PreOrden(reco.der);
            }
        }

        public void Simetrico(Nodo reco)
            {
                if (reco != null)
                {
                    Simetrico(reco.izq);
                    Console.Write(reco.info + " ");
                    Simetrico(reco.der);
                }
            }

        public void PostOrden(Nodo reco)
        {
            if (reco != null)
            {
                PostOrden(reco.izq);
                PostOrden(reco.der);
                Console.Write(reco.info + " ");
            }
        }
            
            

        }
    }
