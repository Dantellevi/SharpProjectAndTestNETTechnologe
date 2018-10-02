using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.IO.Ports;
using Terminal_withGraphicsPlot.Windows;


namespace Terminal_withGraphicsPlot
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        protected internal List<string> ListPort;//список всех портов устройства
        protected internal List<ulong> Baud;//список всех скоростей USART
        protected internal List<string> StopitsList;//список вариантов выбора стопбита
        protected internal List<string> ParityBitList;//список вариантов выбора бита четности
        protected internal List<string> FormatBitList;//список вариантов выбора формата данных
        private SerialPort _serialPort = new SerialPort();//экземпляр для работы с виртуальным COM
        private SettingsConnection setConnection;//структура для хранения настроек


        #region Инициализация ComboBoxes

        /// <summary>
        /// Функция инициализации скоростей USART
        /// </summary>
        void SetInitilizeBuad()
        {
            Baud = new List<ulong>();
            Baud.Add(300);
            ulong speed = 300;
            int i = 0;
          while(speed<921600)
            {
                if(i==7)
                {
                    speed=57600;
                    Baud.Add(speed);
                }
                else
                {
                    speed *= 2;
                    Baud.Add(speed);
                }

                i++;
               
            }


            SpeedBaud.ItemsSource = Baud;
        }

        /// <summary>
        /// Метод инициализации портов ПК
        /// </summary>
        void SetInitilizePortName()
        {
            ListPort = new List<string>();
            ListPort.AddRange(SerialPort.GetPortNames());
            PORT.ItemsSource = ListPort;
        }

        /// <summary>
        /// Метод установки стоп битов
        /// </summary>
        void SetInitilizeStopBits()
        {
            StopitsList = new List<string>()
            {
                "1 стоповый бит",
                "2 стоповых бита"
            };

            CoutStopBit.ItemsSource = StopitsList;
        }


        /// <summary>
        /// Метод установки значений в поле бита четности
        /// </summary>
        void SetInitilizeParityBits()
        {
            ParityBitList = new List<string>()
            {
                "вкл. бит четности",
                "отк. бит четности"
            };

            ParityBit.ItemsSource = ParityBitList;
        }


        /// <summary>
        /// Метод установки формата передачи/приема
        /// </summary>
        void SetInitilizeFormat()
        {
            FormatBitList = new List<string>()
            {
                "Формат: 7 бит",
                "Формат: 8 бит",
                "Формат: 9 бит"
            };

            FormatBit.ItemsSource = FormatBitList;
        }


        /// <summary>
        /// Метод хранения всех настрояк
        /// </summary>
        void Settings()
        {
            SetInitilizeBuad();//инициализация скоростей 
            SetInitilizePortName();//Инициализая имен портов ПК
            SetInitilizeStopBits();//Инициализация стоповых битов
            SetInitilizeParityBits();//инициализация бита четности
            SetInitilizeFormat();//инициализация формата кадра

        }



        #endregion


        /// <summary>
        /// Получаем данные с комбобокса с выбранным именем порта
        /// </summary>
        private string NamePort
        {
            get
            {
                return (string)PORT.SelectedItem;
            }
        }

        /// <summary>
        /// Получаем данные с комбобокса с выбранной скоростью передачи
        /// </summary>
        private ulong SpeeDBuad
        {
            get
            {
                return (ulong)SpeedBaud.SelectedItem;
            }
        }

        /// <summary>
        /// Получаем данные с комбобокса с выбранным кол. стопбитов
        /// </summary>
        private int StoPBits
        {
            get
            {
                if((string)CoutStopBit.SelectedItem== "1 стоповый бит")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }


        /// <summary>
        ///  Получаем данные с комбобокса с выбранным битом четности
        /// </summary>
        private int PARITYBit
        {
            get
            {
                if((string)ParityBit.SelectedItem== "вкл. бит четности")
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        ///  Получаем данные с комбобокса с выбранным форматом посылки
        /// </summary>
        private int FORMATBITS
        {
            get
            {
                if ((string)FormatBit.SelectedItem == "Формат: 7 бит")
                {
                    return 7;
                }
                else if((string)FormatBit.SelectedItem == "Формат: 9 бит")
                {
                    return 9;
                }
                else
                {
                    return 8;
                }
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            Settings();// вызов общих настроек
           
        }

        private void CloseWin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ValidButton_Click(object sender, RoutedEventArgs e)
        {
            

            if (PORT.SelectedIndex != -1 && SpeedBaud.SelectedIndex != -1
                && ParityBit.SelectedIndex != -1 && FormatBit.SelectedIndex != -1 && CoutStopBit.SelectedIndex != -1)
            {
                setConnection = new SettingsConnection();

                setConnection.NamePort = NamePort;//имя порта

                setConnection.Baud = SpeeDBuad;//скорость передачи

                //------------------------бит четности-------------------------
                if (PARITYBit==1)
                {
                    setConnection.ParityBit = true;
                }
                else
                {
                    setConnection.ParityBit = false;
                }
                //-------------------------------------------------------------

                //-----------------------Стоп бит------------------------------
                if(StoPBits==1)
                {
                    setConnection.stopbit = StopBits.stop_Bit_One;
                }
                else if(StoPBits == 2)
                {
                    setConnection.stopbit = StopBits.stop_Bit_Two;
                }
                //-------------------------------------------------------------


                //-----------------------Формат данных--------------------------
                switch(FORMATBITS)
                {
                    case 7:
                        {
                            setConnection.format = FormatBits.Format_7bit;
                            break;
                        }
                    case 8:
                        {
                            setConnection.format = FormatBits.Format_8bit;
                            break;
                        }
                    case 9:
                        {
                            setConnection.format = FormatBits.Format_9bit;
                            break;
                        }
                }

                //---------------------------------------------------------------

                MainPage MainP = new MainPage(_serialPort,setConnection);
                MainP.Show();
            }
            

        }
    }
}
