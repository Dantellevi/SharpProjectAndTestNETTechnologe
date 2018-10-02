using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Input;

namespace Word
{
    /// <summary>
    /// The View Model for the custom flat window
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        //    #region Private Member

        /// <summary>
        /// The window this view model controls
        /// </summary>
        private System.Windows.Window mWindow;

        /// <summary>
        /// Отступы окна 
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// радиусы скругления окна
        /// </summary>
        private int mWindowRadius = 10;

        /// <summary>
        /// Последняя позиция окна
        /// </summary>
        private WindowDockPosition mDockPosition = WindowDockPosition.Undocked;



        #region Public Properties

        /// <summary>
        /// The smallest width the window can go to(мин. длинна)
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 400;

        /// <summary>
        /// The smallest height the window can go to(мин. высота)
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 400;

        /// <summary>
        /// True if the window should be borderless because it is docked or maximized(толщина выделения окна)
        /// </summary>
        public bool Borderless { get { return (mWindow.WindowState == WindowState.Maximized || mDockPosition != WindowDockPosition.Undocked); } }

        /// <summary>
        /// Размер рамки изменения размера окна
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        /// <summary>
        /// Размер границы изменения размера вокруг окна, с учетом внешнего края
        /// </summary>
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        /// <summary>
        /// Заполнение внутреннего содержимого главного окна
        /// </summary>
        public Thickness InnerContentPadding { get { return new Thickness(ResizeBorder); } }

        /// <summary>
        /// Отступы для тени
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                // Если он максимален или закреплен, никакая граница
                return Borderless ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }

        /// <summary>
        ///Отступы вокруг окна, чтобы можно было использовать тень
        /// </summary>
        public Thickness OuterMarginSizeThickness { get { return new Thickness(OuterMarginSize); } }

        /// <summary>
        /// Радиус скругления углов окна
        /// </summary>
        public int WindowRadius
        {
            get
            {
                // Если он максимален или закреплен, никакая граница
                return Borderless ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }

        /// <summary>
        /// Радиус скругления углов окна
        /// </summary>
        public CornerRadius WindowCornerRadius { get { return new CornerRadius(WindowRadius); } }

        /// <summary>
        /// Высота строки заголовка / заголовка окна
        /// </summary>
        public int TitleHeight { get; set; } = 42;
        /// <summary>
        /// Высота строки заголовка / заголовка окна
        /// </summary>
        public GridLength TitleHeightGridLength { get { return new GridLength(TitleHeight + ResizeBorder); } }

#endregion

        #region Commands

        /// <summary>
        /// Команда для минимизации окна
        /// </summary>
        public ICommand MinimizeCommand { get; set; }

        /// <summary>
        /// The command to maximize the window
        /// </summary>
        public ICommand MaximizeCommand { get; set; }

        /// <summary>
        ///Команда для максимизации окна
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// Команда для отображения системного меню окна
        /// </summary>
        public ICommand MenuCommand { get; set; }

        //    #endregion

        //    #region Constructor

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public WindowViewModel(Window window)
        {
            mWindow = window;

            // Получение размера окна
            mWindow.StateChanged += (sender, e) =>
            {
                    //Отключить события для всех свойств, на которые влияет изменение размера
                   // WindowResized();
            };

            // Создание команды
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand = new RelayCommand(() => mWindow.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(mWindow, GetMousePosition()));

            //Fix window resize issue
            var resizer = new WindowResizer(mWindow);

            // Listen out for dock changes
            resizer.WindowDockChanged += (dock) =>
            {
                // Store last position
                mDockPosition = dock;

                // Fire off resize events
                WindowResized();
            };
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Gets the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            // Position of the mouse relative to the window
            var position = Mouse.GetPosition(mWindow);

            // Add the window position so its a "ToScreen"
            return new Point(position.X + mWindow.Left, position.Y + mWindow.Top);
        }

        /// <summary>
        /// If the window resizes to a special position (docked or maximized)
        /// this will update all required property change events to set the borders and radius values
        /// </summary>
        private void WindowResized()
        {
            // Fire off events for all properties that are affected by a resize
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginSizeThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }


        #endregion
    }
}
