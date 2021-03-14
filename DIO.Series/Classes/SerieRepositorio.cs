using System;
using System.Collections.Generic;
using DIO.Series.Interface;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            //listaSerie.RemoveAt(id);     Utilizar esse método pode gerar uma inconsistencia, quando retirar o vetor indicado, os outros vão reoganizar e mudar o Id do vetor sinalizado.
            listaSerie[id].Excluir(); // Vai apenas marcar a informação como excluida, mas não vai de fato excluir.
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}