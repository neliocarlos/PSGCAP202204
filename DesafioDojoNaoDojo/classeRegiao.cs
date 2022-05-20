using System;


namespace Cap202204ConsoleApp.Models
{
    public class Regiao
    {
        private int codigo;
        private string nomeRegiao;
        private string siglaRegiao;

        public int Codigo { get => codigo; set => codigo = value; }
        public string NomeRegiao { get => nomeRegiao; set => nomeRegiao = value; }
        public string SiglaRegiao { get => siglaRegiao; set => siglaRegiao = value; }

        public Regiao()
        { }

        public Regiao(int codigo, string nomeRegiao, string siglaRegiao)
        {
            this.codigo = codigo;
            this.nomeRegiao = nomeRegiao;
            this.siglaRegiao = siglaRegiao;
        }


    }
}
