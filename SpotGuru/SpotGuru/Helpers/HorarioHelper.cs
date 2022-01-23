namespace SpotGuru.Helpers
{
    public class HorarioHelper
    {
        public static System.DateTime calculaDiaEHora(int id, int duracaoSlot, int horaAbertura, int horaFecho, System.DateTime diaAtual)
        {
            int tempo = id * duracaoSlot;
            int dia = tempo / ((horaFecho - horaAbertura) * 60);
            int nrSlotNoDia = (tempo % ((horaFecho - horaAbertura) * 60)) / duracaoSlot;
            System.DateTime date = new System.DateTime(diaAtual.Year,diaAtual.Month,diaAtual.Day).AddDays(dia).AddMinutes(nrSlotNoDia * duracaoSlot);
            return date;
            //Fazer a verificacao abaixo ao inserir na DB
            //if (date.Hour >= horaAbertura && date.Hour <= horaFecho)
        }

        //Assume dia atual com todos os parametros a 0, excepto o dia, mes e ano
        public static int calculaId(System.DateTime diaAtual)
        {
            return 0;
        }
    }
}
