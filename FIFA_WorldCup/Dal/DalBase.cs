using System;
using System.Configuration;
using System.Data.OleDb;
using System.Text;

namespace FIFA_WorldCup.Dal
{
    public class DalBase
    {

        private OleDbConnection oConexao;
        public OleDbCommand oCommand;
        public OleDbDataReader oDR;
        public StringBuilder oSB = new StringBuilder();

        public void AbrirConexao()
        {
            string StringConex = "";
            System.Configuration.AppSettingsReader config = new System.Configuration.AppSettingsReader();
            AppSettingsReader reader = new AppSettingsReader();
            //StringConex = ConfigurationManager.ConnectionStrings["FIFA_WCConnectionString"].ConnectionString;
            StringConex = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Projetos\\_Code\\FIFAWC\\FIFA_WC.mdb";
            oConexao = new OleDbConnection(StringConex);
            oConexao.Open();
        }

        public void FecharConexao()
        {
            if (oConexao.State == System.Data.ConnectionState.Open)
                oConexao.Close();
        }

        public OleDbDataReader LerBanco(string vSQL)
        {
            oCommand = new OleDbCommand(vSQL, oConexao);
            oCommand.CommandType = System.Data.CommandType.Text;
            oDR = oCommand.ExecuteReader();
            return oDR;
        }

        public void ExecutarSQL(string vSQL)
        {
            oCommand = new OleDbCommand(vSQL, oConexao);
            oCommand.CommandType = System.Data.CommandType.Text;
            oCommand.ExecuteNonQuery();
        }

        public object ObterScalar(string vSQL)
        {
            object objeto;
            oCommand = new OleDbCommand(vSQL, oConexao);
            oCommand.CommandType = System.Data.CommandType.Text;
            objeto = oCommand.ExecuteScalar();
            return objeto;
        }

        public bool StringToBoolean(string vValor)
        {
            bool retorno = false;
            if (vValor.ToUpper() == "S")
                retorno = true;
            return retorno;
        }

        public string BooleanToString(bool vValor)
        {
            string retorno;
            if (vValor)
            {
                retorno = "S";
            }
            else
            {
                retorno = "N";
            }
            return retorno;
        }

        public string BooleanToBooleanString(bool vValor)
        {
            string retorno;
            if (vValor)
            {
                retorno = "True";
            }
            else
            {
                retorno = "False";
            }
            return retorno;
        }

        public string CodificaPlic(string vTexto)
        {
            vTexto = vTexto.Replace("'", "&#39;");
            return vTexto;
        }

        public string DecodificaPlic(string vTexto)
        {
            vTexto = vTexto.Replace("&#39;", "'");
            return vTexto;
        }

        public DateTime? NullableDateTime(string vNomeCampo)
        {
            DateTime? resposta = new DateTime();
            if(oDR[vNomeCampo] != DBNull.Value)
            {
                resposta = Convert.ToDateTime( oDR[vNomeCampo]);
            }
            return resposta;
        }


    }
}
