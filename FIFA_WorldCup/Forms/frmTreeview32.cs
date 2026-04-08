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
    public partial class frmTreeview32 : Form
    {
        Int16 gCopaID;
        public frmTreeview32(Int16 vCopaID)
        {
            InitializeComponent();
            this.Visible = false;
            gCopaID = vCopaID;
            CarregarPaises();
        }

        private void CarregarPaises()
        {            
            RNCopa rn = new RNCopa();
            List<PartidaTreeView> lista = rn.LoadTreeview(gCopaID);

            #region 16avos
            pic01.Image = RetornaImagem(lista[0].SelecaoA);
            pic01.SizeMode = PictureBoxSizeMode.StretchImage;
            pic02.Image = RetornaImagem(lista[0].SelecaoB);
            pic02.SizeMode = PictureBoxSizeMode.StretchImage;
            pic03.Image = RetornaImagem(lista[1].SelecaoA);
            pic03.SizeMode = PictureBoxSizeMode.StretchImage;
            pic04.Image = RetornaImagem(lista[1].SelecaoB);
            pic04.SizeMode = PictureBoxSizeMode.StretchImage;
            pic05.Image = RetornaImagem(lista[2].SelecaoA);
            pic05.SizeMode = PictureBoxSizeMode.StretchImage;
            pic06.Image = RetornaImagem(lista[2].SelecaoB);
            pic06.SizeMode = PictureBoxSizeMode.StretchImage;
            pic07.Image = RetornaImagem(lista[3].SelecaoA);
            pic07.SizeMode = PictureBoxSizeMode.StretchImage;
            pic08.Image = RetornaImagem(lista[3].SelecaoB);
            pic08.SizeMode = PictureBoxSizeMode.StretchImage;
            pic09.Image = RetornaImagem(lista[4].SelecaoA);
            pic09.SizeMode = PictureBoxSizeMode.StretchImage;
            pic10.Image = RetornaImagem(lista[4].SelecaoB);
            pic10.SizeMode = PictureBoxSizeMode.StretchImage;
            pic11.Image = RetornaImagem(lista[5].SelecaoA);
            pic11.SizeMode = PictureBoxSizeMode.StretchImage;
            pic12.Image = RetornaImagem(lista[5].SelecaoB);
            pic12.SizeMode = PictureBoxSizeMode.StretchImage;
            pic13.Image = RetornaImagem(lista[6].SelecaoA);
            pic13.SizeMode = PictureBoxSizeMode.StretchImage;
            pic14.Image = RetornaImagem(lista[6].SelecaoB);
            pic14.SizeMode = PictureBoxSizeMode.StretchImage;
            pic15.Image = RetornaImagem(lista[7].SelecaoA);
            pic15.SizeMode = PictureBoxSizeMode.StretchImage;
            pic16.Image = RetornaImagem(lista[7].SelecaoB);
            pic16.SizeMode = PictureBoxSizeMode.StretchImage;
            pic17.Image = RetornaImagem(lista[8].SelecaoA);
            pic17.SizeMode = PictureBoxSizeMode.StretchImage;
            pic18.Image = RetornaImagem(lista[8].SelecaoB);
            pic18.SizeMode = PictureBoxSizeMode.StretchImage;
            pic19.Image = RetornaImagem(lista[9].SelecaoA);
            pic19.SizeMode = PictureBoxSizeMode.StretchImage;
            pic20.Image = RetornaImagem(lista[9].SelecaoB);
            pic20.SizeMode = PictureBoxSizeMode.StretchImage;
            pic21.Image = RetornaImagem(lista[10].SelecaoA);
            pic21.SizeMode = PictureBoxSizeMode.StretchImage;
            pic22.Image = RetornaImagem(lista[10].SelecaoB);
            pic22.SizeMode = PictureBoxSizeMode.StretchImage;
            pic23.Image = RetornaImagem(lista[11].SelecaoA);
            pic23.SizeMode = PictureBoxSizeMode.StretchImage;
            pic24.Image = RetornaImagem(lista[11].SelecaoB);
            pic24.SizeMode = PictureBoxSizeMode.StretchImage;
            pic25.Image = RetornaImagem(lista[12].SelecaoA);
            pic25.SizeMode = PictureBoxSizeMode.StretchImage;
            pic26.Image = RetornaImagem(lista[12].SelecaoB);
            pic26.SizeMode = PictureBoxSizeMode.StretchImage;
            pic27.Image = RetornaImagem(lista[13].SelecaoA);
            pic27.SizeMode = PictureBoxSizeMode.StretchImage;
            pic28.Image = RetornaImagem(lista[13].SelecaoB);
            pic28.SizeMode = PictureBoxSizeMode.StretchImage;
            pic29.Image = RetornaImagem(lista[14].SelecaoA);
            pic29.SizeMode = PictureBoxSizeMode.StretchImage;
            pic30.Image = RetornaImagem(lista[14].SelecaoB);
            pic30.SizeMode = PictureBoxSizeMode.StretchImage;
            pic31.Image = RetornaImagem(lista[15].SelecaoA);
            pic31.SizeMode = PictureBoxSizeMode.StretchImage;
            pic32.Image = RetornaImagem(lista[15].SelecaoB);
            pic32.SizeMode = PictureBoxSizeMode.StretchImage;
            #endregion

            #region Oitavas

            pic33.Image = RetornaImagem(lista[16].SelecaoA);
            pic33.SizeMode = PictureBoxSizeMode.StretchImage;
            pic34.Image = RetornaImagem(lista[16].SelecaoB);
            pic34.SizeMode = PictureBoxSizeMode.StretchImage;
            pic35.Image = RetornaImagem(lista[17].SelecaoA);
            pic35.SizeMode = PictureBoxSizeMode.StretchImage;
            pic36.Image = RetornaImagem(lista[17].SelecaoB);
            pic36.SizeMode = PictureBoxSizeMode.StretchImage;
            pic37.Image = RetornaImagem(lista[18].SelecaoA);
            pic37.SizeMode = PictureBoxSizeMode.StretchImage;
            pic38.Image = RetornaImagem(lista[18].SelecaoB);
            pic38.SizeMode = PictureBoxSizeMode.StretchImage;
            pic39.Image = RetornaImagem(lista[19].SelecaoA);
            pic39.SizeMode = PictureBoxSizeMode.StretchImage;
            pic40.Image = RetornaImagem(lista[19].SelecaoB);
            pic40.SizeMode = PictureBoxSizeMode.StretchImage;
            pic41.Image = RetornaImagem(lista[20].SelecaoA);
            pic41.SizeMode = PictureBoxSizeMode.StretchImage;
            pic42.Image = RetornaImagem(lista[20].SelecaoB);
            pic42.SizeMode = PictureBoxSizeMode.StretchImage;
            pic43.Image = RetornaImagem(lista[21].SelecaoA);
            pic43.SizeMode = PictureBoxSizeMode.StretchImage;
            pic44.Image = RetornaImagem(lista[21].SelecaoB);
            pic44.SizeMode = PictureBoxSizeMode.StretchImage;
            pic45.Image = RetornaImagem(lista[22].SelecaoA);
            pic45.SizeMode = PictureBoxSizeMode.StretchImage;
            pic46.Image = RetornaImagem(lista[22].SelecaoB);
            pic46.SizeMode = PictureBoxSizeMode.StretchImage;
            pic47.Image = RetornaImagem(lista[23].SelecaoA);
            pic47.SizeMode = PictureBoxSizeMode.StretchImage;
            pic48.Image = RetornaImagem(lista[23].SelecaoB);
            pic48.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion

            #region Quartas

            pic49.Image = RetornaImagem(lista[24].SelecaoA);
            pic49.SizeMode = PictureBoxSizeMode.StretchImage;
            pic50.Image = RetornaImagem(lista[24].SelecaoB);
            pic50.SizeMode = PictureBoxSizeMode.StretchImage;
            pic51.Image = RetornaImagem(lista[25].SelecaoA);
            pic51.SizeMode = PictureBoxSizeMode.StretchImage;
            pic52.Image = RetornaImagem(lista[25].SelecaoB);
            pic52.SizeMode = PictureBoxSizeMode.StretchImage;
            pic53.Image = RetornaImagem(lista[26].SelecaoA);
            pic53.SizeMode = PictureBoxSizeMode.StretchImage;
            pic54.Image = RetornaImagem(lista[26].SelecaoB);
            pic54.SizeMode = PictureBoxSizeMode.StretchImage;
            pic55.Image = RetornaImagem(lista[27].SelecaoA);
            pic55.SizeMode = PictureBoxSizeMode.StretchImage;
            pic56.Image = RetornaImagem(lista[27].SelecaoB);
            pic56.SizeMode = PictureBoxSizeMode.StretchImage;


            #endregion

            #region Semifinais

            pic57.Image = RetornaImagem(lista[28].SelecaoA);
            pic57.SizeMode = PictureBoxSizeMode.StretchImage;
            pic58.Image = RetornaImagem(lista[28].SelecaoB);
            pic58.SizeMode = PictureBoxSizeMode.StretchImage;
            pic59.Image = RetornaImagem(lista[29].SelecaoA);
            pic59.SizeMode = PictureBoxSizeMode.StretchImage;
            pic60.Image = RetornaImagem(lista[29].SelecaoB);
            pic60.SizeMode = PictureBoxSizeMode.StretchImage;


            #endregion

            #region Finais

            pic61.Image = RetornaImagem(lista[30].SelecaoA);
            pic61.SizeMode = PictureBoxSizeMode.StretchImage;
            pic62.Image = RetornaImagem(lista[30].SelecaoB);
            pic62.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion

            //this.Visible = true;
        }

        private Image RetornaImagem(Int16 PaisID)
        {
            string path = GlobalVariables.pathFlags;
            Image img = new Bitmap(path + PaisID + ".png");
            return img;
        }

        private void picCampeao_Click(object sender, EventArgs e)
        {
            frmMain pai = (frmMain)this.MdiParent;
            pai.AbrirCopaLista(Competicao.Masculino);
        }

        private void frmTreeview32_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }
    }
}
