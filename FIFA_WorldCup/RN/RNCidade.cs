using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.Dal;

namespace FIFA_WorldCup.RN
{
    public class RNCidade
    {
        public List<Cidade> Sel(Cidade oCidade)
        {
            DalCidade dal = new DalCidade();
            return dal.Sel(oCidade);
        }

        public Cidade Sel(Int16 CidadeID)
        {
            DalCidade dal = new DalCidade();
            Cidade filtro = new Cidade();
            filtro.ID = CidadeID;
            List<Cidade> lista = dal.Sel(filtro);
            if (lista.Count > 0)
                return lista[0];
            else
                return null;
        }


        public List<Cidade> SelPorPais(Int16 PaisID)
        {
            DalCidade dal = new DalCidade();
            Cidade filtro = new Cidade();
            filtro.PaisID = PaisID;
            return dal.Sel(filtro);
        }


        public void Salvar(Cidade oCidade)
        {
            DalCidade dal = new DalCidade();
            if (oCidade.ID == 0)
            {
                dal.Ins(oCidade);
            }
            else
            {
                dal.Upd(oCidade);
            }                
        }


    }
}
