using FIFA_WorldCup.Entidades;
using FIFA_WorldCup.RN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA_WorldCup.Forms
{
    public partial class frmParticipantesDisplay : Form
    {
        Int16 gCopaID;
        Competicao gTipoCopa;
        public frmParticipantesDisplay(Int16 CopaID)
        {
            InitializeComponent();
            gCopaID = CopaID;
            CarregarParticipantes();
            CarregarNomeCopa();
        }


        private void CarregarParticipantes()
        {
            List<Pais> lstUEFA = new List<Pais>();
            List<Pais> lstConmebol = new List<Pais>();
            List<Pais> lstAFC = new List<Pais>();
            List<Pais> lstCAF = new List<Pais>();
            List<Pais> lstConcacaf = new List<Pais>();
            List<Pais> lstOFC = new List<Pais>();

            RNPais rn = new RNPais();
            List<Pais> listaParticipantes = rn.SelParticipantesSelecionados(gCopaID);
            foreach (Pais item in listaParticipantes)
            {
                switch (item.Confederacao)
                {
                    case Confederacao.UEFA:
                        lstUEFA.Add(item);
                        break;
                    
                    case Confederacao.CONMEBOL:
                        lstConmebol.Add(item);
                        break;
                    
                    case Confederacao.AFC:
                        lstAFC.Add(item);
                        break;
                    
                    case Confederacao.CAF:
                        lstCAF.Add(item);
                        break;
                    
                    case Confederacao.CONCACAF:
                        lstConcacaf.Add(item);
                        break;
                    
                    case Confederacao.OFC:
                        lstOFC.Add(item);
                        break;
                }
            }

            listaUEFA.DisplayMember = "Nome";
            listaUEFA.DataSource = lstUEFA;
            
            listaComenbol.DisplayMember = "Nome";
            listaComenbol.DataSource = lstConmebol;
            
            listaAFC.DisplayMember = "Nome";
            listaAFC.DataSource = lstAFC;
               
            listaCAF.DisplayMember = "Nome";
            listaCAF.DataSource = lstCAF;

            listaConcacaf.DisplayMember = "Nome";
            listaConcacaf.DataSource = lstConcacaf;

            listaOFC.DisplayMember = "Nome";
            listaOFC.DataSource = lstOFC;
        }

        private void CarregarNomeCopa()
        {
            RNCopa rn = new RNCopa();
            Copa oCopa = rn.Sel(gCopaID);
            gTipoCopa = oCopa.Competicao;
            string titulo = "Participantes da Copa do Mundo de " + oCopa.Ano;
            lblTitulo.Text = titulo;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirParticipantes(gCopaID);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.AbrirCopaLista(gTipoCopa);
        }
    }
}
