namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService= new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();

            List<ILoggerService> loggers=new List<ILoggerService> {new SmsLoggerService(),new FileLoggerService()};

            BasvuruManager basvuruManager= new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers);

            List<IKrediManager> krediler=new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}