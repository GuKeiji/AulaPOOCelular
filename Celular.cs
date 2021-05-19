namespace AtividadeSistemaPOO
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado = false;

        public bool Ligar()
        {
            ligado = true;
            return ligado;
        }
        public bool Desligar()
        {
            ligado = false;
            return ligado;
        }
        public string FazerLigacao()
        {
            return "Chamando...";
        }
        public string EnviarMensagem()
        {
            return "Mensagem enviada";
        }



    }
}