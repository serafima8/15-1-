using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        ///// <summary>
        ///// Создание поля фамилии, имени и отчества 
        ///// </summary>
        //private string name;
        ///// <summary>
        ///// Создание поля пола школьника
        ///// </summary>
        //private string generic;
        ///// <summary>
        ///// Создание поля год рождения
        ///// </summary>
        //private int years;
        ///// <summary>
        ///// Свойство поля ФИО, котрое выполняет проверку 
        ///// </summary>
        //public string Name
        //{
        //    get { return (name == "") ? "Не удаётся распознать" : name; }
        //    set { name = value; }
        //}
        ///// <summary>
        ///// Свойство поля пола школьников, которое выполняет проверку
        ///// </summary>
        //public string Generic
        //{
        //    get { return (generic == "") ? "Не удаётся распознать" : generic; }
        //    set { generic = value; }
        //}
        ///// <summary>
        ///// Свойство поля Года рождения
        ///// </summary>
        //public int Years
        //{
        //    get { return years; }
        //    set { years = value; }
        //}
        ///// <summary>
        /////  Статическое поле, которое используется для счетчика мальчиков и девочек 
        ///// </summary>
        //static public int girl, boy;
        ///// <summary>
        ///// Статический конструктор, который инициализирует статическое поле boy и girl со значением 0
        ///// </summary>
        //static Student()
        //{
        //    boy = 0;
        //    girl = 0;
        //}
        ///// <summary>
        ///// Конструктор по умолчанию
        ///// </summary>
        //public Student()
        //{    }
        ///// <summary>
        ///// Конструктор с параметрами 
        ///// </summary>
        ///// <param name="name">поле ФИО</param>
        ///// <param name="generic">поле пола</param>
        ///// <param name="yers">поле года рождения</param>
        //public Student(string name, string generic, int yers)
        //{
        //    this.Name = name;
        //    this.Generic = generic;
        //    this.Years = yers;
        //    if (Generic == "Мужской")
        //    {
        //        boy++;
        //    }
        //    if (Generic == "Женский")
        //    {
        //        girl++;
        //    }
        //}
        ///// <summary>
        ///// Метод, который выводит информацию
        ///// </summary>
        ///// <returns></returns>
        //public override string ToString()
        //{
        //    return $"ФИО: {Name}\nПол школьника: {Generic}\nГод рождения: {Years}";
        //}
    }
}
