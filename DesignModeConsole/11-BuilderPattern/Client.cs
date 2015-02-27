using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeConsole.BP
{
    public class Client
    {
        public static void Test()
        {
        //    List<string> sequence = new List<string>();
        //    sequence.Add("engine boom");
        //    sequence.Add("start");
        //    sequence.Add("stop");


        //    BenzBuilder benzBuilder = new BenzBuilder();
        //    benzBuilder.SetSequence(sequence);

        //    BenzModel benz = (BenzModel)benzBuilder.GetCar();
        //    benz.Run();

        //    BMWBuilder bmwBuilder = new BMWBuilder();
        //    bmwBuilder.SetSequence(sequence);
            
        //    BMWModel bmw = (BMWModel)bmwBuilder.GetCar();
        //    bmw.Run();



            Director director = new Director();

            BenzModel benz = (BenzModel)director.GetABenzModel();
            benz.Run();


            BMWModel bmw = (BMWModel)director.GetDBMWModel();
            bmw.Run();
            Console.ReadKey();

        }
    }
}
