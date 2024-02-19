using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_2
{/// <summary>
/// абстрактный класс
/// </summary>
    abstract internal class AbstractHandler
    {/// <summary>
    /// абстрактный метод открытие 
    /// </summary>
        public abstract void Open();
        /// <summary>
        /// абстрактный метод создание
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// асбтрактный метод изменеие
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// абстрактный метод сохранение
        /// </summary>
        public abstract void Save();

    }
}
