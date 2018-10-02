using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace TreeViewWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            

        }
        
        #endregion


        #region OnLoaded
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //проходимся по списку всех логических дисков компьютера
            foreach (var drive in Directory.GetLogicalDrives())       
            {
                var item = new TreeViewItem()
                {
                    //передаем имена дисков
                   Header = drive,
                   Tag = drive
                };
                

                //добавление пустого списка к текущему элементу
                item.Items.Add(null);

                item.Expanded += Item_Expanded;

                //добавляем в treeView список дисков
                FolderView.Items.Add(item);
            }
        }
        #endregion

        /// <summary>
        /// Обработчик события раскрытия TreeVeew
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Item_Expanded(object sender, RoutedEventArgs e)
        {

            #region Get_Folder
            var item = (TreeViewItem)sender;
            //если выбран первый элемент или первый элемент не пустой
            if(item.Items.Count!=1 || item.Items[0]!=null)
            {
                return;
            }

            //Очищаем список второст.элементов(папки , файлы)
            item.Items.Clear();

            //получаем полный путь
            var fullPath = (string)item.Tag;
            //создаем лист с директориями папок
            var directories = new List<string>();
            try
            {
                //получаем имена подкаталогов выбранного диска
                var dirs = Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                {
                    directories.AddRange(dirs);
                }
            }
            catch
            {

            }

           

            directories.ForEach(directoryPath =>
                {
                    //директория элемента
                    var subElement = new TreeViewItem()
                    {
                        Header = GetFileFolderName(directoryPath),
                        Tag=directoryPath
                    };
                    subElement.Items.Add(null);//добавляем пустой элемент
                    subElement.Expanded += Item_Expanded;//событие 
                    item.Items.Add(subElement);//добавление под элемента в основной контейнер
                });

            #endregion

            #region GetFiles
            
            //создаем лист с директориями файлов
            var files = new List<string>();
            try
            {
                //получаем имена файлов выбранного диска
                var f = Directory.GetFiles(fullPath);
                if (f.Length > 0)
                {
                    files.AddRange(f);
                }
            }
            catch
            {

            }



            files.ForEach(FileyPath =>
            {
                //директория элемента
                var subElement = new TreeViewItem()
                {
                    Header = GetFileFolderName(FileyPath),
                    Tag = FileyPath
                };
                
               
                item.Items.Add(subElement);//добавление под элемента в основной контейнер
            });
            #endregion

        }


        #region Helpers

        /// <summary>
        /// Метод получение имени папки
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string  GetFileFolderName(string path)
        {
            if (string.IsNullOrEmpty(path))//проверка
                return string.Empty;

            var normalizedPath = path.Replace('/', '\\');//замена символов

            var lastIndex = normalizedPath.LastIndexOf('\\');

            if(lastIndex<=0)
            {
                return path;
            }

            return path.Substring(lastIndex+1);

        }

        #endregion





    }
}
