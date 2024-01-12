// Определение структуры Worker с полями name и year
struct Worker
{
    public string name;
    public int year;
}

// Основной класс программы
class Program
{
    static void Main()
    {
        // Открывается файл "Inlet.in" для чтения
        StreamReader input = new StreamReader("Inlet.in");

        // Создается объект StreamWriter для записи в файл "Outlet.out"
        StreamWriter output = new StreamWriter("Outlet.out");

        // Читается весь текст из файла и разбивается на строки
        string[] data = input.ReadToEnd().Split('\n');

        // Закрывается поток чтения из файла
        input.Close();

        // Получение значения l и n из данных
        int l = Convert.ToInt32(data[0]),
            n = (data.Length - 1) / 2;

        // Создание массива Worker размером n
        Worker[] w = new Worker[n];

        // Заполнение массива данными из строк(с пмощью фор)
        for (int i = 1, j = 0; i < data.Length; i += 2, j++)
        {
            w[j].name = data[i].Trim();
            w[j].year = Convert.ToInt32(data[i + 1]);
        }

        // Вывод пустой строки в файл "Outlet.out"
        output.WriteLine();

        // Переменная для отслеживания наличия записей
        bool b = false;

        // Проверка условия и вывод работников, соответствующих условию(с ифа в форе)
        for (int i = 0; i < w.Length; i++)
            if (2012 - w[i].year > l)
            {
                b = true;

                // Выводится имя работника, удовлетворяющего условию
                output.WriteLine($"{w[i].name}");
            }

        // Если нет работников, удовлетворяющих условию, выводится "Empty"
        if (!b)
            output.Write("Empty");

        // Закрывается поток записи в файл
        output.Close();
    }
}