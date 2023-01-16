using macchinetta_caffe_finita;
namespace TestRossi
{
    public class UnitTest1
    {
        [Fact] //TEST ACQUA
        public void Test1()
        {
            Macchinetta a = new Macchinetta(1000,100);
            a.Ricarica_acqua();
            Assert.True(a.Stato_acqua() == 1000);
        }

        [Fact] //TEST CAFFE
        public void Test2()
        {
            Macchinetta a = new Macchinetta(1000, 100);
            a.Ricarica_caffe();
            Assert.True(a.Stato_caffe() == 100);
        }

        [Fact] //TEST CONFRONTO
        public void Test3()
        {
            Macchinetta a = new Macchinetta(1000, 100);
            Macchinetta b = new Macchinetta(500, 50);

            Assert.True(a.Confronto(a, b) == b);
        }

        [Fact] //TEST EROGAZIONE CAFFE NORMALE
        public void Test4()
        {
            Macchinetta a = new Macchinetta(1000, 100);
            a.Erogazione_normale();
            a.Erogazione_normale();
            Assert.True(a.Erogati == 2);
            //ERRORE NEL CONTATORE DI EROGAZIONI
            //LA VARIABILE RESTA 1 E NON INCREMENTA     
        }

        [Fact] //TEST EROGAZIONE CAFFE LUNGO
        public void Test5()
        {
            Macchinetta a = new Macchinetta(1000, 100);
            a.Erogazione_lungo();
            a.Erogazione_lungo();
            Assert.True(a.Erogati == 2);
            //ERRORE NEL CONTATORE DI EROGAZIONI
            //LA VARIABILE RESTA 1 E NON INCREMENTA     
        }

        [Fact] //TEST TOSTRING
        public void Test6()
        {
            Macchinetta a = new Macchinetta(1000, 100);
            string b = a.ToString();
            Assert.True(b != null);
        }
    }
}