using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_withGraphicsPlot
{
   public enum StopBits 
    {
        stop_Bit_One=1,
        stop_Bit_Two=2,
        stop_Bit_None=0
    }

    public enum FormatBits
    {
        Format_7bit=7,
        Format_8bit=8,
        Format_9bit=9
    }


    public  struct SettingsConnection
    {
        public  ulong Baud;//скорость COM порта
        public bool ParityBit;//поле для проверки вкл. бита четности
        public StopBits stopbit;//поле для проверки стоп битов
        public FormatBits format;//поле для установки формата посылки
        public string NamePort;//имя порта через которого проиходит подключения

    }
}
