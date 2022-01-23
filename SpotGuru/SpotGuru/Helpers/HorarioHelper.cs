namespace SpotGuru.Helpers
{
    public class HorarioHelper
    {
        //Assume dia atual com todos os parametros a 0, excepto o dia, mes e ano
        public static System.DateTime calculaDiaEHora(int id, int horaAbertura, int horaFecho, int duracaoSlot, System.DateTime diaAtual)
        {
            int tempo = id * duracaoSlot;
            int minsPorDia = (horaFecho - horaAbertura) * 60;
            int dia = tempo / minsPorDia;
            int nrSlotNoDia = (tempo % minsPorDia) / duracaoSlot;
            System.DateTime date = diaAtual.AddDays(dia).AddHours(horaAbertura).AddMinutes(nrSlotNoDia * duracaoSlot);
            return date;
            //Fazer a verificacao abaixo ao inserir na DB
            //if (date.Hour >= horaAbertura && date.Hour <= horaFecho)
        }

        //Assume todos os parametros a 0, excepto o dia, mes e ano, para o argumento diaInicioSemana
        public static int calculaId(System.DateTime diaInicioSemana, System.DateTime diaSlot, int horaAbertura, int horaFecho, int duracaoSlot)
        {
            int nrSlotsNoDia = (diaSlot.Hour * 60 + diaSlot.Minute - horaAbertura * 60) / duracaoSlot;
            int dia = diaSlot.Day - diaInicioSemana.Day;
            int nrSlotsMaxDia = ((horaFecho - horaAbertura) * 60) / duracaoSlot;
            return dia * nrSlotsMaxDia + nrSlotsNoDia;
        }
    }
}
