namespace New_5_2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] num = SortArray(); //Запуск работы метода SortArray. Получение данных из arr в num
                Console.WriteLine("Введенные числа (по возрастанию):\n");
                foreach (var num2 in num)
                {
                    Console.Write(num2 + " ");
                }

                
            }
            static int[] GetArrayFromConsole() //Инициализация метода. Метод для ввода значений элементов в массив result
            {
                var result = new int[5];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                    
                }                
                return result; //Возврат
            }
            static int [] SortArray () // Инициализация метода
            {
                int[] arr = GetArrayFromConsole(); //Обращение к методу GetArrayFromConsole (его полная работа).
                                                   //Инициализация массива, передача значений массива result в arr
                //Сортировка
                int num;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            num = arr[i];
                            arr[i] = arr[j];
                            arr[j] = num;
                        }
                    }
                
                }
                return arr; //Возврат
                
                
            }
        }
    }
}