using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNDtoGrupoCopa
    {

        public List<dtoGrupoCopa> Sel(Int16 vCopaID, Int16 vTipoFase)
        {
            int tamanhoMaximo = 14; // Tamanho máximo do nome do pais
            DalDtoGrupoCopa dal = new DalDtoGrupoCopa();
            List<dtoGrupoCopa> listaInicial = dal.Sel(vCopaID, vTipoFase);
            List<dtoGrupoCopa> listaEditada = new List<dtoGrupoCopa>();
            foreach (dtoGrupoCopa iDTO in listaInicial)
            {
                if(iDTO.Pais.Length > tamanhoMaximo)
                {
                    iDTO.Pais = iDTO.Pais.Substring(0, tamanhoMaximo);
                }
                listaEditada.Add(iDTO);
            }
            return listaEditada;
        }

    }
}
